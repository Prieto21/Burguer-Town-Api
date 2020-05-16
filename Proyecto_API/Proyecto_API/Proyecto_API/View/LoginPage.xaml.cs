using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_API
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

     

        private async void btn_usuario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionPage());
        }

        private async void btn_administrador_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new contiene());
        }

        private async void btn_agregarUsu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddUsuarioPage());
        }
    }
}