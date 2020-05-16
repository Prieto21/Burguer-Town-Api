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
    public partial class AddUsuarioPage : ContentPage
    {
        public AddUsuarioPage()
        {
            InitializeComponent();
        }

        private async void btn_ilusion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IlusionPage());
        }

        private async void btn_agregar_Clicked(object sender, EventArgs e)
        {
            string name = (nombre.Text);
            string lastname = (apellido.Text);
            string users = (user.Text);
            string password = (pass.Text);

            HttpClient client = new HttpClient();
            usuario agregar = new usuario();
            agregar.nombre = name;
            agregar.apellido = lastname;
            agregar.user = users;
            agregar.pass = password;



            String jsonAdd = JsonConvert.SerializeObject(agregar);
            var content = new StringContent(jsonAdd, Encoding.UTF8, "application/json");
            string url = "http://localhost:3000/api/burguer/user/add";
            var respon = await client.PostAsync(url, content);
        }
    }
}