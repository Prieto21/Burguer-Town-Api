using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_API
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterD { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Inicio());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
