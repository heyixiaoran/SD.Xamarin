using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using SD.Xamarin.ViewModels;

namespace SD.Xamarin.Test
{
    [TestClass]
    public class LoginPageTest
    {
        [TestMethod]
        public void TestLogin()
        {
            var navigationService = new Mock<INavigationService>();
            var eventAggregator = new Mock<IEventAggregator>();
            var pageDialogService = new Mock<IPageDialogService>();
            var loginPageViewModel = new LoginPageViewModel(navigationService.Object, eventAggregator.Object, pageDialogService.Object)
            {
                Username = "Name",
                Password = "Password"
            };

            var loginCommand = loginPageViewModel.LoginCommand;

            Assert.IsNotNull(loginCommand);
            Assert.IsTrue(loginCommand.CanExecute("DataCabinPage"));

            loginCommand.Execute("DataCabinPage");
            navigationService.Verify(m => m.NavigateAsync("DataCabinPage", null, null, true), Times.Once);
        }
    }
}
