using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleShoes
{
    public partial class quenmk : Form
    {
        QLBanHangEntities context = new QLBanHangEntities();
        public quenmk()
        {
            InitializeComponent();
        }

        private void bt_laymk_Click(object sender, EventArgs e)
        {
            KhachHang kh = context.KhachHangs.SingleOrDefault(n => n.TenDangNhap == txt_tenlaymk.Text);
            if (txt_tenlaymk.Text == "")
                MessageBox.Show("Chưa nhập tên đăng nhập");
            else if (kh != null)
                txt_matkhau.Text = kh.MatKhau;
            else
                MessageBox.Show("Không tìm thấy tên đăng nhập");

        }
    }
}
