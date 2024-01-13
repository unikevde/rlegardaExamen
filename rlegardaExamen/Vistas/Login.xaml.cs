namespace rlegardaExamen.Vistas;

public partial class Login : ContentPage
{
    string[] users = {"estudiante2024 ", "examen1", "NombreEstudiante"};
    string[] passwords = {"uisrael2024", "parcial1", "2024"};
    public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtusuario.Text;
        string password = txtpassword.Text;
        int index = Array.IndexOf(users, usuario);
        if (index != -1 && passwords[index] == password)
        {
            string nombreUsuario = users[index];
            DisplayAlert("Bienvenido", $"¡Hola {nombreUsuario}!", "Aceptar");
            Navigation.PushAsync(new Vistas.Registro(nombreUsuario));
        }
        else
        {

            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancelar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }
}