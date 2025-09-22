using Microsoft.Maui.Controls;

namespace recicla_belem_app.Page;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Cadastro", "Cadastro de usuário sem banco no momento.", "OK");
    }

    private async void OnExitClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
