namespace PharmacyManagement
{
    partial class F_LoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_MaDanhMucChinh = new System.Windows.Forms.ComboBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_Loai = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Loai)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(971, 546);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(223, 82);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(547, 546);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(223, 82);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(137)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Location = new System.Drawing.Point(82, 546);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(223, 82);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1438, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 1361);
            this.panel1.TabIndex = 6;
            // 
            // cb_MaDanhMucChinh
            // 
            this.cb_MaDanhMucChinh.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaDanhMucChinh.FormattingEnabled = true;
            this.cb_MaDanhMucChinh.Items.AddRange(new object[] {
            ""});
            this.cb_MaDanhMucChinh.Location = new System.Drawing.Point(580, 372);
            this.cb_MaDanhMucChinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_MaDanhMucChinh.Name = "cb_MaDanhMucChinh";
            this.cb_MaDanhMucChinh.Size = new System.Drawing.Size(613, 70);
            this.cb_MaDanhMucChinh.TabIndex = 6;
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoai.Location = new System.Drawing.Point(580, 263);
            this.txt_TenLoai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(614, 70);
            this.txt_TenLoai.TabIndex = 5;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoai.Location = new System.Drawing.Point(578, 153);
            this.txt_MaLoai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(616, 70);
            this.txt_MaLoai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(71, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 62);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã danh mục chính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(71, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Loại: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(516, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_Loai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1394, 1361);
            this.panel2.TabIndex = 10;
            // 
            // dg_Loai
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_Loai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Loai.BackgroundColor = System.Drawing.Color.White;
            this.dg_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Loai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Loai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Loai.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Loai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Loai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Loai.EnableHeadersVisualStyles = false;
            this.dg_Loai.GridColor = System.Drawing.SystemColors.Window;
            this.dg_Loai.Location = new System.Drawing.Point(0, 0);
            this.dg_Loai.Margin = new System.Windows.Forms.Padding(6);
            this.dg_Loai.Name = "dg_Loai";
            this.dg_Loai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_Loai.RowHeadersVisible = false;
            this.dg_Loai.RowHeadersWidth = 70;
            this.dg_Loai.RowTemplate.Height = 70;
            this.dg_Loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Loai.Size = new System.Drawing.Size(1394, 1361);
            this.dg_Loai.TabIndex = 3;
            this.dg_Loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Loai_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_MaDanhMucChinh);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_TenLoai);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_Them);
            this.panel3.Controls.Add(this.txt_MaLoai);
            this.panel3.Controls.Add(this.btn_Sua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1402, 721);
            this.panel3.TabIndex = 10;
            // 
            // F_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(2840, 1361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "F_LoaiSanPham";
            this.Text = "F_LoaiSanPham";
            this.Load += new System.EventHandler(this.F_LoaiSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Loai)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_MaDanhMucChinh;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dg_Loai;
        private System.Windows.Forms.Panel panel3;
    }
}