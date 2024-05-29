namespace HotelSelect.Views
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            this.Message = new System.Windows.Forms.TextBox();
            this.buttonFAQ_1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.buttonFAQ_2 = new System.Windows.Forms.Button();
            this.buttonFAQ_3 = new System.Windows.Forms.Button();
            this.buttonFAQ_4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_message = new System.Windows.Forms.Button();
            this.Сhat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(57, 208);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(187, 20);
            this.Message.TabIndex = 0;
            // 
            // buttonFAQ_1
            // 
            this.buttonFAQ_1.Location = new System.Drawing.Point(488, 53);
            this.buttonFAQ_1.Name = "buttonFAQ_1";
            this.buttonFAQ_1.Size = new System.Drawing.Size(300, 23);
            this.buttonFAQ_1.TabIndex = 1;
            this.buttonFAQ_1.Text = "Как забронировать номер?";
            this.buttonFAQ_1.UseVisualStyleBackColor = true;
            this.buttonFAQ_1.Click += new System.EventHandler(this.buttonFAQ_1_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(488, 258);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(302, 128);
            this.answer.TabIndex = 2;
            // 
            // buttonFAQ_2
            // 
            this.buttonFAQ_2.Location = new System.Drawing.Point(488, 82);
            this.buttonFAQ_2.Name = "buttonFAQ_2";
            this.buttonFAQ_2.Size = new System.Drawing.Size(300, 23);
            this.buttonFAQ_2.TabIndex = 3;
            this.buttonFAQ_2.Text = "Как отменить бронирование?";
            this.buttonFAQ_2.UseVisualStyleBackColor = true;
            this.buttonFAQ_2.Click += new System.EventHandler(this.buttonFAQ_2_Click);
            // 
            // buttonFAQ_3
            // 
            this.buttonFAQ_3.Location = new System.Drawing.Point(488, 111);
            this.buttonFAQ_3.Name = "buttonFAQ_3";
            this.buttonFAQ_3.Size = new System.Drawing.Size(300, 23);
            this.buttonFAQ_3.TabIndex = 4;
            this.buttonFAQ_3.Text = "Сколько денег вернётся при отмене бронирования?";
            this.buttonFAQ_3.UseVisualStyleBackColor = true;
            this.buttonFAQ_3.Click += new System.EventHandler(this.buttonFAQ_3_Click);
            // 
            // buttonFAQ_4
            // 
            this.buttonFAQ_4.Location = new System.Drawing.Point(488, 140);
            this.buttonFAQ_4.Name = "buttonFAQ_4";
            this.buttonFAQ_4.Size = new System.Drawing.Size(300, 23);
            this.buttonFAQ_4.TabIndex = 5;
            this.buttonFAQ_4.Text = "Как передать информацию в отель? ";
            this.buttonFAQ_4.UseVisualStyleBackColor = true;
            this.buttonFAQ_4.Click += new System.EventHandler(this.buttonFAQ_4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FAQ";
            // 
            // button_message
            // 
            this.button_message.Location = new System.Drawing.Point(113, 244);
            this.button_message.Name = "button_message";
            this.button_message.Size = new System.Drawing.Size(75, 23);
            this.button_message.TabIndex = 8;
            this.button_message.Text = "Отправить";
            this.button_message.UseVisualStyleBackColor = true;
            // 
            // Сhat
            // 
            this.Сhat.Location = new System.Drawing.Point(57, 12);
            this.Сhat.Multiline = true;
            this.Сhat.Name = "Сhat";
            this.Сhat.Size = new System.Drawing.Size(187, 189);
            this.Сhat.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Сhat);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFAQ_4);
            this.Controls.Add(this.buttonFAQ_3);
            this.Controls.Add(this.buttonFAQ_2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.buttonFAQ_1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Support";
            this.Text = "Support";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button buttonFAQ_1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button buttonFAQ_2;
        private System.Windows.Forms.Button buttonFAQ_3;
        private System.Windows.Forms.Button buttonFAQ_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.TextBox Сhat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}