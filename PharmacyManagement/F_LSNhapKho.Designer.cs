namespace PharmacyManagement
{
    partial class F_LSNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_NhapHang = new System.Windows.Forms.DataGridView();
            this.col_MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_NhapHang
            // 
            this.dg_NhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaCH,
            this.col_MaLo,
            this.col_TenSp,
            this.col_TenNCC,
            this.col_SL,
            this.col_NgayNhap,
            this.col_NSX,
            this.col_HSD,
            this.col_GiaSP,
            this.col_TongGia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_NhapHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_NhapHang.Location = new System.Drawing.Point(12, 119);
            this.dg_NhapHang.Name = "dg_NhapHang";
            this.dg_NhapHang.RowHeadersWidth = 51;
            this.dg_NhapHang.RowTemplate.Height = 24;
            this.dg_NhapHang.Size = new System.Drawing.Size(906, 645);
            this.dg_NhapHang.TabIndex = 0;
            // 
            // col_MaCH
            // 
            this.col_MaCH.DataPropertyName = "MaCuaHang";
            this.col_MaCH.HeaderText = "Mã Cửa Hàng";
            this.col_MaCH.MinimumWidth = 6;
            this.col_MaCH.Name = "col_MaCH";
            this.col_MaCH.Width = 86;
            // 
            // col_MaLo
            // 
            this.col_MaLo.DataPropertyName = "MaLO";
            this.col_MaLo.HeaderText = "Mã Lô";
            this.col_MaLo.MinimumWidth = 6;
            this.col_MaLo.Name = "col_MaLo";
            this.col_MaLo.Width = 85;
            // 
            // col_TenSp
            // 
            this.col_TenSp.DataPropertyName = "TenSP";
            this.col_TenSp.HeaderText = "Tên Sản Phẩm";
            this.col_TenSp.MinimumWidth = 6;
            this.col_TenSp.Name = "col_TenSp";
            this.col_TenSp.Width = 86;
            // 
            // col_TenNCC
            // 
            this.col_TenNCC.DataPropertyName = "TenNCC";
            this.col_TenNCC.HeaderText = "Nhà Cung Cấp";
            this.col_TenNCC.MinimumWidth = 6;
            this.col_TenNCC.Name = "col_TenNCC";
            this.col_TenNCC.Width = 85;
            // 
            // col_SL
            // 
            this.col_SL.DataPropertyName = "SL_Nhap";
            this.col_SL.HeaderText = "Số Lượng Nhập";
            this.col_SL.MinimumWidth = 6;
            this.col_SL.Name = "col_SL";
            this.col_SL.Width = 86;
            // 
            // col_NgayNhap
            // 
            this.col_NgayNhap.DataPropertyName = "NgayNhap";
            this.col_NgayNhap.HeaderText = "Ngày Nhập";
            this.col_NgayNhap.MinimumWidth = 6;
            this.col_NgayNhap.Name = "col_NgayNhap";
            this.col_NgayNhap.Width = 85;
            // 
            // col_NSX
            // 
            this.col_NSX.DataPropertyName = "NSX";
            this.col_NSX.HeaderText = "Ngày Sản Xuất";
            this.col_NSX.MinimumWidth = 6;
            this.col_NSX.Name = "col_NSX";
            this.col_NSX.Width = 86;
            // 
            // col_HSD
            // 
            this.col_HSD.DataPropertyName = "HSD";
            this.col_HSD.HeaderText = "Ngày Hết Hạn";
            this.col_HSD.MinimumWidth = 6;
            this.col_HSD.Name = "col_HSD";
            this.col_HSD.Width = 85;
            // 
            // col_GiaSP
            // 
            this.col_GiaSP.DataPropertyName = "GiaMotSP";
            this.col_GiaSP.HeaderText = "Giá Sản Phẩm";
            this.col_GiaSP.MinimumWidth = 6;
            this.col_GiaSP.Name = "col_GiaSP";
            this.col_GiaSP.Width = 86;
            // 
            // col_TongGia
            // 
            this.col_TongGia.DataPropertyName = "Gia";
            this.col_TongGia.HeaderText = "Tổng Giá";
            this.col_TongGia.MinimumWidth = 6;
            this.col_TongGia.Name = "col_TongGia";
            this.col_TongGia.Width = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch Sử Nhập Hàng Của Cửa Hàng";
            // 
            // F_LSNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(930, 776);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_NhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_LSNhapKho";
            this.Text = "F_LSNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_NhapHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TongGia;
    }
}