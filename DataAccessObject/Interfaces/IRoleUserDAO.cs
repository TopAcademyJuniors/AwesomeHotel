using HotelSelect.Entities;
using HotelSelect.Entity;
using System.Collections.Generic;

namespace HotelSelect.Dao.inreface
{
    internal interface IRoleUserDAO
    {
        void setUserRole(User user);
        List<Role> GetRolesForUserByUserId(User user);
    }
}