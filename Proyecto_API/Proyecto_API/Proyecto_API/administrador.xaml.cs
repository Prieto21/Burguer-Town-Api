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
    public partial class administrador : ContentPage
    {
        public administrador()
        {
            InitializeComponent();
            GetpedidosActivos();
            GetpedidosCancelados();
        }

        private async void GetpedidosCancelados()
        {
            HttpClient client = new HttpClient();
            var pediC = await client.GetStringAsync("http://localhost:3000/api/burguer/cancel");
            var cancel = JsonConvert.DeserializeObject<List<estadoo>>(pediC);
            cancelado.ItemsSource = cancel;
        }

        private async void GetpedidosActivos()
        {
            HttpClient client = new HttpClient();
            var pediA = await client.GetStringAsync("http://localhost:3000/api/burguer/activos");
            var activados = JsonConvert.DeserializeObject<List<estadoo>>(pediA);
            activo.ItemsSource = activados;
        }
    }
}