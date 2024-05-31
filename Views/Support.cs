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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void buttonFAQ_1_Click(object sender, EventArgs e)
        {
            answer.Text = "После выбора варианта изучите правила отмены и нажмите «Забронировать». Укажите контактные данные и имя и фамилию как минимум одного гостя.";
        }

        private void buttonFAQ_2_Click(object sender, EventArgs e)
        {
            answer.Text = "Правила отмены у каждого отеля свои. Если по условиям тарифа отмена возможна, вы можете самостоятельно отменить бронирование в личном кабинете.";
        }

        private void buttonFAQ_3_Click(object sender, EventArgs e)
        {
            answer.Text = "Это зависит от условий тарифа, по которому вы забронировали объект размещения. Правила отмены вы можете прочитать:\r\n\r\nперед бронированием — в описании номера,\r\nпосле бронирования — в личном кабинете.";
        }

        private void buttonFAQ_4_Click(object sender, EventArgs e)
        {
            answer.Text = "Если вы хотите сообщить в объект размещения какую-то информацию, свяжитесь с нами, и мы передадим ваш запрос. Например, о времени заезда или что вам нужен трансфер.";
        }
    }
}
