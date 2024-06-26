﻿using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using HotelSelect.Entity;
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

                if (!sqlDataReader.HasRows) {
                    throw new Exception("Not has rows");
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
            catch (Exception ex) {
                throw new Exception("Произошла ошибка: " + ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public Country GetCountryById(Country country) {
            try
            {
                sqlConnection.Open();

                string sqlCountries = "SELECT * FROM Countries WHERE id = @id";

                SqlCommand sql = new SqlCommand(sqlCountries, sqlConnection);

                sql.Parameters.Add("@id", System.Data.SqlDbType.BigInt).Value = country.Id;

                SqlDataReader sqlDataReader = sql.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    throw new Exception("Not has rows");
                }

                Country result = new Country();

                while (sqlDataReader.Read())
                {
                    result.Id =     (int)sqlDataReader.GetValue(0);
                    result.Name =   (string)sqlDataReader.GetValue(1);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Произошла ошибка: " + ex.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}
