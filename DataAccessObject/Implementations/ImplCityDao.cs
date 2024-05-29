using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.DataAccessObject.Implementations
{
    public class ImplCityDao : ICityDAO
    {

        private SqlConnection _conn;

        public ImplCityDao() {

            _conn = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
        }


        List<City> ICityDAO.GetAllCitiesByCountryId(string country)
        {
            try
            {
                _conn.Open();
                string sqlCountries = " SELECT Cities.name FROM Cities_countries " +
                    "join Cities on Cities_countries.country_id = " +
                    "(select id from Countries where Countries.name = @Country);";

                SqlCommand sql = new SqlCommand(sqlCountries, _conn);

                sql.Parameters.Add("@Country", System.Data.SqlDbType.VarChar).Value = country;
                SqlDataReader sqlDataReader = sql.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    List<City> result = new List<City>();

                    while (sqlDataReader.Read())
                    {
                        result.Add(new City()
                        {

                           
                            Name = (string)sqlDataReader.GetValue(0)

                        });
                    }

                    return result;
                }


                return null;


            }
            catch (Exception E)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
