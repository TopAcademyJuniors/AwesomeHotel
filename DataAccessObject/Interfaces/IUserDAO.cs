using HotelSelect.Entity;

namespace HotelSelect.Dao.inreface {
    internal interface IUserDAO {
        void SaveUser(User user);
        User FindUserByLogin(User user);
        User FindUserById(long id);// В качестве аргумента передаем объект user класса User в папке Entities 
                                   // Должно выглядеть вот так: User FindUserById(User user)
    }
}
