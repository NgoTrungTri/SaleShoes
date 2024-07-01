using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SaleShoes
{
    public partial class Trangchu : Form
    {
        dangnhap formDangNhap;
        float giamgia;
        int MaSP;
        public string mahoadon;
        List<spmua> selectedProducts = new List<spmua>();
        int customerId = -1;
        public double giamgiay(int masp ) {

            var khuyenMaiId = context.KhuyenMai_SanPham
                              .Where(k => k.MaSanPham == masp)
                              .Select(k => k.MaKhuyenMai)
                              .FirstOrDefault();

            if (khuyenMaiId == null)
                return 1;
            else
            {
                var discount = context.KhuyenMais
                               .Where(g => g.MaKhuyenMai == khuyenMaiId && DateTime.Now >= g.NgayBatDau && DateTime.Now <= g.NgayKetThuc)
                               .Select(g => g.GiaTri)
                               .FirstOrDefault();

                return discount ?? 1.0;
            }

        }
        public double giamloai(int mahang)
        {

            var khuyenMaiId = context.KhuyenMai_Hang
                              .Where(k => k.MaHangGiay == mahang)
                              .Select(k => k.MaKhuyenMai)
                              .FirstOrDefault();
            if (khuyenMaiId == null)
                return 1;
            else
            {
                var discount = context.KhuyenMais
                               .Where(g => g.MaKhuyenMai == khuyenMaiId && DateTime.Now >= g.NgayBatDau && DateTime.Now <= g.NgayKetThuc)
                               .Select(g => g.GiaTri)
                               .FirstOrDefault();

                return discount  ?? 1.0;
            }

        }
            
        QLBanHangEntities context = new QLBanHangEntities();
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void loadsp()
        {
            var query = from item in context.SanPhams
                        select new
                        {
                            item.MaSanPham,
                            item.TenSP,
                            item.Gia,
                            item.SoLuong,
                            item.Size,
                            item.HinhAnh,
                            item.MaHangGiay,
                        };

            // Chuyển kết quả truy vấn thành danh sách
            var data = query.ToList();
            // Gán danh sách vào DataSource của DataGridView
            dgsp.DataSource = data;
            dgsp.Columns["MaHangGiay"].Visible = false;
            dgsp.AutoGenerateColumns = false;

            // Đảm bảo rằng các cột được hiển thị và định dạng đúng cho dữ liệu hình ảnh
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgsp.Columns[5]; // Đặt cột hình ảnh (nếu có)
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom; // Định dạng hình ảnh
        }

        
        public Trangchu()
        {
            InitializeComponent();
        }

        private void dgsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                bt_themsp.Enabled = true;
                
                DataGridViewRow row = dgsp.SelectedRows[0];
                string ID = (row.Cells[0].Value.ToString());
                MaSP = Convert.ToInt32(ID);
                //giam gia sanpham
                double giamhang = giamloai(Convert.ToInt32(dgsp.SelectedRows[0].Cells[6].Value));
                double giam = giamgiay(Convert.ToInt32(ID));
                giamgia = (float)(giam) * (float)giamhang;
                if (ID != "")
                {
                    if (giam != 1 || giamhang != 1)
                    {
                        lb_giam.Text = "Giá giảm còn: " + (Convert.ToInt32(dgsp.SelectedRows[0].Cells[2].Value)-giamgia* Convert.ToInt32(dgsp.SelectedRows[0].Cells[2].Value)).ToString();

                        lb_giam.Visible = true;
                    }
                    else
                        lb_giam.Visible = false;

                    lb_tensp.Text = dgsp.SelectedRows[0].Cells[1].Value.ToString();
                    lb_size.Text = dgsp.SelectedRows[0].Cells[4].Value.ToString();
                    lb_sl.Text = dgsp.SelectedRows[0].Cells[3].Value.ToString();
                    lb_gia.Text = dgsp.SelectedRows[0].Cells[2].Value.ToString();
                    soluongmua.Value = 1;

                    try
                    {
                        MemoryStream m = new MemoryStream((byte[])dgsp.SelectedRows[0].Cells[5].Value);
                        pc1.Image = Image.FromStream(m);

                    }
                    catch (Exception)
                    {
                        pc1.Image = null;
                    }

                    ShowData(Convert.ToInt32(ID));
                }
            }
            catch
            {

            }
        }
        private void ShowData(int MaSP)
        {
            using (var context = new QLBanHangEntities())
            {
                var result = (from DanhGia in context.DanhGias.Where(p => p.MaSanPham.Value == MaSP)
                              join KhachHang in context.KhachHangs on DanhGia.MaKH equals KhachHang.MaKH
                              select new 
                              {
                                  TenKH = KhachHang.Ten,
                                  NoiDung = DanhGia.NoiDung
                              }).ToList();

                GVDanhGia.DataSource = result;

            }
        }
        private void Trangchu_Load(object sender, EventArgs e)
        {
            loadsp();
            cbb_timsize.SelectedItem = cbb_timsize.Items[3];
            soluongmua.Minimum = 1;
            soluongmua.Maximum = 100;
           

        }
        //Đăng nhập
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            formDangNhap = new dangnhap();
            formDangNhap.ShowDialog();
            customerId = formDangNhap.CustomerId;
            Console.WriteLine(customerId);
            if (customerId != -1)
            {
                bt_dangxuat.Visible = true;
                bt_dangnhap.Visible = false;
                bt_thanhtoan.Visible = true;
                bt_donhang.Visible = true;
                bt_suatt.Visible = true;
            }
        }
        //Thanh toán sản phẩm đã mua
        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            if (selectedProducts.Any())
            {
                thanhtoan f = new thanhtoan(selectedProducts, customerId);
                f.ShowDialog();
                selectedProducts.Clear();
            }
            else
                MessageBox.Show("Bạn chưa mua sản phẩm nào !!!");
            loadsp();

        }
        //Đăng xuất
        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            formDangNhap.Close();
            customerId = -1;
            bt_dangxuat.Visible = false;
            bt_dangnhap.Visible = true;
            bt_thanhtoan.Visible = false;
            bt_donhang.Visible = false;
            bt_suatt.Visible = false;
        }
        //Mua sản phẩm
        private void bt_themsp_Click(object sender, EventArgs e)
        {
           
            if (customerId != -1)
            {
                if (dgsp.SelectedRows.Count > 0)
                {
                  
                    // Duyệt qua danh sách các dòng được chọn trong DataGridView
                    foreach (DataGridViewRow row in dgsp.SelectedRows)
                    {
                        int MaSP = int.Parse(row.Cells["MaSanPham"].Value.ToString());
                        int soluong = int.Parse(soluongmua.Value.ToString());
                        if (giamgia != 1)
                        {
                            float price = (Convert.ToInt32(dgsp.SelectedRows[0].Cells[2].Value)) - giamgia * (Convert.ToInt32(dgsp.SelectedRows[0].Cells[2].Value) );
                            spmua selectedProduct = new spmua(MaSP, soluong, price);
                            selectedProducts.Add(selectedProduct);
                            MessageBox.Show("Thêm sản phẩm thành công!!!");

                        }
                        else
                        {
                            float price = (Convert.ToInt32(dgsp.SelectedRows[0].Cells[2].Value)) ;
                            spmua selectedProduct = new spmua(MaSP, soluong, price);
                            selectedProducts.Add(selectedProduct);
                            MessageBox.Show("Thêm sản phẩm thành công!!!");
                        }

                       
                       
                    }                   
                }
            }
            else
                MessageBox.Show("Vui lòng đăng nhập ");

        }
        //tìm sản phẩm
        private void TimSanPham()
        {
            string keyword = tb_timkiem.Text;
          
            var query = from sanPham in context.SanPhams
                        where (sanPham.Size).ToString().Contains(keyword)
                        || sanPham.MaHangGiay.ToString().Contains(keyword)
                        || sanPham.TenSP.Contains(keyword)
                        select sanPham;

            dgsp.DataSource = query.ToList();
        }
        private void tb_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TimSanPham();
            }
        }

        private void soluongmua_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int.Parse(lb_sl.Text.ToString()) - int.Parse(soluongmua.Value.ToString())) >= 0)
                {
                    bt_themsp.Enabled = true;
                }
                else
                    bt_themsp.Enabled = false;
            }
            catch
            {

            }
        }
        
        //Xem đơn hàng đã mua
        private void bt_donhang_Click(object sender, EventArgs e)
        {
            donhangKH f= new donhangKH(customerId);
            f.ShowDialog();

        }
        //sửa thông tin khách hàng
        private void bt_suatt_Click(object sender, EventArgs e)
        {
            SuaThongTin f = new SuaThongTin(customerId);
            f.ShowDialog();
        }
        //Tìm kiếm theo giá sản phẩm
        private void cbb_timsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRange = cbb_timsize.SelectedItem.ToString();

            // Phân tích phạm vi giá tiền để xác định giá trị tối thiểu và tối đa
           
            
                double minPrice = 0;
                double maxPrice = double.MaxValue;

                if (selectedRange.Contains("Giá từ <200.000"))
                {
                    maxPrice = 200;
                }
                else if (selectedRange.Contains("Từ >200.000 đến <500.000"))
                {
                    minPrice = 200;
                    maxPrice = 500;
                }
                else if (selectedRange.Contains(">500.000"))
                {
                    minPrice = 500;
                }

                // Thực hiện truy vấn dữ liệu từ cơ sở dữ liệu sử dụng Entity Framework dựa trên giá trị tối thiểu và tối đa
                var products = context.SanPhams.Where(p => p.Gia >= minPrice && p.Gia <= maxPrice).ToList();

                // Hiển thị kết quả tìm kiếm cho người dùng (ví dụ: trong một DataGridView)
                dgsp.DataSource = products;
            if (selectedRange.Contains("Lọc Theo Giá"))
                loadsp();


        }

        private void btDanhGia_Click(object sender, EventArgs e)
        {

            if (customerId != -1)
            {
                if (string.IsNullOrWhiteSpace(rtxtDanhGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đánh giá");
                }
                else
                {
                    DanhGia newDG = new DanhGia
                    {
                        NoiDung = rtxtDanhGia.Text,
                        MaKH = customerId,
                        MaSanPham = MaSP
                    };
                    context.DanhGias.Add(newDG);
                    context.SaveChanges();
                    ShowData(MaSP);
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập để đánh giá ");
            }

            rtxtDanhGia.Clear();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimSanPham();
        }

        private void dgsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
