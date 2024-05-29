using HotelSelect.Dao.impl;
using HotelSelect.DataAccessObject.Services;
using HotelSelect.Entity;
using HotelSelect.Mappers;
using HotelSelect.Proxy;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSelect
{
    public partial class AuthForm : Form
    {
        private UserDaoProxy UserDaoProxy = new UserDaoProxy();
        private UserMapper userMapper = new UserMapper();
        public AuthForm()
        {
            InitializeComponent();


            if(File.Exists("Session.s"))
            {
                using (StreamReader sr = new StreamReader("session.s"))
                {
                    string json = sr.ReadToEnd();
                    User savedUser = userMapper.MapJsonToUser(json);

                    this.TryAuthAndShowPersonalForm(savedUser);
                }
            }


        }



        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrForm registrationForm = new RegistrForm();
            registrationForm.Hide();

            if (registrationForm.ShowDialog() == DialogResult.Cancel) { this.Show(); }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            

            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(login.Text, password.Text))
            {
                return;
            }

            User user = new User { Login = login.Text, Password = password.Text };


            //TODO: Перенесети в регистрацию


            //VerificationUserForAuth verificationUserForAuth = new VerificationUserForAuth();
            //if (verificationUserForAuth.CheckExistUser(user))
            //{
            //    MessageBox.Show("This user does't exist");
            //    return;
            //}
            //

            this.TryAuthAndShowPersonalForm(user);

        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(login.Text)) {
                label1.Visible = true;
            }
            else {
                label1.Visible = false;
            }   
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text)) {
                label2.Visible = true;
            }
            else {
                label2.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(password.PasswordChar == '\0') {
                button3.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*') {
                button2.BringToFront();
                password.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TryAuthAndShowPersonalForm(User user)
        {
            Security.Security sec = new Security.Security();



            if (sec.AuthUser(user))
            {
                PersonalAccount personalAccount = new PersonalAccount();

                if (saveAuthSession.Checked)
                {
                    userMapper.MapUserToJsonAndSave(user);
                }

                personalAccount.ShowDialog();
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
