using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();

            // Evento para el botón regresar
            RegresarButton.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}
