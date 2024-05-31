using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.DataAccessObject.Interfaces
{
    internal interface IRezervHotelDAO
    {
        void RezervHotel(Hotel hotel);
        List<Hotel> SearchHotel(Hotel hotel);
    }
}
