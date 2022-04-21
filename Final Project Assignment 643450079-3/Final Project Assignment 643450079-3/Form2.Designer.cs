namespace Final_Project_Assignment_643450079_3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_ProductCode = new System.Windows.Forms.TextBox();
            this.textBox_ListProduct = new System.Windows.Forms.TextBox();
            this.textBox_INputProduct = new System.Windows.Forms.TextBox();
            this.textBox_OUTputProduct = new System.Windows.Forms.TextBox();
            this.label_ProductCode = new System.Windows.Forms.Label();
            this.label_ListProduct = new System.Windows.Forms.Label();
            this.label_INputProduct = new System.Windows.Forms.Label();
            this.label_OUTputProduct = new System.Windows.Forms.Label();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Import
            // 
            this.button_Import.BackColor = System.Drawing.Color.Thistle;
            this.button_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Import.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Import.Location = new System.Drawing.Point(137, 196);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(75, 23);
            this.button_Import.TabIndex = 5;
            this.button_Import.Text = "รับเข้า";
            this.button_Import.UseVisualStyleBackColor = false;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Thistle;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(218, 196);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "แก้ไข";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Thistle;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(178, 229);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "ลบ";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.fileToolStripMenuItem.Text = "ไฟล์";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.OpenToolStripMenuItem.Text = "เปิด";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.SaveToolStripMenuItem.Text = "บันทึก";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.LogoutToolStripMenuItem.Text = "ล็อกเอ้าท์";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.ExitToolStripMenuItem.Text = "ออกจากโปรแกรม";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // textBox_ProductCode
            // 
            this.textBox_ProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProductCode.Location = new System.Drawing.Point(137, 84);
            this.textBox_ProductCode.Name = "textBox_ProductCode";
            this.textBox_ProductCode.Size = new System.Drawing.Size(156, 22);
            this.textBox_ProductCode.TabIndex = 1;
            // 
            // textBox_ListProduct
            // 
            this.textBox_ListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ListProduct.Location = new System.Drawing.Point(137, 112);
            this.textBox_ListProduct.Name = "textBox_ListProduct";
            this.textBox_ListProduct.Size = new System.Drawing.Size(156, 22);
            this.textBox_ListProduct.TabIndex = 2;
            // 
            // textBox_INputProduct
            // 
            this.textBox_INputProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_INputProduct.Location = new System.Drawing.Point(137, 140);
            this.textBox_INputProduct.Name = "textBox_INputProduct";
            this.textBox_INputProduct.Size = new System.Drawing.Size(156, 22);
            this.textBox_INputProduct.TabIndex = 3;
            // 
            // textBox_OUTputProduct
            // 
            this.textBox_OUTputProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OUTputProduct.Location = new System.Drawing.Point(137, 168);
            this.textBox_OUTputProduct.Name = "textBox_OUTputProduct";
            this.textBox_OUTputProduct.Size = new System.Drawing.Size(156, 22);
            this.textBox_OUTputProduct.TabIndex = 4;
            // 
            // label_ProductCode
            // 
            this.label_ProductCode.AutoSize = true;
            this.label_ProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProductCode.ForeColor = System.Drawing.Color.White;
            this.label_ProductCode.Location = new System.Drawing.Point(37, 90);
            this.label_ProductCode.Name = "label_ProductCode";
            this.label_ProductCode.Size = new System.Drawing.Size(54, 16);
            this.label_ProductCode.TabIndex = 0;
            this.label_ProductCode.Text = "รหัสสินค้า";
            // 
            // label_ListProduct
            // 
            this.label_ListProduct.AutoSize = true;
            this.label_ListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListProduct.ForeColor = System.Drawing.Color.White;
            this.label_ListProduct.Location = new System.Drawing.Point(37, 118);
            this.label_ListProduct.Name = "label_ListProduct";
            this.label_ListProduct.Size = new System.Drawing.Size(67, 16);
            this.label_ListProduct.TabIndex = 0;
            this.label_ListProduct.Text = "รายการสินค้า";
            // 
            // label_INputProduct
            // 
            this.label_INputProduct.AutoSize = true;
            this.label_INputProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_INputProduct.ForeColor = System.Drawing.Color.White;
            this.label_INputProduct.Location = new System.Drawing.Point(37, 146);
            this.label_INputProduct.Name = "label_INputProduct";
            this.label_INputProduct.Size = new System.Drawing.Size(61, 16);
            this.label_INputProduct.TabIndex = 0;
            this.label_INputProduct.Text = "รับสินค้าเข้า";
            // 
            // label_OUTputProduct
            // 
            this.label_OUTputProduct.AutoSize = true;
            this.label_OUTputProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OUTputProduct.ForeColor = System.Drawing.Color.White;
            this.label_OUTputProduct.Location = new System.Drawing.Point(37, 174);
            this.label_OUTputProduct.Name = "label_OUTputProduct";
            this.label_OUTputProduct.Size = new System.Drawing.Size(64, 16);
            this.label_OUTputProduct.TabIndex = 0;
            this.label_OUTputProduct.Text = "ส่งสินค้าออก";
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateTime.ForeColor = System.Drawing.Color.White;
            this.label_DateTime.Location = new System.Drawing.Point(681, 46);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(183, 20);
            this.label_DateTime.TabIndex = 0;
            this.label_DateTime.Text = "dd/MM/yyyy     HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(321, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รหัสสินค้า";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "สินค้าคงเหลือ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "รายการสินค้า";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "รับเข้าสินค้า";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ส่งออกสินค้า";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(905, 285);
            this.Controls.Add(this.textBox_ProductCode);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_ListProduct);
            this.Controls.Add(this.textBox_INputProduct);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.label_OUTputProduct);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_OUTputProduct);
            this.Controls.Add(this.label_INputProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_ProductCode);
            this.Controls.Add(this.label_ListProduct);
            this.Controls.Add(this.label_DateTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_ProductCode;
        private System.Windows.Forms.TextBox textBox_ListProduct;
        private System.Windows.Forms.TextBox textBox_INputProduct;
        private System.Windows.Forms.TextBox textBox_OUTputProduct;
        private System.Windows.Forms.Label label_ProductCode;
        private System.Windows.Forms.Label label_ListProduct;
        private System.Windows.Forms.Label label_INputProduct;
        private System.Windows.Forms.Label label_OUTputProduct;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}