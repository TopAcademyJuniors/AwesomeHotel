namespace HotelSelect
{
    partial class RegistrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.PhoneNumberOrEmail = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.role = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Registration = new System.Windows.Forms.Button();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Countries = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.City = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(39, 101);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(341, 34);
            this.Name.TabIndex = 0;
            this.Name.Text = "Имя";
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.Name.Enter += new System.EventHandler(this.Name_Enter);
            this.Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.ForeColor = System.Drawing.Color.White;
            this.Surname.Location = new System.Drawing.Point(39, 39);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(341, 34);
            this.Surname.TabIndex = 8;
            this.Surname.Text = "Фамилия";
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата рождения";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(555, 43);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(337, 34);
            this.Login.TabIndex = 12;
            this.Login.Text = "Логин";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(555, 101);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(337, 34);
            this.Password.TabIndex = 14;
            this.Password.Text = "Пароль";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // PhoneNumberOrEmail
            // 
            this.PhoneNumberOrEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PhoneNumberOrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberOrEmail.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberOrEmail.Location = new System.Drawing.Point(555, 165);
            this.PhoneNumberOrEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumberOrEmail.Name = "PhoneNumberOrEmail";
            this.PhoneNumberOrEmail.Size = new System.Drawing.Size(337, 34);
            this.PhoneNumberOrEmail.TabIndex = 16;
            this.PhoneNumberOrEmail.Text = "Номер телефона/Email";
            this.PhoneNumberOrEmail.TextChanged += new System.EventHandler(this.PhoneNumberOrEmail_TextChanged);
            this.PhoneNumberOrEmail.Enter += new System.EventHandler(this.PhoneNumberOrEmail_Enter);
            this.PhoneNumberOrEmail.Leave += new System.EventHandler(this.PhoneNumberOrEmail_Leave);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateOfBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirth.Location = new System.Drawing.Point(39, 235);
            this.DateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateOfBirth.MaxDate = new System.DateTime(2030, 1, 7, 0, 0, 0, 0);
            this.DateOfBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(341, 30);
            this.DateOfBirth.TabIndex = 20;
            this.DateOfBirth.Value = new System.DateTime(2024, 4, 19, 0, 0, 0, 0);
            this.DateOfBirth.ValueChanged += new System.EventHandler(this.DateOfBirth_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(47, 295);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 155);
            this.panel1.TabIndex = 25;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role.Location = new System.Drawing.Point(31, 26);
            this.role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(164, 20);
            this.role.TabIndex = 8;
            this.role.Text = "Изначальная роль";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Teal;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(555, 396);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(337, 54);
            this.Registration.TabIndex = 26;
            this.Registration.Text = "Зарегестририроваться";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Patronymic
            // 
            this.Patronymic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.ForeColor = System.Drawing.Color.White;
            this.Patronymic.Location = new System.Drawing.Point(39, 165);
            this.Patronymic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(341, 34);
            this.Patronymic.TabIndex = 27;
            this.Patronymic.Text = "Отчество";
            this.Patronymic.TextChanged += new System.EventHandler(this.Patronymic_TextChanged);
            this.Patronymic.Enter += new System.EventHandler(this.Patronymic_Enter);
            this.Patronymic.Leave += new System.EventHandler(this.Patronymic_Leave);
            // 
            // Countries
            // 
            this.Countries.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Countries.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countries.ForeColor = System.Drawing.Color.White;
            this.Countries.FormattingEnabled = true;
            this.Countries.Location = new System.Drawing.Point(553, 236);
            this.Countries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(337, 37);
            this.Countries.TabIndex = 29;
            this.Countries.Text = "Страна";
            this.Countries.SelectedIndexChanged += new System.EventHandler(this.Countries_SelectedIndexChanged);
            this.Countries.Enter += new System.EventHandler(this.Countries_Enter);
            this.Countries.Leave += new System.EventHandler(this.Countries_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelSelect.Properties.Resources.translucent_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City.ForeColor = System.Drawing.Color.White;
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(553, 304);
            this.City.Margin = new System.Windows.Forms.Padding(4);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(337, 37);
            this.City.TabIndex = 34;
            this.City.Text = "Город";
            this.City.Enter += new System.EventHandler(this.City_Enter);
            this.City.Leave += new System.EventHandler(this.City_Leave);
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1189, 524);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Countries);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.PhoneNumberOrEmail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.Name = "RegistrForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Registration;

        #endregion

        private new System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox PhoneNumberOrEmail;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.ComboBox Countries;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox City;
    }
}