namespace SaleShoes
{
    partial class QLKhuyenMai
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
            this.btHuyKM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BangQLKMHang = new System.Windows.Forms.DataGridView();
            this.BangQLKMSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BangQLKMHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangQLKMSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuyKM
            // 
            this.btHuyKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyKM.Location = new System.Drawing.Point(892, 380);
            this.btHuyKM.Name = "btHuyKM";
            this.btHuyKM.Size = new System.Drawing.Size(160, 62);
            this.btHuyKM.TabIndex = 8;
            this.btHuyKM.Text = "Hủy Khuyến Mãi";
            this.btHuyKM.UseVisualStyleBackColor = true;
            this.btHuyKM.Click += new System.EventHandler(this.btHuyKM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khuyến Mãi Theo Hãng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khuyến Mãi Theo Giày";
            // 
            // BangQLKMHang
            // 
            this.BangQLKMHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangQLKMHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangQLKMHang.Location = new System.Drawing.Point(15, 439);
            this.BangQLKMHang.Name = "BangQLKMHang";
            this.BangQLKMHang.RowHeadersWidth = 51;
            this.BangQLKMHang.RowTemplate.Height = 24;
            this.BangQLKMHang.Size = new System.Drawing.Size(819, 341);
            this.BangQLKMHang.TabIndex = 5;
            // 
            // BangQLKMSP
            // 
            this.BangQLKMSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangQLKMSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangQLKMSP.Location = new System.Drawing.Point(15, 39);
            this.BangQLKMSP.Name = "BangQLKMSP";
            this.BangQLKMSP.RowHeadersWidth = 51;
            this.BangQLKMSP.RowTemplate.Height = 24;
            this.BangQLKMSP.Size = new System.Drawing.Size(819, 348);
            this.BangQLKMSP.TabIndex = 4;
            // 
            // QLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 685);
            this.Controls.Add(this.btHuyKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BangQLKMHang);
            this.Controls.Add(this.BangQLKMSP);
            this.Name = "QLKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKhuyenMai";
            this.Load += new System.EventHandler(this.QLKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangQLKMHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangQLKMSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuyKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BangQLKMHang;
        private System.Windows.Forms.DataGridView BangQLKMSP;
    }
}