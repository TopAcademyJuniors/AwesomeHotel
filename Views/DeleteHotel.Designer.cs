namespace HotelSelect.Views
{
    partial class DeleteHotel
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
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country,
            this.City,
            this.NameHotel,
            this.Stars,
            this.Address,
            this.PhoneNumber,
            this.CountRooms});
            this.dataGridViewHotels.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.Size = new System.Drawing.Size(776, 293);
            this.dataGridViewHotels.TabIndex = 0;
            // 
            // Country
            // 
            this.Country.HeaderText = "Страна";
            this.Country.Name = "Country";
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            // 
            // NameHotel
            // 
            this.NameHotel.HeaderText = "Название отеля";
            this.NameHotel.Name = "NameHotel";
            // 
            // Stars
            // 
            this.Stars.HeaderText = "Звёзды";
            this.Stars.Name = "Stars";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона отеля";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // CountRooms
            // 
            this.CountRooms.HeaderText = "Количество комнат";
            this.CountRooms.Name = "CountRooms";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(50, 13);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 1;
            this.comboBoxCountry.Text = "Страна";
            this.comboBoxCountry.Enter += new System.EventHandler(this.comboBoxCountry_Enter);
            this.comboBoxCountry.Leave += new System.EventHandler(this.comboBoxCountry_Leave);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxCity.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(50, 55);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 2;
            this.comboBoxCity.Text = "Город";
            this.comboBoxCity.Enter += new System.EventHandler(this.comboBoxCity_Enter);
            this.comboBoxCity.Leave += new System.EventHandler(this.comboBoxCity_Leave);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(676, 30);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 28);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удаление отеля";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.dataGridViewHotels);
            this.Name = "DeleteHotel";
            this.Text = "DeleteHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBoxCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRooms;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}