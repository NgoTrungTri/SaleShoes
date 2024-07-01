namespace SaleShoes
{
    partial class thanhtoan
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
            this.btThoat = new System.Windows.Forms.Button();
            this.bt_thanhtoan = new System.Windows.Forms.Button();
            this.dgspmua = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCK = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_damua = new System.Windows.Forms.Label();
            this.lbTienHang = new System.Windows.Forms.Label();
            this.txt_stk = new System.Windows.Forms.Label();
            this.lb_STK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgspmua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(709, 595);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 44);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thanhtoan.Location = new System.Drawing.Point(945, 595);
            this.bt_thanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(136, 44);
            this.bt_thanhtoan.TabIndex = 18;
            this.bt_thanhtoan.Text = "Đặt Hàng";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // dgspmua
            // 
            this.dgspmua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgspmua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgspmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgspmua.Location = new System.Drawing.Point(240, 111);
            this.dgspmua.Name = "dgspmua";
            this.dgspmua.RowTemplate.Height = 24;
            this.dgspmua.Size = new System.Drawing.Size(813, 165);
            this.dgspmua.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCK);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 298);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức Thanh Toán";
            // 
            // rbtCK
            // 
            this.rbtCK.AutoSize = true;
            this.rbtCK.Location = new System.Drawing.Point(25, 68);
            this.rbtCK.Margin = new System.Windows.Forms.Padding(4);
            this.rbtCK.Name = "rbtCK";
            this.rbtCK.Size = new System.Drawing.Size(340, 29);
            this.rbtCK.TabIndex = 0;
            this.rbtCK.Text = "Thanh Toán Bằng Chuyển Khoảng";
            this.rbtCK.UseVisualStyleBackColor = true;
            this.rbtCK.CheckedChanged += new System.EventHandler(this.rbtCK_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 31);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(279, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thanh Toán Khi Nhận Hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(240, 21);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(841, 28);
            this.lbDiaChi.TabIndex = 13;
            this.lbDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Địa chỉ nhận hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền hàng thanh toán";
            // 
            // lb_damua
            // 
            this.lb_damua.AutoSize = true;
            this.lb_damua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_damua.Location = new System.Drawing.Point(4, 81);
            this.lb_damua.Name = "lb_damua";
            this.lb_damua.Size = new System.Drawing.Size(228, 29);
            this.lb_damua.TabIndex = 19;
            this.lb_damua.Text = "Sản phẩm đã mua:";
            // 
            // lbTienHang
            // 
            this.lbTienHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTienHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienHang.Location = new System.Drawing.Point(317, 475);
            this.lbTienHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTienHang.Name = "lbTienHang";
            this.lbTienHang.Size = new System.Drawing.Size(234, 44);
            this.lbTienHang.TabIndex = 23;
            this.lbTienHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_stk
            // 
            this.txt_stk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_stk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stk.Location = new System.Drawing.Point(612, 475);
            this.txt_stk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_stk.Name = "txt_stk";
            this.txt_stk.Size = new System.Drawing.Size(432, 44);
            this.txt_stk.TabIndex = 26;
            this.txt_stk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_stk.Visible = false;
            // 
            // lb_STK
            // 
            this.lb_STK.AutoSize = true;
            this.lb_STK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_STK.Location = new System.Drawing.Point(607, 437);
            this.lb_STK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_STK.Name = "lb_STK";
            this.lb_STK.Size = new System.Drawing.Size(132, 25);
            this.lb_STK.TabIndex = 25;
            this.lb_STK.Text = "Số tài khoảng";
            this.lb_STK.Visible = false;
            // 
            // thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 670);
            this.Controls.Add(this.txt_stk);
            this.Controls.Add(this.lb_STK);
            this.Controls.Add(this.lbTienHang);
            this.Controls.Add(this.lb_damua);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.bt_thanhtoan);
            this.Controls.Add(this.dgspmua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "thanhtoan";
            this.Text = "thanhtoan";
            this.Load += new System.EventHandler(this.thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgspmua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button bt_thanhtoan;
        private System.Windows.Forms.DataGridView dgspmua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCK;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_damua;
        private System.Windows.Forms.Label lbTienHang;
        private System.Windows.Forms.Label txt_stk;
        private System.Windows.Forms.Label lb_STK;
    }
}