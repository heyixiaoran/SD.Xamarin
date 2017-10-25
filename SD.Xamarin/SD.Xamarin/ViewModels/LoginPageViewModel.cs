using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

using SD.Xamarin.Views;
using System.Windows.Input;

namespace SD.Xamarin.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPageDialogService _pageDialogService;


        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get { return _loginCommand ?? new DelegateCommand(Login); }
        }

        public LoginPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            _pageDialogService = pageDialogService;
        }

        private async void Login()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                //await _navigationService.NavigateAsync("/Master/Navigation");
                await _navigationService.NavigateAsync(nameof(DataCabinPage));
            }
            else
            {
                await _pageDialogService.DisplayAlertAsync("Error", "Wrong Username or Password", "OK!");
            }
        }
    }
}
