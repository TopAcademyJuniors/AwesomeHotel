using HotelSelect.Entities;
using System.Collections.Generic;

namespace HotelSelect.DataAccessObject.Interfaces {
    internal interface ICountryDAO {
        List<Country> GetAllCountries();
        Country GetCountryById(Country id);// В качестве аргумента передаем объект country класса Country в папке Entities 
    }                                   // Должно выглядеть вот так: Country GetCountryById(Country country);
}
