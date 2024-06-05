using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelSelect.Dao.repository;
using System.Data;
using System.Runtime.InteropServices;
using System.Configuration;

namespace HotelSelect.Dao.impl
{
    internal class ImplUserDAO : IUserDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;


        
        public User FindUserById(long id)
        {
            try
            {
                sqlConnection.Open();
                string sqlQueryFindUserById = "SELECT * FROM Users WHERE id = @id";

                SqlCommand sqlCommandFindUserById = new SqlCommand(sqlQueryFindUserById, sqlConnection);

                sqlCommandFindUserById.Parameters.Add("@id", System.Data.SqlDbType.BigInt).Value = id;

                SqlDataReader sqlDataReader = sqlCommandFindUserById.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    return null;
                }

                User findedUser = new User();

                while (sqlDataReader.Read())
                {
                    findedUser.Id = (long)sqlDataReader.GetValue(0);
                    findedUser.CountryId = (int)sqlDataReader.GetValue(1);
                    findedUser.CityId = (long)sqlDataReader.GetValue(2);
                    findedUser.FullName = new FullName
                    {
                        Surname = (string)sqlDataReader.GetValue(3),
                        Name = (string)sqlDataReader.GetValue(4),
                        Patronymic = (string)sqlDataReader.GetValue(5)
                    };
                    findedUser.DateOfBirth = (DateTime)sqlDataReader.GetValue(6);
                    findedUser.Login = (string)sqlDataReader.GetValue(7);
                    findedUser.Password = (string)sqlDataReader.GetValue(8);
                    findedUser.PhoneNumber = (string)sqlDataReader.GetValue(9);
                    findedUser.Email = (string)sqlDataReader.GetValue(10);
                }

                return findedUser;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { sqlConnection.Close(); }
        }

        public User FindUserByLoginAndPassword(User user)
        {
            try
            {
                sqlConnection.Open();
                string sqlQueryFindUser = "SELECT * FROM Users WHERE login = @login";

                SqlCommand sqlCommandFindUser = new SqlCommand(sqlQueryFindUser, sqlConnection);

                sqlCommandFindUser.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
              //  sqlCommandFindUser.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;

                SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                   return null; 
                }

                User findedUser = new User();

                while (sqlDataReader.Read())
                {
                    findedUser.Id = (long)sqlDataReader.GetValue(0);
                    findedUser.CountryId = (int)sqlDataReader.GetValue(1);
                    findedUser.CityId = (long)sqlDataReader.GetValue(2);
                    findedUser.FullName = new FullName
                    {
                        Surname = (string)sqlDataReader.GetValue(3),
                        Name = (string)sqlDataReader.GetValue(4),
                        Patronymic = (string)sqlDataReader.GetValue(5)
                    };
                    findedUser.DateOfBirth = (DateTime)sqlDataReader.GetValue(6);
                    findedUser.Login = (string)sqlDataReader.GetValue(7);
                    findedUser.Password = (string)sqlDataReader.GetValue(8);
                    findedUser.PhoneNumber = (string)sqlDataReader.GetValue(9);
                    findedUser.Email = (string)sqlDataReader.GetValue(10);
                }

                if (!BCrypt.Net.BCrypt.EnhancedVerify(user.Password, findedUser.Password))
                {
                    return null;
                }

                
                return findedUser;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }finally { sqlConnection.Close(); }

           
        }

        public void SaveUser(User user)
        {
            try
            {
                sqlConnection.Open();

                string sqlQuerySaveUser = "INSERT INTO Users (country_id, city_id, surname, name, patronymic, date_of_birth, " +
                                          "login, password, phone_number, email) " +
                                          "VALUES (@country_id, @city_id, @surname, @name, @patronymic, @date_of_birth, @login, " +
                                          "@password, @phone_number, @email)";

                SqlCommand sqlCommandSaveUser = new SqlCommand(sqlQuerySaveUser, sqlConnection);
                user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
                sqlCommandSaveUser.Parameters.Add("@country_id", System.Data.SqlDbType.Int).Value = user.CountryId;
                sqlCommandSaveUser.Parameters.Add("@city_id", System.Data.SqlDbType.BigInt).Value = user.CityId;
                sqlCommandSaveUser.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = user.FullName.Surname;
                sqlCommandSaveUser.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = user.FullName.Name;
                sqlCommandSaveUser.Parameters.Add("@patronymic", System.Data.SqlDbType.VarChar).Value = user.FullName.Patronymic;
                sqlCommandSaveUser.Parameters.Add("@date_of_birth", System.Data.SqlDbType.Date).Value = user.DateOfBirth;
                sqlCommandSaveUser.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
                sqlCommandSaveUser.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;
                sqlCommandSaveUser.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar).Value = user.PhoneNumber;
                sqlCommandSaveUser.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;

                sqlCommandSaveUser.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { sqlConnection.Close(); }
        }
        public void Chenge_user(User user)
        {
            try
            {
                sqlConnection.Open();
                string sqlQueryFindUserById = "UPDATE Users SET login = @login,password=@password,surname=@surname,name=@name" +
                    ",patronymic=@patronymic,email=@email WHERE id = @id";

                SqlCommand sql = new SqlCommand(sqlQueryFindUserById, sqlConnection);
                user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
                sql.Parameters.Add("@id", System.Data.SqlDbType.BigInt).Value = user.Id;
                sql.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
                sql.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;
                sql.Parameters.Add("@surname", System.Data.SqlDbType.VarChar).Value = user.FullName.Surname;
                sql.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = user.FullName.Name;
                sql.Parameters.Add("@patronymic", System.Data.SqlDbType.VarChar).Value = user.FullName.Patronymic;
                sql.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;

                sql.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { sqlConnection.Close(); }
        }
       
        public void Delete_user(User user) 
        {

        }
    }

}
