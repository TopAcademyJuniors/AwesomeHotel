using HotelSelect.DataAccessObject.Implementations;
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

namespace HotelSelect.Views
{
    public partial class UpdateHotel : Form
    {
        IHotelDAO hotelDAO = new ImplHotelDAO();
        public UpdateHotel()
        {
            InitializeComponent();

            id_city.Enabled = false;
            id_country.Enabled = false;
            stars.Enabled = false;
            adres.Enabled = false;
            numerTel.Enabled = false;
            countNumer.Enabled = false;
            description.Enabled = false;
        }

        private void comboBox1NameHotel_Enter(object sender, EventArgs e)
        {
            if (comboBox1NameHotel.Text == "Название отеля")
            {
                comboBox1NameHotel.Text = "";
                comboBox1NameHotel.ForeColor = SystemColors.WindowText;
                comboBox1NameHotel.BackColor = SystemColors.Window;
            }
        }

        private void comboBox1NameHotel_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1NameHotel.Text))
            {

                comboBox1NameHotel.Text = "Название отеля";
                comboBox1NameHotel.ForeColor = SystemColors.WindowFrame;
                comboBox1NameHotel.BackColor = SystemColors.ActiveBorder;
                
            }
        }

        private void comboBox2City_Enter(object sender, EventArgs e)
        {
            if (comboBox2City.Text == "Город")
            {
                comboBox2City.Text = "";
                comboBox2City.ForeColor = SystemColors.WindowText;
                comboBox2City.BackColor = SystemColors.Window;
            }
        }

        private void comboBox2City_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox2City.Text))
            {

                comboBox2City.Text = "Город";
                comboBox2City.ForeColor = SystemColors.WindowFrame;
                comboBox2City.BackColor = SystemColors.ActiveBorder;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            id_city.Enabled = true;
            id_country.Enabled = true;
            stars.Enabled = true;
            adres.Enabled = true;
            numerTel.Enabled = true;
            countNumer.Enabled = true;
            description.Enabled = true;

            hotelDAO.SearchHotel(new Hotel());

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            hotelDAO.UpdateHotel(new Hotel());
        }
    }
}
