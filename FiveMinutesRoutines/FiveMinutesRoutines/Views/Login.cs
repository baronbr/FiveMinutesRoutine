using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FiveMinutesRoutines.Views
{
    public partial class Login : CarouselPage
    {
        static bool sts = true;
        public Login()
        {
            InitializeComponent();
        }
        void OnToggled(object sender, ToggledEventArgs e)
        {
            if (sts == true)
            {
                sts = false;
            }
            else if (sts == false)
            {
                sts = true;
            }
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                CrossLocalNotifications.Current.Show("5 Minute Routines", "Drink Water");
                return sts;

            });

            CrossLocalNotifications.Current.Show("5 Minute Routines", "Stretch", 102, DateTime.Now.AddSeconds(45));

        }
    }
}