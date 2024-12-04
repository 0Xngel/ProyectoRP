using Microsoft.Maui.Controls;

namespace TuProyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IniciarSesionButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new NewPage1());
            };
            CrearCuentaButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new MainPage());
            };
        }
    }
}
