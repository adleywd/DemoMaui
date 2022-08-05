using System.Collections.ObjectModel;
using DemoMaui.App.Model;
using DemoMaui.App.Services;
using CommunityToolkit.Mvvm.Input;
using DemoMaui.App.View;

namespace DemoMaui.App.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        private MainService _mainService;
        public ObservableCollection<TestModel> TestModels { get; } = new();

        public MainViewModel(MainService mainService)
        {
            Title = "Test Model Finder";
            _mainService = mainService;
            //GetTestDataCommand = new Command(async () => await GetTestData());
        }

        [RelayCommand]
        public async Task GotODetails(TestModel testModel)
        {
            if(testModel is null)
                return;

            await Shell.Current
                .GoToAsync($"{nameof(DetailsPage)}", true, 
                    new Dictionary<string, object>
                    {
                        {"TestModel", testModel}
                    })
                .ConfigureAwait(false);
        }

        [RelayCommand]
        public void GetTestData()
        {

            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
                var testdata = _mainService.GetTestList();

                if(TestModels.Count != 0)
                {
                    TestModels.Clear();
                }

                testdata.ForEach(data => TestModels.Add(data));

                //foreach (var testItem in testdata)
                //{
                //    TestModels.Add(testItem);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Shell.Current.DisplayAlert(
                    "Error!",
                    $"Error {e.Message}", 
                    "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
