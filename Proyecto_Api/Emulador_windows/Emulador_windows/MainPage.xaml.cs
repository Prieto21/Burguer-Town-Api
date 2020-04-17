using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Emulador_windows
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Getusuarios();
        }

        private async void Getusuarios()
        {
            HttpClient client = new HttpClient();
            var usu = await client.GetStringAsync("http://localhost:3000/api/yuju/user");
            var user = JsonConvert.DeserializeObject<List<usuarios>>(usu);
            usuario.ItemsSource = user;

        }
    }
}
