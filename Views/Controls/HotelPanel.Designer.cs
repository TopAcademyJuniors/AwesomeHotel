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
            this.hotelName.Size = new System.Drawing.Size(60, 24);
            this.hotelName.TabIndex = 1;
            this.hotelName.Text = "label1";
            // 
            // hotelDescription
            // 
            this.hotelDescription.AutoSize = true;
            this.hotelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelDescription.Location = new System.Drawing.Point(245, 46);
            this.hotelDescription.Name = "hotelDescription";
            this.hotelDescription.Size = new System.Drawing.Size(46, 18);
            this.hotelDescription.TabIndex = 2;
            this.hotelDescription.Text = "label2";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(248, 167);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(318, 23);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "button1";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // HotelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
