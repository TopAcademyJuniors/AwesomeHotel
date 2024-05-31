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
            this.SupportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerchHotelButton
            // 
            this.SerchHotelButton.Location = new System.Drawing.Point(12, 12);
            this.SerchHotelButton.Name = "SerchHotelButton";
            this.SerchHotelButton.Size = new System.Drawing.Size(97, 42);
            this.SerchHotelButton.TabIndex = 0;
            this.SerchHotelButton.Text = "Поиск отелей";
            this.SerchHotelButton.UseVisualStyleBackColor = true;
            this.SerchHotelButton.Click += new System.EventHandler(this.SerchHotelButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(685, 395);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(103, 43);
            this.SupportButton.TabIndex = 1;
            this.SupportButton.Text = "Помогите мне!";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.SerchHotelButton);
            this.Name = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SerchHotelButton;
        private System.Windows.Forms.Button SupportButton;
    }
}