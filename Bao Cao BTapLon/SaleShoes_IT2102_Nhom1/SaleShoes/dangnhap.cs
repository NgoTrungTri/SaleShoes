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
    public partial class dangnhap : Form
    {
        int  makh=-1;
        public int CustomerId
        {
            get { return makh; }
        }
        QLBanHangEntities context = new QLBanHangEntities();
        public dangnhap()  
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_dangnhap.Text.Trim();
            string matkhau = txt_matkhau.Text.Trim();
            if (txt_dangnhap.Text == "")
                MessageBox.Show("Vui lòng nhập tên đăng nhập!!!");
            else if (matkhau == "")
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
            else
            {
                //makh = GetCustomerIdFromDatabase(tendangnhap, matkhau);
                //if (makh!=-1)
                //{
                //    this.DialogResult = DialogResult.OK;

                //    this.Hide();

                //}
                //else
                //    MessageBox.Show("Đăng nhập khong thành công!!");
                string quyen = cb_quyen.SelectedItem.ToString();

                if (quyen == "Admin" )
                {

                    var customer = context.QuanTriViens
                    .FirstOrDefault(c => c.TenDangNhap == tendangnhap && c.MatKhau == matkhau);
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    admintrangchu f = new admintrangchu();
                    f.ShowDialog();
                }
                else if (quyen == "User")
                {

                    makh = GetCustomerIdFromDatabase(tendangnhap, matkhau);
                    if (makh != -1)
                    {
                        this.DialogResult = DialogResult.OK;

                        this.Hide();

                    }
                    else
                        MessageBox.Show("Đăng nhập khong thành công!!");
                }
                else
                {
                    // Hiển thị thông báo nếu không chọn quyền
                    MessageBox.Show("Vui lòng chọn quyền!");
                }
            }
           
        }
        private int GetCustomerIdFromDatabase(string username, string password)
        {
            {
                // Thực hiện truy vấn để lấy ID của khách hàng dựa trên tên đăng nhập và mật khẩu
                var customer = context.KhachHangs
                    .FirstOrDefault(c => c.TenDangNhap == username && c.MatKhau == password);

                // Nếu khách hàng tồn tại, trả về ID của họ
                if (customer != null)
                {

                    return customer.MaKH;

                }
                else
                {
                    return -1;
                }
            }
        }

        private void bt_dangki_Click(object sender, EventArgs e)
        {
            dangki f = new dangki();
            f.ShowDialog();
        }

        private void link_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmk f = new quenmk();
            f.ShowDialog();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            cb_quyen.SelectedItem = cb_quyen.Items[1];
        }
    }
}
