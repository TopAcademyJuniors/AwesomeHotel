namespace HotelSelect.Views
{
    partial class UpdateHotel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.comboBox1NameHotel = new System.Windows.Forms.ComboBox();
            this.comboBox2City = new System.Windows.Forms.ComboBox();
            this.SearchHotel = new System.Windows.Forms.Button();
            this.countNumer = new System.Windows.Forms.TextBox();
            this.stars = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.id_city = new System.Windows.Forms.ComboBox();
            this.id_country = new System.Windows.Forms.ComboBox();
            this.numerTel = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelSelect.Properties.Resources.IRS_IT_Systems_to_Get_a_Facelift;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UPDATE.Location = new System.Drawing.Point(463, 473);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(4);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(155, 50);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // comboBox1NameHotel
            // 
            this.comboBox1NameHotel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1NameHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1NameHotel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1NameHotel.FormattingEnabled = true;
            this.comboBox1NameHotel.Location = new System.Drawing.Point(12, 31);
            this.comboBox1NameHotel.Name = "comboBox1NameHotel";
            this.comboBox1NameHotel.Size = new System.Drawing.Size(239, 33);
            this.comboBox1NameHotel.TabIndex = 2;
            this.comboBox1NameHotel.Text = "Название отеля";
            this.comboBox1NameHotel.Enter += new System.EventHandler(this.comboBox1NameHotel_Enter);
            this.comboBox1NameHotel.Leave += new System.EventHandler(this.comboBox1NameHotel_Leave);
            // 
            // comboBox2City
            // 
            this.comboBox2City.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox2City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2City.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox2City.FormattingEnabled = true;
            this.comboBox2City.Location = new System.Drawing.Point(12, 70);
            this.comboBox2City.Name = "comboBox2City";
            this.comboBox2City.Size = new System.Drawing.Size(239, 33);
            this.comboBox2City.TabIndex = 3;
            this.comboBox2City.Text = "Город";
            this.comboBox2City.Enter += new System.EventHandler(this.comboBox2City_Enter);
            this.comboBox2City.Leave += new System.EventHandler(this.comboBox2City_Leave);
            // 
            // SearchHotel
            // 
            this.SearchHotel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchHotel.Location = new System.Drawing.Point(12, 371);
            this.SearchHotel.Name = "SearchHotel";
            this.SearchHotel.Size = new System.Drawing.Size(114, 44);
            this.SearchHotel.TabIndex = 4;
            this.SearchHotel.Text = "поиск";
            this.SearchHotel.UseVisualStyleBackColor = false;
            this.SearchHotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // countNumer
            // 
            this.countNumer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.countNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNumer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.countNumer.Location = new System.Drawing.Point(12, 317);
            this.countNumer.Margin = new System.Windows.Forms.Padding(4);
            this.countNumer.Name = "countNumer";
            this.countNumer.Size = new System.Drawing.Size(229, 30);
            this.countNumer.TabIndex = 34;
            this.countNumer.Text = "Количество номеров";
            // 
            // stars
            // 
            this.stars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stars.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.stars.Location = new System.Drawing.Point(12, 207);
            this.stars.Margin = new System.Windows.Forms.Padding(4);
            this.stars.Multiline = true;
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(229, 29);
            this.stars.TabIndex = 33;
            this.stars.Text = "Количество звезд";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.description.Location = new System.Drawing.Point(695, 31);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(359, 180);
            this.description.TabIndex = 32;
            this.description.Text = "Описание";
            // 
            // id_city
            // 
            this.id_city.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_city.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id_city.FormattingEnabled = true;
            this.id_city.Location = new System.Drawing.Point(12, 165);
            this.id_city.Margin = new System.Windows.Forms.Padding(4);
            this.id_city.Name = "id_city";
            this.id_city.Size = new System.Drawing.Size(229, 33);
            this.id_city.TabIndex = 31;
            this.id_city.Text = "id_города";
            // 
            // id_country
            // 
            this.id_country.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_country.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id_country.FormattingEnabled = true;
            this.id_country.Location = new System.Drawing.Point(12, 124);
            this.id_country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_country.Name = "id_country";
            this.id_country.Size = new System.Drawing.Size(229, 33);
            this.id_country.TabIndex = 30;
            this.id_country.Text = "id_страны";
            // 
            // numerTel
            // 
            this.numerTel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numerTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numerTel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numerTel.Location = new System.Drawing.Point(12, 279);
            this.numerTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerTel.Name = "numerTel";
            this.numerTel.Size = new System.Drawing.Size(229, 30);
            this.numerTel.TabIndex = 29;
            this.numerTel.Text = "Номер телефона";
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adres.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.adres.Location = new System.Drawing.Point(12, 242);
            this.adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(229, 30);
            this.adres.TabIndex = 28;
            this.adres.Text = "Адрес";
            // 
            // UpdateHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.countNumer);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.description);
            this.Controls.Add(this.id_city);
            this.Controls.Add(this.id_country);
            this.Controls.Add(this.numerTel);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.SearchHotel);
            this.Controls.Add(this.comboBox2City);
            this.Controls.Add(this.comboBox1NameHotel);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateHotel";
            this.Text = "UpdateHotel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.ComboBox comboBox1NameHotel;
        private System.Windows.Forms.ComboBox comboBox2City;
        private System.Windows.Forms.Button SearchHotel;
        private System.Windows.Forms.TextBox countNumer;
        private System.Windows.Forms.TextBox stars;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox id_city;
        private System.Windows.Forms.ComboBox id_country;
        private System.Windows.Forms.TextBox numerTel;
        private System.Windows.Forms.TextBox adres;
    }
}