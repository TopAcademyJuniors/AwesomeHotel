using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Entities
{
    internal class Hotel
    {
        public Hotel(string name, int countr_id, int sity_id, int stars, string adress, string phone_number, string descript)
        {
            Name = name;
            Countr_id = countr_id;
            Sity_id = sity_id;
            Stars = stars;
            Adress = adress;
            Phone_number = phone_number;
            Description = descript;
        }
        public long Id { get; set; }
        public int CountryId { get; set; }
        public long CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
    }


}
