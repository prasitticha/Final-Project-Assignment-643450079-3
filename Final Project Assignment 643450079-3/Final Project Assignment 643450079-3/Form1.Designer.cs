namespace Final_Project_Assignment_643450079_3
{
    partial class Form1
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(465, 39);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TabStop = false;
            this.textBoxDisplay.Text = "โปรแกรม เช็คสต๊อก และ เพิ่มสินค้า";
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Login.Location = new System.Drawing.Point(242, 158);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "ล็อกอิน";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.Location = new System.Drawing.Point(323, 158);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(110, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "ออกจากโปรแกรม";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(242, 106);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(191, 20);
            this.textBox_User.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(242, 132);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(191, 20);
            this.textBox_Password.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Final_Project_Assignment_643450079_3.Properties.Resources.Login_Key;
            this.pictureBox.Location = new System.Drawing.Point(40, 90);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(99, 86);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(173, 113);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(40, 13);
            this.label_User.TabIndex = 0;
            this.label_User.Text = "ชื่อผู้ใช้";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(173, 139);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(46, 13);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "รหัสผ่าน";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(294, 80);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(40, 13);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "ล็อกอิน";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(489, 216);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Login;
    }
}

