using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiCAP_GrupoCARARA.App_Domain
{
    public class ParkingLot
    {
        int id;
        string parkingLotName;
        bool exists;

        public ParkingLot()
        {
        }

        public ParkingLot(int id, string parkingLotName, bool exists)
        {
            this.id = id;
            this.parkingLotName = parkingLotName;
            this.exists = exists;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ParkingLotName
        {
            get { return parkingLotName; }
            set { parkingLotName = value; }
        }

        public bool Exists
        {
            get { return exists; }
            set { exists = value; }
        }


    }
}