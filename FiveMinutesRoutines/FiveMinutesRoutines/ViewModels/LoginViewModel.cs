using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using FiveMinutesRoutines.Models;
using System.Windows.Input;
using SQLite;

using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiveMinutesRoutines.ViewModels
{
    public class LoginViewModel : BindableBase
    {


        private string _firstName ;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }


        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public ICommand SignIn { get; set;  }

        /// <summary>
        /// the next part of the code is the navetation between the
        /// login and signup page.
        /// </summary>
        public DelegateCommand<string> NavigateCommand { get; }

        INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);

            SignIn = new DelegateCommand(executeMethod, canExecuteMethod).ObservesProperty(()=> FirstName).ObservesProperty(()=>LastName);
        }

        private bool canExecuteMethod()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
        }

        private void executeMethod()
        {
            //Navigate(location);
            Navigate("Home");
            EnterData();
        }

        string location = "";
        private async void Navigate(String name)
        {
            this.location = name;
            await _navigationService.NavigateAsync(name);

        }

        private void EnterData() {

            Test test = new Test();

            test.Name = FirstName;
            test.LName = LastName;
      
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Test>();
                int rows = conn.Insert(test);

                if (rows > 0)
                    Application.Current.MainPage.DisplayAlert("Success", "Experience succesfully inserted", "Ok");
                else
                    Application.Current.MainPage.DisplayAlert("Failure", "Experience failed to be inserted", "Ok");
            }
        }




    }
}

