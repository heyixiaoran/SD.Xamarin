using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using SD.Xamarin.Views;
using Xamarin.Forms;

namespace SD.Xamarin.ViewModels
{
    public class ChartPageViewModel: BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPageDialogService _pageDialogService;

        

        public ChartPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            _pageDialogService = pageDialogService;
        }

        
    }
}
