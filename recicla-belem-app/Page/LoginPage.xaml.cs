using Microsoft.Maui.Controls;

namespace recicla_belem_app.Page;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string user = UserEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Erro", "Informe usuário e senha", "OK");
            return;
        }

        if (user == "admin" && password == "123")
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
            await DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
        }
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Registrar", "Aqui depois você irá para a tela de cadastro.", "OK");
    }
}