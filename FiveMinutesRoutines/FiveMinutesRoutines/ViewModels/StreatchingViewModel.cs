using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FiveMinutesRoutines.ViewModels
{
	public class StreatchingViewModel : BindableBase
	{

        private List<StreatchingViewModel> imageCollection = new List<StreatchingViewModel>();
       
        public List<StreatchingViewModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }



        public StreatchingViewModel()
        {

            ImageCollection.Add(new StreatchingViewModel("stretch1.png"));
            ImageCollection.Add(new StreatchingViewModel("stretch2.png"));
            ImageCollection.Add(new StreatchingViewModel("stretch3.png"));
            ImageCollection.Add(new StreatchingViewModel("stretch4.png"));
            ImageCollection.Add(new StreatchingViewModel("stretch5.png"));


        }

        public StreatchingViewModel(string imageString)
        {
            Image = imageString;
        }
        private String _image;
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }

    }
}
