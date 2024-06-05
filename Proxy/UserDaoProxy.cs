using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Threading.Tasks;

namespace HotelSelect.Proxy
{
    public class UserDaoProxy
    {
        private IUserDAO userDAO;
        public UserDaoProxy()
        {
            userDAO = new ImplUserDAO();

        }

        public async Task<User> FindUserById(User user) {
            User u = null;
            await Task.Run(async () => u = userDAO.FindUserById(user));

            return u;
        }

        public async Task<User> FindUserByLoginAndPassword(User user)
        {
            User u = null;
            await Task.Run(async () => u = userDAO.FindUserByLogin(user));
            return u;

        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
