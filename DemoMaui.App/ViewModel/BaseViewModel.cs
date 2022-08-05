using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DemoMaui.App.ViewModel
{
    public partial class BaseViewModel: ObservableObject
    {
        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private bool _isBusy;

        public bool IsNotBusy => !_isBusy;
        public BaseViewModel()
        {

        }
    }
}
