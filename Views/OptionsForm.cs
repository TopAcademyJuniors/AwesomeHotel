using HotelSelect.Entity;
using HotelSelect.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSelect.Dao.impl;
using System.Data.SqlClient;

namespace HotelSelect.Views.Controls
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            User user = UserSession.GetCurrentSession().CurrentAuthUser;
           

            this.login.Text = user.Login;
            this.surname.Text = user.FullName.Surname;
            this.name.Text=user.FullName.Name;
            this.patronymic.Text=user.FullName.Patronymic;
            this.email.Text = user.Email;
        }

        private void save_Click(object sender, EventArgs e)
        {
            User user = UserSession.GetCurrentSession().CurrentAuthUser;
            ImplUserDAO save = new ImplUserDAO();
            User updateUser = new User();
            
            updateUser.Id = user.Id;
            updateUser.Login = user.Login;
            updateUser.FullName = new FullName 
            {
                Surname = user.FullName.Surname,
                Name = user.FullName.Name,
                Patronymic = user.FullName.Patronymic
            };
            



            //save.Chenge_user( updateUser);
        }
    }
}
