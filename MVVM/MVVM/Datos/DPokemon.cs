using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Modelo;
using MVVM.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace MVVM.Datos
{
    public class DPokemon
    {

        public async Task InsertarPokemon(MPokemon parametros)
        {
            await CConexion.firebase
                .Child("Pokemon")
                .PostAsync(new MPokemon()
                {
                    ColorFondo = parametros.ColorFondo,
                    ColorPoder = parametros.ColorPoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    NrOrden = parametros.NrOrden,
                    Poder = parametros.Poder
                });
        }
        
        public async Task<ObservableCollection<MPokemon>> MostrarPokemon()
        {
            //ejemplo usando observablecollection
            var data = await Task.Run(() => CConexion.firebase
                .Child("Pokemon")
                .AsObservable<MPokemon>()
                .AsObservableCollection());

            return data;

            //ejemplo usando listas
            //return (await CConexion.firebase.Child("Pokemon")
            //    .OnceAsync<MPokemon>())
            //    .Select(item => new MPokemon
            //    {
            //        IdPokemon = item.Key,
            //        Nombre = item.Object.Nombre,
            //        ColorFondo = item.Object.ColorFondo,
            //        ColorPoder = item.Object.ColorPoder,
            //        Poder = item.Object.Poder,
            //        NrOrden = item.Object.NrOrden,
            //        Icono = item.Object.Icono
            //    }).ToList();
        }

    }
}
