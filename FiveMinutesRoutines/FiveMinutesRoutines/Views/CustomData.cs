using Xamarin.Forms;

namespace FiveMinutesRoutines.Views
{
    public class CustomData : ContentPage
    {
        public CustomData(string image)
        {
            Image = image;
        }
        public string Image
        {
            get;
            set;
        }
        public CustomData()
        {

        }
    }
}