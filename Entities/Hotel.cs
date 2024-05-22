using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Entities
{
    internal class Hotel
    {
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
