using Prism.Unity;
using SD.Xamarin.Views;
using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace SD.Xamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null)
            : base(initializer)
        {
            MobileCenter.Start("android=5c81276c-2895-4204-a743-080b1e18ff04;"
                               + "ios=d9bb5279-f4b5-4d57-9888-8d6a16dfa690",
                               //+ "uwp={Your UWP App secret here};" 
                typeof(Analytics), typeof(Crashes));
        }

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
            Container.RegisterTypeForNavigation<DataCabinPage>();

            Container.RegisterTypeForNavigation<ChartPage>();
            Container.RegisterTypeForNavigation<GridPage>();
            Container.RegisterTypeForNavigation<GuagePage>();
            Container.RegisterTypeForNavigation<MapPage>();
        }
    }
}
