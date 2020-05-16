using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_API
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class contiene : MasterDetailPage
    {
        public contiene()
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new Menu());

            App.MasterD = this;
        }
    }
}