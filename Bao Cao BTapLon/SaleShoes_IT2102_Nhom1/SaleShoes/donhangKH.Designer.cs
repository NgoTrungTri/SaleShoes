namespace SaleShoes
{
    partial class donhangKH
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
            this.GVDonHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_donmua = new System.Windows.Forms.Panel();
            this.bt_huydon = new System.Windows.Forms.Button();
            this.panelDonHang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GVDonHang)).BeginInit();
            this.pan_donmua.SuspendLayout();
            this.panelDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(892, 21);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(144, 47);
            this.btThoat.TabIndex = 22;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // GVDonHang
            // 
            this.GVDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDonHang.Location = new System.Drawing.Point(39, 76);
            this.GVDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.GVDonHang.Name = "GVDonHang";
            this.GVDonHang.RowHeadersWidth = 51;
            this.GVDonHang.Size = new System.Drawing.Size(1033, 260);
            this.GVDonHang.TabIndex = 20;
            this.GVDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVDonHang_CellClick);
            this.GVDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVDonHang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đơn Hàng";
            // 
            // pan_donmua
            // 
            this.pan_donmua.AutoScroll = true;
            this.pan_donmua.Controls.Add(this.bt_huydon);
            this.pan_donmua.Controls.Add(this.panelDonHang);
            this.pan_donmua.Controls.Add(this.GVDonHang);
            this.pan_donmua.Controls.Add(this.label1);
            this.pan_donmua.Controls.Add(this.btThoat);
            this.pan_donmua.Location = new System.Drawing.Point(12, 12);
            this.pan_donmua.Name = "pan_donmua";
            this.pan_donmua.Size = new System.Drawing.Size(1100, 642);
            this.pan_donmua.TabIndex = 24;
            this.pan_donmua.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_donmua_Paint);
            // 
            // bt_huydon
            // 
            this.bt_huydon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huydon.Location = new System.Drawing.Point(892, 466);
            this.bt_huydon.Name = "bt_huydon";
            this.bt_huydon.Size = new System.Drawing.Size(180, 53);
            this.bt_huydon.TabIndex = 26;
            this.bt_huydon.Text = "Hủy đơn";
            this.bt_huydon.UseVisualStyleBackColor = true;
            this.bt_huydon.Click += new System.EventHandler(this.bt_huydon_Click);
            // 
            // panelDonHang
            // 
            this.panelDonHang.Controls.Add(this.label2);
            this.panelDonHang.Controls.Add(this.dataGridView1);
            this.panelDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDonHang.Location = new System.Drawing.Point(39, 343);
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(798, 271);
            this.panelDonHang.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chi Tiết Đơn Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // donhangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 666);
            this.Controls.Add(this.pan_donmua);
            this.Name = "donhangKH";
            this.Text = "donhangKH";
            this.Load += new System.EventHandler(this.donhangKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDonHang)).EndInit();
            this.pan_donmua.ResumeLayout(false);
            this.pan_donmua.PerformLayout();
            this.panelDonHang.ResumeLayout(false);
            this.panelDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView GVDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_donmua;
        private System.Windows.Forms.Panel panelDonHang;
        private System.Windows.Forms.Button bt_huydon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}