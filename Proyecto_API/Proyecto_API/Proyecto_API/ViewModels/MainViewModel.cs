using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_API.ViewModels
{
    class MainViewModel
    {

        public InicioViewModel Inicio { get; set; }
        public AddUsuarioViewModel AddUsuario { get; set; }
        public ContactenosViewModel Contactenos { get; set; }
        public IlusionViewModel Ilusion { get; set; }
        public IlusionDosViewModel IlusionDos { get; set; }
        public LoginViewModel Login { get; set; }
        public MenuViewModel Menu { get; set; }
        public NewProductViewModel NewProduct { get; set; }
        public PerfilViewModel Perfil { get; set; }
        public BebidasViewModel Bebidas { get; set; }



        public MainViewModel()
        {
            this.AddUsuario = new AddUsuarioViewModel();
        }

    }
}
