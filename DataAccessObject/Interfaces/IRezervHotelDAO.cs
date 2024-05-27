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
        Hotel SearchHotel();
        void RezervHotel(Hotel hotel);
    }
}
