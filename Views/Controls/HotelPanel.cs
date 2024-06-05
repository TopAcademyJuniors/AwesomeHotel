using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect.Views.Controls
{
    public partial class HotelPanel : UserControl
    {
      

        public HotelPanel(Hotel hotel)
        {
            InitializeComponent();
            hotelName.Text = hotel.Name;
            hotelDescription.Text = hotel.Description;
          
        }

        //public HotelPanel(List<Hotel> hotelSearch)
        //{
        //    this.hotelSearch = hotelSearch;
        //}

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
