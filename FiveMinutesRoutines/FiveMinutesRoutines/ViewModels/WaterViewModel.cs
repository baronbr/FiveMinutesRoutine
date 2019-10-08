using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveMinutesRoutines.ViewModels
{
	public class WaterViewModel : BindableBase
	{

       
        public bool set1 = false;
        public DelegateCommand AreaSelected { get; }
        public WaterViewModel()
        {

            AreaSelected = new DelegateCommand(OnAreaSelected);
        }

        private void OnAreaSelected()
        {


           


        }


    }
}
