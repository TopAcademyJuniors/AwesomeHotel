﻿using HotelSelect.Entities;
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
        private List<Hotel> hotelSearch;

        public HotelPanel()
        {
            InitializeComponent();
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
