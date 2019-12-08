using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveMinutesRoutines.ViewModels
{
	public class HomeViewModel : BindableBase
	{




        // private DelegateCommand _navigateCommand;



        public DelegateCommand<string> NavigateCommand { get; }

        INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(String name)
        {
            switch (name)
            {
                case "Breathing":
                    await _navigationService.NavigateAsync("breathHome");
                    break;
                case "Stretching":
                    await _navigationService.NavigateAsync("Streatching");
                    break;
                case "Water":
                    await _navigationService.NavigateAsync("Water");
                    break;
            }

           
        }
    }
    }
