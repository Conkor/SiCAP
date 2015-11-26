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
    public class VehicleData : BaseData
    {

        // BaseData class will be parent of VehicleData
        public void InsertVehicle(Vehicle vehicle)
        {

            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("insert_vehicle", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@NumberPlate", SqlDbType.VarChar).Value = vehicle.NumberPlate;
                    sqlCommand.Parameters.Add("@IdUser", SqlDbType.Int).Value = vehicle.IdUser;  // Hay que arregar esto..!!! Le falta idUser al objeto Vehicle..!!!!
                    sqlCommand.Parameters.Add("@Color", SqlDbType.VarChar).Value = vehicle.Color;
                    sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = vehicle.Type;
                    sqlCommand.Parameters.Add("@IsApproved", SqlDbType.Bit).Value = vehicle.IsAproved;
                    sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = vehicle.HasCertificate;

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

    }
}