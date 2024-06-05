using HotelSelect.Entity;
using System.IO;
using System.Text.Json;

namespace HotelSelect.Mappers {
    public class UserMapper {
        public UserMapper() { }

        public User MapJsonToUser(string userJson) {
            return JsonSerializer.Deserialize<User>(userJson); 
        }

        public void MapUserToJsonAndSave(User user) {

            string jsonUser = JsonSerializer.Serialize(user);

            using (StreamWriter sw = new StreamWriter("Session.s")) {
                sw.WriteLine(jsonUser);
            }
        }
    }
}
