using HotelSelect.Entity;
using HotelSelect.Security;
using HotelSelect.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect
{
    public partial class PersonalAccount : Form
    {
        public PersonalAccount()
        {
            InitializeComponent();
            User user = UserSession.GetCurrentSession().CurrentAuthUser;
            this.User_name.Text = user.FullName.Surname + " " + user.FullName.Name + " " + user.FullName.Patronymic;
        }

        private void SerchHotelButton_Click(object sender, EventArgs e)
        {
            HotelRoomReservation SerchHote =new HotelRoomReservation ();
            this.Hide();
            SerchHote.ShowDialog();
           
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm();
            form.ShowDialog();
        }
    }
}
