using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace EXFAY
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CVPage());
        }
    }
}
