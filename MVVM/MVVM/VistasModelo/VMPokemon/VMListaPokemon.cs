using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.Vistas.Pokemon;
using MVVM.Datos;
using MVVM.Modelo;
using System.Collections.ObjectModel;

namespace MVVM.VistasModelo.VMPokemon
{
    public class VMListaPokemon : BaseViewModel
    {

        #region VARIABLES

        string _Texto;
        ObservableCollection<MPokemon> _listaPokemon;

        #endregion

        #region CONSTRUCTOR

        public VMListaPokemon(INavigation navigation)
        {

            Navigation = navigation;
            mostrarPokemon();

        }

        #endregion

        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public ObservableCollection<MPokemon> listaPokemon
        {
            get { return _listaPokemon; }
            set { SetValue(ref _listaPokemon, value);
                OnPropertyChanged();
            }
        }

        #endregion

        #region PROCESOS

        public async Task mostrarPokemon()
        {
            var funcion = new DPokemon();
            listaPokemon = await funcion.MostrarPokemon();
        }
        public async Task IrRegistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }

        public async Task IraDetalle(MPokemon parametros)
        {
            await Navigation.PushAsync(new DetallePokemon(parametros));
        }

        #endregion

        #region COMANDOS

        public ICommand iiARegistroCommand => new Command(async () => await IrRegistro());
        public ICommand IraDetalleCommand => new Command<MPokemon>(async (x) => await IraDetalle(x));
        #endregion

    }
}
