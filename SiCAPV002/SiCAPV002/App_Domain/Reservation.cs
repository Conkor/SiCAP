using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace SiCAP_GrupoCARARA.App_Domain
{
    public class Reservation
    {
        private int id;
        private DateTime date;
        private int idTimeForReservation;
        private int idUser;
        private int idParkingSpace;
        private int idVehicle;
        private bool hasBeenCanceled;

        public Reservation()
        {
        }

        public Reservation(int id, DateTime date, int idTimeForReservation, int idUser, int idParkingSpace, int idVehicle, bool hasBeenCanceled)
        {
            this.id = id;
            this.date = date;
            this.idTimeForReservation = idTimeForReservation;
            this.idUser = idUser;
            this.idParkingSpace = idParkingSpace;
            this.idVehicle = idVehicle;
            this.hasBeenCanceled = hasBeenCanceled;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int IdTimeForReservation
        {
            get { return idTimeForReservation; }
            set { idTimeForReservation = value; }
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public int IdParkingSpace
        {
            get { return idParkingSpace; }
            set { idParkingSpace = value; }
        }

        public int IdVehicle
        {
            get { return idVehicle; }
            set { idVehicle = value; }
        }
        public bool HasBeenCanceled
        {
            get { return hasBeenCanceled; }
            set { hasBeenCanceled = value; }
        }


    }
}
