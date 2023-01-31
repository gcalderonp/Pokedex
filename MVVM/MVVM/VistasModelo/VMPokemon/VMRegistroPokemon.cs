using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.Datos;
using MVVM.Modelo;

namespace MVVM.VistasModelo.VMPokemon
{
    public class VMRegistroPokemon : BaseViewModel
    {

        #region VARIABLES

        string _TxtColorFondo;
        string _TxtColorPoder;
        string _TxtNombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;

        #endregion

        #region CONSTRUCTOR

        public VMRegistroPokemon(INavigation navigation)
        {

            Navigation = navigation;

        }

        #endregion

        #region OBJETOS

        public string TxtColorFondo
        {
            get { return _TxtColorFondo; }
            set { SetValue(ref _TxtColorFondo, value); }
        }

        public string TxtColorPoder
        {
            get { return _TxtColorPoder; }
            set { SetValue(ref _TxtColorPoder, value); }
        }

        public string TxtNombre
        {
            get { return _TxtNombre; }
            set { SetValue(ref _TxtNombre, value); }
        }

        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }

        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }

        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }

        #endregion

        #region PROCESOS

        public async Task insertar()
        {

            var funcion = new DPokemon();
            var parametros = new MPokemon();

            parametros.ColorPoder = TxtColorPoder;
            parametros.ColorFondo = TxtColorFondo;
            parametros.Icono = Txticono;
            parametros.Nombre = TxtNombre;
            parametros.NrOrden = Txtnro;
            parametros.Poder = Txtpoder;

            await funcion.InsertarPokemon(parametros);
            await volver();

        }

        public async Task volver()
        {
            await Navigation.PopAsync();
        }

        public void procesoSimple()
        {

        }

        #endregion

        #region COMANDOS

        public ICommand volverCommand => new Command(async () => await volver());
        public ICommand procesoSimpCommand => new Command(procesoSimple);

        public ICommand insertarCommand => new Command(async () => await insertar());
        #endregion

    }
}
