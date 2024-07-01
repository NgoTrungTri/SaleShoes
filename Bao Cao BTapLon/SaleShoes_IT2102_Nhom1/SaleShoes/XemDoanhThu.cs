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
namespace SaleShoes
{
    public partial class XemDoanhThu : Form
    {
        private QLBanHangEntities db;
        public XemDoanhThu()
        {
            InitializeComponent();
            db = new QLBanHangEntities();
            LoadHangGiayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCriteria = cbbTieuChi.SelectedItem.ToString();

                // Kiểm tra tiêu chí được chọn và thực hiện lọc tương ứng
                if (selectedCriteria == "Ngày")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        // Lấy ngày được chọn từ DatePicker hoặc các điều khiển tương tự
                        DateTime selectedDate = dtpNgay.Value.Date;

                        // Truy vấn tổng tiền của các đơn hàng trong ngày được chọn
                        var doanhthu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" && DbFunctions.TruncateTime(dh.NgayTao) == selectedDate.Date)
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        // Hiển thị kết quả
                        txtDoanhThu.Text = "Tổng Doanh Thu trong ngày là: " + doanhthu + " VND";
                    }
                }
                if (selectedCriteria == "Quí")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        // Lấy giá trị của quí và năm từ các điều khiển tương ứng
                        int quy = Convert.ToInt32(txtQui.Text);
                        int nam = Convert.ToInt32(txtNam.Text);

                        // Truy vấn tổng tiền của các đơn hàng trong quí và năm được chọn
                        var doanhThu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" && dh.NgayTao.Value.Year == nam && ((dh.NgayTao.Value.Month - 1) / 3 + 1) == quy)
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        // Hiển thị kết quả
                        txtDoanhThu.Text = "Tổng Doanh Thu trong quý " + quy + " năm " + nam + " là: " + doanhThu + " VND";
                    }
                }
                if (selectedCriteria == "Năm")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        // Lấy giá trị của năm từ điều khiển tương ứng
                        int nam = Convert.ToInt32(txtNam.Text);

                        // Truy vấn tổng tiền của các đơn hàng trong năm được chọn
                        var doanhThu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" && dh.NgayTao.Value.Year == nam)
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        // Hiển thị kết quả
                        txtDoanhThu.Text = "Tổng Doanh Thu trong năm " + nam + " là: " + doanhThu + " VND";
                    }
                }

                ///Theo Hãng Giày

                if (selectedCriteria == "Hãng Giày trong Ngày")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        DateTime selectedDate = dtpNgay.Value.Date;
                        string selectedHangGiay = cbbHangGiay.SelectedItem.ToString();
                        var doanhThu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" &&
                                         DbFunctions.TruncateTime(dh.NgayTao) == selectedDate.Date &&
                                         dh.ChiTietDonHangs.Any(ct => ct.SanPham.HangGiay.TenHang == selectedHangGiay))
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        txtDoanhThu.Text = "Tổng Doanh Thu của hãng giày " + selectedHangGiay + " trong ngày " +
                                            selectedDate.ToString("dd/MM/yyyy") + " là: " + doanhThu + " VND";
                    }
                }
                if (selectedCriteria == "Hãng Giày trong Quí")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        int selectedQuy = Convert.ToInt32(txtQui.Text);
                        int selectedYear = Convert.ToInt32(txtNam.Text);
                        string selectedHangGiay = cbbHangGiay.SelectedItem.ToString();
                        var doanhThu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" &&
                                         dh.NgayTao.Value.Year == selectedYear &&
                                         ((dh.NgayTao.Value.Month - 1) / 3 + 1) == selectedQuy &&
                                         dh.ChiTietDonHangs.Any(ct => ct.SanPham.HangGiay.TenHang == selectedHangGiay))
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        txtDoanhThu.Text = "Tổng Doanh Thu của hãng giày " + selectedHangGiay + " trong quý " +
                                            selectedQuy + " năm " + selectedYear + " là: " + doanhThu + " VND";
                    }
                }
                if (selectedCriteria == "Hãng Giày trong Năm")
                {
                    using (var context = new QLBanHangEntities())
                    {
                        int selectedYear = Convert.ToInt32(txtNam.Text);
                        string selectedHangGiay = cbbHangGiay.SelectedItem.ToString();
                        var doanhThu = context.DonHangs
                            .Where(dh => dh.TrangThai == "Hoàn Thành" &&
                                         dh.NgayTao.Value.Year == selectedYear &&
                                         dh.ChiTietDonHangs.Any(ct => ct.SanPham.HangGiay.TenHang == selectedHangGiay))
                            .Select(dh => dh.TongTien)
                            .ToList()
                            .Sum();

                        txtDoanhThu.Text = "Tổng Doanh Thu của hãng giày " + selectedHangGiay + " trong năm " +
                                            selectedYear + " là: " + doanhThu + " VND";
                    }
                }

            }
            catch { }

        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tieuChi = cbbTieuChi.SelectedItem.ToString();

            if (tieuChi == "Ngày")
            {
                dtpNgay.Enabled = true;
                txtQui.Enabled = false;
                txtNam.Enabled = false;
                cbbHangGiay.Enabled = false;
            }
            if (tieuChi == "Quí")
            {
                dtpNgay.Enabled = false;
                txtQui.Enabled = true;
                txtNam.Enabled = true;
                cbbHangGiay.Enabled = false;
            }
            if (tieuChi == "Năm")
            {
                txtQui.Enabled = false;
                txtNam.Enabled = true;
                dtpNgay.Enabled = false;
                cbbHangGiay.Enabled = false;
            }
            if (tieuChi == "Hãng Giày trong Ngày")
            {
                dtpNgay.Enabled = true;               
                cbbHangGiay.Enabled = true;
            }
            if (tieuChi == "Hãng Giày trong Quí")
            {
                dtpNgay.Enabled = false;
                txtQui.Enabled = true;
                txtNam.Enabled = true;
                cbbHangGiay.Enabled = true;
            }
            if (tieuChi == "Hãng Giày trong Năm")
            {
                dtpNgay.Enabled = false;
                txtQui.Enabled = false;
                txtNam.Enabled = true;
                cbbHangGiay.Enabled = true;
            }
        }

        private void XemDoanhThu_Load(object sender, EventArgs e)
        {
            dtpNgay.Enabled = false;
            txtQui.Enabled = false;
            txtNam.Enabled = false;
            cbbHangGiay.Enabled = false;
        }

        private void LoadHangGiayData()
        {
            try
            {
                // Truy vấn dữ liệu từ bảng HangGiay
                var hangGiayList = db.HangGiays.ToList();

                // Xóa tất cả các mục đã có trong ComboBox trước khi thêm mới
                cbbHangGiay.Items.Clear();

                // Duyệt qua danh sách dữ liệu và thêm vào ComboBox
                foreach (var hangGiay in hangGiayList)
                {
                    // Thêm mỗi item vào ComboBox
                    cbbHangGiay.Items.Add(hangGiay.TenHang); // Giả sử TenHang là tên thuộc tính bạn muốn hiển thị trong ComboBox
                }

                // Chọn mục đầu tiên trong ComboBox (tuỳ chọn)
                if (cbbHangGiay.Items.Count > 0)
                    cbbHangGiay.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
