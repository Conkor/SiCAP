using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.Data
{
    public class BaseData
    {
        public SqlConnection ManageDatabaseConnection(string actionToPerform)
        {
            string connectionString = "Data Source=uxgv6xybvi.database.windows.net;Initial Catalog=Sicap;Persist Security Info=True;User ID=carara;Password=c4r4r4SICAP";


            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                // Decision whether open or close the database connections
                if (actionToPerform.Equals("Open"))
                {
                    sqlConnection.Open();
                }
                else
                {
                    sqlConnection.Close();
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }




            return sqlConnection;
        }
    }
}

