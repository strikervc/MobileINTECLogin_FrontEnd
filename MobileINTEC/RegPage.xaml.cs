using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileINTEC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }

        async void GoToMaster(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) | string.IsNullOrEmpty(Email.Text) | string.IsNullOrEmpty(Password.Text)| string.IsNullOrEmpty(Confirm.Text))
            {
                await DisplayAlert("Error", "Campo nombre, email y/o contraseña no puede estar vacío", "Ok");
            }
            else if (!Password.Text.Equals(Confirm.Text))
            {
                await DisplayAlert("Error", $"Las contraseñas deben coincidir", "Ok");
            }
            else
            {
                await Navigation.PushAsync(new HomePage());
                await DisplayAlert("Bienvenido", $"Bienvenido {Name.Text}", "Ok");
            }
            
        }
    }
}