using MVVM.Modelo;
using MVVM.VistasModelo.VMPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePokemon : ContentPage
    {
        public DetallePokemon(MPokemon parametros)
        {
            InitializeComponent();
            BindingContext = new VMDetallePokemon(Navigation, parametros);
        }
    }
}