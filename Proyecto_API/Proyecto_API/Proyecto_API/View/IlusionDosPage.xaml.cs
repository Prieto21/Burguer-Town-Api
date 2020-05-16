using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_API
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IlusionDosPage : ContentPage
    {
        public IlusionDosPage()
        {
            InitializeComponent();
            GetilusionDos();
        }

        private async void GetilusionDos()
        {
            HttpClient client = new HttpClient();
            var pro = await client.GetStringAsync("http://localhost:3000/api/burguer/bebidas");
            var bebi = JsonConvert.DeserializeObject<List<productos>>(pro);
            bebida.ItemsSource = bebi;
        }

        private async void btn_ilusion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionPage());
        }

        private async void btn_salir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

        private async void btn_somos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new contactenos());
        }
    }
}