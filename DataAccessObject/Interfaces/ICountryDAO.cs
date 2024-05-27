using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.DataAccessObject.Interfaces
{
    interface ICountryDAO
    {
        Country GetCountryById(long id);

        List<Country> GetAllCountries();
    }
}
