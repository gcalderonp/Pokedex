using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Modelo;

namespace MVVM.VistasModelo.VMPokemon
{
    public class VMDetallePokemon : BaseViewModel
    {

        #region VARIABLES

        string _Texto;
        public MPokemon _MPokemon12 { get; set; }

        #endregion

        #region CONSTRUCTOR

        public VMDetallePokemon(INavigation navigation, MPokemon parametros)
        {

            Navigation = navigation;
            _MPokemon12 = parametros;

        }

        #endregion

        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        #endregion

        #region PROCESOS

        public async Task ProcesoAsyncrono()
        {

        }

        public void procesoSimple()
        {

        }

        #endregion

        #region COMANDOS

        public ICommand procesoAsyncCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand procesoSimpCommand => new Command(procesoSimple);
        #endregion

    }
}
