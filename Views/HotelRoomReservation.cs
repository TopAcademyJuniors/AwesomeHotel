﻿using HotelSelect.Dao.repository;
using HotelSelect.DataAccessObject.Implementations;
using HotelSelect.DataAccessObject.Interfaces;
using HotelSelect.Entities;
using HotelSelect.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect
{
    public partial class HotelRoomReservation : Form
    {
        private ICountryDAO countryDAO;
        private ICityDAO cityDAO;

        public HotelRoomReservation()
        {
            InitializeComponent();


            countryDAO = new ImplCountryDAO();
            cityDAO = new ImplCityDao();

            List<Country> countries = countryDAO.GetAllCountries();

            foreach (var item in countries)
            {
                ComBoxCountry.Items.Add(item.Name);
            }

            //SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
            //sqlConnection.Open();

            //string sqlQueryCountries = "SELECT * FROM Countries";

            //SqlCommand sqlCommandFindCountries = new SqlCommand(sqlQueryCountries, sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommandFindCountries.ExecuteReader();
            
            //while (sqlDataReader.Read())
            //{
            //    ComBoxCountry.Items.Add((string)sqlDataReader.GetValue(1));
                
            //}
            //sqlConnection.Close();



        }

        private void ComBoxCountry_Enter(object sender, EventArgs e)
        {
            if (ComBoxCountry.Text == "Страна")
            {
                ComBoxCountry.Text = "";
                ComBoxCountry.ForeColor = SystemColors.WindowText;
                ComBoxCountry.BackColor = SystemColors.Window;
            }


        }

        private void ComBoxCountry_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ComBoxCountry.Text))
            {

                ComBoxCountry.Text = "Страна";
                ComBoxCountry.ForeColor = SystemColors.GrayText;
                ComBoxCountry.BackColor = SystemColors.ScrollBar;

            }

        }

        private void ComBoxCity_Enter(object sender, EventArgs e)
        {
            if (ComBoxCity.Text == "Город")
            {
                ComBoxCity.Text = "";
                ComBoxCity.ForeColor = SystemColors.WindowText;
                ComBoxCity.BackColor = SystemColors.Window;

            }
        }

        private void ComBoxCity_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ComBoxCity.Text))
            {
                ComBoxCity.Text = "Город";
                ComBoxCity.ForeColor = SystemColors.GrayText;
                ComBoxCity.BackColor = SystemColors.ScrollBar;
            }
        }

        private void ComBoxNameHotel_Enter(object sender, EventArgs e)
        {
            if (ComBoxNameHotel.Text == "Название отеля")
            {
                ComBoxNameHotel.Text = "";
                ComBoxNameHotel.ForeColor = SystemColors.WindowText;
                ComBoxNameHotel.BackColor = SystemColors.Window;
            }
        }

        private void ComBoxNameHotel_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ComBoxNameHotel.Text))
            {
                ComBoxNameHotel.Text = "Название отеля";
                ComBoxNameHotel.ForeColor = SystemColors.GrayText;
                ComBoxNameHotel.BackColor = SystemColors.ScrollBar;
            }
        }

        private void textBoxPriceFrom_Enter(object sender, EventArgs e)
        {
            if (textBoxPriceFrom.Text == "Цена от")
            {
                textBoxPriceFrom.Text = "";
                textBoxPriceFrom.ForeColor = SystemColors.WindowText;
                textBoxPriceFrom.BackColor = SystemColors.Window;
            }

        }

        private void textBoxPriceFrom_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPriceFrom.Text))
            {
                textBoxPriceFrom.Text = "Цена от";
                textBoxPriceFrom.ForeColor = SystemColors.GrayText;
                textBoxPriceFrom.BackColor = SystemColors.ScrollBar;
            }

        }

        private void textBoxPriceBefore_Enter(object sender, EventArgs e)
        {
            if (textBoxPriceBefore.Text == "Цена до")
            {
                textBoxPriceBefore.Text = "";
                textBoxPriceBefore.ForeColor = SystemColors.WindowText;
                textBoxPriceBefore.BackColor = SystemColors.Window;
            }

        }

        private void textBoxPriceBefore_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPriceBefore.Text))
            {
                textBoxPriceBefore.Text = "Цена до";
                textBoxPriceBefore.ForeColor = SystemColors.GrayText;
                textBoxPriceBefore.BackColor = SystemColors.ScrollBar;
            }

        }

        private void ComBoxCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            List < City > cities = cityDAO.GetAllCitiesByCountryId(ComBoxCountry.Text);

            foreach (var item in cities)
            {
                ComBoxCity.Items.Add(item.Name);
            }

        }
        private void ComBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


       
    }
}
