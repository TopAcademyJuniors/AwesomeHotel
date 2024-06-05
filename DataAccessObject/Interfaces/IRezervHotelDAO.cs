using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect.DataAccessObject.Interfaces {
    internal interface IRezervHotelDAO {
        void RezervHotel(Hotel hotel);
        List <Hotel> SearchHotel(Hotel hotel);
    }
}
