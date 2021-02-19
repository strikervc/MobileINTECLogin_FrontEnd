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
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void GoToSign(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }

        async void LogInUser(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(User.Text) | string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Error", "Campo email y/o contraseña no puede estar vacío", "Ok");
            }
            else
            {
                await DisplayAlert("Bienvenido", $"Hola {User.Text}", "Ok");  
            }
        }

    }
}