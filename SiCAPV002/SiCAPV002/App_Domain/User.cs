using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.App_Domain
{
    public class User
    {
        private int id;
        private string username;
        private int idNumber;
        private string name;
        private string secondName;
        private string lastname;
        private string secondLastname;
        private string cellphone;
        private string password;
        private int idMajor;
        private int type;
        private bool hasCertificate;
        private bool isSantionated;

        public User()
        {
        username = "";
        idNumber = 0;
        name = "";
        secondName = "";
        lastname = "";
        secondLastname = "";
        cellphone = "";
        password = "";
        idMajor = 0;
        type=0;
        hasCertificate= false;
        }

        public User(int id,string username, int idNumber, string name, string secondName, string lastName, string secondLastname, string cellphone, string password, int idMajor, int type, bool hasCertificate)
        {
            this.id = id;
            this.username = username;
            this.idNumber = idNumber;
            this.name = name;
            this.secondName = secondName;
            this.lastname = lastName;
            this.secondLastname = secondLastname;
            this.cellphone = cellphone;
            this.password = password;
            this.idMajor = idMajor;
            this.type = type;
            this.hasCertificate = hasCertificate;

        }
        public User(string username, int idNumber,string name, string secondName, string lastName, string secondLastname, string cellphone, string password, int idMajor, int type, bool hasCertificate)
        {
            this.username = username;
            this.idNumber = idNumber;
            this.name = name;
            this.secondName = secondName;
            this.lastname = lastName;
            this.secondLastname = secondLastname;
            this.cellphone = cellphone;
            this.password = password;
            this.idMajor = idMajor;
            this.type = type;
            this.hasCertificate = hasCertificate;

        }
        public User(string username, int idNumber, string name, string secondName, string lastName, string secondLastname, string cellphone, string password, int idMajor, int type, bool hasCertificate, bool isSantionated)
        {
            
            this.username = username;
            this.idNumber = idNumber;
            this.name = name;
            this.secondName = secondName;
            this.lastname = lastName;
            this.secondLastname = secondLastname;
            this.cellphone = cellphone;
            this.password = password;
            this.idMajor = idMajor;
            this.type = type;
            this.hasCertificate = hasCertificate;
            this.isSantionated = isSantionated;

        }

        public User(string username)
        {
            this.username = username;
        }

        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string SecondLastName
        {
            get { return secondLastname; }
            set { secondLastname = value; }
        }

        public string Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool HasCertificate {
            get { return hasCertificate; }
            set { hasCertificate = value; }
        }

        public int IdMajor
        {
            get { return idMajor; }
            set { idMajor = value; }
        }
        public bool IsSantionated
        {
            get { return isSantionated; }
            set { isSantionated = value; }
        }

    }
}
