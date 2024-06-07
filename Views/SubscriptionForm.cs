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
    public partial class PodpiskaForm : Form
    {
        private User user;

        public PodpiskaForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PodpiskaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = $"{user.FullName.Surname} {user.FullName.Name} {user.FullName.Patronymic}";
            textBox2.Text = user.Email;
        }

        private void PodpiskaForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
