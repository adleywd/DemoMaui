using DemoMaui.App.View;

namespace DemoMaui.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent(); 

            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        }
    }
}