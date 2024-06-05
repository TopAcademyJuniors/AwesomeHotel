using HotelSelect.Dao.inreface;
using HotelSelect.Dao.repository;
using HotelSelect.Entities;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelSelect.DataAccessObject.Implementations
{
    public class ImplIRoleUser : IRoleUserDAO
    {
        private SqlConnection sqlConnection;
        public ImplIRoleUser() { 
            sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
        }

        public List<Role> GetRolesForUserByUserId(User user) {

            try {
                sqlConnection.Open();

                string sqlCommand = "SELECT Roles.id, Roles.name FROM User_Roles " +
                                    "JOIN Roles on Roles.id = User_Roles.role_id " +
                                    "WHERE User_Roles.user_id = @user_id";

                SqlCommand sqlCommandGetRoles = new SqlCommand(sqlCommand, sqlConnection);

                sqlCommandGetRoles.Parameters.Add("@user_id", System.Data.SqlDbType.BigInt).Value = user.Id;

                SqlDataReader reader = sqlCommandGetRoles.ExecuteReader(); 

                List<Role> userRoles = new List<Role>();

                if(!reader.HasRows) {
                    throw new Exception("Not has rows");
                }

                while (reader.Read()) {
                    Role role = new Role();
                    role.Id = (int)reader.GetValue(0);
                    role.Name = (string)reader.GetValue(1);
                    userRoles.Add(role);
                }

                return userRoles;
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public void setUserRole(User user) {
            
            try {
                sqlConnection.Open();

                string sqlCommand = "INSERT INTO User_Roles (user_id, role_id) VALUES ((SELECT id FROM users WHERE users.name = @user_login),1);";

                SqlCommand sqlCommandGetRoles = new SqlCommand(sqlCommand, sqlConnection);

                sqlCommandGetRoles.Parameters.Add("@user_login", System.Data.SqlDbType.VarChar).Value = user.Login;

                sqlCommandGetRoles.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}
