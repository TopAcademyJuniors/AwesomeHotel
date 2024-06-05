using HotelSelect.Dao.repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSelect.Views
{
    public partial class Support : Form
    {
        List<string> mas_answer = new List<string>();
        public Support()
        {
            InitializeComponent();
            SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;
            sqlConnection.Open();
            string sqlFindQuestion = "SELECT * FROM question";
            SqlCommand sqlCommandFindQuestion = new SqlCommand(sqlFindQuestion, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommandFindQuestion.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Question_comboBox.Items.Add(sqlDataReader.GetValue(1));
                    mas_answer.Add((string)sqlDataReader.GetValue(2));
                }
            }
            sqlConnection.Close();
        }

        private void Question_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            answer.Text = mas_answer[Question_comboBox.SelectedIndex];
        }
    }
}
