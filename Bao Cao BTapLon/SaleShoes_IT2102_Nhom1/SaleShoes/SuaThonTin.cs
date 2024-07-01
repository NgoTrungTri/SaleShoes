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
    public partial class SuaThongTin : Form
    {
        public SuaThongTin()
        {
            InitializeComponent();
        }
  
        private int Makh;
        public SuaThongTin(int makh)
        {
            InitializeComponent();
            this.Makh = makh;
        }
        QLBanHangEntities context = new QLBanHangEntities();
        private void bt_sua_Click(object sender, EventArgs e)
        {
            var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.MaKH == Makh);
            if (txt_email.Text.Contains("@"))
            {
                khachHang.Ten = txt_ten.Text;
                khachHang.DiaChi = txt_diachi.Text;
                //khachHang.TenDangNhap = txt_dangnhap.Text;
                khachHang.MatKhau = txt_matkhau.Text;
                //khachHang.SDT = txt_sdt.Text;  Không được sửa sdt khách hàng
                khachHang.Email = txt_email.Text;
                context.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
                MessageBox.Show("Email không đúng định dạng");
        }

        private void SuaThongTin_Load(object sender, EventArgs e)
        {
            var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.MaKH == Makh);
            txt_ten.Text = khachHang.Ten;
            txt_diachi.Text = khachHang.DiaChi;
            txt_dangnhap.Text = khachHang.TenDangNhap;
            txt_matkhau.Text = khachHang.MatKhau;
            txt_sdt.Text = khachHang.SDT;
            txt_email.Text = khachHang.Email;

            txt_ten.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            txt_dangnhap.ReadOnly = false;
            txt_matkhau.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_email.ReadOnly = false;
        }
    }
}
