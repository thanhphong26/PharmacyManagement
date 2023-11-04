namespace PharmacyManagement
{
    partial class FBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBanHang));
            this.pnHoaDon = new System.Windows.Forms.Panel();
            this.pnTTSp = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCongCu = new System.Windows.Forms.Panel();
            this.cbbDanhMucChinh = new System.Windows.Forms.ComboBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnDSSanPham = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnTTSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnCongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnHoaDon.Location = new System.Drawing.Point(2280, 0);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(600, 1550);
            this.pnHoaDon.TabIndex = 0;
            // 
            // pnTTSp
            // 
            this.pnTTSp.Controls.Add(this.dataGridView1);
            this.pnTTSp.Controls.Add(this.textBox1);
            this.pnTTSp.Controls.Add(this.label1);
            this.pnTTSp.Controls.Add(this.pictureBox1);
            this.pnTTSp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTTSp.Location = new System.Drawing.Point(0, 0);
            this.pnTTSp.Name = "pnTTSp";
            this.pnTTSp.Padding = new System.Windows.Forms.Padding(50, 10, 0, 10);
            this.pnTTSp.Size = new System.Drawing.Size(2280, 500);
            this.pnTTSp.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(483, 247);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1050, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng kho ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PharmacyManagement.Properties.Resources.Screenshot_2023_09_16_130552;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnCongCu
            // 
            this.pnCongCu.Controls.Add(this.cbbDanhMucChinh);
            this.pnCongCu.Controls.Add(this.cbbLoai);
            this.pnCongCu.Controls.Add(this.txtSearch);
            this.pnCongCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCongCu.Location = new System.Drawing.Point(0, 500);
            this.pnCongCu.Name = "pnCongCu";
            this.pnCongCu.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pnCongCu.Size = new System.Drawing.Size(2280, 80);
            this.pnCongCu.TabIndex = 2;
            // 
            // cbbDanhMucChinh
            // 
            this.cbbDanhMucChinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbDanhMucChinh.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDanhMucChinh.FormattingEnabled = true;
            this.cbbDanhMucChinh.Location = new System.Drawing.Point(550, 0);
            this.cbbDanhMucChinh.Name = "cbbDanhMucChinh";
            this.cbbDanhMucChinh.Size = new System.Drawing.Size(500, 79);
            this.cbbDanhMucChinh.TabIndex = 2;
            // 
            // cbbLoai
            // 
            this.cbbLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbLoai.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(50, 0);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(500, 79);
            this.cbbLoai.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1653, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(627, 78);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = " Tim kiem";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pnDSSanPham
            // 
            this.pnDSSanPham.AutoScroll = true;
            this.pnDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDSSanPham.Location = new System.Drawing.Point(0, 580);
            this.pnDSSanPham.Name = "pnDSSanPham";
            this.pnDSSanPham.Size = new System.Drawing.Size(2280, 970);
            this.pnDSSanPham.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(1272, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 480);
            this.dataGridView1.TabIndex = 3;
            // 
            // FBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2880, 1550);
            this.Controls.Add(this.pnDSSanPham);
            this.Controls.Add(this.pnCongCu);
            this.Controls.Add(this.pnTTSp);
            this.Controls.Add(this.pnHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBanHang";
            this.Text = "FBanHang";
            this.pnTTSp.ResumeLayout(false);
            this.pnTTSp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnCongCu.ResumeLayout(false);
            this.pnCongCu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHoaDon;
        private System.Windows.Forms.Panel pnTTSp;
        private System.Windows.Forms.Panel pnCongCu;
        private System.Windows.Forms.Panel pnDSSanPham;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbDanhMucChinh;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}