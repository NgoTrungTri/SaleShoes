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
    public partial class SuaSanPham : Form
    {
        private int maSP;
        private Image image;
        public SuaSanPham()
        {
            InitializeComponent();
        }

        public SuaSanPham(int maSP)
        {
            this.maSP = maSP;
            InitializeComponent();
        }
      

        private void btDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = " CHOISE picture";
            file.Filter = "Image Files (*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.tiff;*.tif)| *.png; *.bmp; *.jpg;*.jpeg; *.gif; *.tiff;*.tif";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pic.ImageLocation = file.FileName;

                string filePath = file.FileName;
                this.image = Image.FromFile(filePath);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {           
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Dữ liệu không được trống");
                }
            }    
            return null;
        }
        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            using (var context = new QLBanHangEntities())
            {
                ///Tìm Sản Phẩm có Mã = maSP
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSP);
                // Hiển thị thông tin sản phẩm trong các điều khiển trên form SuaSanPham
                txtTenSP.Text = sanPham.TenSP;
                txtSize.Text = sanPham.Size.ToString();
                txtGia.Text = sanPham.Gia.ToString();
                txtSoLuong.Text = sanPham.SoLuong.ToString();
                byte[] imageData = sanPham.HinhAnh;

                // Kiểm tra xem dữ liệu hình ảnh có tồn tại không
                if (imageData != null && imageData.Length > 0)
                {
                    // Chuyển dữ liệu nhị phân thành hình ảnh
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        // Hiển thị hình ảnh trong PictureBox
                        pic.Image = image;
                    }
                }
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new QLBanHangEntities())
                {
                    ///Tìm Sản Phẩm có Mã = maSP
                    var sanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSP);
                    int soLuong = Convert.ToInt32(txtSoLuong.Text);
                    double gia = double.Parse(txtGia.Text);
                    if (soLuong > 0 && gia > 0)
                    {
                        sanPham.SoLuong = soLuong;
                        sanPham.Gia = gia;
                        sanPham.HinhAnh = ImageToByteArray(this.image);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật");
                    }

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    this.Close();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Nhập thông tin cần cập nhật");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Số lượng quá lớn");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
