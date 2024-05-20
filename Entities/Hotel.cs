using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSelect.Entities
{
    internal class Hotel
    {
        int Id;
        string Name;
        int Countr_id;
        int Sity_id;
        int Stars;
        string Adress;
        string Phone_number;

        public Hotel(string name, int countr_id, int sity_id, int stars, string adress, string phone_number)
        {
            Name = name;
            Countr_id = countr_id;
            Sity_id = sity_id;
            Stars = stars;
            Adress = adress;
            Phone_number = phone_number;
        }

        public int id { get { return Id; } set { Id = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public int countr_id { get { return Countr_id; } set { Countr_id = value; } }
        public int sity_id { get { return Sity_id; } set { Sity_id = value; } }
        public int stars { get { return Stars; } set { Stars = value; } }
        public string adress { get { return Adress; } set { Adress = value; } }
        public string phone_number { get { return Phone_number; } set { Phone_number = value; } }
    }
}
