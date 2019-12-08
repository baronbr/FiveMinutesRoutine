using Prism.Commands;
using Prism.Mvvm;
using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FiveMinutesRoutines.ViewModels
{
    public class WaterViewModel : BindableBase
    {

        public ObservableCollection<SfSegmentItem> SegmentItems { get; set; }
        static int v = 0;

        public bool set1 = false;
        public DelegateCommand AreaSelected { get; }
        public DelegateCommand<int> Add { get; }

        public WaterViewModel()
        {
            SegmentItems = new ObservableCollection<SfSegmentItem>
        {
            new SfSegmentItem(){Text="200ML",FontColor=Color.FromHex("#3F3F3F")},
            new SfSegmentItem(){Text="300ML",FontColor=Color.FromHex("#3F3F3F")},
            new SfSegmentItem(){Text="500ML",FontColor=Color.FromHex("#3F3F3F")},
            new SfSegmentItem(){Text="700ML",FontColor=Color.FromHex("#3F3F3F")},
            new SfSegmentItem(){Text="800ML",FontColor=Color.FromHex("#3F3F3F")},
        };
            AreaSelected = new DelegateCommand(OnAreaSelected);
            
        }

        private void OnAreaSelected()
        {





        }


       

    }
}