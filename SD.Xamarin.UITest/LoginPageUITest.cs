using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SD.Xamarin.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class LoginPageUITest
    {
        private IApp _app;
        private Platform _platform;

        public LoginPageUITest(Platform platform)
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
            //_app.Tap(c => c.TextField("Username"));
            //_app.EnterText(n => n.Marked("Username"), "Name");
            //_app.WaitForElement(n => n.Marked("Username").Text("Name"));

            //_app.Tap(c => c.TextField("Password"));
            //_app.EnterText(n => n.Marked("Password"), "Password");
            //_app.WaitForElement(n => n.Marked("Password").Text("Password"), "");

            //_app.Screenshot("Fill Parameter Finished");

            //_app.Tap(c => c.Button("LoginButton"));

            //_app.Screenshot("Login Finished");


            _app.WaitForElement(x => x.Marked("Username"));
            _app.Tap(x => x.Marked("Username"));
            _app.EnterText(x => x.Marked("Username"), "Name");
            _app.Screenshot("Fill Name Finished");

            _app.DismissKeyboard();
            _app.WaitForElement(x => x.Marked("Password"));
            _app.Tap(x => x.Marked("Password"));
            _app.EnterText(x => x.Marked("Password"), "Password");

            _app.Tap(x => x.Marked("LoginButton"));
            _app.Screenshot("Login");

            AppResult[] result = _app.Query();
            Assert.IsTrue(result.Any(), "Login");
        }

        /// <summary>
        /// Xamarin Recorder
        /// </summary>
        //[Test]
        //public void NewTest()
        //{
        //    _app.WaitForElement(x => x.Marked("Username"));
        //    _app.Tap(x => x.Marked("Username"));
        //    _app.EnterText(x => x.Marked("Username"), "Name");
        //    _app.WaitForElement(x => x.Marked("Password"));
        //    _app.Tap(x => x.Marked("Password"));
        //    _app.EnterText(x => x.Marked("Password"), "Password");
        //    _app.Tap(x => x.Marked("LoginButton"));
        //    _app.Back();
        //    //_app.ClearText(x => x.Marked("Password"));
        //    //_app.ScrollUp();
        //    //_app.ScrollDown();
        //    //_app.SwipeLeftToRight();
        //    //_app.SwipeRightToLeft();
        //    //_app.TouchAndHold(x => x.Class("FormsImageView"));
        //    _app.Screenshot("Long press on view with class: FormsImageView");

        //    AppResult[] result = _app.Query();
        //    Assert.IsTrue(result.Any(), "Login");
        //}
    }
}

