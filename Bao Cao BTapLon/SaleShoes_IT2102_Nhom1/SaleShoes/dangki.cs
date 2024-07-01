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
    public partial class dangki : Form
    {
        QLBanHangEntities context = new QLBanHangEntities();
        public dangki()
        {
            InitializeComponent();
        }

        private void bt_dangki_Click(object sender, EventArgs e)
        {
            if ((txt_ten.Text == "" || txt_diachi.Text == "" || txt_dangnhap.Text == "" || txt_matkhau.Text == "" || txt_sdt.Text == "" || txt_email.Text == "" ))
            {
                MessageBox.Show("Đây là một thông báo!", "Vui lòng nhập đầy đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                KhachHang k;
                k = context.KhachHangs.SingleOrDefault(n => n.TenDangNhap == txt_dangnhap.Text);
                if (k == null)
                {
                    LoaiKhachHang loaiKhachHangs = context.LoaiKhachHangs.FirstOrDefault(lkh => lkh.MaLoaiKH == 1);
                    try
                    {
                        k = new KhachHang
                        {                        
                            Ten = txt_ten.Text,
                            DiaChi = txt_diachi.Text,
                            TenDangNhap = txt_dangnhap.Text,
                            MatKhau = txt_matkhau.Text,
                            SDT = txt_sdt.Text,
                            Email = txt_email.Text,
                            LoaiKhachHang = loaiKhachHangs
                        };
                        if (txt_email.Text.Contains("@"))
                        {
                            context.KhachHangs.Add(k);
                            context.SaveChanges();
                            MessageBox.Show("Đăng kí thành công");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Email sai định dạng");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đăng kí không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                }
            }
        }

        private void dangki_Load(object sender, EventArgs e)
        {

        }
    }
}
