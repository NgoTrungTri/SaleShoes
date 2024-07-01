namespace SaleShoes
{
    partial class TrangChuAdmin
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
            this.cbbTieuChi = new System.Windows.Forms.ComboBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btLocDonHang = new System.Windows.Forms.Button();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btXemChiTietDH = new System.Windows.Forms.Button();
            this.btSuaTrangThai = new System.Windows.Forms.Button();
            this.btCapNhatTrang = new System.Windows.Forms.Button();
            this.BangDonHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTieuChi
            // 
            this.cbbTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTieuChi.FormattingEnabled = true;
            this.cbbTieuChi.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Đơn Đang Duyệt",
            "Đơn Đã Duyệt",
            "Đơn Đang Giao",
            "Đơn Hoàn Thành",
            "Đơn Hủy"});
            this.cbbTieuChi.Location = new System.Drawing.Point(26, 69);
            this.cbbTieuChi.Name = "cbbTieuChi";
            this.cbbTieuChi.Size = new System.Drawing.Size(217, 28);
            this.cbbTieuChi.TabIndex = 26;
            this.cbbTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbbTieuChi_SelectedIndexChanged);
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(205, 178);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(139, 27);
            this.txtThang.TabIndex = 25;
            // 
            // btLocDonHang
            // 
            this.btLocDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLocDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocDonHang.Location = new System.Drawing.Point(149, 301);
            this.btLocDonHang.Name = "btLocDonHang";
            this.btLocDonHang.Size = new System.Drawing.Size(185, 51);
            this.btLocDonHang.TabIndex = 24;
            this.btLocDonHang.Text = "Lọc Đơn Hàng";
            this.btLocDonHang.UseVisualStyleBackColor = true;
            this.btLocDonHang.Click += new System.EventHandler(this.btLocDonHang_Click);
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Location = new System.Drawing.Point(26, 118);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(281, 22);
            this.dtpNgayDat.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lọc đơn hàng theo: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbTieuChi);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.btLocDonHang);
            this.panel1.Controls.Add(this.dtpNgayDat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(822, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 371);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lọc theo tháng";
            // 
            // btXemChiTietDH
            // 
            this.btXemChiTietDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXemChiTietDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemChiTietDH.Location = new System.Drawing.Point(1093, 81);
            this.btXemChiTietDH.Name = "btXemChiTietDH";
            this.btXemChiTietDH.Size = new System.Drawing.Size(174, 38);
            this.btXemChiTietDH.TabIndex = 35;
            this.btXemChiTietDH.Text = "Xem Chi Tiết ĐH";
            this.btXemChiTietDH.UseVisualStyleBackColor = true;
            this.btXemChiTietDH.Click += new System.EventHandler(this.btXemChiTietDH_Click);
            // 
            // btSuaTrangThai
            // 
            this.btSuaTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSuaTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaTrangThai.Location = new System.Drawing.Point(821, 81);
            this.btSuaTrangThai.Name = "btSuaTrangThai";
            this.btSuaTrangThai.Size = new System.Drawing.Size(173, 38);
            this.btSuaTrangThai.TabIndex = 33;
            this.btSuaTrangThai.Text = "Sửa Trạng Thái";
            this.btSuaTrangThai.UseVisualStyleBackColor = true;
            this.btSuaTrangThai.Click += new System.EventHandler(this.btSuaTrangThai_Click);
            // 
            // btCapNhatTrang
            // 
            this.btCapNhatTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCapNhatTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatTrang.Location = new System.Drawing.Point(1093, 12);
            this.btCapNhatTrang.Name = "btCapNhatTrang";
            this.btCapNhatTrang.Size = new System.Drawing.Size(173, 38);
            this.btCapNhatTrang.TabIndex = 34;
            this.btCapNhatTrang.Text = "Cập Nhật Trang";
            this.btCapNhatTrang.UseVisualStyleBackColor = true;
            // 
            // BangDonHang
            // 
            this.BangDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BangDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDonHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BangDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.BangDonHang.Location = new System.Drawing.Point(34, 66);
            this.BangDonHang.Name = "BangDonHang";
            this.BangDonHang.RowHeadersWidth = 51;
            this.BangDonHang.RowTemplate.Height = 24;
            this.BangDonHang.Size = new System.Drawing.Size(751, 627);
            this.BangDonHang.TabIndex = 32;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(34, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(745, 30);
            this.txtTimKiem.TabIndex = 23;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(822, 12);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(157, 38);
            this.btTimKiem.TabIndex = 24;
            this.btTimKiem.Text = "Tìm Kiếm ";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // TrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1278, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btXemChiTietDH);
            this.Controls.Add(this.btSuaTrangThai);
            this.Controls.Add(this.btCapNhatTrang);
            this.Controls.Add(this.BangDonHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TrangChuAdmin";
            this.Text = "TrangChuAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTieuChi;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btLocDonHang;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXemChiTietDH;
        private System.Windows.Forms.Button btSuaTrangThai;
        private System.Windows.Forms.Button btCapNhatTrang;
        private System.Windows.Forms.DataGridView BangDonHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
    }
}