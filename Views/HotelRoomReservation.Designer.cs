namespace HotelSelect
{
    partial class HotelRoomReservation
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
            this.labelDataBefore = new System.Windows.Forms.Label();
            this.labelDataFrom = new System.Windows.Forms.Label();
            this.dateTimeBefore = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearh = new System.Windows.Forms.Button();
            this.labelPriceBofore = new System.Windows.Forms.Label();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxPriceBefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericRoom = new System.Windows.Forms.NumericUpDown();
            this.ComBoxNameHotel = new System.Windows.Forms.ComboBox();
            this.ComBoxCity = new System.Windows.Forms.ComboBox();
            this.ComBoxCountry = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelSelect.Properties.Resources.RezHotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // labelDataBefore
            // 
            this.labelDataBefore.AutoSize = true;
            this.labelDataBefore.Location = new System.Drawing.Point(9, 222);
            this.labelDataBefore.Name = "labelDataBefore";
            this.labelDataBefore.Size = new System.Drawing.Size(48, 13);
            this.labelDataBefore.TabIndex = 37;
            this.labelDataBefore.Text = "Дата до";
            // 
            // labelDataFrom
            // 
            this.labelDataFrom.AutoSize = true;
            this.labelDataFrom.Location = new System.Drawing.Point(10, 180);
            this.labelDataFrom.Name = "labelDataFrom";
            this.labelDataFrom.Size = new System.Drawing.Size(47, 13);
            this.labelDataFrom.TabIndex = 36;
            this.labelDataFrom.Text = "Дата от";
            // 
            // dateTimeBefore
            // 
            this.dateTimeBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBefore.Location = new System.Drawing.Point(58, 222);
            this.dateTimeBefore.Name = "dateTimeBefore";
            this.dateTimeBefore.Size = new System.Drawing.Size(126, 23);
            this.dateTimeBefore.TabIndex = 35;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeFrom.Location = new System.Drawing.Point(58, 180);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(126, 23);
            this.dateTimeFrom.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "Бронировать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSearh
            // 
            this.buttonSearh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearh.Location = new System.Drawing.Point(11, 340);
            this.buttonSearh.Name = "buttonSearh";
            this.buttonSearh.Size = new System.Drawing.Size(171, 40);
            this.buttonSearh.TabIndex = 32;
            this.buttonSearh.Text = "Поиск номеров";
            this.buttonSearh.UseVisualStyleBackColor = false;
            // 
            // labelPriceBofore
            // 
            this.labelPriceBofore.AutoSize = true;
            this.labelPriceBofore.Location = new System.Drawing.Point(266, 297);
            this.labelPriceBofore.Name = "labelPriceBofore";
            this.labelPriceBofore.Size = new System.Drawing.Size(48, 13);
            this.labelPriceBofore.TabIndex = 31;
            this.labelPriceBofore.Text = "Цена до";
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceFrom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPriceFrom.Location = new System.Drawing.Point(11, 259);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(172, 26);
            this.textBoxPriceFrom.TabIndex = 29;
            this.textBoxPriceFrom.Text = "Цена от";
            this.textBoxPriceFrom.Enter += new System.EventHandler(this.textBoxPriceFrom_Enter);
            this.textBoxPriceFrom.Leave += new System.EventHandler(this.textBoxPriceFrom_Leave);
            // 
            // textBoxPriceBefore
            // 
            this.textBoxPriceBefore.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPriceBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceBefore.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPriceBefore.Location = new System.Drawing.Point(11, 299);
            this.textBoxPriceBefore.Name = "textBoxPriceBefore";
            this.textBoxPriceBefore.Size = new System.Drawing.Size(172, 26);
            this.textBoxPriceBefore.TabIndex = 28;
            this.textBoxPriceBefore.Text = "Цена до";
            this.textBoxPriceBefore.Enter += new System.EventHandler(this.textBoxPriceBefore_Enter);
            this.textBoxPriceBefore.Leave += new System.EventHandler(this.textBoxPriceBefore_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Количество комнат";
            // 
            // numericRoom
            // 
            this.numericRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericRoom.Location = new System.Drawing.Point(12, 141);
            this.numericRoom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRoom.Name = "numericRoom";
            this.numericRoom.Size = new System.Drawing.Size(170, 26);
            this.numericRoom.TabIndex = 26;
            this.numericRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComBoxNameHotel
            // 
            this.ComBoxNameHotel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ComBoxNameHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxNameHotel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ComBoxNameHotel.FormattingEnabled = true;
            this.ComBoxNameHotel.Location = new System.Drawing.Point(12, 90);
            this.ComBoxNameHotel.Name = "ComBoxNameHotel";
            this.ComBoxNameHotel.Size = new System.Drawing.Size(171, 28);
            this.ComBoxNameHotel.TabIndex = 24;
            this.ComBoxNameHotel.Text = "Название отеля";
            this.ComBoxNameHotel.Enter += new System.EventHandler(this.ComBoxNameHotel_Enter);
            this.ComBoxNameHotel.Leave += new System.EventHandler(this.ComBoxNameHotel_Leave);
            // 
            // ComBoxCity
            // 
            this.ComBoxCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ComBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxCity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ComBoxCity.FormattingEnabled = true;
            this.ComBoxCity.Location = new System.Drawing.Point(11, 57);
            this.ComBoxCity.Name = "ComBoxCity";
            this.ComBoxCity.Size = new System.Drawing.Size(172, 28);
            this.ComBoxCity.TabIndex = 22;
            this.ComBoxCity.TabStop = false;
            this.ComBoxCity.Text = "Город";
            this.ComBoxCity.Enter += new System.EventHandler(this.ComBoxCity_Enter);
            this.ComBoxCity.Leave += new System.EventHandler(this.ComBoxCity_Leave);
            // 
            // ComBoxCountry
            // 
            this.ComBoxCountry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ComBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxCountry.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ComBoxCountry.FormattingEnabled = true;
            this.ComBoxCountry.Location = new System.Drawing.Point(11, 22);
            this.ComBoxCountry.Name = "ComBoxCountry";
            this.ComBoxCountry.Size = new System.Drawing.Size(172, 28);
            this.ComBoxCountry.TabIndex = 20;
            this.ComBoxCountry.Text = "Страна";
            this.ComBoxCountry.Enter += new System.EventHandler(this.ComBoxCountry_Enter);
            this.ComBoxCountry.Leave += new System.EventHandler(this.ComBoxCountry_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(575, 419);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // HotelRoomReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelDataBefore);
            this.Controls.Add(this.labelDataFrom);
            this.Controls.Add(this.dateTimeBefore);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSearh);
            this.Controls.Add(this.labelPriceBofore);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.textBoxPriceBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRoom);
            this.Controls.Add(this.ComBoxNameHotel);
            this.Controls.Add(this.ComBoxCity);
            this.Controls.Add(this.ComBoxCountry);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HotelRoomReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирование номера";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDataBefore;
        private System.Windows.Forms.Label labelDataFrom;
        private System.Windows.Forms.DateTimePicker dateTimeBefore;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearh;
        private System.Windows.Forms.Label labelPriceBofore;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericRoom;
        private System.Windows.Forms.ComboBox ComBoxNameHotel;
        private System.Windows.Forms.ComboBox ComBoxCity;
        private System.Windows.Forms.ComboBox ComBoxCountry;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}