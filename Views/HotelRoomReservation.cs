using HotelSelect.Dao.repository;
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
        public HotelRoomReservation()
        {
            InitializeComponent();


            SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
            sqlConnection.Open();

            string sqlQueryCountries = "SELECT * FROM Countries";

            SqlCommand sqlCommandFindCountries = new SqlCommand(sqlQueryCountries, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommandFindCountries.ExecuteReader();
            
            while (sqlDataReader.Read())
            {
                ComBoxCountry.Items.Add((string)sqlDataReader.GetValue(1));
                
            }
            sqlConnection.Close();



        }


    }
}
