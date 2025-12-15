using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Android_MonoGame_Test
{
    [Activity(Label = "FE4XNA"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.Landscape //ScreenOrientation.SensorLandscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(FE4XNA.ExceptionLogger.Handler);

            var g = new FE4XNA.Game1(new string[0]);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}

