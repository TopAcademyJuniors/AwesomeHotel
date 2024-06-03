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

namespace HotelSelect
{
    public partial class PersonalAccount : Form
    {


        public PersonalAccount()
        {
            InitializeComponent();

            User user = UserSession.GetCurrentSession().CurrentAuthUser;

            foreach (var item in user.Role)
            {
                if (item.Name == "ADMIN") // Изменить на роль.
                {
                    buttonAddHotel.Enabled = true;
                }
               
            }
        }

        private void SerchHotelButton_Click(object sender, EventArgs e)
        {
            HotelRoomReservation SerchHote =new HotelRoomReservation ();
            this.Hide();
            SerchHote.ShowDialog();
           
        }

        private void buttonAddHotel_Click(object sender, EventArgs e)
        {
            HotelAdd hotelAdd = new HotelAdd ();
            this.Hide();
            hotelAdd.ShowDialog();
        }
    }
}
