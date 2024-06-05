using HotelSelect.Entities;

namespace HotelSelect {
    internal interface IHotelDAO {
        void AddHotel(Hotel hotel);
        Hotel SearchHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(Hotel hotel);
    }
}
