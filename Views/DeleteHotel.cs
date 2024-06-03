using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelSelect.Views
{
    public partial class DeleteHotel : Form
    {
        public DeleteHotel()
        {
            InitializeComponent();
        }

        private void comboBoxCountry_Enter(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "Страна") {
                comboBoxCountry.Text = "";
                comboBoxCountry.ForeColor = SystemColors.WindowText;
                comboBoxCountry.BackColor = SystemColors.Window;
            }
        }

        private void comboBoxCountry_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxCountry.Text)) {
                comboBoxCountry.Text = "Страна";
                comboBoxCountry.ForeColor = SystemColors.Window;
                comboBoxCountry.BackColor = SystemColors.WindowFrame;
            }
        }

        private void comboBoxCity_Enter(object sender, EventArgs e)
        {
            if (comboBoxCity.Text == "Город")
            {
               comboBoxCity.Text = "";
               comboBoxCity.ForeColor = SystemColors.WindowText;
               comboBoxCity.BackColor = SystemColors.Window;
            }
        }

        private void comboBoxCity_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxCity.Text))
            {
                comboBoxCity.Text = "Город";
                comboBoxCity.ForeColor = SystemColors.Window;
                comboBoxCity.BackColor = SystemColors.WindowFrame;
            }
        }
    }
}
