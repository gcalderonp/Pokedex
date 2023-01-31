using MVVM.Modelo;
using MVVM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.VistasModelo
{
    public class VMMenuPrincipal : BaseViewModel
    {

        #region VARIABLES

        string _Texto;
        public List<MMenuPrincipal> listaPaginas { get; set; }

        #endregion

        #region CONSTRUCTOR

        public VMMenuPrincipal(INavigation navigation)
        {

            Navigation = navigation;
            MostrarPaginas();

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

        public async Task volver()
        {
            await Navigation.PopAsync();
        }

        public async Task navegar(MMenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }

            if (pagina.Contains("collectionview"))
            {
                await Navigation.PushAsync(new Pagina2());
            }

            if (pagina.Contains("crud"))
            {
                await Navigation.PushAsync(new CrudPokemon());
            }
        }

        public void MostrarPaginas()
        {
            listaPaginas = new List<MMenuPrincipal>();

            listaPaginas.Add(new MMenuPrincipal
            {
                Pagina = "entry, datepicker, picker, label, navegacion",
                Icono = "volver.png"
            });

            listaPaginas.Add(new MMenuPrincipal
            {
                Pagina = "collectionview sin enlace a bd",
                Icono = "volver.png"
            });

            listaPaginas.Add(new MMenuPrincipal
            {
                Pagina = "crud pokemon",
                Icono = "volver.png"
            });


        }

        #endregion

        #region COMANDOS

        //public ICommand volverCommand => new Command(async () => await volver());
        public ICommand navegarCommand => new Command<MMenuPrincipal>(async (x) => await navegar(x));
        //public ICommand procesoSimpCommand => new Command(MostrarUsuarios);
        #endregion

    }
}
