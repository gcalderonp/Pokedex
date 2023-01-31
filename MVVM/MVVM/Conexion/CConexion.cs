using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM.Conexion
{
    public class CConexion
    {

        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-1451b-default-rtdb.firebaseio.com/");

    }
}
