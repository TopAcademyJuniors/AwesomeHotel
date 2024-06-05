using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect.DataAccessObject.Interfaces {
    internal interface ICityDAO {
        List<City> GetAllCitiesByCountryId(Country country); 
    }                                                    
}
