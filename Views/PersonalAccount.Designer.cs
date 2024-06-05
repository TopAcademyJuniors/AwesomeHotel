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
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.DeleteHotel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerchHotelButton
            // 
            this.SerchHotelButton.Location = new System.Drawing.Point(28, 20);
            this.SerchHotelButton.Name = "SerchHotelButton";
            this.SerchHotelButton.Size = new System.Drawing.Size(97, 42);
            this.SerchHotelButton.TabIndex = 0;
            this.SerchHotelButton.Text = "Поиск отелей";
            this.SerchHotelButton.UseVisualStyleBackColor = true;
            this.SerchHotelButton.Click += new System.EventHandler(this.SerchHotelButton_Click);
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Enabled = false;
            this.buttonAddHotel.Location = new System.Drawing.Point(143, 20);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(100, 42);
            this.buttonAddHotel.TabIndex = 1;
            this.buttonAddHotel.Text = "Добавить отель";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.buttonAddHotel_Click);
            // 
            // DeleteHotel
            // 
            this.DeleteHotel.Location = new System.Drawing.Point(281, 20);
            this.DeleteHotel.Name = "DeleteHotel";
            this.DeleteHotel.Size = new System.Drawing.Size(108, 41);
            this.DeleteHotel.TabIndex = 2;
            this.DeleteHotel.Text = "Удаление отеля";
            this.DeleteHotel.UseVisualStyleBackColor = true;
            this.DeleteHotel.Click += new System.EventHandler(this.DeleteHotel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактирование отеля";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeleteHotel);
            this.Controls.Add(this.buttonAddHotel);
            this.Controls.Add(this.SerchHotelButton);
            this.Name = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SerchHotelButton;
        private System.Windows.Forms.Button buttonAddHotel;
        private System.Windows.Forms.Button DeleteHotel;
        private System.Windows.Forms.Button button2;
    }
}