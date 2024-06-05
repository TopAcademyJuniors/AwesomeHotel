using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect.DataAccessObject.Interfaces {
    internal interface ICountryDAO {
        List<Country> GetAllCountries();
        Country GetCountryById(Country country);
    }                                   
}
