using HotelSelect.Dao.repository;
using HotelSelect.Entities;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect.DataAccessObject.Implementations
{
    internal class ImplHotelDAO : IHotelDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void AddHotel(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();

                string sqlQuerySaveHotel = "INSERT INTO Hotel (country_id, city_id, name, description, stars, " +
                                          "address, phone_number) " +
                                          "VALUES (@country_id, @city_id, @name, @description, @stars, @address, " +
                "@phone_number)";

                SqlCommand sqlCommandSaveHotel = new SqlCommand(sqlQuerySaveHotel, sqlConnection);
                sqlCommandSaveHotel.Parameters.Add("@country_id", System.Data.SqlDbType.Int).Value = hotel.countr_id;
                sqlCommandSaveHotel.Parameters.Add("@city_id", System.Data.SqlDbType.BigInt).Value = hotel.sity_id;
                sqlCommandSaveHotel.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = hotel.name;
                //sqlCommandSaveHotel.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = hotel.;
                sqlCommandSaveHotel.Parameters.Add("@stars", System.Data.SqlDbType.Date).Value = hotel.stars;
                sqlCommandSaveHotel.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = hotel.adress;
                sqlCommandSaveHotel.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar).Value = hotel.phone_number;

                sqlCommandSaveHotel.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public void DeleteHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Hotel SearchHotel(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();

                string sqlQueryFindHotel = "SELECT * FROM Hotel WHERE country_id = @country_id, city_id = @city_id, name = @name, stars = @stars, address = @address";

                SqlCommand sqlCommandFindHotel = new SqlCommand(sqlQueryFindHotel, sqlConnection);

                sqlCommandFindHotel.Parameters.Add("@country_id", System.Data.SqlDbType.VarChar).Value = hotel.countr_id;
                sqlCommandFindHotel.Parameters.Add("@city_id", System.Data.SqlDbType.VarChar).Value = hotel.sity_id;
                sqlCommandFindHotel.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = hotel.name;
                sqlCommandFindHotel.Parameters.Add("@stars", System.Data.SqlDbType.VarChar).Value = hotel.stars;
                sqlCommandFindHotel.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = hotel.adress;

                SqlDataReader sqlDataReader = sqlCommandFindHotel.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    return null;
                }

                User findedHotel = new User();

                while (sqlDataReader.Read())
                {
                    findedHotel.Id = (long)sqlDataReader.GetValue(0);
                    findedHotel.CountryId = (int)sqlDataReader.GetValue(1);
                    findedHotel.CityId = (long)sqlDataReader.GetValue(2);
                    findedHotel.FullName = new FullName
                    {
                        Surname = (string)sqlDataReader.GetValue(3),
                        Name = (string)sqlDataReader.GetValue(4),
                        Patronymic = (string)sqlDataReader.GetValue(5)
                    };
                    findedHotel.DateOfBirth = (DateTime)sqlDataReader.GetValue(6);
                    findedHotel.Login = (string)sqlDataReader.GetValue(7);
                    findedHotel.Password = (string)sqlDataReader.GetValue(8);
                    findedHotel.PhoneNumber = (string)sqlDataReader.GetValue(9);
                    findedHotel.Email = (string)sqlDataReader.GetValue(10);
                }

                if (!BCrypt.Net.BCrypt.EnhancedVerify(user.Password, findedHotel.Password))
                {
                    return null;
                }


                return findedHotel;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { sqlConnection.Close(); }
        }

        public void UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
