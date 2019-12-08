using Prism.Commands;
using FiveMinutesRoutines.Business;
using FiveMinutesRoutines.Services;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Xamarin.Forms;
using Syncfusion.XForms.Buttons;
using System.Collections.ObjectModel;

namespace FiveMinutesRoutines.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

       
        private const int V = 1000;
        private readonly INavigationService _navigationService;
        
        public DelegateCommand<string> AreaSelected { get; }
            private IInfo _recipeService { get; }
        public DelegateCommand start { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
           





            Title = "Welcome Back";
            _navigationService = navigationService;
            AreaSelected = new DelegateCommand<string>(OnAreaSelected);
            InfoSelectedCommand = new DelegateCommand<Business.Info>(InfoSelected);
            start = new DelegateCommand(Start);
            
        }
        public DelegateCommand<Business.Info> InfoSelectedCommand { get; }

        private async void InfoSelected(Business.Info info)
        {
            var p = new NavigationParameters
            {
                { "recipe", info }
            };

            await _navigationService.NavigateAsync("RecipePage", p);
        }

        private void OnAreaSelected(string name)
        {
                switch (name)
                {
                    case "Login":
                         _navigationService.NavigateAsync("Login");
                        break;
                    case "Home":
                         _navigationService.NavigateAsync("Home");
                        break;
                    
                }


        }

        static int time = 60;
        static int min = 5;
        static int userTime = min * time;
        static bool sts = true;

        private async void Start() {



            if (sts == true)
            {
                sts = false;
            }
            else if (sts == false)
            {
                sts = true;
            }
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {



                userTime--;
                timestring = userTime / 60 + ":" + ((userTime % 60) >= 10 ? (userTime % 60).ToString() : "0" + (userTime % 60));




                return sts;

            });




        }



        string timestring = "00:00";
        public string timeString
        {
            get { return timestring; }
            set { timestring = value; }
        }


  



    }
}
