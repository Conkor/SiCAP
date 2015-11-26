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
    public class ReservationTransaction
    {

        ReservationData reservationData = new ReservationData();

        public void InsertReservation(SiCAP_GrupoCARARA.App_Domain.Reservation reservation)
        {
            reservationData.InsertReservation(reservation);
        }



        public  List<Vehicle> ReadVehiclesOfUser(User user)
        {
            List<Vehicle> lstVehiclesOfOneUser = reservationData.readVehiclesOfUserFromDB(user);

            return lstVehiclesOfOneUser;
        }

        public List<ParkingLot> ReadExistingParkingLots()
        {
            List<ParkingLot> lstParkingLots = reservationData.ReadExistingParkingLotsFromDB();

            return lstParkingLots;
        }
    }

}
