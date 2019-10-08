using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveMinutesRoutines.ViewModels
{
    public class LoginViewModel : BindableBase
    {



        public DelegateCommand<string> NavigateCommand { get; }

        INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(String name)
        {
            
                    await _navigationService.NavigateAsync("Home");
                  

            }
        }
    }

