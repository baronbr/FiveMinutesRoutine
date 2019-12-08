using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;

namespace FiveMinutesRoutines.Views
{
    public partial class expert : ContentPage
    {
        static string time = "new";
        static int userTime = 60 * 5;
        static bool sts = true;
        static int maxsecond = 60;
        public expert()
        {
            InitializeComponent();
        }


        void st_Clicked(System.Object sender, System.EventArgs e)
        {
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
                _timePicker.Text = userTime / 60 + ":" + ((userTime % 60) >= 10 ? (userTime % 60).ToString() : "0" + (userTime % 60));




                return sts;

            });

        }





        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {


            userTime--;
            time = userTime / 60 + ":" + ((userTime % 60) >= 10 ? (userTime % 60).ToString() : "0" + (userTime % 60));

        }
    }
}
