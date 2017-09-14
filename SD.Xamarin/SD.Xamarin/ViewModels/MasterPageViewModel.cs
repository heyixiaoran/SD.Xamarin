using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Prism.Events;
using Prism.Services;
using SD.Xamarin.Common;
using SD.Xamarin.Models;
using SD.Xamarin.Views;

namespace SD.Xamarin.ViewModels
{
    public class MasterPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPageDialogService _pageDialogService;
        
        public MasterPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            _pageDialogService = pageDialogService;
        }
    }
}
