using SiCAP_GrupoCARARA.Data;
using SiCAPV002.App_Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAPV002.Data
{
    class MajorData : BaseData
    {
        public List<Major> Majors()
        {

            List<Major> majors = new List<Major>();
            Major majorD;
            
            try
            {
                SqlConnection connection = ManageDatabaseConnection("Open");
                using (SqlCommand sqlCommand = new SqlCommand("readMainMajor", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        majorD = new Major((int)reader["idMajor"], (string)reader["mainMajor"]);
                        majors.Add(majorD);
                        
                    }

                    connection = ManageDatabaseConnection("Close");
                    return majors;
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }
          
        }
    }
}

