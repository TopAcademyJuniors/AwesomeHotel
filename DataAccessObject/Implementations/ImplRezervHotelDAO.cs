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
    internal class ImplRezervHotelDAO : IRezervHotelDAO
    {
        SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
        public void RezervHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Hotel SearchHotel()
        {
            throw new NotImplementedException();
        }
    }
}
