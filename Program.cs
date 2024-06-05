using HotelSelect.Dao.impl;
using HotelSelect.Entity;
using HotelSelect.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static  void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());

        }


        public static async Task<User> userGet(ImplUserDAO implUserDAO)
        {
            User user = new User();
            user.Login = "admin";
            user.Password = "admin";


            await Task.Run(() => {
                user = implUserDAO.FindUserByLogin(user);
               

            });
            return user;
        }
    }
}
