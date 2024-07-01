using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace SaleShoes
{
    public partial class thanhtoan : Form
    {
        QLBanHangEntities context = new QLBanHangEntities();

        private List<spmua> selectedProducts;
        public int madonhang;
        int customerId;
        public thanhtoan()
        {
            InitializeComponent();

        }

        public thanhtoan(List<spmua> selectedProducts, int customerId)
        {
            InitializeComponent();
            this.selectedProducts = selectedProducts;
            dgspmua.DataSource = selectedProducts;
            this.customerId = customerId;
        }
        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            createHoaDon();
        }
        public void createHoaDon()
        {
            DateTime ngayHienTai = DateTime.Now;

            try
            {
                // Tạo hóa đơn
                DonHang a = new DonHang
                {
                    MaKH = customerId,
                    TongTien = null, // Tổng tiền ban đầu là null
                    NgayTao = ngayHienTai,
                    TrangThai = "Đang Duyệt"

                };
                // Thêm hóa đơn vào cơ sở dữ liệu
                context.DonHangs.Add(a);
                context.SaveChanges();
                madonhang = a.MaDonHang;

                MessageBox.Show("Tạo hóa đơn thành công");

                // Lấy hóa đơn vừa được tạo
                DonHang createdHoaDon = context.DonHangs.FirstOrDefault(hd => hd.MaDonHang == madonhang); // Thay "20" bằng mã hóa đơn vừa tạo

                // Thêm các chi tiết hóa đơn
                foreach (spmua product in selectedProducts)
                {

                    try
                    {
                        ChiTietDonHang chitiethoadon = new ChiTietDonHang
                        {

                            MaDonHang = madonhang, // Gán hóa đơn tương ứng
                            MaSanPham = product.masp,
                            SoLuong = product.soluong,
                            TongTienSP = (float)product.TongTien
                        };

                        // Thêm chi tiết hóa đơn vào cơ sở dữ liệu
                        context.ChiTietDonHangs.Add(chitiethoadon);
                        context.SaveChanges();

                        var sanPham = context.SanPhams.FirstOrDefault(p => p.MaSanPham == product.masp);
                        if (sanPham != null)
                        {
                            sanPham.SoLuong -= product.soluong; // Giảm số lượng sản phẩm
                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu 
                        }
                        else
                            MessageBox.Show("khong giam thành công");
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ và hiển thị thông báo lỗi
                        MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn: " + ex.Message);
                    }
                }

                // Tính tổng giá trị của các chi tiết hóa đơn
                float totalTongTienSP = selectedProducts.Sum(product => (float)product.TongTien);

                // Cập nhật tổng tiền của hóa đơn với tổng giá trị của các chi tiết hóa đơn
                createdHoaDon.TongTien = totalTongTienSP;
                context.SaveChanges();
                //ht(madonhang);
               
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tạo hóa đơn: " + ex.Message);
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtCK_CheckedChanged(object sender, EventArgs e)
        {
            lb_STK.Visible = true;
            txt_stk.Visible = true;
            txt_stk.Text = "0344 069 347 Ngân hàng MBBank Vương Hữu Hậu";
        }

        private void thanhtoan_Load(object sender, EventArgs e)
        {

            double total = 0;

            // Duyệt qua tất cả các hàng trong cột
            foreach (DataGridViewRow row in dgspmua.Rows)
            {
                // Kiểm tra giá trị của ô không phải là null hoặc rỗng
                if (row.Cells["TongTien"].Value != null && row.Cells["TongTien"].Value.ToString() != "")
                {
                    // Lấy giá trị của ô và cộng vào tổng
                    total += Double.Parse(row.Cells["TongTien"].Value.ToString());
                }
            }
            lbTienHang.Text = total.ToString();
        }
    }
}
