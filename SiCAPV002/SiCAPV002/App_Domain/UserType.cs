using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAPV002.App_Domain
{
    class UserTypes
    {
        private int idUserType;
        private string userType;
        private string descripcion;

        public int IdUserType
        {
            get { return idUserType; }
            set { idUserType = value; }
        }
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public UserTypes(int idUserType, string userType)
        {
            this.idUserType = idUserType;
            this.userType = userType;
        }
    }
}
