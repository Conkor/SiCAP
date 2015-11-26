using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.App_Domain
{
    public class ParkingSpace
    {
        private int id;
        private string spaceNumber;
        private int idParkingLot;

        public ParkingSpace() 
        {
        }

        public ParkingSpace(int id, string spaceNumber, int idParkingLot)
        {
            this.id = id;
            this.spaceNumber = spaceNumber;
            this.idParkingLot = idParkingLot;
        }

        public ParkingSpace(string spaceNumber, int idParkingLot)
        {
            this.spaceNumber = spaceNumber;
            this.idParkingLot = idParkingLot;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdParkingLot
        {
            get { return this.idParkingLot; }
            set { this.idParkingLot = value; }
        }

        public string SpaceNumber
        {
            get { return spaceNumber; }
            set { spaceNumber = value; }
        }



    }
}
