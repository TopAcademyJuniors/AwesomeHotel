using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotelSelect.Mappers
{
    public class UserMapper
    {
        public UserMapper()
        {

        }

        public User MapJsonToUser(string userJson)
        {
            return JsonSerializer.Deserialize<User>(userJson); 
        }

        public void MapUserToJsonAndSave(User user)
        {
            string jsonUser = JsonSerializer.Serialize(user);

            using (StreamWriter sw = new StreamWriter("Session.s"))
            {
                sw.WriteLine(jsonUser);
            }
        }


    }
}
