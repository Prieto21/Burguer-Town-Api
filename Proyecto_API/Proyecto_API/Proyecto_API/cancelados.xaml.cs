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
    public partial class cancelados : ContentPage
    {
        public cancelados()
        {
            InitializeComponent();
            Getcancelados();
        }

        private async void Getcancelados()
        {
            HttpClient client = new HttpClient();
            var pediC = await client.GetStringAsync("http://localhost:3000/api/burguer/cancel");
            var cancel = JsonConvert.DeserializeObject<List<estadoo>>(pediC);
            cancelado.ItemsSource = cancel;
        }
    }
}