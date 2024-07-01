using Microsoft.Maui.Controls;

namespace EXFAY
{
    public partial class CVPage : ContentPage
    {
        public CVPage()
        {
            InitializeComponent();
        }

        private async void OnCVButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CVPage());
        }

        private async void OnIMCButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IMCPage());
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
