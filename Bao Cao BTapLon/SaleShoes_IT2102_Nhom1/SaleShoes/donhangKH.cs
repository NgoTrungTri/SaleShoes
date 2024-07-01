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
    public partial class donhangKH : Form
    {
        QLBanHangEntities context = new QLBanHangEntities();
        public donhangKH()
        {
            InitializeComponent();
        }
        private int Makh;
        public donhangKH(int makh)
        {
            InitializeComponent();
            this.Makh = makh;
        }
        private void loaddon()
        {
           
            var query = from dh in context.DonHangs.Where(p => p.MaKH.Value == Makh )
                        join kh in context.KhachHangs on dh.MaKH equals kh.MaKH
                        select new
                        {
                            MaDonHang = dh.MaDonHang,
                            TenKhachHang = kh.Ten,
                            Ngayda = dh.NgayTao,
                            TongTien = dh.TongTien,
                            trangthai = dh.TrangThai
                            //Thêm các trường dữ liệu khác bạn muốn hiển thị
                        };

            // Gán kết quả truy vấn vào DataSource của DataGridView
            GVDonHang.DataSource = query.ToList();
        }
        private void donhangKH_Load(object sender, EventArgs e)
        {
            loaddon();           
        }

        private void btChiTietDH_Click(object sender, EventArgs e)
        {

        }

        private void GVDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                DataGridViewRow row = GVDonHang.SelectedRows[0];
                int MaDH = Convert.ToInt16(row.Cells[0].Value.ToString());

                var CTDH =/*from ChiTietDonHang context.ChiTietDonHangs.Where(a => a.MaDonHang.Value == MaDH)*/
                          from ctdh in context.ChiTietDonHangs.Where(a => a.MaDonHang.Value == MaDH)
                          join sp in context.SanPhams on ctdh.MaSanPham equals sp.MaSanPham
                          select new
                          {
                              MaDonHang = ctdh.MaDonHang,
                              MaChiTietDon= ctdh.MaChiTiet,
                              TenSanPham=sp.TenSP,
                              SoLuong=ctdh.SoLuong,
                              TongTien=ctdh.TongTienSP
                          };
                dataGridView1.DataSource = CTDH.ToList();
                //if (CTDH != null)
                //{
                //    dataGridView1.DataSource = CTDH;
                //    dataGridView1.Columns["DonHang"].Visible = false;
                //    dataGridView1.Columns["SanPham"].Visible = false;
                //}

            }
            catch
            {

            }


        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void bt_huydon_Click(object sender, EventArgs e)
        {
            if (GVDonHang.SelectedRows.Count > 0)
            {
                // Lấy mã đơn hàng từ DataGridView
                int maDonHang = Convert.ToInt32(GVDonHang.SelectedRows[0].Cells["MaDonHang"].Value);

                // Lấy đối tượng đơn hàng từ cơ sở dữ liệu
                var donHang = context.DonHangs.FirstOrDefault(dh => dh.MaDonHang == maDonHang);

                // Kiểm tra xem đơn hàng có tồn tại không
                if (donHang != null && donHang.TrangThai=="Đang Duyệt")
                {
                    // Cập nhật tình trạng của đơn hàng thành "Đã hủy"
                    donHang.TrangThai = "Hủy";

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Hiển thị thông báo thành công

                    var chiTietDonHang = context.ChiTietDonHangs.Where(ct => ct.MaDonHang == maDonHang).ToList();

                    // Duyệt qua từng chi tiết đơn hàng
                    foreach (var chiTiet in chiTietDonHang)
                    {
                        // Lấy thông tin sản phẩm dựa trên mã sản phẩm trong chi tiết đơn hàng
                        var sanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSanPham == chiTiet.MaSanPham);

                        // Kiểm tra xem sản phẩm có tồn tại không
                        if (sanPham != null)
                        {
                            // Cập nhật lại số lượng của sản phẩm bằng cách trừ đi số lượng đã đặt trong chi tiết đơn hàng
                            sanPham.SoLuong += chiTiet.SoLuong;
                        }
                    }

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                    // Cập nhật lại DataSource của DataGridView sau khi thay đổi
                    var result = context.DonHangs.ToList();
                    GVDonHang.DataSource = result;
                    loaddon();
                }
                else
                    MessageBox.Show("Đơn hàng không thể hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Hiển thị thông báo cho người dùng nếu không có hàng được chọn
                MessageBox.Show("Vui lòng chọn một đơn hàng để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pan_donmua_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GVDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
