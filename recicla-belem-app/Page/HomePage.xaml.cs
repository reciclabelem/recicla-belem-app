using Microsoft.Maui.Controls;

namespace recicla_belem_app.Page;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnTiposLixoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TiposLixoPage());
    }

    private async void OnMapaClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mapa", "Aqui você verá os pontos de coleta.", "OK");
    }

    private async void OnDesafiosClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Desafios", "Aqui você verá os desafios semanais.", "OK");
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
