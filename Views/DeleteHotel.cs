﻿using HotelSelect.DataAccessObject.Implementations;
using HotelSelect.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelSelect.Views {
    public partial class DeleteHotel : Form {

        IHotelDAO hotelDAO = new ImplHotelDAO();

        public DeleteHotel() {
            InitializeComponent();

            List<Hotel> hotels = new List<Hotel>();
            Country c = new Country();
            dataGridViewHotels.DataSource = hotelDAO.SearchHotelsByCountry(c);
        }

        private void LoadHotels() {

        }

        private void Delete_Click(object sender, EventArgs e) {

            //Hotel hotel = dataGridViewHotels().SelectItem();

            hotelDAO.DeleteHotel(new Hotel());
        }

        private void comboBoxCountry_Enter(object sender, EventArgs e) {

            if (comboBoxCountry.Text == "Страна") {
                comboBoxCountry.Text = "";
                comboBoxCountry.ForeColor = SystemColors.WindowText;
                comboBoxCountry.BackColor = SystemColors.Window;
            }
        }

        private void comboBoxCountry_Leave(object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace(comboBoxCountry.Text)) {
                comboBoxCountry.Text = "Страна";
                comboBoxCountry.ForeColor = SystemColors.Window;
                comboBoxCountry.BackColor = SystemColors.WindowFrame;
            }
        }

        private void comboBoxCity_Enter(object sender, EventArgs e) {

            if (comboBoxCity.Text == "Город") {
               comboBoxCity.Text = "";
               comboBoxCity.ForeColor = SystemColors.WindowText;
               comboBoxCity.BackColor = SystemColors.Window;
            }
        }

        private void comboBoxCity_Leave(object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace(comboBoxCity.Text)) {
                comboBoxCity.Text = "Город";
                comboBoxCity.ForeColor = SystemColors.Window;
                comboBoxCity.BackColor = SystemColors.WindowFrame;
            }
        }
    }
}
