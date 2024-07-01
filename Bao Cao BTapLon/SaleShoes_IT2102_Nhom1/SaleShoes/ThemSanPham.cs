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
    public partial class ThemSanPham : Form
    {
        private Image image;
        public ThemSanPham()
        {
            InitializeComponent();
        }
        public void LoadHangGiay()
        {
            using (var context = new QLBanHangEntities())
            {
                var results = context.HangGiays.Select(sp => new
                {
                    MaSanPham = sp.MaHangGiay,
                    TenHangGiay = sp.TenHang,
                }).ToList();
                BangHangSP.DataSource = results;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = " CHOISE picture";
            file.Filter = "Image Files (*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.tiff;*.tif)| *.png; *.bmp; *.jpg;*.jpeg; *.gif; *.tiff;*.tif";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = file.FileName;

                string filePath = file.FileName;
                this.image = Image.FromFile(filePath);

            }
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadHangGiay();
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void btTaoSanPham_Click(object sender, EventArgs e)
        {

            try
            {
                ///Lấy Dữ Liệu Nhập Vào
                string tensp = txtTenSP.Text;
                int soluong = Int16.Parse(txtSoLuong.Text);
                double gia = double.Parse(txtGia.Text);
                int size = Int16.Parse(txtSize.Text);
                string mota = txtMoTaSP.Text;

                ///Lấy Mã Hãng Giày
                DataGridViewRow row = BangHangSP.SelectedRows[0];
                int MaHangGiay = Convert.ToInt16(row.Cells[0].Value.ToString());

                using (var context = new QLBanHangEntities())
                {
                    // Tạo sản phẩm mới
                    SanPham sp = new SanPham
                    {
                        TenSP = tensp,
                        Size = size,
                        Gia = gia,
                        SoLuong = soluong,
                        MoTaSP = mota,
                        MaHangGiay = MaHangGiay,
                        HinhAnh = ImageToByteArray(this.image)
                    };
                    context.SanPhams.Add(sp);
                    context.SaveChanges();
                }

                MessageBox.Show("Thêm Sản Phẩm Thành Công");
                ///Lấy Dữ Liệu Nhập Vào
                tensp = null;
                soluong = 0;
                gia = 0;
                size = 0;
                mota = null;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Chọn Hãng Giày của sản phẩm");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Thiếu thông tin sản phẩm");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
