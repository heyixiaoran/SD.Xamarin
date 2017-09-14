using Prism.Unity;
using SD.Xamarin.Views;
using Xamarin.Forms;

namespace SD.Xamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) 
            : base(initializer)
        { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(nameof(LoginPage));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>("Navigation");

            Container.RegisterTypeForNavigation<RegistPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<MasterPage>("Master");
            Container.RegisterTypeForNavigation<ChartPage>();
            Container.RegisterTypeForNavigation<GridPage>();
            Container.RegisterTypeForNavigation<GuagePage>();
            Container.RegisterTypeForNavigation<MapPage>();
            Container.RegisterTypeForNavigation<DataCabinPage>();
        }
    }
}
