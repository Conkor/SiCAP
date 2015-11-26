using SiCAP_GrupoCARARA.App_Domain;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;


namespace SiCAP_GrupoCARARA.Data
{
    public class ReservationData : BaseData
    {
        // BaseData class will be parent of BookData

        public void InsertReservation(SiCAP_GrupoCARARA.App_Domain.Reservation reservation)
        {
            
            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using(SqlCommand sqlCommand = new SqlCommand("insert_reservation", connection))
                {
                    
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = reservation.Date;
                    sqlCommand.Parameters.Add("@IdTimeForReservation", SqlDbType.Int).Value = reservation.IdTimeForReservation;
                    sqlCommand.Parameters.Add("@IdUser", SqlDbType.Int).Value = reservation.IdUser;
                    sqlCommand.Parameters.Add("@IdParkingSpace", SqlDbType.Int).Value = reservation.IdParkingSpace;
                    sqlCommand.Parameters.Add("@IdVehicle", SqlDbType.Int).Value = reservation.IdVehicle;
                    sqlCommand.Parameters.Add("@HasBeenCanceled", SqlDbType.Bit).Value = reservation.HasBeenCanceled;

                    //connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    connection = ManageDatabaseConnection("Close");
                } 
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }
             
             
           
        }


        public List<Vehicle> readVehiclesOfUserFromDB(User user)
        {

            SqlConnection connection = ManageDatabaseConnection("Open");
            List<Vehicle> lstVehiclesOfOneUser = new List<Vehicle>();
            Vehicle vehicle;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_all_Vehicles_underOneUser", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Username_Email", SqlDbType.VarChar).Value = user.Username;

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        vehicle = new Vehicle((int)reader["IdVehicle"], (string)reader["NumberPlate"]);
                        lstVehiclesOfOneUser.Add(vehicle);
                    }
                    
                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

            return lstVehiclesOfOneUser;
        }






        public List<ParkingLot> ReadExistingParkingLotsFromDB()
        {
            
            SqlConnection connection = ManageDatabaseConnection("Open");
            List<ParkingLot> lstExistingParkingLots = new List<ParkingLot>();
            ParkingLot parkingLot;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_allExistingParkingLots", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        parkingLot = new ParkingLot((int)reader["IdParkingLot"], (string)reader["ParkingLotName"], (bool)reader["exists"]);
                        lstExistingParkingLots.Add(parkingLot);
                    }

                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }


            return lstExistingParkingLots;
        }
    }
}

