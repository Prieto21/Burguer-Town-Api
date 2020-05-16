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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            Gethamburguesas();
        }

        private async void Gethamburguesas()
        {
            HttpClient client = new HttpClient();
            var pro = await client.GetStringAsync("http://localhost:3000/api/burguer/burger");
            var bur = JsonConvert.DeserializeObject<List<productos>>(pro);
            burguer.ItemsSource = bur;
        }
    }
}