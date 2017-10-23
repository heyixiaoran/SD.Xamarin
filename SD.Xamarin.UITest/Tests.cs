using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SD.Xamarin.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        private IApp _app;
        private Platform _platform;

        public Tests(Platform platform)
        {
            this._platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);
        }

        [Test]
        public void AppLaunches()
        {
            _app.Screenshot("First screen.");
        }

        [Test]
        public void TestLogin()
        {
            //—— Repl ——
            //_app.EnterText(n => n.Marked("Username"), "Name");
            //_app.EnterText(n => n.Marked("Password"), "Password");
            //_app.Tap(c => c.Button("LoginButton"));
            //_app.Screenshot("Login Finished");

            //_app.Repl();

            //AppResult[] result = _app.Query();
            //Assert.IsTrue(result.Any(), "Login");


            //—— Device ——
            //_app.Tap(c => c.TextField("Username"));
            //_app.EnterText(n => n.Marked("Username"), "Name");
            //_app.WaitForElement(n => n.Marked("Username").Text("Name"));

            //_app.Tap(c => c.TextField("Password"));
            //_app.EnterText(n => n.Marked("Password"), "Password");
            //_app.WaitForElement(n => n.Marked("Password").Text("Password"), "");

            //_app.Tap(c => c.Button("LoginButton"));

            //AppResult[] result = _app.Query();
            //Assert.IsTrue(result.Any(), "Login");


            //—— Test Cloud ——
            _app.Tap(c => c.TextField("Username"));
            _app.EnterText(n => n.Marked("Username"), "Name");
            _app.WaitForElement(n => n.Marked("Username").Text("Name"));

            _app.Tap(c => c.TextField("Password"));
            _app.EnterText(n => n.Marked("Password"), "Password");
            _app.WaitForElement(n => n.Marked("Password").Text("Password"), "");

            _app.Screenshot("Fill Parameter Finished");

            _app.Tap(c => c.Button("LoginButton"));

            _app.Screenshot("Login Finished");

            AppResult[] result = _app.Query();
            Assert.IsTrue(result.Any(), "Login");
        }
    }
}

