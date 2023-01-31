using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM.VistasModelo.VMPokemon;

namespace MVVM.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPokemon : ContentPage
    {

        //VMListaPokemon vm;

        public ListaPokemon()
        {
            InitializeComponent();
            
            BindingContext = new VMListaPokemon(Navigation);
            //this.Appearing += ListaPokemon_Appearing;
        }

        /*private async void ListaPokemon_Appearing(object sender, EventArgs e)
        {
            await vm.mostrarPokemon();
        }*/
    }
}