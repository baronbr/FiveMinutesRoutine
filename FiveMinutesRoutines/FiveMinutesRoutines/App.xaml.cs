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
/*
        public static SignUp_Data Database
        {
            get
            {
                if (database == null)
                {
                    database = new SignUp_Data(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        */





        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer ) : base(initializer) { }

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

            containerRegistry.RegisterForNavigation<Breathing,BreathingViewModel>();
            containerRegistry.RegisterForNavigation<Streatching, StreatchingViewModel>();
            containerRegistry.RegisterForNavigation<Water, WaterViewModel>();
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();
            containerRegistry.RegisterForNavigation<SignUp, SignUpViewModel>();
            containerRegistry.RegisterForNavigation<Settings, SettingsViewModel>();
        }
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<Home, HomeViewModel>();
        }

    }
}
