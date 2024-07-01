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
    public partial class QuanLiSanPham : Form
    {
        public QuanLiSanPham()
        {
            InitializeComponent();
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {

            ThemSanPham formThemSP = new ThemSanPham();
            formThemSP.ShowDialog();
        }
        public void LoadSanPham()
        {
            using (var context = new QLBanHangEntities())
            {
                BangSanPham.DataSource = context.SanPhams.ToList();
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)BangSanPham.Columns[6];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

                var results = context.SanPhams.Select(sp => new
                {
                    MaSanPham = sp.MaSanPham,
                    TenSanPham = sp.TenSP,
                    Size = sp.Size,
                    SoLuong = sp.SoLuong,
                    Gia = sp.Gia,
                    HinhAnh = sp.HinhAnh
                }).ToList();
                BangSanPham.DataSource = results;
            }
        }
        private void QuanLiSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = BangSanPham.SelectedRows[0];
                int MaSP = Convert.ToInt16(row.Cells[0].Value.ToString());
                SuaSanPham formSuaSP = new SuaSanPham(MaSP);
                formSuaSP.Show();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Chọn sản phẩm cần cập nhật");
            }
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = BangSanPham.SelectedRows[0];
                int MaSP = Convert.ToInt16(row.Cells[0].Value.ToString());
                using (var context = new QLBanHangEntities())
                {
                    var SanPham = context.SanPhams.Where(sp => sp.MaSanPham == MaSP).ToList();
                    context.SanPhams.RemoveRange(SanPham);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Thành Công");
                    LoadSanPham();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Chọn Sản Phẩm Cần Xóa");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenGiayTimKiem = txtTimKiem.Text.Trim().ToLower(); // Lấy tên giày từ textbox và chuyển thành chữ thường để so sánh

            using (var context = new QLBanHangEntities())
            {
                var results = (from sp in context.SanPhams
                               where sp.TenSP.ToLower().Contains(tenGiayTimKiem) // Lọc sản phẩm có tên chứa chuỗi tìm kiếm
                               select new
                               {
                                   MaSanPham = sp.MaSanPham,
                                   TenSanPham = sp.TenSP,
                                   Size = sp.Size,
                                   SoLuong = sp.SoLuong,
                                   Gia = sp.Gia
                               }).ToList();
                BangSanPham.DataSource = results;
            }
        }

        private void BangSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = BangSanPham.SelectedRows[0];
                string ID = (row.Cells[0].Value.ToString());
                if (ID != "")
                {
                    MemoryStream m = new MemoryStream((byte[])BangSanPham.SelectedRows[0].Cells[5].Value);
                    pic.Image = Image.FromStream(m);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Hãy Chọn Sản Phẩm để xem hình");
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Sản Phẩm Hiện tại chưa có hình");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChuAdmin admin = new TrangChuAdmin();
            admin.Show();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
