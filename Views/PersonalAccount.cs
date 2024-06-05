
using HotelSelect.Views;
using HotelSelect.Entity;
using HotelSelect.Security;

using HotelSelect.Views;

using System;
using System.Windows.Forms;

namespace HotelSelect {
    public partial class PersonalAccount : Form {
        public PersonalAccount() {
            InitializeComponent();

            User user = UserSession.GetCurrentSession().CurrentAuthUser;

            foreach (var item in user.Role) {

                if (item.Name == "ADMIN") {
                    buttonAddHotel.Enabled = true;
                }
            }
        }

        private void SerchHotelButton_Click(object sender, EventArgs e) {
            HotelRoomReservation SerchHote =new HotelRoomReservation ();
            this.Hide();
            SerchHote.ShowDialog();
        }


        private void buttonAddHotel_Click(object sender, EventArgs e) {
            HotelAdd hotelAdd = new HotelAdd ();

        private void SupportButton_Click(object sender, EventArgs e)
        {
            Support supportForm = new Support();
            this.Hide();
            supportForm.ShowDialog();

        }
        private void buttonAddHotel_Click(object sender, EventArgs e)
        {
            HotelAdd hotelAdd = new HotelAdd();
            this.Hide();
            hotelAdd.ShowDialog();
        }

        private void DeleteHotel_Click(object sender, EventArgs e) {
            DeleteHotel deleteHotel = new DeleteHotel();
            this.Hide();
            deleteHotel.ShowDialog();
        }
    }
}
