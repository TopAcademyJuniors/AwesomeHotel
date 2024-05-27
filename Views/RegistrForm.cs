using System;
using System.Drawing;
using System.Windows.Forms;
using HotelSelect.DataAccessObject.Services;
using HotelSelect.Entity;
using HotelSelect.Patterns;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSelect
{
    public partial class RegistrForm : Form
    {
        bool clickForDateTimePicker;

        public RegistrForm()
        {
            InitializeComponent();

            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.ValueChanged += DateOfBirth_ValueChanged;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(Surname.Text, Name.Text, Patronymic.Text, 
                Login.Text, Password.Text) || !CheckDateTimePickerClicked()) {
                return;
            }
            //else if (!UniversalMethodsCheckIsEmptyAndSelected.CheckComboBoxesIsSelected(Countries, Cities))
            //{
            //    MessageBox.Show("ComboBoxes no selected");
            //    return;
            //}

            FacadeRegistrUser facadeRegistrUser = new FacadeRegistrUser();

            newUser = facadeRegistrUser.RegistrationFacade(PhoneNumberOrEmail.Text, newUser);

            newUser.FullName = new FullName
            {
                Surname = Surname.Text,
                Name = Name.Text,
                Patronymic = Patronymic.Text,
            };
            newUser.DateOfBirth = DateOfBirth.Value;
            newUser.Login = Login.Text;
            newUser.Password = Password.Text;

            //todo: поправить как буду страны
            newUser.CountryId = 1;
            newUser.CityId = 1;

            //if (facadeRegistrUser.CheckExistUser(newUser))
            //{
            //    MessageBox.Show("User already exist");
            //    return;
            //}

            facadeRegistrUser.RegistrationUser(newUser);

            PersonalAccount personalAccount = new PersonalAccount();
            this.Close();
        }

        private void Patronymic_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void PhoneNumberOrEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            clickForDateTimePicker = true;
        }

        private bool CheckDateTimePickerClicked()
        {
            bool isClicked = false;

            if (clickForDateTimePicker)
            {
                isClicked = true;
            }

            return isClicked;
        }

        private void RegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Фамилия")
            {
                Surname.Text = "";
                Surname.ForeColor = SystemColors.WindowText;
                Surname.BackColor = SystemColors.Window;
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Surname.Text))
            {

                Surname.Text = "Фамилия";
                Surname.ForeColor = SystemColors.Window;
                Surname.BackColor = SystemColors.WindowFrame;

            }

        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (Name.Text == "Имя")
            {
                Name.Text = "";
                Name.ForeColor = SystemColors.WindowText;
                Name.BackColor = SystemColors.Window;
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Name.Text))
            {

                Name.Text = "Имя";
                Name.ForeColor = SystemColors.Window;
                Name.BackColor = SystemColors.WindowFrame;
                
            }
        }

        private void Patronymic_Enter(object sender, EventArgs e)
        {
            if (Patronymic.Text == "Фамилия")
            {
                Patronymic.Text = "";
                Patronymic.ForeColor = SystemColors.WindowText;
                Patronymic.BackColor = SystemColors.Window;
            }
        }

        private void Patronymic_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Patronymic.Text))
            {

                Patronymic.Text = "Фамилия";
                Patronymic.ForeColor = SystemColors.Window;
                Patronymic.BackColor = SystemColors.WindowFrame;

            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Логин")
            {
                Login.Text = "";
                Login.ForeColor = SystemColors.WindowText;
                Login.BackColor = SystemColors.Window;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login.Text))
            {

                Login.Text = "Логин";
                Login.ForeColor = SystemColors.Window;
                Login.BackColor = SystemColors.WindowFrame;

            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Пароль")
            {
                Password.Text = "";
                Password.ForeColor = SystemColors.WindowText;
                Password.BackColor = SystemColors.Window;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Password.Text))
            {

                Password.Text = "Пароль";
                Password.ForeColor = SystemColors.Window;
                Password.BackColor = SystemColors.WindowFrame;

            }
        }

        private void PhoneNumberOrEmail_Enter(object sender, EventArgs e)
        {
            if (PhoneNumberOrEmail.Text == "Номер телефона/Email")
            {
                PhoneNumberOrEmail.Text = "";
                PhoneNumberOrEmail.ForeColor = SystemColors.WindowText;
                PhoneNumberOrEmail.BackColor = SystemColors.Window;
            }
        }

        private void PhoneNumberOrEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PhoneNumberOrEmail.Text))
            {

                PhoneNumberOrEmail.Text = "Номер телефона/Email";
                PhoneNumberOrEmail.ForeColor = SystemColors.Window;
                PhoneNumberOrEmail.BackColor = SystemColors.WindowFrame;

            }
        }

        private void Countries_Enter(object sender, EventArgs e)
        {
            if (Countries.Text == "Страна")
            {
                Countries.Text = "";
                Countries.ForeColor = SystemColors.WindowText;
                Countries.BackColor = SystemColors.Window;
            }
        }

        private void Countries_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Countries.Text))
            {

                Countries.Text = "Страна";
                Countries.ForeColor = SystemColors.Window;
                Countries.BackColor = SystemColors.WindowFrame;

            }
        }

        

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void City_Enter(object sender, EventArgs e)
        {
            if (City.Text == "Город")
            {
                City.Text = "";
                City.ForeColor = SystemColors.WindowText;
                City.BackColor = SystemColors.Window;
            }
        }

        private void City_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(City.Text))
            {

                City.Text = "Город";
                City.ForeColor = SystemColors.Window;
                City.BackColor = SystemColors.WindowFrame;

            }
        }
    }

        
    
}
