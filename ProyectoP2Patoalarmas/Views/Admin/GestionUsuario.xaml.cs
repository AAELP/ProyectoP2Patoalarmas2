using ProyectoP2Patoalarmas.Models;

namespace ProyectoP2Patoalarmas.Views.Admin;

public partial class GestionUsuario : ContentPage
{
    private UsuarioViewModel viewModel;
    public GestionUsuario()
	{
		InitializeComponent();
        // Crear una instancia del ViewModel
        viewModel = new UsuarioViewModel();

        // Establecer el contexto de datos de la p�gina
        this.BindingContext = viewModel;

        // Cargar los datos de los usuarios, si necesario
        viewModel.CargarUsuarios();
    }
    private async void OnAgregarUsuarioClicked(object sender, EventArgs e)
    {
        string nombre = await DisplayPromptAsync("Nuevo Usuario", "Ingrese el nombre del usuario:");
        if (!string.IsNullOrWhiteSpace(nombre))
        {
            string email = await DisplayPromptAsync("Nuevo Usuario", "Ingrese el email del usuario:");
            if (!string.IsNullOrWhiteSpace(email))
            {
                // Aqu�, asumimos que tienes una funci�n en tu ViewModel para agregar el usuario.
                // Puedes pasar m�s informaci�n seg�n el modelo de tu usuario.
                viewModel.AgregarUsuario(new Usuario { Nombre = nombre, Email = email });
            }
        }
    }
}