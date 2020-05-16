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
    public partial class IlusionPage : ContentPage
    {
        public IlusionPage()
        {
            InitializeComponent();
            Getilusion();
        }

        private async void Getilusion()
        {
            HttpClient client = new HttpClient();
            var pro = await client.GetStringAsync("http://localhost:3000/api/burguer/burger");
            var bur = JsonConvert.DeserializeObject<List<productos>>(pro);
            burguer.ItemsSource = bur;
        }

        private async void btn_salir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

        private async void btn_ilusionDos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionDosPage());
        }

        private async void btn_somos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new contactenos());
        }
    }
}