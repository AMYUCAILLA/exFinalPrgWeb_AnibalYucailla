using Microsoft.Maui.Controls;

namespace EXFAY
{
    public partial class IMCPage : ContentPage
    {
        public IMCPage()
        {
            InitializeComponent();
        }

        private void OnCalculateIMCClicked(object sender, EventArgs e)
        {
            
            if (double.TryParse(PesoEntry.Text, out double peso) && double.TryParse(AlturaEntry.Text, out double altura))
            {
                double alturaMetros = altura / 100;  // Convertir cm a metros
                double imc = peso / (alturaMetros * alturaMetros);  // Calcular IMC
                ResultLabel.Text = $"IMC: {imc:F2}";
            }
            else
            {
                ResultLabel.Text = "Por favor, ingrese correctamente el peso y la altura.";
            }



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
