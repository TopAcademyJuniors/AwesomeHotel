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
            this.answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_message = new System.Windows.Forms.Button();
            this.Сhat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question_comboBox = new System.Windows.Forms.ComboBox();
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
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(485, 171);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(300, 128);
            this.answer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 62);
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
            // Question_comboBox
            // 
            this.Question_comboBox.FormattingEnabled = true;
            this.Question_comboBox.Location = new System.Drawing.Point(485, 90);
            this.Question_comboBox.Name = "Question_comboBox";
            this.Question_comboBox.Size = new System.Drawing.Size(300, 21);
            this.Question_comboBox.TabIndex = 12;
            this.Question_comboBox.SelectedIndexChanged += new System.EventHandler(this.Question_comboBox_SelectedIndexChanged);
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Question_comboBox);
            this.Controls.Add(this.Сhat);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
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
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.TextBox Сhat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Question_comboBox;
    }
}