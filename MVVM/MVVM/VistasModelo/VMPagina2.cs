using MVVM.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.VistasModelo
{
    public class VMPagina2 : BaseViewModel
    {

        #region VARIABLES

        string _Texto;
        public List<MUsuarios> listaUsuarios { get; set; }

        #endregion

        #region CONSTRUCTOR

        public VMPagina2(INavigation navigation)
        {

            Navigation = navigation;
            MostrarUsuarios();

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

        public async Task alerta(MUsuarios parametros)
        {
            await DisplayAlert("titulo", parametros.Nombre, "OK");
        }

        public void MostrarUsuarios()
        {
            listaUsuarios = new List<MUsuarios>();

            listaUsuarios.Add(new MUsuarios
            {
                Nombre = "george",
                Imagen = "volver.png"
            });

            listaUsuarios.Add(new MUsuarios
            {
                Nombre = "reinaldo",
                Imagen = "volver.png"
            });

            listaUsuarios.Add(new MUsuarios
            {
                Nombre = "calderon",
                Imagen = "volver.png"
            });


        }

        #endregion

        #region COMANDOS

        public ICommand volverCommand => new Command(async () => await volver());
        public ICommand alertaCommand => new Command<MUsuarios>(async (x) => await alerta(x));
        //public ICommand procesoSimpCommand => new Command(MostrarUsuarios);
        #endregion

    }
}
