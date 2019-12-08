using System;

using Xamarin.Forms;

namespace FiveMinutesRoutines.ViewModels
{
    public class breathHomeViewModel : ContentPage
    {
        public breathHomeViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

