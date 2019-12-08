using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiveMinutesRoutines.ViewModels
{
    class BreathingViewModel : BindableBase
    {


        public DelegateCommand<string> NavigateCommand { get; }

        INavigationService _navigationService;

        public BreathingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(String name)
        {
            switch (name)
            {
                case "Beginner":
                    await _navigationService.NavigateAsync("beginner");
                    break;
                case "Intermediate":
                    await _navigationService.NavigateAsync("intermediate");
                    break;
                case "Expert":
                    await _navigationService.NavigateAsync("expert");
                    break;
            }


        }
    }
}