using Microsoft.Maui.Controls;

namespace EXFAY
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string validUsername = "admin";  
            string validPassword = "admin";  

            if (UsuarioEntry.Text == validUsername && PasswordEntry.Text == validPassword)
            {
                LoginMessage.Text = "Bienvenido a la carrera de Desarrollo del Software";
            }
            else
            {
                LoginMessage.Text = "Usuario o contraseña incorrectos";
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

