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

            SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
            sqlConnection.Open();
            string sqlQueryFindUser = "select * from Countries";
            SqlCommand sqlCommandFindUser = new SqlCommand(sqlQueryFindUser, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    mas_id_con.Add((int)(sqlDataReader.GetValue(0)));
                    mas_con.Add((string)sqlDataReader.GetValue(1));
                }
            }
            sqlConnection.Close();

            foreach (string con in mas_con)
            {
                comboBox1.Items.Add(con);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e) {}

        private void textBox2_TextChanged(object sender, EventArgs e) {}

        private void textBox5_TextChanged(object sender, EventArgs e) {}

        private void textBox6_TextChanged(object sender, EventArgs e) {}

        private void AddHotel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null
                            && textBox2.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                if (textBox1.BackColor == Color.Red)
                {
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox5.BackColor = Color.White;
                    textBox6.BackColor = Color.White;
                }
                
                int id_con = 0;
                int id_city = 0;
                for (int i = 0; i < mas_con.Count; i++)
                {
                    if (mas_con[i] == comboBox1.SelectedItem)
                    {
                        id_con = i + 1;
                    }
                }
                for (int i = 0; i < mas_city.Count; i++)
                {
                    if (mas_city[i] == comboBox2.SelectedItem)
                    {
                        id_city = i + 1;
                    }
                }

                Hotel hotel = new Hotel(textBox1.Text, id_con, id_city,
                    Convert.ToInt32(textBox2.Text), textBox5.Text, textBox6.Text, textBox7.Text);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
            }
            
        }

        private void label2_Click(object sender, EventArgs e) {}

        private void label3_Click(object sender, EventArgs e) {}

        private void label4_Click(object sender, EventArgs e) {}

        private void label5_Click(object sender, EventArgs e) {}

        private void label6_Click(object sender, EventArgs e) {}

        private void label7_Click(object sender, EventArgs e) {}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox2.Items != null)
                {
                    comboBox2.Items.Clear();
                }
                string zapros = "select Cities.id, Cities.name from Cities_countries " +
                    "join Countries on Cities_countries.country_id = Countries.id " +
                    "join Cities on Cities.id = Cities_countries.city_id";

                SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
                sqlConnection.Open();
                SqlCommand sqlCommandFindUser = new SqlCommand(zapros, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        mas_id_city.Add(Convert.ToInt32(sqlDataReader.GetValue(0)));
                        mas_city.Add((string)sqlDataReader.GetValue(1));
                    }
                }
                sqlConnection.Close();

                foreach (string city in mas_city)
                {
                    comboBox2.Items.Add(city);
                }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e) {}

        private void label8_Click(object sender, EventArgs e) {}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {}
    }
}
