﻿using HotelSelect.Entity;
using HotelSelect.Properties;
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
    public partial class HOTEL_CARD : Form
    {
        public HOTEL_CARD()
        {
            InitializeComponent();
        }
        public object imageLocation { get; private set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void HOTEL_CARD_Load(object sender, EventArgs e)
        {
            

                }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = this.Controls.OfType<PictureBox>().FirstOrDefault();
          
        }
    }
}
