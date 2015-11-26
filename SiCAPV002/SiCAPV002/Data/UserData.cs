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
using SiCAP_GrupoCARARA.App_Security;

namespace SiCAP_GrupoCARARA.Data
{
    public class UserData : BaseData
    {

        

        // Next method takes username and goes to the DataBase to extrac the encrypted password corresponding to it, and returns it
        public string bringsEncryptedPasswordFromDataBase_underNameOfUser(string username)
        {
            string encriptedPassword = "";
            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_password_underUsername_fromUser", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Username_Email", SqlDbType.VarChar).Value = username;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        encriptedPassword = reader.GetString(reader.GetOrdinal("Password_Encr"));
                    }

                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }


            return encriptedPassword;
        }


        public bool comparesPasswordComingFromUser_toPasswordInDataBase(string username, string password)
        {
            bool isTheCorrectPassword = false;
            SecurityPassword securityPassword = new SecurityPassword();
            String encryptedPasswordFromDataBase = bringsEncryptedPasswordFromDataBase_underNameOfUser(username);
            String passwordFromUserAferEncryption = securityPassword.Encrypt(password);
            if (encryptedPasswordFromDataBase == passwordFromUserAferEncryption)
            {
                isTheCorrectPassword = true;
            }
            return isTheCorrectPassword;
        }


        public string checksInDataBaseIfUsernameExists(string username)
        {

            String userNameFromDataBase = "";
            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("check_ifUser_Exists", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Username_Email", SqlDbType.VarChar).Value = username;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        userNameFromDataBase = reader.GetString(reader.GetOrdinal("Username_Email")); ;
                    }

                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

            return userNameFromDataBase;
        }


        public bool isARegisteredUser(string username)
        {
            bool matchesCorrectlyWithDataBase = false;
            if (username == checksInDataBaseIfUsernameExists(username))
            {
                matchesCorrectlyWithDataBase = true;
            }
            return matchesCorrectlyWithDataBase;
        }

        public User getUserInSession(string email)
        {
            User userInSession = new User();
            int id = 0;
            string username = "";
            int idNumber = 0;
            string name = "";
            string secondName = "";
            string lastname = "";
            string secondLastname = "";
            string cellphone = "";
            string password = "";
            int idMajor = 0;
            int type = 0;
            bool hasCertificate = false;

            SqlConnection connection = ManageDatabaseConnection("Open");

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("read_userInSession", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Username_Email", SqlDbType.VarChar).Value = email;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(reader.GetOrdinal("IdUser"));
                        username = reader.GetString(reader.GetOrdinal("Username_Email"));
                        idNumber = reader.GetInt32(reader.GetOrdinal("IdNumber"));
                        name = reader.GetString(reader.GetOrdinal("Name"));
                        secondName = reader.GetString(reader.GetOrdinal("MidName"));
                        lastname = reader.GetString(reader.GetOrdinal("Lastname"));
                        secondLastname = reader.GetString(reader.GetOrdinal("SecondLastname"));
                        cellphone = reader.GetString(reader.GetOrdinal("Celular"));
                        password = reader.GetString(reader.GetOrdinal("Password_Encr"));
                        idMajor = reader.GetInt32(reader.GetOrdinal("IdMajor"));
                        type = reader.GetInt32(reader.GetOrdinal("IdUserType"));
                        //hasCertificate = reader.GetBoolean(reader.GetOrdinal("IsSanctionaed"));
                        userInSession = new User(id,username, idNumber, name, secondName, lastname, secondLastname, cellphone, password, idMajor, type, hasCertificate);


                    }

                    connection = ManageDatabaseConnection("Close");
                }
            }
            catch (SqlException sqlException)
            {

                throw sqlException;
            }

            return userInSession;
        }

        public void createUser(User user) {
            SecurityPassword encrPass = new SecurityPassword();
            string password = encrPass.Encrypt(user.Password);
            try
            {
                SqlConnection connection = ManageDatabaseConnection("Open");
                using (SqlCommand sqlCommand = new SqlCommand("Insert_user1", connection))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@Username_Email", SqlDbType.VarChar).Value = user.Username;
                    sqlCommand.Parameters.Add("@IdNumber", SqlDbType.Int).Value = user.IdNumber;
                    sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Name;
                    sqlCommand.Parameters.Add("@MidName", SqlDbType.VarChar).Value = user.SecondName;
                    sqlCommand.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = user.LastName;
                    sqlCommand.Parameters.Add("@SecondLastname", SqlDbType.VarChar).Value = user.SecondName;
                    sqlCommand.Parameters.Add("@Celular", SqlDbType.VarChar).Value = user.Cellphone;
                    sqlCommand.Parameters.Add("@Password_Encr", SqlDbType.VarChar).Value = password;
                    sqlCommand.Parameters.Add("@IdMajor", SqlDbType.Int).Value = user.IdMajor;
                    sqlCommand.Parameters.Add("@IdUserType", SqlDbType.Int).Value = user.Type;
                    sqlCommand.Parameters.Add("@HasCertificate", SqlDbType.Bit).Value = "false";
                    sqlCommand.Parameters.Add("@IsSanctioned", SqlDbType.Bit).Value = "false";


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
    