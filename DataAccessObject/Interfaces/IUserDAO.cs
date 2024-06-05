using HotelSelect.Entity;

namespace HotelSelect.Dao.inreface {
    internal interface IUserDAO {
        void SaveUser(User user);
        User FindUserByLogin(User user);
        User FindUserById(User user);
    }
}
