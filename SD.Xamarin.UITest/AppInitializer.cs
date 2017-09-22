using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SD.Xamarin.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                       .Android
                       .ApkFile("../../../SD.Xamarin.Droid/bin/Debug/SD.Xamarin.Droid-Signed.apk")
                       .StartApp();
            }

            return ConfigureApp
                   .iOS
                   .AppBundle("../../../SD.Xamarin.iOS/bin/iPhoneSimulator/Debug/SD.Xamarin.iOS.app")
                   .StartApp();
        }
    }
}