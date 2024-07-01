namespace SaleShoes
{
    partial class XemChiTietDH
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
            this.BangChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.txtNgayDat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BangChiTietDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // BangChiTietDonHang
            // 
            this.BangChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangChiTietDonHang.Location = new System.Drawing.Point(27, 198);
            this.BangChiTietDonHang.Name = "BangChiTietDonHang";
            this.BangChiTietDonHang.RowHeadersWidth = 51;
            this.BangChiTietDonHang.RowTemplate.Height = 24;
            this.BangChiTietDonHang.Size = new System.Drawing.Size(763, 297);
            this.BangChiTietDonHang.TabIndex = 8;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDat.Location = new System.Drawing.Point(219, 131);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(293, 36);
            this.txtNgayDat.TabIndex = 2;
            this.txtNgayDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đặt";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(219, 77);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(293, 36);
            this.txtTenKhachHang.TabIndex = 4;
            this.txtTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonHang.Location = new System.Drawing.Point(219, 27);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(293, 36);
            this.txtMaDonHang.TabIndex = 6;
            this.txtMaDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã đơn hàng";
            // 
            // XemChiTietDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 537);
            this.Controls.Add(this.BangChiTietDonHang);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label1);
            this.Name = "XemChiTietDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemChiTietDH";
            this.Load += new System.EventHandler(this.XemChiTietDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangChiTietDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BangChiTietDonHang;
        private System.Windows.Forms.Label txtNgayDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMaDonHang;
        private System.Windows.Forms.Label label1;
    }
}