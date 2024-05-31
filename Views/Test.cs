using HotelSelect.Dao.impl;
using HotelSelect.Dao.inreface;
using HotelSelect.Entity;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUserDAO userDAO = new ImplUserDAO();
            long id = Convert.ToInt64(textBox1.Text);
            if (userDAO.FindUserById(id) != null)
                MessageBox.Show("Пользователь сущетсвует");
            else
                MessageBox.Show("Пользователь не сущетсвует");
        }
    }
}
