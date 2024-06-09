using Microsoft.Maui.Controls;
using ProyectoP2Patoalarmas.Helpers;
using ProyectoP2Patoalarmas.Views.Admin;

namespace ProyectoP2Patoalarmas.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (email == Config.AdminEmail && password == Config.AdminPassword)
            {
                await Navigation.PushAsync(new GestionUsuario() );
            }
            else
            {
                await DisplayAlert("Error", "Correo o contraseña incorrectos", "OK");
            }
        }
    }
}
