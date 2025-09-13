using Microsoft.Maui; 
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using recicla_belem_app.Page;

namespace recicla_belem_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500; // Largura aproximada de um celular
            window.Height = 800; // Altura aproximada de um celular

            return window;
        }
    }
}
