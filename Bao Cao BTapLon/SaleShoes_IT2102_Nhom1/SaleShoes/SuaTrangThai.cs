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
    public partial class SuaTrangThai : Form
    {
        public SuaTrangThai()
        {
            InitializeComponent();
        }
        private int maDonHang;



        public SuaTrangThai(int maDonHang)
        {
            this.maDonHang = maDonHang;
            InitializeComponent();
        }
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị trạng thái mới từ ComboBox
                string newStatus = cbbTrangThai.SelectedItem.ToString();

                // Lấy mã đơn hàng từ constructor của form
                int maDonHang = this.maDonHang;

                // Tiến hành cập nhật trạng thái của đơn hàng trong cơ sở dữ liệu
                using (var context = new QLBanHangEntities())
                {
                    // Tìm đơn hàng cần cập nhật
                    var donHang = context.DonHangs.FirstOrDefault(dh => dh.MaDonHang == maDonHang);
                    if (donHang.TrangThai == "Hoàn Thành" || donHang.TrangThai == "Hủy")
                    {
                        MessageBox.Show("Không thể đổi trạng thái");
                    }
                    else
                    {
                        // Cập nhật trạng thái mới cho đơn hàng
                        donHang.TrangThai = newStatus;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Cập nhật trạng thái thành công!");
                    }     

                }
                // Đóng form SuaTrangThai
                this.Close();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Không có trạng thái này");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaTrangThai_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
