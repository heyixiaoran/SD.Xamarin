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
                       .ApkFile("../../../SD.Xamarin/SD.Xamarin.Droid/bin/Release/SD.Xamarin.Droid.apk")
                       .DeviceSerial("96e5b85b")
                       .EnableLocalScreenshots()
                       .StartApp();

                //.DeviceSerial("96e5b85b")
            }

            return ConfigureApp
                   .iOS
                   .AppBundle("../../../SD.Xamarin/SD.Xamarin.iOS/bin/iPhoneSimulator/Release/SD.Xamarin.iOS.app")
                   .EnableLocalScreenshots()
                   .StartApp();
        }
    }
}

