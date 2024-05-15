using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Entity;

namespace HotelSelect.Security
{
    public class Security
    {
        private IUserDAO implUserDAO = new ImplUserDAO();

        public bool AuthUser(User user)
        {
            User tryAuthUser = implUserDAO.FindUserByLoginAndPassword(user);

            if (tryAuthUser != null) {
                UserSession.StartSession(tryAuthUser);

                return true;
            }

            return false;
        }

        public static void LogOutUser()
        {
            UserSession.EndSession();
        }
    }
}