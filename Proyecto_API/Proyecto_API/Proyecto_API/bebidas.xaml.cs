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
    public partial class bebidas : ContentPage
    {
        public bebidas()
        {
            InitializeComponent();
            Getbebidas();
        }

        private async void Getbebidas()
        {
            HttpClient client = new HttpClient();
            var pro = await client.GetStringAsync("http://localhost:3000/api/burguer/bebidas");
            var bebi = JsonConvert.DeserializeObject<List<productos>>(pro);
            bebida.ItemsSource = bebi;
        }
    }
}