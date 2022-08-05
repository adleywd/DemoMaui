using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using DemoMaui.App.Model;

namespace DemoMaui.App.ViewModel
{
    [QueryProperty("TestModel", "TestModel")]
    public partial class DetailsViewModel : BaseViewModel
    {
        public DetailsViewModel()
        {
            
        }

        [ObservableProperty]
        private TestModel _testModel;
    }
}
