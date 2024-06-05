namespace HotelSelect.Entities {
    internal class Hotel {
        public Hotel() { }

        public Hotel(string name, int countr_id, int sity_id, int stars, string adress, string phone_number, string descript, int numberRooms)
        {
            Name = name;
            CountryId = countr_id;
            CityId = sity_id;
            Stars = stars;
            Adress = adress;
            PhoneNumber = phone_number;
            Description = descript;
            NumberRooms = numberRooms;
        }

        public long Id { get; set; }
        public int CountryId { get; set; }
        public long CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberRooms { get; set; }
    }
}
