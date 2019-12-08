using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xamd.ImageCarousel.Forms.Plugin.Abstractions;
using System.Timers;
using System.Threading;
using System.Collections.ObjectModel;


namespace FiveMinutesRoutines.Views
{
    public partial class Streatching : ContentPage
    {

        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();

        public Streatching()
        {
            InitializeComponent();



            imageSources.Add("stretch1.png");
            imageSources.Add("stretch2.png");
            imageSources.Add("stretch3.png");
            imageSources.Add("stretch4.png");
            imageSources.Add("stretch5.png");

            imgSlider.Images = imageSources;
            

        }
    }
}
