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
            this.User_name = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerchHotelButton
            // 
            this.SerchHotelButton.Location = new System.Drawing.Point(55, 352);
            this.SerchHotelButton.Name = "SerchHotelButton";
            this.SerchHotelButton.Size = new System.Drawing.Size(97, 42);
            this.SerchHotelButton.TabIndex = 0;
            this.SerchHotelButton.Text = "Поиск отелей";
            this.SerchHotelButton.UseVisualStyleBackColor = true;
            this.SerchHotelButton.Click += new System.EventHandler(this.SerchHotelButton_Click);
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.BackColor = System.Drawing.Color.Transparent;
            this.User_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_name.Location = new System.Drawing.Point(50, 49);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(79, 29);
            this.User_name.TabIndex = 1;
            this.User_name.Text = "label1";
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(48, 107);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(81, 44);
            this.Options.TabIndex = 2;
            this.Options.Text = "настройки";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelSelect.Properties.Resources._1635857120_55_na_dache_pro_p_dom_u_morya_krasivie_s_basseinom_foto_60;
            this.ClientSize = new System.Drawing.Size(806, 692);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.SerchHotelButton);
            this.Name = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerchHotelButton;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Button Options;
    }
}