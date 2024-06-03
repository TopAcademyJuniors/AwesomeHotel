using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelSelect.DataAccessObject.Implementations {
    public class ImplCityDao : ICityDAO {

        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        List<City> ICityDAO.GetAllCitiesByCountryId(Country country)
        { // В качестве аргумента принимаем объект country класса Country в папке Entities 
          // Должно выглядеть вот так: List<City> ICityDAO.GetAllCitiesByCountryId(Сountry country)
            try
            {          
                sqlConnection.Open();

                string sqlCountries = "SELECT Cities.name FROM Cities_countries " +
                                      "JOIN Cities on Cities_countries.country_id = " +
                                      "(select id from Countries where Countries.name = @Country);";

                SqlCommand sql = new SqlCommand(sqlCountries, sqlConnection);

                sql.Parameters.Add("@Country", System.Data.SqlDbType.VarChar).Value = country.Name;

                SqlDataReader sqlDataReader = sql.ExecuteReader();

                if (!sqlDataReader.HasRows) {
                    return null;
                }

                List<City> result = new List<City>();

                while (sqlDataReader.Read()) {

                    result.Add(new City() {
                        Name = (string)sqlDataReader.GetValue(0)
                    });
                }

                return result;
            }
            catch (Exception E) {
                return null;
            }
            finally { sqlConnection.Close(); }
        }
    }
}
