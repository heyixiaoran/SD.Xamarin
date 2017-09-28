using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using SD.Xamarin.Common;
using SD.Xamarin.Models;
using SD.Xamarin.Views;
using Xamarin.Forms;

namespace SD.Xamarin.ViewModels
{
    public class DataCabinPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPageDialogService _pageDialogService;

        private DataCabinModel _selectedDataCabin;

        public DataCabinModel SelectedDataCabin
        {
            get { return _selectedDataCabin; }
            set
            {
                _selectedDataCabin = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<DataCabinModel> _dataCabins;

        public ObservableCollection<DataCabinModel> DataCabins
        {
            get { return _dataCabins; }
            set
            {
                _dataCabins = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<GroupingModel<string, DataCabinModel>> _dataCabinsGrouped;

        public ObservableCollection<GroupingModel<string, DataCabinModel>> DataCabinsGrouped
        {
            get { return _dataCabinsGrouped; }
            set
            {
                _dataCabinsGrouped = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _itemTappedCommand;

        public ICommand ItemTappedCommand
        {
            get { return _itemTappedCommand ?? new DelegateCommand(ItemTapped); }
            set { _itemTappedCommand = value; }
        }

        private ICommand _goBackCommand;

        public ICommand GoBackCommand
        {
            get { return _goBackCommand ?? new DelegateCommand(GoBack); }
            set { _goBackCommand = value; }
        }

        public DataCabinPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            _pageDialogService = pageDialogService;

            DataCabins = new ObservableCollection<DataCabinModel>()
            {
                new DataCabinModel(){Id=1,Name = "T1",GroupName="G1",DisplayType= DataCabinType.Chart},
                new DataCabinModel(){Id=2,Name = "T2",GroupName="G1",DisplayType= DataCabinType.Grid},
                new DataCabinModel(){Id=3,Name = "T3",GroupName="G2",DisplayType= DataCabinType.Guage},
                new DataCabinModel(){Id=4,Name = "T4",GroupName="G2",DisplayType= DataCabinType.Map}
            };

            var grouped = from menuItem in DataCabins
                          orderby menuItem.Id
                          group menuItem by menuItem.GroupName into menuItemGroup
                          select new GroupingModel<string, DataCabinModel>(menuItemGroup.Key, menuItemGroup);

            DataCabinsGrouped = new ObservableCollection<GroupingModel<string, DataCabinModel>>(grouped);
        }

        private async void ItemTapped()
        {
            if (SelectedDataCabin == null)
            {
                return;
            }

            switch (SelectedDataCabin.DisplayType)
            {
                case DataCabinType.Chart:
                    await _navigationService.NavigateAsync("/Master/Navigation/" + nameof(ChartPage));
                    break;
                case DataCabinType.Grid:
                    await _navigationService.NavigateAsync("/Master/Navigation/" + nameof(GridPage));
                    break;
                case DataCabinType.Guage:
                    await _navigationService.NavigateAsync("/Master/Navigation/" + nameof(GuagePage));
                    break;
                case DataCabinType.Map:
                    await _navigationService.NavigateAsync("/Master/Navigation/" + nameof(MapPage));
                    break;
                default:
                    await _pageDialogService.DisplayAlertAsync("Error", "Type Error!!!", "OK");
                    break;
            }
        }

        private void GoBack()
        {
            _navigationService.NavigateAsync(nameof(DataCabinPage));
        }
    }
}
