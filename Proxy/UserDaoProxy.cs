using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public User FindUserById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindUserByLoginAndPassword(User user)
        {
            User u = null;
            await Task.Run(async () => u = userDAO.FindUserByLoginAndPassword(user));
            return u;

        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
