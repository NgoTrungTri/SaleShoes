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
    public partial class admintrangchu : Form
    {
        public admintrangchu()
        {
            InitializeComponent();
        }

        private void bn_button_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form formhientai;
        private void openform(Form f)
        {
            if (formhientai != null)
            {
                formhientai.Close();
            }
            formhientai = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pntrang.Controls.Add(f);
            pntrang.Tag = f;
            f.BringToFront();
            f.Show();

        }

        private void admintrangchu_Load(object sender, EventArgs e)
        {
            TrangChuAdmin f = new TrangChuAdmin();

            // Đặt kích thước của f sao cho phù hợp với panel2
            f.Dock = DockStyle.Fill;

            // Đặt TopLevel của f thành false để có thể chèn vào panel2
            f.TopLevel = false;

            // Thêm f vào panel2
            pntrang.Controls.Add(f);

            // Hiển thị f
            f.Show();
            openform(new TrangChuAdmin());
        }

        private void btQLdon_Click(object sender, EventArgs e)
        {
            openform(new TrangChuAdmin());
        }

        private void btQLSP_Click(object sender, EventArgs e)
        {
            openform(new QuanLiSanPham());
            
        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            openform(new XemDoanhThu());
            
        }

        private void btTaoGiamGia_Click(object sender, EventArgs e)
        {
            openform(new TaoKhuyenMai());
           
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pntrang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
