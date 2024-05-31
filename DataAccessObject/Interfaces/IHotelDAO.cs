using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect
{
    internal interface IHotelDAO
    {
        void AddHotel(Hotel hotel);
        Hotel SearchHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(Hotel hotel);
    }
}
