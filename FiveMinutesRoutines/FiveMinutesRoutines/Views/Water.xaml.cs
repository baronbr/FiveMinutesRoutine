using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace FiveMinutesRoutines.Views
{




    public partial class Water : ContentPage
    {
        public Water()
        {
            InitializeComponent();
        }

        int val = 0;
        int val1 = 0;

        void add_Clicked(System.Object sender, System.EventArgs e)
        {


            val1 += 25;
            Pointer.Value += val1;

            if (val1 >= 25) { 
            val +=  500;
                }
            LiterText.Text = $"{ val } ml";
          
        }



    }

    
        
}



