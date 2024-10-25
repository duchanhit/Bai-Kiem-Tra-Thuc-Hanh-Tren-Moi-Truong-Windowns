namespace GUI
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
            this.label8 = new System.Windows.Forms.Label();
            this.dsCtyDaTestTheoYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsNVDuongTinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCongTy = new System.Windows.Forms.ComboBox();
            this.rBtnDuongTinh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnAmTinh = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtCMNDCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(331, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 38);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thông Tin Xét Nghiệm";
            // 
            // dsCtyDaTestTheoYCToolStripMenuItem
            // 
            this.dsCtyDaTestTheoYCToolStripMenuItem.Name = "dsCtyDaTestTheoYCToolStripMenuItem";
            this.dsCtyDaTestTheoYCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.dsCtyDaTestTheoYCToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.dsCtyDaTestTheoYCToolStripMenuItem.Text = "Danh Sách Cty Đã Test Theo Y/C";
            // 
            // dsNVDuongTinhToolStripMenuItem
            // 
            this.dsNVDuongTinhToolStripMenuItem.Name = "dsNVDuongTinhToolStripMenuItem";
            this.dsNVDuongTinhToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.dsNVDuongTinhToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.dsNVDuongTinhToolStripMenuItem.Text = "Danh Sách NV Dương Tính";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsNVDuongTinhToolStripMenuItem,
            this.dsCtyDaTestTheoYCToolStripMenuItem,
            this.xuatBaoCaoToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            this.xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            this.xuatBaoCaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuatBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.xuatBaoCaoToolStripMenuItem.Text = "Xuất Báo Cáo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(61, 216);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(97, 23);
            this.btnCapNhap.TabIndex = 6;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông tin xét nghiệm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Công Ty";
            // 
            // cbbCongTy
            // 
            this.cbbCongTy.FormattingEnabled = true;
            this.cbbCongTy.Location = new System.Drawing.Point(67, 170);
            this.cbbCongTy.Name = "cbbCongTy";
            this.cbbCongTy.Size = new System.Drawing.Size(265, 24);
            this.cbbCongTy.TabIndex = 10;
            // 
            // rBtnDuongTinh
            // 
            this.rBtnDuongTinh.AutoSize = true;
            this.rBtnDuongTinh.Location = new System.Drawing.Point(61, 131);
            this.rBtnDuongTinh.Name = "rBtnDuongTinh";
            this.rBtnDuongTinh.Size = new System.Drawing.Size(97, 20);
            this.rBtnDuongTinh.TabIndex = 9;
            this.rBtnDuongTinh.TabStop = true;
            this.rBtnDuongTinh.Text = "Dương Tính";
            this.rBtnDuongTinh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // rBtnAmTinh
            // 
            this.rBtnAmTinh.AutoSize = true;
            this.rBtnAmTinh.Location = new System.Drawing.Point(61, 105);
            this.rBtnAmTinh.Name = "rBtnAmTinh";
            this.rBtnAmTinh.Size = new System.Drawing.Size(77, 20);
            this.rBtnAmTinh.TabIndex = 8;
            this.rBtnAmTinh.TabStop = true;
            this.rBtnAmTinh.Text = "Âm Tính";
            this.rBtnAmTinh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "KQ";
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(67, 58);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(265, 22);
            this.txtSLXN.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "SLXN";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(67, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(265, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ Tên";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(254, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtCMNDCCCD
            // 
            this.txtCMNDCCCD.Location = new System.Drawing.Point(97, 13);
            this.txtCMNDCCCD.Name = "txtCMNDCCCD";
            this.txtCMNDCCCD.Size = new System.Drawing.Size(151, 22);
            this.txtCMNDCCCD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CMND/CCCD";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbCongTy);
            this.panel1.Controls.Add(this.rBtnDuongTinh);
            this.panel1.Controls.Add(this.rBtnAmTinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSLXN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 292);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtCMNDCCCD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 47);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 345);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 466);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem dsCtyDaTestTheoYCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsNVDuongTinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCongTy;
        private System.Windows.Forms.RadioButton rBtnDuongTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnAmTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtCMNDCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

