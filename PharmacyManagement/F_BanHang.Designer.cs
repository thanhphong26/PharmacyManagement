namespace PharmacyManagement
{
    partial class F_BanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.lbTenSp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenCuaHang = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.pnDSSanPham = new System.Windows.Forms.Panel();
            this.pnCongCu = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.pnTTSp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongKho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDSoluong = new System.Windows.Forms.NumericUpDown();
            this.btnMua = new System.Windows.Forms.Button();
            this.dgvLoSpOfCH = new System.Windows.Forms.DataGridView();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtNameSp = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnCongCu.SuspendLayout();
            this.pnTTSp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoSpOfCH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.lbTenSp);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(2181, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 1550);
            this.panel1.TabIndex = 0;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(256, 1140);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(137, 54);
            this.lbTongTien.TabIndex = 6;
            this.lbTongTien.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 1140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 54);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng Tiền ";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(123, 1445);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(517, 81);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Lập hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // lbTenSp
            // 
            this.lbTenSp.AutoSize = true;
            this.lbTenSp.Location = new System.Drawing.Point(101, 1290);
            this.lbTenSp.Name = "lbTenSp";
            this.lbTenSp.Size = new System.Drawing.Size(92, 32);
            this.lbTenSp.TabIndex = 3;
            this.lbTenSp.Text = "label2";
            this.lbTenSp.Click += new System.EventHandler(this.lbTenSp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 1271);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.SoLuong,
            this.Tien,
            this.MaLO});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 501);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 102;
            this.dgvHoaDon.RowTemplate.Height = 40;
            this.dgvHoaDon.Size = new System.Drawing.Size(699, 637);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellDoubleClick);
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên";
            this.TenSP.MinimumWidth = 12;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.MinimumWidth = 12;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 250;
            // 
            // Tien
            // 
            this.Tien.HeaderText = "Tổng";
            this.Tien.MinimumWidth = 12;
            this.Tien.Name = "Tien";
            this.Tien.Width = 250;
            // 
            // MaLO
            // 
            this.MaLO.HeaderText = "Lô";
            this.MaLO.MinimumWidth = 12;
            this.MaLO.Name = "MaLO";
            this.MaLO.Width = 250;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TenCuaHang);
            this.panel5.Controls.Add(this.txtSDT);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(699, 501);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "TenNhanVien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người lập";
            // 
            // TenCuaHang
            // 
            this.TenCuaHang.AutoSize = true;
            this.TenCuaHang.Location = new System.Drawing.Point(259, 19);
            this.TenCuaHang.Name = "TenCuaHang";
            this.TenCuaHang.Size = new System.Drawing.Size(168, 32);
            this.TenCuaHang.TabIndex = 1;
            this.TenCuaHang.Text = "tencuaHang";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(123, 129);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(383, 38);
            this.txtSDT.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.btnSearchKH);
            this.panel6.Controls.Add(this.txtTenKH);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtDiem);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDiaChi);
            this.panel6.Location = new System.Drawing.Point(5, 114);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(683, 360);
            this.panel6.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 278);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 80);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.Location = new System.Drawing.Point(499, 12);
            this.btnSearchKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(155, 38);
            this.btnSearchKH.TabIndex = 5;
            this.btnSearchKH.Text = "Tìm kiếm ";
            this.btnSearchKH.UseVisualStyleBackColor = true;
            this.btnSearchKH.Click += new System.EventHandler(this.btnSearchKH_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(275, 69);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(380, 38);
            this.txtTenKH.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(275, 112);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(215, 38);
            this.txtDiem.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điểm tích";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(275, 165);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(380, 90);
            this.txtDiaChi.TabIndex = 9;
            // 
            // pnDSSanPham
            // 
            this.pnDSSanPham.AutoScroll = true;
            this.pnDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDSSanPham.Location = new System.Drawing.Point(0, 582);
            this.pnDSSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDSSanPham.Name = "pnDSSanPham";
            this.pnDSSanPham.Size = new System.Drawing.Size(2181, 968);
            this.pnDSSanPham.TabIndex = 7;
            // 
            // pnCongCu
            // 
            this.pnCongCu.Controls.Add(this.btnSearch);
            this.pnCongCu.Controls.Add(this.txtSearch);
            this.pnCongCu.Controls.Add(this.cbbLoai);
            this.pnCongCu.Controls.Add(this.cbbDanhMuc);
            this.pnCongCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCongCu.Location = new System.Drawing.Point(0, 501);
            this.pnCongCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCongCu.Name = "pnCongCu";
            this.pnCongCu.Padding = new System.Windows.Forms.Padding(51, 0, 59, 0);
            this.pnCongCu.Size = new System.Drawing.Size(2181, 81);
            this.pnCongCu.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(1666, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(456, 81);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm Kiếm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1051, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 78);
            this.txtSearch.TabIndex = 3;
            // 
            // cbbLoai
            // 
            this.cbbLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbLoai.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(551, 0);
            this.cbbLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(500, 79);
            this.cbbLoai.TabIndex = 2;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(51, 0);
            this.cbbDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(500, 79);
            this.cbbDanhMuc.TabIndex = 1;
            this.cbbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMuc_SelectedIndexChanged);
            // 
            // pnTTSp
            // 
            this.pnTTSp.Controls.Add(this.panel2);
            this.pnTTSp.Controls.Add(this.panel3);
            this.pnTTSp.Controls.Add(this.txtDonVi);
            this.pnTTSp.Controls.Add(this.txtGiaBan);
            this.pnTTSp.Controls.Add(this.txtNameSp);
            this.pnTTSp.Controls.Add(this.txtMota);
            this.pnTTSp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTTSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTSp.Location = new System.Drawing.Point(0, 0);
            this.pnTTSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTTSp.Name = "pnTTSp";
            this.pnTTSp.Padding = new System.Windows.Forms.Padding(51, 10, 59, 10);
            this.pnTTSp.Size = new System.Drawing.Size(2181, 501);
            this.pnTTSp.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(51, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 481);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvLoSpOfCH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1058, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 481);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongKho);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.nUDSoluong);
            this.panel4.Controls.Add(this.btnMua);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 407);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel4.Size = new System.Drawing.Size(1064, 74);
            this.panel4.TabIndex = 4;
            // 
            // txtTongKho
            // 
            this.txtTongKho.AutoSize = true;
            this.txtTongKho.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTongKho.Location = new System.Drawing.Point(200, 5);
            this.txtTongKho.Name = "txtTongKho";
            this.txtTongKho.Size = new System.Drawing.Size(46, 54);
            this.txtTongKho.TabIndex = 7;
            this.txtTongKho.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng kho";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nUDSoluong
            // 
            this.nUDSoluong.Dock = System.Windows.Forms.DockStyle.Right;
            this.nUDSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDSoluong.Location = new System.Drawing.Point(616, 5);
            this.nUDSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSoluong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDSoluong.Name = "nUDSoluong";
            this.nUDSoluong.Size = new System.Drawing.Size(120, 61);
            this.nUDSoluong.TabIndex = 5;
            // 
            // btnMua
            // 
            this.btnMua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMua.Location = new System.Drawing.Point(736, 5);
            this.btnMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(328, 64);
            this.btnMua.TabIndex = 4;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLoSpOfCH
            // 
            this.dgvLoSpOfCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoSpOfCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoSpOfCH.Location = new System.Drawing.Point(0, 0);
            this.dgvLoSpOfCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoSpOfCH.Name = "dgvLoSpOfCH";
            this.dgvLoSpOfCH.RowHeadersWidth = 102;
            this.dgvLoSpOfCH.RowTemplate.Height = 40;
            this.dgvLoSpOfCH.Size = new System.Drawing.Size(1064, 401);
            this.dgvLoSpOfCH.TabIndex = 3;
            this.dgvLoSpOfCH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoSpOfCH_CellClick);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(549, 155);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(500, 61);
            this.txtDonVi.TabIndex = 9;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(549, 81);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(500, 61);
            this.txtGiaBan.TabIndex = 8;
            // 
            // txtNameSp
            // 
            this.txtNameSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSp.Location = new System.Drawing.Point(549, 10);
            this.txtNameSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameSp.Name = "txtNameSp";
            this.txtNameSp.Size = new System.Drawing.Size(500, 61);
            this.txtNameSp.TabIndex = 7;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(549, 236);
            this.txtMota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(500, 252);
            this.txtMota.TabIndex = 2;
            // 
            // F_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2880, 1550);
            this.Controls.Add(this.pnDSSanPham);
            this.Controls.Add(this.pnCongCu);
            this.Controls.Add(this.pnTTSp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_BanHang";
            this.Text = "F_BanHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnCongCu.ResumeLayout(false);
            this.pnCongCu.PerformLayout();
            this.pnTTSp.ResumeLayout(false);
            this.pnTTSp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoSpOfCH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDSSanPham;
        private System.Windows.Forms.Panel pnCongCu;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Panel pnTTSp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDSoluong;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.DataGridView dgvLoSpOfCH;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtNameSp;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label txtTongKho;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLO;
        private System.Windows.Forms.Label lbTenSp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TenCuaHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}