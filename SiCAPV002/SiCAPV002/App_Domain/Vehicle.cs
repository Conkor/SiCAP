using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.App_Domain
{
    public class Vehicle
    {
        private int id;
        private string numberPlate;
        private int idUser;
        private string color;
        private bool isApproved;
        private bool hasCertificate;
        private string type;

        public Vehicle()
        {
        }

        public Vehicle(int id, string numberPlate)
        {
            this.id = id;
            this.numberPlate = numberPlate;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string NumberPlate {
            get { return numberPlate; }
            set { numberPlate = value; }
        }
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public string Color {
            get { return color; }
            set { color = value; }
        }
        public bool IsAproved {
            get { return isApproved; }
            set { isApproved = value; }
        }
        public bool HasCertificate {
            get { return hasCertificate; }
            set { hasCertificate = value; }
        }
        public string Type {
            get { return type; }
            set { type = value; }
        }

        public Vehicle(string numberPlate, int idUser, string color, string type, bool isApproved, bool hasCertificate)
        {
            this.idUser = idUser;
            this.numberPlate = numberPlate;
            this.color = color;
            this.isApproved = isApproved;
            this.hasCertificate = hasCertificate;
            this.type = type;
        }



    }
}
