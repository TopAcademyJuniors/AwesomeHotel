using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelSelect.DataAccessObject.Implementations {
    internal class ImplRezervHotelDAO : IRezervHotelDAO {

        SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void RezervHotel(Hotel hotel) {
            throw new NotImplementedException();
        }

        public List <Hotel> SearchHotel(Hotel hotel) {
            throw new NotImplementedException();
        }
    }
}
