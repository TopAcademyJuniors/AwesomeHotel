namespace HotelSelect.Views
{
    partial class Hotel_card
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
            this.ID = new System.Windows.Forms.TextBox();
            this.COUNTRY = new System.Windows.Forms.TextBox();
            this.CITYNAME = new System.Windows.Forms.TextBox();
            this.NAMEHOTEL = new System.Windows.Forms.TextBox();
            this.DESCRIPTION = new System.Windows.Forms.TextBox();
            this.STARS = new System.Windows.Forms.TextBox();
            this.ADRESS = new System.Windows.Forms.TextBox();
            this.PHONENUMBER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.Silver;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ID.Location = new System.Drawing.Point(41, 41);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(192, 48);
            this.ID.TabIndex = 0;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // COUNTRY
            // 
            this.COUNTRY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.COUNTRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.COUNTRY.Location = new System.Drawing.Point(85, 109);
            this.COUNTRY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.COUNTRY.Multiline = true;
            this.COUNTRY.Name = "COUNTRY";
            this.COUNTRY.Size = new System.Drawing.Size(192, 48);
            this.COUNTRY.TabIndex = 1;
            this.COUNTRY.Text = "      COUNTRY";
            this.COUNTRY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CITYNAME
            // 
            this.CITYNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CITYNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CITYNAME.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CITYNAME.Location = new System.Drawing.Point(124, 176);
            this.CITYNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CITYNAME.Multiline = true;
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.Size = new System.Drawing.Size(192, 48);
            this.CITYNAME.TabIndex = 2;
            this.CITYNAME.Text = "         CITY";
            this.CITYNAME.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // NAMEHOTEL
            // 
            this.NAMEHOTEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NAMEHOTEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NAMEHOTEL.Location = new System.Drawing.Point(155, 255);
            this.NAMEHOTEL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NAMEHOTEL.Multiline = true;
            this.NAMEHOTEL.Name = "NAMEHOTEL";
            this.NAMEHOTEL.Size = new System.Drawing.Size(284, 48);
            this.NAMEHOTEL.TabIndex = 3;
            this.NAMEHOTEL.Text = "     NAMEHOTEL\r\n\r\n";
            this.NAMEHOTEL.TextChanged += new System.EventHandler(this.Название_TextChanged);
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DESCRIPTION.Location = new System.Drawing.Point(202, 328);
            this.DESCRIPTION.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DESCRIPTION.Multiline = true;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Size = new System.Drawing.Size(284, 48);
            this.DESCRIPTION.TabIndex = 4;
            this.DESCRIPTION.Text = "       DESCRIPTION";
            this.DESCRIPTION.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // STARS
            // 
            this.STARS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.STARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STARS.Location = new System.Drawing.Point(262, 399);
            this.STARS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.STARS.Multiline = true;
            this.STARS.Name = "STARS";
            this.STARS.Size = new System.Drawing.Size(284, 48);
            this.STARS.TabIndex = 5;
            this.STARS.Text = "             STARS";
            this.STARS.TextChanged += new System.EventHandler(this.Количествозвезд_TextChanged);
            // 
            // ADRESS
            // 
            this.ADRESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ADRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADRESS.Location = new System.Drawing.Point(320, 463);
            this.ADRESS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADRESS.Multiline = true;
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.Size = new System.Drawing.Size(284, 48);
            this.ADRESS.TabIndex = 6;
            this.ADRESS.Text = "               ADRESS";
            this.ADRESS.TextChanged += new System.EventHandler(this.Адрес_TextChanged);
            // 
            // PHONENUMBER
            // 
            this.PHONENUMBER.BackColor = System.Drawing.Color.IndianRed;
            this.PHONENUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PHONENUMBER.Location = new System.Drawing.Point(370, 533);
            this.PHONENUMBER.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PHONENUMBER.Multiline = true;
            this.PHONENUMBER.Name = "PHONENUMBER";
            this.PHONENUMBER.Size = new System.Drawing.Size(305, 48);
            this.PHONENUMBER.TabIndex = 7;
            this.PHONENUMBER.Text = "         PHONENUMBER";
            this.PHONENUMBER.TextChanged += new System.EventHandler(this.Номертелефона_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // Hotel_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1020, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PHONENUMBER);
            this.Controls.Add(this.ADRESS);
            this.Controls.Add(this.STARS);
            this.Controls.Add(this.DESCRIPTION);
            this.Controls.Add(this.NAMEHOTEL);
            this.Controls.Add(this.CITYNAME);
            this.Controls.Add(this.COUNTRY);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Hotel_card";
            this.Text = "HOTEL_CARD";
            this.Load += new System.EventHandler(this.Hotel_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox COUNTRY;
        private System.Windows.Forms.TextBox CITYNAME;
        private System.Windows.Forms.TextBox NAMEHOTEL;
        private System.Windows.Forms.TextBox DESCRIPTION;
        private System.Windows.Forms.TextBox STARS;
        private System.Windows.Forms.TextBox ADRESS;
        private System.Windows.Forms.TextBox PHONENUMBER;
        private System.Windows.Forms.Label label1;
    }
}