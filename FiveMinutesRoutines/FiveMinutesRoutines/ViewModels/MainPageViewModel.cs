using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FiveMinutesRoutines.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {


        private readonly INavigationService _navigationService;
        public DelegateCommand AreaSelected { get; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page1111";
            _navigationService = navigationService;
            AreaSelected = new DelegateCommand(OnAreaSelected);
        }


        private void OnAreaSelected()
        {

           
           _navigationService.NavigateAsync("Home");


        }
     





    }
}
