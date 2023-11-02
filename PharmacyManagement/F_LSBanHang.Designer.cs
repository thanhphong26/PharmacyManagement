namespace PharmacyManagement
{
    partial class F_LSBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_BanHang = new System.Windows.Forms.DataGridView();
            this.col_MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Bán Hàng Của Cửa Hàng";
            // 
            // dg_BanHang
            // 
            this.dg_BanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_BanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_BanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_BanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaCH,
            this.col_MaHD,
            this.col_TenNV,
            this.col_TenKH,
            this.col_NgayBan,
            this.col_TongTien});
            this.dg_BanHang.Location = new System.Drawing.Point(12, 119);
            this.dg_BanHang.Name = "dg_BanHang";
            this.dg_BanHang.RowHeadersWidth = 51;
            this.dg_BanHang.RowTemplate.Height = 24;
            this.dg_BanHang.Size = new System.Drawing.Size(906, 645);
            this.dg_BanHang.TabIndex = 1;
            // 
            // col_MaCH
            // 
            this.col_MaCH.DataPropertyName = "MaCuaHang";
            this.col_MaCH.HeaderText = "Mã Cửa Hàng";
            this.col_MaCH.MinimumWidth = 6;
            this.col_MaCH.Name = "col_MaCH";
            // 
            // col_MaHD
            // 
            this.col_MaHD.DataPropertyName = "MaHD";
            this.col_MaHD.HeaderText = "Mã Hóa Đơn";
            this.col_MaHD.MinimumWidth = 6;
            this.col_MaHD.Name = "col_MaHD";
            // 
            // col_TenNV
            // 
            this.col_TenNV.DataPropertyName = "TenNhanVien";
            this.col_TenNV.HeaderText = "Nhân Viên";
            this.col_TenNV.MinimumWidth = 6;
            this.col_TenNV.Name = "col_TenNV";
            // 
            // col_TenKH
            // 
            this.col_TenKH.DataPropertyName = "TenKhachHang";
            this.col_TenKH.HeaderText = "Khách Hàng";
            this.col_TenKH.MinimumWidth = 6;
            this.col_TenKH.Name = "col_TenKH";
            // 
            // col_NgayBan
            // 
            this.col_NgayBan.DataPropertyName = "NgayBan";
            this.col_NgayBan.HeaderText = "Ngày Bán";
            this.col_NgayBan.MinimumWidth = 6;
            this.col_NgayBan.Name = "col_NgayBan";
            // 
            // col_TongTien
            // 
            this.col_TongTien.DataPropertyName = "TongTien";
            this.col_TongTien.HeaderText = "Tổng Giá Trị Hóa Đơn";
            this.col_TongTien.MinimumWidth = 6;
            this.col_TongTien.Name = "col_TongTien";
            // 
            // F_LSBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(930, 776);
            this.Controls.Add(this.dg_BanHang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_LSBanHang";
            this.Text = "F_LSBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dg_BanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_BanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TongTien;
    }
}