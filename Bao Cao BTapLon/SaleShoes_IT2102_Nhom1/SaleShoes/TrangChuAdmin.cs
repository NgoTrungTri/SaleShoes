using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace SaleShoes
{
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }
        public void LoadDonHang()
        {
            using (var context = new QLBanHangEntities())
            {
                var results = (from donHang in context.DonHangs
                               join khachHang in context.KhachHangs on donHang.MaKH equals khachHang.MaKH
                               select new
                               {
                                   MaDonHang = donHang.MaDonHang,
                                   TenNguoiMua = khachHang.Ten,
                                   TongTien = donHang.TongTien,
                                   NgayTao = donHang.NgayTao,
                                   TrangThai = donHang.TrangThai,
                               }).ToList();
                // Gán danh sách kết quả cho DataGridView để hiển thị
                BangDonHang.DataSource = results;
            }
        }

        private void btSuaTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = BangDonHang.SelectedRows[0];
                int MaDonHang = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (MaDonHang > 0)
                {
                    SuaTrangThai formSuaTrangThai = new SuaTrangThai(MaDonHang);
                    formSuaTrangThai.ShowDialog();
                }
                LoadDonHang();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng để sửa");
            }
        }

        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            LoadDonHang();
        }

        private void btLocDonHang_Click(object sender, EventArgs e)
        {
            string selectedCriteria = cbbTieuChi.SelectedItem.ToString();

            // Kiểm tra tiêu chí được chọn và thực hiện lọc tương ứng
            if (selectedCriteria == "Ngày")
            {
                DateTime ngayLoc = dtpNgayDat.Value.Date; // Lấy ngày được chọn từ DateTimePicker

                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where DbFunctions.TruncateTime(dh.NgayTao) == ngayLoc
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            if (selectedCriteria == "Tháng")
            {
                int thangLoc = Convert.ToInt32(txtThang.Text); // Lấy tháng được chọn từ TextBox

                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.NgayTao.Value.Month == thangLoc // So sánh tháng
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            ///Lọc đơn có trạng thái Đang Duyệt
            if (selectedCriteria == "Đơn Đang Duyệt")
            {
                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.TrangThai == "Đang Duyệt"
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            ///Lọc đơn có trạng thái Đã Duyệt
            if (selectedCriteria == "Đơn Đã Duyệt")
            {
                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.TrangThai == "Đã Duyệt"
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            ///Lọc đơn có trạng thái Đang Giao                    
            if (selectedCriteria == "Đơn Đang Giao")
            {
                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.TrangThai == "Đang Giao"
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            ///Lọc đơn có trạng thái Hoàn Thành
            if (selectedCriteria == "Đơn Hoàn Thành")
            {
                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.TrangThai == "Hoàn Thành"
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
            ///Lọc đơn có trạng thái Hủy
            if (selectedCriteria == "Đơn Hủy")
            {
                using (var context = new QLBanHangEntities())
                {
                    var results = (from dh in context.DonHangs
                                   join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                                   where dh.TrangThai == "Hủy"
                                   select new
                                   {
                                       MaDonHang = dh.MaDonHang,
                                       TenNguoiMua = kh.Ten,
                                       TongTien = dh.TongTien,
                                       NgayTao = dh.NgayTao,
                                       TrangThai = dh.TrangThai,
                                   }).ToList();
                    BangDonHang.DataSource = results;
                }
            }
        
    }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ ComboBox
            string tieuChi = cbbTieuChi.SelectedItem.ToString();

            if (tieuChi == "Ngày")
            {
                dtpNgayDat.Enabled = true; // Hiển thị DateTimePicker và cho phép thao tác
                txtThang.Enabled = false;   // Ẩn TextBox và không cho phép thao tác
            }
            else if (tieuChi == "Tháng")
            {
                dtpNgayDat.Enabled = false; // Ẩn DateTimePicker và không cho phép thao tác
                txtThang.Enabled = true;     // Hiển thị TextBox và cho phép thao tác
            }
            else
            {
                dtpNgayDat.Enabled = false; // Ẩn DateTimePicker và không cho phép thao tác
                txtThang.Enabled = false;    // Ẩn TextBox và không cho phép thao tác
            }
        }

        private void btXemChiTietDH_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = BangDonHang.SelectedRows[0];
                int MaDonHang = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (MaDonHang > 0)
                {
                    XemChiTietDH formChiTietDH = new XemChiTietDH(MaDonHang);
                    formChiTietDH.ShowDialog();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xem");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;
            using (var context = new QLBanHangEntities())
            {
                var results = (from donHang in context.DonHangs
                               join khachHang in context.KhachHangs on donHang.MaKH equals khachHang.MaKH
                               where khachHang.Ten.Contains(tuKhoa)
                               select new
                               {
                                   MaDonHang = donHang.MaDonHang,
                                   TenNguoiMua = khachHang.Ten,
                                   TongTien = donHang.TongTien,
                                   NgayTao = donHang.NgayTao,
                                   TrangThai = donHang.TrangThai,
                               }).ToList();

                // Gán danh sách kết quả cho DataGridView để hiển thị
                BangDonHang.DataSource = results;
            }

        }
    }
}
