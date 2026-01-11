using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tactile.Graphics.Text;
using TactileLibrary;

namespace Tactile.Windows.UserInterface.Status
{
    class StatusLeadershipUINode : StatusUINode
    {
        protected Func<Game_Unit, int> LeadershipLevel;
        protected Icon_Sprite LeadershipIcon;
        protected TextSprite Label;

        internal StatusLeadershipUINode(string helpLabel, Func<Game_Unit, int> leadershipLevel): base (helpLabel)
        {
            LeadershipLevel = leadershipLevel;

            LeadershipIcon = new Icon_Sprite();
            LeadershipIcon.draw_offset = new Vector2(48, 0);
            LeadershipIcon.texture = Global.Content.Load<Texture2D>(@"Graphics/Icons/Leadership Icons");
            LeadershipIcon.size = new Vector2(80, 16);

            Label = new TextSprite();
            Label.draw_offset = new Vector2(0, 0);
            Label.SetFont(Config.UI_FONT, Global.Content, "Yellow");
            Label.text = "Authority";

            Size = new Vector2(56, 16);
        }

        internal override void refresh(Game_Unit unit)
        {
            LeadershipIcon.index = LeadershipLevel(unit);
        }
        protected override void update_graphics(bool activeNode)
        {
            LeadershipIcon.update();
            Label.update();
        }

        protected override void mouse_off_graphic()
        {
            Label.tint = Color.White;
            LeadershipIcon.tint = Color.White;
        }
        protected override void mouse_highlight_graphic()
        {
            Label.tint = Config.MOUSE_OVER_ELEMENT_COLOR;
            LeadershipIcon.tint = Config.MOUSE_OVER_ELEMENT_COLOR;
        }
        protected override void mouse_click_graphic()
        {
            Label.tint = Config.MOUSE_PRESSED_ELEMENT_COLOR;
            LeadershipIcon.tint = Config.MOUSE_PRESSED_ELEMENT_COLOR;
        }

        public override void Draw(SpriteBatch sprite_batch, Vector2 draw_offset = default(Vector2))
        {
            LeadershipIcon.draw(sprite_batch, draw_offset - (loc + draw_vector()));
            Label.draw(sprite_batch, draw_offset - (loc + draw_vector()));
        }
    }
}
