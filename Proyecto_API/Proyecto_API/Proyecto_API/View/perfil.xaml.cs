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
    public partial class perfil : ContentPage
    {
        public perfil()
        {
            InitializeComponent();
            Getinformacion();
        }

        private async void Getinformacion()
        {
            HttpClient client = new HttpClient();
            var usu = await client.GetStringAsync("http://localhost:3000/api/burguer/user");
            var user = JsonConvert.DeserializeObject<List<usuario>>(usu);
            infousu.ItemsSource = user;
        }

        private void btnEditar_Clicked(object sender, EventArgs e)
        {
            var Men = "Estamos Trabajando En Eso...";
            if (!string.IsNullOrEmpty(Men))
            {
                DisplayAlert("Mensaje", Men, "Aceptar");
            }

        }
    }
}