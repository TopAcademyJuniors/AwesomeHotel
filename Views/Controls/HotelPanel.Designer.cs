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
            this.hotelSity = new System.Windows.Forms.Label();
            this.hotelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hotelName
            // 
            this.hotelName.AutoSize = true;
            this.hotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelName.Location = new System.Drawing.Point(325, 16);
            this.hotelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(79, 29);
            this.hotelName.TabIndex = 1;
            this.hotelName.Text = "label1";
            // 
            // hotelDescription
            // 
            this.hotelDescription.AutoSize = true;
            this.hotelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelDescription.Location = new System.Drawing.Point(327, 57);
            this.hotelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotelDescription.Name = "hotelDescription";
            this.hotelDescription.Size = new System.Drawing.Size(60, 24);
            this.hotelDescription.TabIndex = 2;
            this.hotelDescription.Text = "label2";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.Location = new System.Drawing.Point(331, 206);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(424, 42);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "бронировать";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // hotelSity
            // 
            this.hotelSity.AutoSize = true;
            this.hotelSity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelSity.Location = new System.Drawing.Point(595, 19);
            this.hotelSity.Name = "hotelSity";
            this.hotelSity.Size = new System.Drawing.Size(64, 25);
            this.hotelSity.TabIndex = 4;
            this.hotelSity.Text = "label1";
            // 
            // hotelPrice
            // 
            this.hotelPrice.AutoSize = true;
            this.hotelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelPrice.Location = new System.Drawing.Point(326, 177);
            this.hotelPrice.Name = "hotelPrice";
            this.hotelPrice.Size = new System.Drawing.Size(64, 25);
            this.hotelPrice.TabIndex = 5;
            this.hotelPrice.Text = "label2";
            // 
            // HotelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotelPrice);
            this.Controls.Add(this.hotelSity);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.hotelDescription);
            this.Controls.Add(this.hotelName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HotelPanel";
            this.Size = new System.Drawing.Size(783, 252);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hotelName;
        private System.Windows.Forms.Label hotelDescription;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label hotelSity;
        private System.Windows.Forms.Label hotelPrice;
    }
}
