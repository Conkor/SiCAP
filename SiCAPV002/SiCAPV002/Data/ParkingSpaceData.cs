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
using System.Web.UI.WebControls;
using System.Configuration;

namespace SiCAP_GrupoCARARA.Data
{
    public class ParkingSpaceData : BaseData
    {
        // BaseData class will be parent of this class
        public void InsertParkingSpace(ParkingSpace parkingSpace)
        {

            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("insert_newParkingSpace", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@SpaceNumber", SqlDbType.VarChar).Value = parkingSpace.SpaceNumber;
                    sqlCommand.Parameters.Add("@IdParkingLot", SqlDbType.Int).Value = parkingSpace.IdParkingLot;

                    sqlCommand.ExecuteNonQuery();
                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

        }

        public List<string> ReadParkingSpacesFromDB(int idParkingLot)
        {
            SqlConnection connection = ManageDatabaseConnection("Open");
            List<string> lstParkingSpaces;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_allParkingSpaces_underParkingLot", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@IdParkingLot", SqlDbType.Int).Value = idParkingLot;

                    string Column1;
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        lstParkingSpaces = new List<string>();
                        while (reader.Read())
                            lstParkingSpaces.Add( Column1 = reader.GetString(0) );
                    }

                    sqlCommand.ExecuteNonQuery();
                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

            return lstParkingSpaces;
        }




        public void eliminateLastSpace(int idParkingLot)
        {

            List<string> lstParkingSpaces = ReadParkingSpacesFromDB(idParkingLot);
            int i = lstParkingSpaces.Count;
            string lastSpace = lstParkingSpaces[i-1];
            executeElimination(lastSpace);
           
        }

        public void executeElimination(string lastSpace)
        {

            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("delete_lastParkingSpace", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@SpaceNumber", SqlDbType.VarChar).Value = lastSpace;

                    sqlCommand.ExecuteNonQuery();
                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }


        }


        public List<string> GetAllReservedSpacesForOneHour(int idParkingLot, DateTime date, int idTimeForReservation)
        {
            List<string> lstReservedSpaces = new List<string>();
            string dateTest = date.ToString("dd/MM/yyyy");

            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_allReservations_forOneParkingLot_inSpecificDate_andTime", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@IdParkingLot", SqlDbType.Int).Value = idParkingLot;
                    sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = dateTest; //  date.ToString("dd/MM/yyyy");
                    sqlCommand.Parameters.Add("@IdTimeForReservation", SqlDbType.Int).Value = idTimeForReservation;

                    string Column1;
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        lstReservedSpaces = new List<string>();
                        while (reader.Read())
                            lstReservedSpaces.Add(Column1 = reader.GetString(0));
                    }

                    sqlCommand.ExecuteNonQuery();
                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }


            return lstReservedSpaces;
        }


    }
}