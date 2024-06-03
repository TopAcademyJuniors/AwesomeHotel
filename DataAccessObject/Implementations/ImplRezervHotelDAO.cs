using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelSelect.DataAccessObject.Implementations {
    internal class ImplRezervHotelDAO : IRezervHotelDAO {

        SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void RezervHotel(Hotel hotel) {
            throw new NotImplementedException();
        }

        public List <Hotel> SearchHotel(Hotel hotel) {

            try
            {
                sqlConnection.Open();

                string sqlQueryFindHotel = "SELECT * FROM Hotel WHERE country_id = @country_id, city_id = @city_id, name = @name, stars = @stars, address = @address";

                SqlCommand sqlCommandFindHotel = new SqlCommand(sqlQueryFindHotel, sqlConnection);

                sqlCommandFindHotel.Parameters.Add("@country_id", System.Data.SqlDbType.VarChar).Value = hotel.CountryId;
                sqlCommandFindHotel.Parameters.Add("@city_id", System.Data.SqlDbType.VarChar).Value = hotel.CityId;
                sqlCommandFindHotel.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = hotel.Name;
                sqlCommandFindHotel.Parameters.Add("@stars", System.Data.SqlDbType.VarChar).Value = hotel.Stars;
                sqlCommandFindHotel.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = hotel.Adress;

                SqlDataReader sqlDataReader = sqlCommandFindHotel.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    return null;
                }

                List <Hotel> rezultSearchHotel = new List <Hotel>();

                while (sqlDataReader.Read())
                {
                    rezultSearchHotel.Add(new Hotel()
                    {

                        Id = (long)sqlDataReader.GetValue(0),
                        CountryId = (int)sqlDataReader.GetValue(1),
                        CityId = (long)sqlDataReader.GetValue(2),
                        Name = (string)sqlDataReader.GetValue(3),
                        Description = (string)sqlDataReader.GetValue(4),
                        Stars = (int)sqlDataReader.GetValue(5),
                        Adress = (string)sqlDataReader.GetValue(6),
                        PhoneNumber = (string)sqlDataReader.GetValue(7)


                    });


                }

                return rezultSearchHotel;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { sqlConnection.Close(); }



        }
    }
}
