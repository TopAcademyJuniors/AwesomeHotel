namespace HotelSelect.Views.Controls
{
    partial class OptionsForm
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
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.password_new = new System.Windows.Forms.TextBox();
            this.password_old = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(67, 146);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(141, 27);
            this.surname.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(67, 179);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(141, 27);
            this.name.TabIndex = 1;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(67, 212);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(141, 27);
            this.patronymic.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(67, 245);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(141, 27);
            this.email.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(67, 80);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 27);
            this.login.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(99, 291);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // password_new
            // 
            this.password_new.Location = new System.Drawing.Point(67, 113);
            this.password_new.Multiline = true;
            this.password_new.Name = "password_new";
            this.password_new.Size = new System.Drawing.Size(141, 27);
            this.password_new.TabIndex = 6;
            // 
            // password_old
            // 
            this.password_old.Location = new System.Drawing.Point(228, 113);
            this.password_old.Multiline = true;
            this.password_old.Name = "password_old";
            this.password_old.Size = new System.Drawing.Size(141, 27);
            this.password_old.TabIndex = 7;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelSelect.Properties.Resources._1612755328_4_p_fon_goluboi_shesterenki_5;
            this.ClientSize = new System.Drawing.Size(799, 545);
            this.Controls.Add(this.password_old);
            this.Controls.Add(this.password_new);
            this.Controls.Add(this.save);
            this.Controls.Add(this.login);
            this.Controls.Add(this.email);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox password_new;
        private System.Windows.Forms.TextBox password_old;
    }
}