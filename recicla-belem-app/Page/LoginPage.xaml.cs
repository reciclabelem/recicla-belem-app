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
            await DisplayAlert("Erro", "Informe usu�rio e senha", "OK");
            return;
        }

        if (user == "admin" && password == "123")
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
            await DisplayAlert("Erro", "Usu�rio ou senha inv�lidos", "OK");
        }
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Registrar", "Aqui depois voc� ir� para a tela de cadastro.", "OK");
    }
}