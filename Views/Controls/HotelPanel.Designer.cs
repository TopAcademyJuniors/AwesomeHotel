namespace HotelSelect.Views.Controls
{
    partial class HotelPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hotelName = new System.Windows.Forms.Label();
            this.hotelDescription = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.hotelCity = new System.Windows.Forms.Label();
            this.hotelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hotelName
            // 
            this.hotelName.AutoSize = true;
            this.hotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelName.Location = new System.Drawing.Point(244, 13);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(102, 24);
            this.hotelName.TabIndex = 1;
            this.hotelName.Text = "hotelName";
            // 
            // hotelDescription
            // 
            this.hotelDescription.AutoSize = true;
            this.hotelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelDescription.Location = new System.Drawing.Point(245, 46);
            this.hotelDescription.Name = "hotelDescription";
            this.hotelDescription.Size = new System.Drawing.Size(115, 18);
            this.hotelDescription.TabIndex = 2;
            this.hotelDescription.Text = "hotelDescription";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.Location = new System.Drawing.Point(248, 167);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(318, 34);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "бронировать";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // hotelCity
            // 
            this.hotelCity.AutoSize = true;
            this.hotelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelCity.Location = new System.Drawing.Point(446, 15);
            this.hotelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hotelCity.Name = "hotelCity";
            this.hotelCity.Size = new System.Drawing.Size(70, 20);
            this.hotelCity.TabIndex = 4;
            this.hotelCity.Text = "hotelCity";
            // 
            // hotelPrice
            // 
            this.hotelPrice.AutoSize = true;
            this.hotelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelPrice.Location = new System.Drawing.Point(244, 144);
            this.hotelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hotelPrice.Name = "hotelPrice";
            this.hotelPrice.Size = new System.Drawing.Size(79, 20);
            this.hotelPrice.TabIndex = 5;
            this.hotelPrice.Text = "hotelPrice";
            // 
            // HotelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotelPrice);
            this.Controls.Add(this.hotelCity);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.hotelDescription);
            this.Controls.Add(this.hotelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HotelPanel";
            this.Size = new System.Drawing.Size(587, 205);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hotelName;
        private System.Windows.Forms.Label hotelDescription;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label hotelCity;
        private System.Windows.Forms.Label hotelPrice;
    }
}
