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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_BanHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_BanHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_BanHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_BanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_BanHang.BackgroundColor = System.Drawing.Color.White;
            this.dg_BanHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_BanHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_BanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_BanHang.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_BanHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_BanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_BanHang.EnableHeadersVisualStyles = false;
            this.dg_BanHang.GridColor = System.Drawing.SystemColors.Window;
            this.dg_BanHang.Location = new System.Drawing.Point(0, 0);
            this.dg_BanHang.Margin = new System.Windows.Forms.Padding(6);
            this.dg_BanHang.Name = "dg_BanHang";
            this.dg_BanHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_BanHang.RowHeadersVisible = false;
            this.dg_BanHang.RowHeadersWidth = 70;
            this.dg_BanHang.RowTemplate.Height = 70;
            this.dg_BanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_BanHang.Size = new System.Drawing.Size(1860, 1504);
            this.dg_BanHang.TabIndex = 3;
            // 
            // F_LSBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1860, 1504);
            this.Controls.Add(this.dg_BanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "F_LSBanHang";
            this.Text = "F_LSBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dg_BanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_BanHang;
    }
}