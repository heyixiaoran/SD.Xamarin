using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace SD.Xamarin.ViewModels
{
    public class MapPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPageDialogService _pageDialogService;

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            _pageDialogService = pageDialogService;
        }
    }
}
