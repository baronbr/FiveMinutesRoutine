using Prism;
using Prism.Ioc;
using Prism.Unity;
using FiveMinutesRoutines.ViewModels;
using FiveMinutesRoutines.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Mvvm;
using System;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FiveMinutesRoutines
{
    public partial class App
    {


        static SignUp_Data database;

        public static string DatabaseLocation = string.Empty;

    
        public App(string databaseLocation)

        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTY3MDc0QDMxMzcyZTMzMmUzMGlmSzRCbVdGcS9abGRjNUpleUVmYUNmNExuUVc1NUJiS3ltMjQySXR3WW89");


            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
        }
      
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App( ) : this(null) {  }

        public App(IPlatformInitializer initializer, string databaseLocation) : base(initializer) {



            MainPage = new NavigationPage(new MainPage())
            {

                BarTextColor = Color.FromHex("90FFFF"),
                BarBackgroundColor = Color.FromHex("0A09FA")
           

        };

            DatabaseLocation = databaseLocation;
        }

    
        protected override  async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("Login");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Home , HomeViewModel>();

            containerRegistry.RegisterForNavigation<breathHome,BreathingViewModel>();
            containerRegistry.RegisterForNavigation<beginner, BreathingViewModel>();
            containerRegistry.RegisterForNavigation<intermediate, BreathingViewModel>();
            containerRegistry.RegisterForNavigation<expert, BreathingViewModel>();

            containerRegistry.RegisterForNavigation<Streatching, StreatchingViewModel>();
            containerRegistry.RegisterForNavigation<Water, WaterViewModel>();
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();
            containerRegistry.RegisterForNavigation<SignUp, SignUpViewModel>();
            containerRegistry.RegisterForNavigation<Settings, SettingsViewModel>();
            containerRegistry.RegisterForNavigation<List>();

        }
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<Home, HomeViewModel>();
        }

    }
}
