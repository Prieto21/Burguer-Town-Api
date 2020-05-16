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
    public partial class NewProductPage : ContentPage
    {
        public NewProductPage()
        {
            InitializeComponent();
        }

        private async void btn_agregar_Clicked(object sender, EventArgs e)
        {
            string name = (nombre.Text);
            string img = (imagen.Text);
            string desc = (descripcion.Text);
            string id_clf = (clasificacion.Text);

            HttpClient client = new HttpClient();
            productos agregar = new productos();
            agregar.nombre = name;
            agregar.imagen = img;
            agregar.descripcion = desc;
            agregar.id_clasificacion = id_clf;



            String jsonAdd = JsonConvert.SerializeObject(agregar);
            var content = new StringContent(jsonAdd, Encoding.UTF8, "application/json");
            string url = "http://localhost:3000/api/burguer/product/add";
            var respon = await client.PostAsync(url, content);
        }
    }
}