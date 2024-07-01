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
    public partial class TaoKhuyenMai : Form
    {
        public TaoKhuyenMai()
        {
            InitializeComponent();
        }
        public void LoadSanPham()
        {
            using (var context = new QLBanHangEntities())
            {
                var results = context.SanPhams.Select(sp => new
                {
                    MaSanPham = sp.MaSanPham,
                    TenSanPham = sp.TenSP,
                    Size = sp.Size,
                    SoLuong = sp.SoLuong,
                    Gia = sp.Gia
                }).ToList();
                BangKhuyenMai.DataSource = results;
            }
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
                BangKhuyenMai.DataSource = results;
            }
        }

        private void btTaoKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các control trên form
                string tenKhuyenMai = txtTenKhuyenMai.Text;
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;
                double giaTri = double.Parse(txtGiaTri.Text);
                string tieuChi = cbbTieuChi.SelectedItem.ToString();

                // Kiểm tra nếu người dùng đã chọn một sản phẩm từ DataGridView BangSanPham
                if (BangKhuyenMai.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = BangKhuyenMai.SelectedRows[0];
                    int MaLuaChon = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo và lưu khuyến mãi mới vào cơ sở dữ liệu
                    using (var context = new QLBanHangEntities())
                    {
                        // Tạo khuyến mãi mới
                        KhuyenMai khuyenMai = new KhuyenMai
                        {
                            Ten = tenKhuyenMai,
                            NgayBatDau = ngayBatDau,
                            NgayKetThuc = ngayKetThuc,
                            GiaTri = giaTri
                        };
                        context.KhuyenMais.Add(khuyenMai);
                        context.SaveChanges();

                        if (tieuChi == "Giày")
                        {
                            KhuyenMai_SanPham kmSp = new KhuyenMai_SanPham
                            {
                                MaKhuyenMai = khuyenMai.MaKhuyenMai,
                                MaSanPham = MaLuaChon
                            };
                            context.KhuyenMai_SanPham.Add(kmSp);
                            context.SaveChanges();
                        }
                        // Lưu id của khuyến mãi mới và id của sản phẩm vào bảng KhuyenMai_SanPham
                        if (tieuChi == "Hãng Giày")
                        {
                            KhuyenMai_Hang kmHg = new KhuyenMai_Hang
                            {
                                MaKhuyenMai = khuyenMai.MaKhuyenMai,
                                MaHangGiay = MaLuaChon
                            };
                            context.KhuyenMai_Hang.Add(kmHg);
                            context.SaveChanges();
                        }
                    }
                    // Thông báo cho người dùng biết rằng khuyến mãi đã được tạo và áp dụng thành công
                    MessageBox.Show("Khuyến mãi đã được tạo và áp dụng thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách trước khi tạo khuyến mãi.");
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Hãy Chọn Giày hoặc Hãng Giày để áp dụng KM");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }

        private void btQuanLyKM_Click(object sender, EventArgs e)
        {
            QLKhuyenMai qlKM = new QLKhuyenMai();
            qlKM.Show();
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tieuChi = cbbTieuChi.SelectedItem.ToString();

            if (tieuChi == "Giày")
            {
                LoadSanPham();
            }
            else if (tieuChi == "Hãng Giày")
            {
                LoadHangGiay();
            }
        }

        private void TaoKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
