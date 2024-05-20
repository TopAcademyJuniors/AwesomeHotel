using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSelect.Entities;
using System.Data.SqlClient;
using HotelSelect.Dao.repository;
using HotelSelect.Entity;

namespace HotelSelect
{

    public partial class HotelAdd : Form
    {
        List<int> mas_id_con = new List<int>();
        List<int> mas_id_city = new List<int>();
        List<string> mas_con = new List<string>();
        List<string> mas_city = new List<string>();

        public HotelAdd()
        {
            InitializeComponent();

            comboBox2.Hide();

            SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
            sqlConnection.Open();
            string sqlQueryFindUser = "select Countries.name, Cities.name, Cities_countries.country_id," +
                " Cities_countries.city_id from Cities_countries " +
                "join Countries on Countries.id = Cities_countries.country_id" +
                "join Cities on Cities.id = Cities_countries.city_id";
            SqlCommand sqlCommandFindUser = new SqlCommand(sqlQueryFindUser, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    mas_con.Add((string)sqlDataReader.GetValue(0));
                    mas_city.Add((string)sqlDataReader.GetValue(1));
                    mas_id_city.Add((int)sqlDataReader.GetValue(2));
                    mas_id_con.Add((int)(sqlDataReader.GetValue(3)));
                }
            }

            foreach (string con in mas_con)
            {
                comboBox1.Items.Add(con);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label2.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label3.Text))
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label4.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label5.Text))
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label6.Text))
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label7.Text))
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void AddHotel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""
                && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                if (textBox1.BackColor == Color.Red)
                {
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;
                    textBox4.BackColor = Color.White;
                    textBox5.BackColor = Color.White;
                    textBox6.BackColor = Color.White;
                }

                Hotel hotel = new Hotel(textBox1.Text,
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text),
                    textBox5.Text, textBox6.Text);
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                foreach (string city in mas_city)
                {
                    comboBox2.Items.Add(city);
                }
            }
        }
    }
}
