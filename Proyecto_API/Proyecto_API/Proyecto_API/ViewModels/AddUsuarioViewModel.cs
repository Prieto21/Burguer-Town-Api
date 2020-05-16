using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_API.ViewModels
{
    class AddUsuarioViewModel
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public ICommand agregarCommand
        {
            get
            {
                return new RelayCommand(Usuario);
            }
        }

        public async void Usuario()
        {
            string name = (this.Nombre);
            string lastname = (this.Apellido);
            string users = (this.User);
            string password = (this.Pass);


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
