using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelSelect.DataAccessObject.Implementations {
    internal class ImplCountryDAO : ICountryDAO {

        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public List<Country> GetAllCountries() {

            try {
                sqlConnection.Open();

                string sqlCountries = "SELECT * FROM Countries";

                SqlCommand sql = new SqlCommand(sqlCountries, sqlConnection);

                SqlDataReader sqlDataReader = sql.ExecuteReader();

                if (sqlDataReader.HasRows) {
                    return null;
                }

                List<Country> result = new List<Country>();

                while (sqlDataReader.Read()) {

                    result.Add(new Country() {
                        Id = (int)sqlDataReader.GetValue(0),
                        Name = (string)sqlDataReader.GetValue(1)
                    });
                }

                return result;
            } 
            catch (Exception E) {
                return null;
            }
            finally { sqlConnection.Close(); }
        }

        public Country GetCountryById(Country id) {// В качестве аргумента принимаем объект country класса Country в папке Entities 
            throw new NotImplementedException();// Должно выглядеть вот так:  public Country GetCountryById(Country country)
        }
    }
}
