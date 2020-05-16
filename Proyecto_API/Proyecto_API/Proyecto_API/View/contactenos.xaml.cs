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
    public partial class contactenos : ContentPage
    {
        public contactenos()
        {
            InitializeComponent();
        }

        private async void btn_comidas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionPage());
        }

        private async void btn_ilusionDos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionDosPage());
        }

        private async void btn_salir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
    }
}