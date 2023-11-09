namespace PharmacyManagement
{
    partial class F_QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QLNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.ptb_NhanVien = new System.Windows.Forms.PictureBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdio_Nu = new System.Windows.Forms.RadioButton();
            this.rdio_Nam = new System.Windows.Forms.RadioButton();
            this.cb_MaCV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_MaCuaHang = new System.Windows.Forms.ComboBox();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_NhanVien = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.btn_ChonAnh);
            this.panel1.Controls.Add(this.ptb_NhanVien);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 315);
            this.panel1.TabIndex = 0;
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonAnh.Location = new System.Drawing.Point(95, 251);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(105, 47);
            this.btn_ChonAnh.TabIndex = 6;
            this.btn_ChonAnh.Text = "Chọn ảnh";
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // ptb_NhanVien
            // 
            this.ptb_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptb_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("ptb_NhanVien.Image")));
            this.ptb_NhanVien.Location = new System.Drawing.Point(67, 46);
            this.ptb_NhanVien.Name = "ptb_NhanVien";
            this.ptb_NhanVien.Size = new System.Drawing.Size(163, 184);
            this.ptb_NhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_NhanVien.TabIndex = 5;
            this.ptb_NhanVien.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1168, 261);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 51);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(990, 261);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 51);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(819, 261);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 51);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdio_Nu);
            this.panel3.Controls.Add(this.rdio_Nam);
            this.panel3.Controls.Add(this.cb_MaCV);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbo_MaCuaHang);
            this.panel3.Controls.Add(this.dt_NgaySinh);
            this.panel3.Controls.Add(this.txt_TenNV);
            this.panel3.Controls.Add(this.txt_SDT);
            this.panel3.Controls.Add(this.txt_Diachi);
            this.panel3.Controls.Add(this.txt_MaNV);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(305, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1085, 229);
            this.panel3.TabIndex = 1;
            // 
            // rdio_Nu
            // 
            this.rdio_Nu.AutoSize = true;
            this.rdio_Nu.Location = new System.Drawing.Point(785, 74);
            this.rdio_Nu.Name = "rdio_Nu";
            this.rdio_Nu.Size = new System.Drawing.Size(57, 29);
            this.rdio_Nu.TabIndex = 18;
            this.rdio_Nu.TabStop = true;
            this.rdio_Nu.Text = "Nữ";
            this.rdio_Nu.UseVisualStyleBackColor = true;
            // 
            // rdio_Nam
            // 
            this.rdio_Nam.AutoSize = true;
            this.rdio_Nam.Location = new System.Drawing.Point(685, 74);
            this.rdio_Nam.Name = "rdio_Nam";
            this.rdio_Nam.Size = new System.Drawing.Size(71, 29);
            this.rdio_Nam.TabIndex = 17;
            this.rdio_Nam.TabStop = true;
            this.rdio_Nam.Text = "Nam";
            this.rdio_Nam.UseVisualStyleBackColor = true;
            // 
            // cb_MaCV
            // 
            this.cb_MaCV.FormattingEnabled = true;
            this.cb_MaCV.Location = new System.Drawing.Point(181, 68);
            this.cb_MaCV.Name = "cb_MaCV";
            this.cb_MaCV.Size = new System.Drawing.Size(249, 33);
            this.cb_MaCV.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã cửa hàng";
            // 
            // cbo_MaCuaHang
            // 
            this.cbo_MaCuaHang.FormattingEnabled = true;
            this.cbo_MaCuaHang.Location = new System.Drawing.Point(685, 182);
            this.cbo_MaCuaHang.Name = "cbo_MaCuaHang";
            this.cbo_MaCuaHang.Size = new System.Drawing.Size(291, 33);
            this.cbo_MaCuaHang.TabIndex = 14;
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(685, 126);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(291, 31);
            this.dt_NgaySinh.TabIndex = 13;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(685, 20);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(291, 31);
            this.txt_TenNV.TabIndex = 11;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(181, 125);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(249, 31);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(181, 176);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(249, 31);
            this.txt_Diachi.TabIndex = 8;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(181, 14);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(249, 31);
            this.txt_MaNV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_NhanVien);
            this.panel2.Location = new System.Drawing.Point(12, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1416, 410);
            this.panel2.TabIndex = 1;
            // 
            // dg_NhanVien
            // 
            this.dg_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNV,
            this.col_TenNV,
            this.col_NgaySinh,
            this.col_SDT,
            this.col_GioiTinh,
            this.col_DiaChi,
            this.col_ChucVu,
            this.col_CuaHang,
            this.col_Image});
            this.dg_NhanVien.Location = new System.Drawing.Point(6, 8);
            this.dg_NhanVien.Name = "dg_NhanVien";
            this.dg_NhanVien.RowHeadersWidth = 51;
            this.dg_NhanVien.RowTemplate.Height = 24;
            this.dg_NhanVien.Size = new System.Drawing.Size(1399, 387);
            this.dg_NhanVien.TabIndex = 0;
            this.dg_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_NhanVien_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(647, 261);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(103, 51);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // col_MaNV
            // 
            this.col_MaNV.DataPropertyName = "MaNhanVien";
            this.col_MaNV.HeaderText = "Mã Nhân Viên";
            this.col_MaNV.MinimumWidth = 6;
            this.col_MaNV.Name = "col_MaNV";
            // 
            // col_TenNV
            // 
            this.col_TenNV.DataPropertyName = "TenNhanVien";
            this.col_TenNV.HeaderText = "Tên Nhân Viên";
            this.col_TenNV.MinimumWidth = 6;
            this.col_TenNV.Name = "col_TenNV";
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày Sinh";
            this.col_NgaySinh.MinimumWidth = 6;
            this.col_NgaySinh.Name = "col_NgaySinh";
            // 
            // col_SDT
            // 
            this.col_SDT.DataPropertyName = "SDT";
            this.col_SDT.HeaderText = "SDT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới Tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa Chỉ";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_ChucVu
            // 
            this.col_ChucVu.DataPropertyName = "TenChucVu";
            this.col_ChucVu.HeaderText = "Chức Vụ";
            this.col_ChucVu.MinimumWidth = 6;
            this.col_ChucVu.Name = "col_ChucVu";
            // 
            // col_CuaHang
            // 
            this.col_CuaHang.DataPropertyName = "MaCuaHang";
            this.col_CuaHang.HeaderText = "Cửa Hàng";
            this.col_CuaHang.MinimumWidth = 6;
            this.col_CuaHang.Name = "col_CuaHang";
            // 
            // col_Image
            // 
            this.col_Image.DataPropertyName = "Image";
            this.col_Image.HeaderText = "Image";
            this.col_Image.MinimumWidth = 6;
            this.col_Image.Name = "col_Image";
            this.col_Image.Visible = false;
            // 
            // F_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_QLNhanVien";
            this.Text = "F_QLNhanVien";
            this.Load += new System.EventHandler(this.F_QLNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_NhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_MaCuaHang;
        private System.Windows.Forms.ComboBox cb_MaCV;
        private System.Windows.Forms.RadioButton rdio_Nu;
        private System.Windows.Forms.RadioButton rdio_Nam;
        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.PictureBox ptb_NhanVien;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Image;
    }
}