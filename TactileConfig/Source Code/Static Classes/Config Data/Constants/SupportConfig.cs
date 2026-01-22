using System.Collections.Generic;
using TactileLibrary;

namespace Tactile.Constants
{
    public class Support
    {
        // Maximum support levels an actor can gain
        public const int SUPPORT_TOTAL = 11;
        // Radius of support bonuses
        public const int SUPPORT_RANGE = 3;

        // The letters labelling each support level
        // Also implicitly the number of support levels
        public readonly static List<string> SUPPORT_LETTERS = new List<string> { "-", "C", "B", "A", "S" };
        public const int MAX_SUPPORT_LEVEL = 3;
        public const int BOND_SUPPORT_RANK = 4;
        public const bool PLAYER_SUPPORT_ONLY = false; // Can only player units gain support points

        public const int MAX_SUPPORT_POINTS = 999; // The maximum number of points a support rank can require; support progress won't count higher
        public const int ADJACENT_SUPPORT_POINTS = 3;
        public const int SAME_TARGET_SUPPORT_POINTS = 2;
        public const int HEAL_SUPPORT_POINTS = 3;
        public const int TALK_SUPPORT_POINTS = 5;
        public const int RESCUE_SUPPORT_POINTS = 5;
        public const int CHAPTER_SUPPORT_POINTS = 10;

        public const bool ONE_SUPPORT_PER_CHAPTER = true;
        public const bool BASE_COUNTS_AS_SEPARATE_CHAPTER = true;
        public const bool NEW_MAP_COUNTS_AS_SEPARATE_CHAPTER = false;

        // Supports for actors that are presumed forced, so they count against
        //     the remaining support count even before they're activated
        public readonly static Dictionary<int, HashSet<int>> RESERVED_SUPPORTS = new Dictionary<int, HashSet<int>>
        {
        };

        public readonly static Dictionary<Affinities, float[]> AFFINITY_BOOSTS = new Dictionary<Affinities, float[]>
        {
            //                                   Atk,  Def,  Hit,  Avo, Crit,  Dod
            { Affinities.Baldr,     new float[] {   0f, 0.5f,   0f, 2.5f,   0f,   0f } }, // 3Off, 1Def
            { Affinities.Od,        new float[] {   0f,   0f,   0f, 2.5f, 2.5f,   0f } }, // 1Off, 3Def
            { Affinities.Hodr,      new float[] { 0.5f,   0f,   0f,   0f, 2.5f,   0f } }, // 2Off, 2Def
            { Affinities.Njorun,    new float[] { 0.5f, 0.5f,   0f,   0f,   0f, 2.5f } }, // 2Off, 2Def
            { Affinities.Dainn,     new float[] {   0f,   0f, 2.5f, 2.5f,   0f,   0f } }, // 2Off, 2Def
            { Affinities.Nal,       new float[] {   0f, 0.5f,   0f,   0f,   0f, 2.5f } }, // 2Off, 2Def
            { Affinities.Ullr,      new float[] {   0f,   0f, 2.5f,   0f, 2.5f,   0f } }, // 2Off, 2Def
            { Affinities.Bragi,     new float[] { 0.5f,   0f,   0f,   0f,   0f, 2.5f } }, // 2Off, 2Def
            { Affinities.Fjalar,    new float[] { 0.5f,   0f, 2.5f,   0f,   0f,   0f } }, // 2Off, 2Def
            { Affinities.Thrud,     new float[] {   0f, 0.5f,   0f,   0f, 2.5f,   0f } }, // 2Off, 2Def
            { Affinities.Forseti,   new float[] {   0f,   0f,   0f, 2.5f,   0f, 2.5f } }, // 2Off, 2Def
            { Affinities.Naga,      new float[] { 0.5f, 0.5f, 2.5f, 2.5f, 2.5f, 2.5f } }, // 2Off, 2Def
            { Affinities.Loptous,   new float[] { 0.5f, 0.5f, 2.5f, 2.5f, 2.5f, 2.5f } }, // 2Off, 2Def
            
            { Affinities.None,      new float[] {   0f,   0f, 2.5f, 2.5f,   0f,   0f } }
        };
        // The support bonus for a bond, default is one support rank worth of every stat
        public readonly static float[] BOND_BOOSTS = new float[] { 1f, 1f, 5f, 5f, 5f, 5f };

        // Growth rate change to apply to generics
        public const int AFFINITY_GROWTH_MOD = 10;
        // Stats that each affinity affects
        // The first list in each entry is boosted by that affinity,
        //     the second group is reduced
        public readonly static Dictionary<Affinities, List<Stat_Labels>[]> AFFINITY_GROWTHS =
            new Dictionary<Affinities, List<Stat_Labels>[]>
        {
            { Affinities.Baldr, new List<Stat_Labels>[] { // HP +20%, Str +10%, Dex +10%, Luck +10%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Str, Stat_Labels.Skl, Stat_Labels.Lck },
                new List<Stat_Labels> {  } } },
            { Affinities.Od, new List<Stat_Labels>[] { // HP +20% Dex +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Skl, Stat_Labels.Skl, Stat_Labels.Skl },
                new List<Stat_Labels> {  } } },
            { Affinities.Hodr, new List<Stat_Labels>[] { // HP +20%, Str +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Str, Stat_Labels.Str, Stat_Labels.Str },
                new List<Stat_Labels> {  } } },
            { Affinities.Njorun, new List<Stat_Labels>[] { // HP +20%, Str +10%, Spd +10%, Def +10%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Str, Stat_Labels.Spd, Stat_Labels.Def },
                new List<Stat_Labels> {  } } },
            { Affinities.Dainn, new List<Stat_Labels>[] { // HP +20%, Spd +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Skl, Stat_Labels.Skl, Stat_Labels.Skl },
                new List<Stat_Labels> {  } } },
            { Affinities.Nal, new List<Stat_Labels>[] { // HP +20%, Def +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Def, Stat_Labels.Def, Stat_Labels.Def },
                new List<Stat_Labels> {  } } },
            { Affinities.Ullr, new List<Stat_Labels>[] { // HP +20%, Lck +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Lck, Stat_Labels.Lck, Stat_Labels.Lck },
                new List<Stat_Labels> {  } } },
            { Affinities.Bragi, new List<Stat_Labels>[] { // HP +10%, Mag +10%, Luck +10%, Res +20%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Mag, Stat_Labels.Lck, Stat_Labels.Res, Stat_Labels.Res },
                new List<Stat_Labels> {  } } },
            { Affinities.Fjalar, new List<Stat_Labels>[] { // HP +20%, Mag +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Mag, Stat_Labels.Mag, Stat_Labels.Mag },
                new List<Stat_Labels> {  } } },
            { Affinities.Thrud, new List<Stat_Labels>[] { // HP +20%, Dex +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Skl, Stat_Labels.Skl, Stat_Labels.Skl },
                new List<Stat_Labels> {  } } },
            { Affinities.Forseti, new List<Stat_Labels>[] { // HP +20%, Spd +30%
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Hp, Stat_Labels.Spd, Stat_Labels.Spd, Stat_Labels.Spd },
                new List<Stat_Labels> {  } } },
            { Affinities.Naga, new List<Stat_Labels>[] { // HP +10%, Mag +20%, Res +20
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Mag, Stat_Labels.Mag, Stat_Labels.Res, Stat_Labels.Res },
                new List<Stat_Labels> {  } } },
            { Affinities.Loptous, new List<Stat_Labels>[] { // HP +10%, Mag +20%, Res +20
                new List<Stat_Labels> { Stat_Labels.Hp, Stat_Labels.Mag, Stat_Labels.Mag, Stat_Labels.Res, Stat_Labels.Res },
                new List<Stat_Labels> {  } } }
        };

        /// <summary>
        /// Convo backgrounds to use in the support viewer for field supports.
        /// One background is randomly selected each time a support is viewed.
        /// Entries for the "" key are unlocked from the start of the game.
        /// When the player clears a chapter, the list of backgrounds with that
        /// chapter's Id are added to the pool, if any.
        /// </summary>
        public readonly static Dictionary<string, List<string>> SUPPORT_VIEWER_BACKGROUNDS = new Dictionary<string, List<string>>
        {
            { "", new List<string> { "Fields", "Courtyard", "House", "Town", "Village", "Chamber", "Hill", "Market" } },

            {"Tr1", new List<string> { "Port", "Ship", "Shrine", "Castle", "Cell", "Hallway", "Inn" } },
            {"Tr2", new List<string> { "Camp", "Ruins", "Fortress", "Tent" } },
            {"Tr3", new List<string> { "Desert", "Plains", "Mountains", "Dungeon", "Fort Hall", "Garden" } },
        };
    }
}
