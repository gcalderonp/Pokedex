using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.VistasModelo
{
    internal class VMPatron : BaseViewModel
    {

        #region VARIABLES

        string _Texto;

        #endregion

        #region CONSTRUCTOR

        public VMPatron(INavigation navigation)
        {

            Navigation = navigation;

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

        public ICommand procesoAsyncCommand => new Command(async() => await ProcesoAsyncrono());
        public ICommand procesoSimpCommand => new Command(procesoSimple);
        #endregion

    }
}
