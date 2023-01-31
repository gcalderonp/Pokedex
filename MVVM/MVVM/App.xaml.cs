using MVVM.Vistas;
using MVVM.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListaPokemon());
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
