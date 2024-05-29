namespace HotelSelect
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.authBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveAuthSession = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(145, 134);
            this.login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(314, 39);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(145, 269);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(259, 39);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.Teal;
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBtn.Location = new System.Drawing.Point(327, 499);
            this.authBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(215, 62);
            this.authBtn.TabIndex = 2;
            this.authBtn.Text = "Авторизация";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(154, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(154, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Teal;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(89, 499);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(215, 62);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::HotelSelect.Properties.Resources.eye_visible;
            this.button3.Location = new System.Drawing.Point(413, 269);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 42);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::HotelSelect.Properties.Resources.not_visible;
            this.button2.Location = new System.Drawing.Point(413, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveAuthSession
            // 
            this.saveAuthSession.AutoSize = true;
            this.saveAuthSession.Location = new System.Drawing.Point(145, 338);
            this.saveAuthSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAuthSession.Name = "saveAuthSession";
            this.saveAuthSession.Size = new System.Drawing.Size(160, 24);
            this.saveAuthSession.TabIndex = 8;
            this.saveAuthSession.Text = "Запомнить вход";
            this.saveAuthSession.UseVisualStyleBackColor = true;
            this.saveAuthSession.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 626);
            this.Controls.Add(this.saveAuthSession);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Registration;

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox saveAuthSession;
    }
}

