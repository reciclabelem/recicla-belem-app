using Microsoft.Maui.Controls;

namespace recicla_belem_app.Page;

public partial class TiposLixoPage : ContentPage
{
    public TiposLixoPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Cadastro", "Tipos de Lixo sem banco no momento.", "OK");
    }

    private void OnLimparClicked(object sender, EventArgs e)
    {
        MaterialEntry.Text = string.Empty;
        OrigemEntry.Text = string.Empty;
        CorEntry.Text = string.Empty;
        OrigemDescrEntry.Text = string.Empty;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
