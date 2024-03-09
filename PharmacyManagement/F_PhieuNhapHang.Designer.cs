namespace PharmacyManagement
{
    partial class F_PhieuNhapHang
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
            this.btn_Reload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_hsd = new System.Windows.Forms.TextBox();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.cbb_MNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_Gia1SP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_MaCH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(425, 385);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(86, 35);
            this.btn_Reload.TabIndex = 58;
            this.btn_Reload.Text = "ReLoad";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 271);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "PHIẾU NHẬP HÀNG";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(1171, 438);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 38);
            this.btn_Luu.TabIndex = 51;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(957, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Ngày nhập hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Mã cửa hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1069, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_hsd);
            this.panel2.Controls.Add(this.txt_nsx);
            this.panel2.Controls.Add(this.cbb_MNCC);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_SoLuong);
            this.panel2.Controls.Add(this.txt_Gia1SP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_MaSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(592, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 285);
            this.panel2.TabIndex = 56;
            // 
            // txt_hsd
            // 
            this.txt_hsd.Location = new System.Drawing.Point(445, 116);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.Size = new System.Drawing.Size(100, 22);
            this.txt_hsd.TabIndex = 22;
            // 
            // txt_nsx
            // 
            this.txt_nsx.Location = new System.Drawing.Point(445, 52);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(100, 22);
            this.txt_nsx.TabIndex = 21;
            // 
            // cbb_MNCC
            // 
            this.cbb_MNCC.FormattingEnabled = true;
            this.cbb_MNCC.Location = new System.Drawing.Point(170, 52);
            this.cbb_MNCC.Name = "cbb_MNCC";
            this.cbb_MNCC.Size = new System.Drawing.Size(121, 24);
            this.cbb_MNCC.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "VND";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(170, 195);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(100, 22);
            this.txt_SoLuong.TabIndex = 2;
            // 
            // txt_Gia1SP
            // 
            this.txt_Gia1SP.Location = new System.Drawing.Point(445, 195);
            this.txt_Gia1SP.Name = "txt_Gia1SP";
            this.txt_Gia1SP.Size = new System.Drawing.Size(137, 22);
            this.txt_Gia1SP.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giá một sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã sản phẩm";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(170, 119);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(100, 22);
            this.txt_MaSP.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hạn sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày sản xuất";
            // 
            // cbb_MaCH
            // 
            this.cbb_MaCH.FormattingEnabled = true;
            this.cbb_MaCH.Location = new System.Drawing.Point(690, 89);
            this.cbb_MaCH.Name = "cbb_MaCH";
            this.cbb_MaCH.Size = new System.Drawing.Size(121, 24);
            this.cbb_MaCH.TabIndex = 53;
            // 
            // F_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 500);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbb_MaCH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_PhieuNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_PhieuNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_hsd;
        private System.Windows.Forms.TextBox txt_nsx;
        private System.Windows.Forms.ComboBox cbb_MNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_Gia1SP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_MaCH;
    }
}