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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
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
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ChonAnh);
            this.panel1.Controls.Add(this.ptb_NhanVien);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(2840, 688);
            this.panel1.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Location = new System.Drawing.Point(362, 547);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(272, 99);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonAnh.Location = new System.Drawing.Point(189, 537);
            this.btn_ChonAnh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(273, 99);
            this.btn_ChonAnh.TabIndex = 6;
            this.btn_ChonAnh.Text = "Chọn ảnh";
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // ptb_NhanVien
            // 
            this.ptb_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptb_NhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptb_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("ptb_NhanVien.Image")));
            this.ptb_NhanVien.Location = new System.Drawing.Point(5, 5);
            this.ptb_NhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ptb_NhanVien.Name = "ptb_NhanVien";
            this.ptb_NhanVien.Size = new System.Drawing.Size(645, 678);
            this.ptb_NhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_NhanVien.TabIndex = 5;
            this.ptb_NhanVien.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(1708, 547);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(240, 99);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(1370, 547);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(238, 99);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(137)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.Location = new System.Drawing.Point(1015, 547);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(270, 99);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Reset);
            this.panel3.Controls.Add(this.rdio_Nu);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.rdio_Nam);
            this.panel3.Controls.Add(this.btn_Sua);
            this.panel3.Controls.Add(this.cb_MaCV);
            this.panel3.Controls.Add(this.btn_Them);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(662, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2173, 678);
            this.panel3.TabIndex = 1;
            // 
            // rdio_Nu
            // 
            this.rdio_Nu.AutoSize = true;
            this.rdio_Nu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_Nu.Location = new System.Drawing.Point(1579, 168);
            this.rdio_Nu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdio_Nu.Name = "rdio_Nu";
            this.rdio_Nu.Size = new System.Drawing.Size(116, 58);
            this.rdio_Nu.TabIndex = 18;
            this.rdio_Nu.TabStop = true;
            this.rdio_Nu.Text = "Nữ";
            this.rdio_Nu.UseVisualStyleBackColor = true;
            // 
            // rdio_Nam
            // 
            this.rdio_Nam.AutoSize = true;
            this.rdio_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_Nam.Location = new System.Drawing.Point(1370, 166);
            this.rdio_Nam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdio_Nam.Name = "rdio_Nam";
            this.rdio_Nam.Size = new System.Drawing.Size(147, 58);
            this.rdio_Nam.TabIndex = 17;
            this.rdio_Nam.TabStop = true;
            this.rdio_Nam.Text = "Nam";
            this.rdio_Nam.UseVisualStyleBackColor = true;
            // 
            // cb_MaCV
            // 
            this.cb_MaCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_MaCV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaCV.FormattingEnabled = true;
            this.cb_MaCV.Location = new System.Drawing.Point(362, 167);
            this.cb_MaCV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_MaCV.Name = "cb_MaCV";
            this.cb_MaCV.Size = new System.Drawing.Size(494, 62);
            this.cb_MaCV.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1006, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 54);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã cửa hàng";
            // 
            // cbo_MaCuaHang
            // 
            this.cbo_MaCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_MaCuaHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaCuaHang.FormattingEnabled = true;
            this.cbo_MaCuaHang.Location = new System.Drawing.Point(1370, 414);
            this.cbo_MaCuaHang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbo_MaCuaHang.Name = "cbo_MaCuaHang";
            this.cbo_MaCuaHang.Size = new System.Drawing.Size(578, 62);
            this.cbo_MaCuaHang.TabIndex = 14;
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(1370, 287);
            this.dt_NgaySinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(578, 61);
            this.dt_NgaySinh.TabIndex = 13;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(1370, 55);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(578, 54);
            this.txt_TenNV.TabIndex = 11;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(362, 289);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(494, 54);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Diachi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diachi.Location = new System.Drawing.Point(362, 415);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(494, 54);
            this.txt_Diachi.TabIndex = 8;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(362, 55);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(494, 54);
            this.txt_MaNV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 54);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1006, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 54);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1006, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 54);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1006, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_NhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 736);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2840, 794);
            this.panel2.TabIndex = 1;
            // 
            // dg_NhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dg_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_NhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_NhanVien.ColumnHeadersHeight = 70;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_NhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_NhanVien.EnableHeadersVisualStyles = false;
            this.dg_NhanVien.GridColor = System.Drawing.SystemColors.Window;
            this.dg_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dg_NhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dg_NhanVien.Name = "dg_NhanVien";
            this.dg_NhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_NhanVien.RowHeadersVisible = false;
            this.dg_NhanVien.RowHeadersWidth = 70;
            this.dg_NhanVien.RowTemplate.Height = 70;
            this.dg_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_NhanVien.Size = new System.Drawing.Size(2840, 794);
            this.dg_NhanVien.TabIndex = 0;
            this.dg_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_NhanVien_CellClick);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(2880, 1550);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "F_QLNhanVien";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "F_QLNhanVien";
            this.Load += new System.EventHandler(this.F_QLNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_NhanVien)).EndInit();
            this.ResumeLayout(false);

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