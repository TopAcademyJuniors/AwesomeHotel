using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect.DataAccessObject.Interfaces {
    internal interface ICityDAO {
        List<City> GetAllCitiesByCountryId(Country country); // В качестве аргумента передаем объект country класса Country в папке Entities 
    }                                                       // Должно выглядеть вот так: List<City> GetAllCitiesByCountryId(Country country); 
}
