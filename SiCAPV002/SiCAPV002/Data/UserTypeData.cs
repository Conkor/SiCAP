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
    class UserTypeData : BaseData
    {
        public List<UserTypes> Types()
        {

            List<UserTypes> type = new List<UserTypes>();
            UserTypes userType;

            try
            {
                SqlConnection connection = ManageDatabaseConnection("Open");
                using (SqlCommand sqlCommand = new SqlCommand("readUserType", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        userType = new UserTypes((int)reader["idUserType"], (string)reader["UserType"]);
                        type.Add(userType);

                    }

                    connection = ManageDatabaseConnection("Close");
                    return type;
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

        }


    }
}
