﻿using HotelSelect.Dao.repository;
using HotelSelect.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelSelect.DataAccessObject.Implementations {
    internal class ImplHotelDAO : IHotelDAO {

        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void AddHotel(Hotel hotel) {

            try {
                sqlConnection.Open();

                string sqlQuerySaveHotel = "INSERT INTO Hotel (country_id, city_id, name, description, stars, address, phone_number) " +
                                           "VALUES (@country_id, @city_id, @name, @description, @stars, @address, @phone_number)";

                SqlCommand sqlCommandSaveHotel = new SqlCommand(sqlQuerySaveHotel, sqlConnection);
                sqlCommandSaveHotel.Parameters.Add("@country_id", System.Data.SqlDbType.Int).Value =       hotel.CountryId;
                sqlCommandSaveHotel.Parameters.Add("@city_id", System.Data.SqlDbType.BigInt).Value =       hotel.CityId;
                sqlCommandSaveHotel.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value =         hotel.Name;
                sqlCommandSaveHotel.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value =  hotel.Description;
                sqlCommandSaveHotel.Parameters.Add("@stars", System.Data.SqlDbType.Date).Value =           hotel.Stars;
                sqlCommandSaveHotel.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value =      hotel.Adress;
                sqlCommandSaveHotel.Parameters.Add("@phone_number", System.Data.SqlDbType.VarChar).Value = hotel.PhoneNumber;

                sqlCommandSaveHotel.ExecuteNonQuery();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public Hotel SearchHotel(Hotel hotel) {

            try {
                sqlConnection.Open();

                string sqlQueryFindHotel = "SELECT * FROM Hotel WHERE country_id = @country_id, city_id = @city_id, name = @name, stars = @stars, address = @address";

                SqlCommand sqlCommandFindHotel = new SqlCommand(sqlQueryFindHotel, sqlConnection);

                sqlCommandFindHotel.Parameters.Add("@country_id", System.Data.SqlDbType.VarChar).Value = hotel.CountryId;
                sqlCommandFindHotel.Parameters.Add("@city_id", System.Data.SqlDbType.VarChar).Value =    hotel.CityId;
                sqlCommandFindHotel.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value =       hotel.Name;
                sqlCommandFindHotel.Parameters.Add("@stars", System.Data.SqlDbType.VarChar).Value =      hotel.Stars;
                sqlCommandFindHotel.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value =    hotel.Adress;

                SqlDataReader sqlDataReader = sqlCommandFindHotel.ExecuteReader();

                if (!sqlDataReader.HasRows) {
                    return null;
                }

                Hotel findedHotel = new Hotel();

                while (sqlDataReader.Read()) {
                    findedHotel.Id =          (long)sqlDataReader.GetValue(0);
                    findedHotel.CountryId =   (int)sqlDataReader.GetValue(1);
                    findedHotel.CityId =      (long)sqlDataReader.GetValue(2);
                    findedHotel.Name =        (string)sqlDataReader.GetValue(3);
                    findedHotel.Description = (string)sqlDataReader.GetValue(4);
                    findedHotel.Stars =       (int)sqlDataReader.GetValue(5);
                    findedHotel.Adress =      (string)sqlDataReader.GetValue(6);
                    findedHotel.PhoneNumber = (string)sqlDataReader.GetValue(7);
                }

                return findedHotel;
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { sqlConnection.Close(); }
        }

        public void UpdateHotel(Hotel hotel) {
            throw new NotImplementedException();
        }

        public void DeleteHotel(Hotel hotel) {
            throw new NotImplementedException();
        }
    }
}
