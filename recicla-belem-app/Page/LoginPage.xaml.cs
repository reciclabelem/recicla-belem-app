using Microsoft.Maui.Controls;

namespace recicla_belem_app.Page;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Limpa os campos ao voltar
        UserEntry.Text = string.Empty;
        PasswordEntry.Text = string.Empty;
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
            await Navigation.PushAsync(new HomePage());
        }
        else
        {
            await DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
        }
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
    private async void OnExitClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Confirmação", "Deseja realmente sair do aplicativo?", "Sim", "Cancelar");
        
        if (!confirmar)
            return;

        var button = sender as Button;

        await Task.WhenAll(
            button.ScaleTo(0.8, 150),
            button.FadeTo(0, 150)
        );
#if ANDROID
        Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
#elif WINDOWS
        Application.Current.Quit();
#elif IOS
        // iOS não permite fechar o app programaticamente
#endif
    }
}