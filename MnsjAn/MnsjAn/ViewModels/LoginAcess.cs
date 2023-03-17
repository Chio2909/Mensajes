using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MnsjAn.ViewModels
{
   public class LoginAcess
    {
        public static string sstrUser = "";

        //Encargado de asignar un valor a la propiedad keyEmail
        public LoginAcess(string pstrUser)
        {

            if (Application.Current.Properties.ContainsKey("keyUser"))
            {
                var vKeyUser = Application.Current.Properties["keyUser"];
                sstrUser = vKeyUser.ToString();
            }
        }
        //método encargado de retornar el valor de la propiedad keyEmail después de iniciar la sesión
        //(valor que persistirá durante todo el ciclo de vida de nuestra aplicación).
        public string AuthentifyLogin()
        {
            return sstrUser;
        }

        //encargado de limpiar las propiedades que administrar la sesión de la aplicación.
        public void LogoutLogin()
        {
            Application.Current.Properties["IsLoggedIn"] = false;
            Application.Current.Properties["keyUser"] = null;
        }
    }

}

