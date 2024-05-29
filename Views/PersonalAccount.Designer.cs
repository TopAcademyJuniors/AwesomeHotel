namespace HotelSelect
{
    partial class PersonalAccount
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
            this.SerchHotelButton = new System.Windows.Forms.Button();
            this.Name_user = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete_acc = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerchHotelButton
            // 
            this.SerchHotelButton.Location = new System.Drawing.Point(51, 353);
            this.SerchHotelButton.Name = "SerchHotelButton";
            this.SerchHotelButton.Size = new System.Drawing.Size(97, 42);
            this.SerchHotelButton.TabIndex = 0;
            this.SerchHotelButton.Text = "Поиск отелей";
            this.SerchHotelButton.UseVisualStyleBackColor = true;
            this.SerchHotelButton.Click += new System.EventHandler(this.SerchHotelButton_Click);
            // 
            // Name_user
            // 
            this.Name_user.AutoSize = true;
            this.Name_user.BackColor = System.Drawing.Color.Gray;
            this.Name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_user.Location = new System.Drawing.Point(48, 36);
            this.Name_user.Name = "Name_user";
            this.Name_user.Size = new System.Drawing.Size(100, 37);
            this.Name_user.TabIndex = 1;
            this.Name_user.Text = "label1";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(691, 26);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(97, 47);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход из аккаунта";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Delete_acc
            // 
            this.Delete_acc.Location = new System.Drawing.Point(691, 122);
            this.Delete_acc.Name = "Delete_acc";
            this.Delete_acc.Size = new System.Drawing.Size(97, 47);
            this.Delete_acc.TabIndex = 4;
            this.Delete_acc.Text = "Удалить аккаунт";
            this.Delete_acc.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.Setting.Location = new System.Drawing.Point(51, 88);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(97, 47);
            this.Setting.TabIndex = 5;
            this.Setting.Text = "Настройки";
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelSelect.Properties.Resources._84971495226962;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.Delete_acc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Name_user);
            this.Controls.Add(this.SerchHotelButton);
            this.Name = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerchHotelButton;
        private System.Windows.Forms.Label Name_user;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete_acc;
        private System.Windows.Forms.Button Setting;
    }
}