using Proyecto_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_API.Infraestructure
{
    class IntanceLocator
    {

        public MainViewModel Main { get; set; }


        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
