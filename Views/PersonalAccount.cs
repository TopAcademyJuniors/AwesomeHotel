using HotelSelect.Entity;
using HotelSelect.Properties;
using HotelSelect.Security;
using HotelSelect.Views;
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
            User user= UserSession.GetCurrentSession().CurrentAuthUser;
            InitializeComponent();
            this.Name_user.Text = "Здраствуйте " + user.FullName.Surname + " " + user.FullName.Name + " " + user.FullName.Patronymic+"!";
        }

        private void SerchHotelButton_Click(object sender, EventArgs e)
        {
            HotelRoomReservation SerchHote =new HotelRoomReservation ();
            this.Hide();
            SerchHote.ShowDialog();
           
        }

        private void Setting_Click(object sender, EventArgs e)
        {
           Setting form = new Setting();
           form.ShowDialog();
        }
    }
}
