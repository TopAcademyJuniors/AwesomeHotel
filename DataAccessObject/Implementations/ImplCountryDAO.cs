using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.DataAccessObject.Implementations
{
    internal class ImplCountryDAO : ICountryDAO
    {
        private SqlConnection _conn;

        public ImplCountryDAO() {

            _conn = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        }


        public List<Country> GetAllCountries()
        {

            try
            {
                _conn.Open();
                string sqlCountries = "SELECT * FROM Countries";

                SqlCommand sql = new SqlCommand(sqlCountries, _conn);
                SqlDataReader sqlDataReader = sql.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    List<Country> result = new List<Country>();

                    while (sqlDataReader.Read())
                    {
                        result.Add(new Country()
                        {

                            Id = (int)sqlDataReader.GetValue(0),
                            Name = (string)sqlDataReader.GetValue(1)

                        });
                    }

                    return result;
                }


                return null;

                
            } catch (Exception E) {
                return null;
            }
            finally
            {
                _conn.Close();
            }

         
        }

        public Country GetCountryById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
