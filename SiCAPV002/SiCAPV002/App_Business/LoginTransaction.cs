using System;
using SiCAP_GrupoCARARA.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SiCAP_GrupoCARARA.App_Security;

namespace SiCAP_GrupoCARARA.App_Business
{
    public partial class LoginTransaction : System.Web.UI.Page
    {
        string username;
        string password;

        // Únicamente se va a tener un sólo constructor, el sobrecargado..!!
        /* Desde el formulario correpondiente, entonces, se tendría que hacer SÓLO dos cosas para cada intento de login
              1)   declarar un objeto de LoginTransaction con sus parámetros: username y password en el new..., y
         *    2)   con el objeto anterior, llamar al método llamado "ExecuteLoginTransaction() y que retorna un string si no tiene éxito el login
         *    
         * Usando esta clase, el trabajo dentro del formulario de login, con JavaScript, se reduce a:
         *        ---->  Llevar a cabo 1)  y  2)
         *        ---->  En caso de que falle el login, capturar el mensaje que se retorna y desplegarlo...!!!
         *        
         */
        public LoginTransaction(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // El siguiente método hace la transacción general del LOGiN y devuelve un mensaje diferenciado para cada caso de respuesta, excepto la exitosa..!!!!

        public string executeLoginTransaction()
        {
            string message;

            if (username != "")
            {
                if (password != "")
                {
                    if (isExistingUser())
                    {
                        message = matchesUserName_and_Password(); // Hace el match de usuario y contraseña y devuelve mensaje en caso de no-correspondencia: Message03
                    }
                    else
                    {
                       message = Message02(); // Avisa que el usuario no existe... 
                    }
                }
                else
                {
                    message = Message04(); // Le indica al usuario que no ingresó nada en Password....
                }

            }
            else
            {
               message = Message01();  // Avisa que el usuario no ingresó nada en Username....
            }

            return message;
        }


        public bool isExistingUser()
        {
            bool isAnExistinguser = false;
            UserData userData = new UserData();
            if (userData.isARegisteredUser(username))
            {
                isAnExistinguser = true;
            }

            return isAnExistinguser;
        }


        public string matchesUserName_and_Password()
        {
            string message = "";
            UserData userData = new UserData();
            if (userData.comparesPasswordComingFromUser_toPasswordInDataBase(username, password))
            {
                String userSession = userData.checksInDataBaseIfUsernameExists(username);
                Session["user"] = userSession;
                

            }
            else
            {
                message = Message03(); // Avisa que la contraseña ingresada es incorrecta......  Debe imprimirse este mensaje en algún lugar del formulario Web Correspondiente
            };

            return message;
        }

        // Loa siguientes son los métodos con los 4 mensajes posibles para problemas del usuario con el login

        public string Message01()
        {
            return "Debe llenar la casilla 'NOMBRE DE USUARIO'";
        }

        public string Message02()
        {
            return "El nombre de usuario que ingresó no se encuentra registrado!";
        }

        public string Message03()
        {
            return "La contraseña que ingresó es incorrecta!";
        }

        public string Message04()
        {
            return "Debe llenar la casilla 'CONTRASEÑA'";
        }


    }
}