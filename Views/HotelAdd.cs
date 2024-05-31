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
                    Convert.ToInt32(textBox2.Text), textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(NumberRooms.Text));

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Название отеля")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
                textBox1.BackColor = SystemColors.Window;
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "Название отеля";
                textBox1.ForeColor = SystemColors.Window;
                textBox1.BackColor = SystemColors.WindowFrame;
                
            }

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "id_страны")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = SystemColors.WindowText;
                comboBox1.BackColor = SystemColors.Window;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {

                comboBox1.Text = "id_страны";
                comboBox1.ForeColor = SystemColors.Window;
                comboBox1.BackColor = SystemColors.WindowFrame;

            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "id_города")
            {
                comboBox2.Text = "";
                comboBox2.ForeColor = SystemColors.WindowText;
                comboBox2.BackColor = SystemColors.Window;
            }
            
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox2.Text))
            {

                comboBox2.Text = "id_города";
                comboBox2.ForeColor = SystemColors.Window;
                comboBox2.BackColor = SystemColors.WindowFrame;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Количество звезд")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
                textBox2.BackColor = SystemColors.Window;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {

                textBox2.Text = "Количество звезд";
                textBox2.ForeColor = SystemColors.Window;
                textBox2.BackColor = SystemColors.WindowFrame;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Адрес")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
                textBox5.BackColor = SystemColors.Window;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox5.Text))
            {

                textBox5.Text = "Адрес";
                textBox5.ForeColor = SystemColors.Window;
                textBox5.BackColor = SystemColors.WindowFrame;

            }
        }

       

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Номер телефона")
            {
                textBox6.Text = "";
                textBox6.ForeColor = SystemColors.WindowText;
                textBox6.BackColor = SystemColors.Window;
            }
        } 
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox6.Text))
            {

                textBox6.Text = "Номер телефона";
                textBox6.ForeColor = SystemColors.Window;
                textBox6.BackColor = SystemColors.WindowFrame;

            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Описание")
            {
                textBox7.Text = "";
                textBox7.ForeColor = SystemColors.WindowText;
                textBox7.BackColor = SystemColors.Window;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox7.Text))
            {

                textBox7.Text = "Описание";
                textBox7.ForeColor = SystemColors.Window;
                textBox7.BackColor = SystemColors.WindowFrame;

            }
        }

        private void NumberRooms_Enter(object sender, EventArgs e)
        {
            if (NumberRooms.Text == "Количество номеров")
            {
                NumberRooms.Text = "";
                NumberRooms.ForeColor = SystemColors.WindowText;
                NumberRooms.BackColor = SystemColors.Window;
            }
        }

        private void NumberRooms_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NumberRooms.Text))
            {

                NumberRooms.Text = "Количество номеров";
                NumberRooms.ForeColor = SystemColors.Window;
                NumberRooms.BackColor = SystemColors.WindowFrame;

            }
        }
    }
}
