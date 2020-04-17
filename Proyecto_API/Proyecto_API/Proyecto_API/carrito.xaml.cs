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
    public partial class carrito : ContentPage
    {
        public carrito()
        {
            InitializeComponent();
            Getcarrito();
        }

        private async void Getcarrito()
        {
            HttpClient client = new HttpClient();
            var pro = await client.GetStringAsync("http://localhost:3000/api/burguer/carrito");
            var cars = JsonConvert.DeserializeObject<List<productos>>(pro);
            carro.ItemsSource = cars;
        }
    }
}