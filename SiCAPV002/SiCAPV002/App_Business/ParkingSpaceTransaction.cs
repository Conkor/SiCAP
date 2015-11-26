using SiCAP_GrupoCARARA.Data;
using SiCAP_GrupoCARARA.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SiCAP_GrupoCARARA.App_Business
{
    public class ParkingSpaceTransaction
    {

        ParkingSpaceData parkingSpaceData = new ParkingSpaceData();

        public void InsertNewParkingSpace(ParkingSpace parkingSpace)
        {
            parkingSpaceData.InsertParkingSpace(parkingSpace);
        }

        public List<string> PrintExistingSpaces(int idParkingLot)
        {
            return parkingSpaceData.ReadParkingSpacesFromDB(idParkingLot);
        }

        public void deleteLastSpaceinDB(int idParkingLot)
        {
            parkingSpaceData.eliminateLastSpace(idParkingLot);

        }

        public List<string> GetAllReservedSpacesOnDayAndHour(int idParkingLot, DateTime date, int idTimeForReservation)
        {
            return parkingSpaceData.GetAllReservedSpacesForOneHour(idParkingLot, date, idTimeForReservation);
        }

    }
}