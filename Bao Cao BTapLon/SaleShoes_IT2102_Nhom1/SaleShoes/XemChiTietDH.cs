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
    public partial class XemChiTietDH : Form
    {
        private int maDonHang;
        public XemChiTietDH()
        {
            InitializeComponent();
        }
        public XemChiTietDH(int maDonHang)
        {
            this.maDonHang = maDonHang;
            InitializeComponent();
        }

        private void XemChiTietDH_Load(object sender, EventArgs e)
        {
            int maDonHang = this.maDonHang;

            using (var context = new QLBanHangEntities())
            {
                ////Tìm đơn hàng có mã đơn hàng đã chọn 
                var donHang = (from dh in context.DonHangs
                               join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                               where dh.MaDonHang == maDonHang
                               select new
                               {
                                   TenKhachHang = kh.Ten,
                                   NgayTao = dh.NgayTao
                               }).FirstOrDefault();

                // Gán thông tin vào các trường trên form
                txtMaDonHang.Text = maDonHang.ToString();
                txtTenKhachHang.Text = donHang.TenKhachHang;
                txtNgayDat.Text = donHang.NgayTao.ToString();

                // Truy vấn các chi tiết đơn hàng tương ứng với mã đơn hàng
                var results = (from chiTiet in context.ChiTietDonHangs
                               where chiTiet.MaDonHang == maDonHang
                               select new
                               {
                                   TenSanPham = chiTiet.SanPham.TenSP,
                                   SoLuong = chiTiet.SoLuong,
                                   Gia = chiTiet.TongTienSP,
                                   TongTien = chiTiet.TongTienSP
                               }).ToList();
                // Gán danh sách kết quả cho DataGridView để hiển thị
                BangChiTietDonHang.DataSource = results;
            }
        }
    }
}
