using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect {
    internal interface IHotelDAO {
        void AddHotel(Hotel hotel);
        Hotel SearchHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(Hotel hotel);
        List<Hotel> SearchHotelsByCountry(Country country);
    }
}
