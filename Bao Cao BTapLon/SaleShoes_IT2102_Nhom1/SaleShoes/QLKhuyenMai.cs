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
    public partial class QLKhuyenMai : Form
    {
        public QLKhuyenMai()
        {
            InitializeComponent();
        }
        public void LoadKhuyenMai_SanPham()
        {
            using (var context = new QLBanHangEntities())
            {
                var khuyenMais = context.KhuyenMais
                    .Join(
                        context.KhuyenMai_SanPham,
                        km => km.MaKhuyenMai,
                        kmsp => kmsp.MaKhuyenMai,
                        (km, kmsp) => new { KhuyenMai = km, KhuyenMai_SanPham = kmsp })
                    .Join(
                        context.SanPhams,
                        x => x.KhuyenMai_SanPham.MaSanPham,
                        sp => sp.MaSanPham,
                        (x, sp) => new
                        {
                            MaKhuyenMai = x.KhuyenMai.MaKhuyenMai,
                            TenKhuyenMai = x.KhuyenMai.Ten,
                            NgayBatDau = x.KhuyenMai.NgayBatDau,
                            NgayKetThuc = x.KhuyenMai.NgayKetThuc,
                            GiaTri = x.KhuyenMai.GiaTri,
                            ApDung = sp.TenSP // Tên sản phẩm tương ứng với IdSanPham trong bảng KhuyenMai_SanPham
                        })
                    .ToList();

                BangQLKMSP.DataSource = khuyenMais;
            }
        }

        public void LoadKhuyenMai_Hang()
        {
            using (var context = new QLBanHangEntities())
            {
                var khuyenMais = context.KhuyenMais
                    .Join(
                        context.KhuyenMai_Hang,
                        km => km.MaKhuyenMai,
                        kmh => kmh.MaKhuyenMai,
                        (km, kmh) => new { KhuyenMai = km, KhuyenMai_Hang = kmh })
                    .Join(
                        context.HangGiays,
                        x => x.KhuyenMai_Hang.MaHangGiay,
                        hg => hg.MaHangGiay,
                        (x, hg) => new
                        {
                            MaKhuyenMai = x.KhuyenMai.MaKhuyenMai,
                            TenKhuyenMai = x.KhuyenMai.Ten,
                            NgayBatDau = x.KhuyenMai.NgayBatDau,
                            NgayKetThuc = x.KhuyenMai.NgayKetThuc,
                            GiaTri = x.KhuyenMai.GiaTri,
                            ApDung = hg.TenHang // Tên Hãng giày tương ứng với IdHang trong bảng KhuyenMai_Hang
                        })
                    .ToList();

                BangQLKMHang.DataSource = khuyenMais;
            }
        }
        public void XoaKM(int MaKM)
        {
            using (var context = new QLBanHangEntities())
            {
                var khuyenMai = context.KhuyenMais.FirstOrDefault(km => km.MaKhuyenMai == MaKM);
                if (khuyenMai != null)
                {
                    context.KhuyenMais.Remove(khuyenMai);
                    context.SaveChanges();
                }
            }
        }
        private void btHuyKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (BangQLKMSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = BangQLKMSP.SelectedRows[0];
                    int MaKMGiay = Convert.ToInt16(row.Cells[0].Value.ToString());
                    using (var context = new QLBanHangEntities())
                    {
                        var khuyenMaiSanPham = context.KhuyenMai_SanPham.Where(kmsp => kmsp.MaKhuyenMai == MaKMGiay).ToList();
                        context.KhuyenMai_SanPham.RemoveRange(khuyenMaiSanPham);
                        context.SaveChanges();
                        // Xóa khuyến mãi tương ứng trong bảng KhuyenMai
                        XoaKM(MaKMGiay);
                    }
                }
                else if (BangQLKMHang.SelectedRows.Count > 0)
                {
                    // Xóa các mục liên kết trong bảng KhuyenMai_Hang dựa trên MaKMHang
                    DataGridViewRow row = BangQLKMHang.SelectedRows[0];
                    int MaKMHang = Convert.ToInt16(row.Cells[0].Value.ToString());
                    using (var context = new QLBanHangEntities())
                    {
                        var khuyenMaiHang = context.KhuyenMai_Hang.Where(kmh => kmh.MaKhuyenMai == MaKMHang).ToList();
                        context.KhuyenMai_Hang.RemoveRange(khuyenMaiHang);
                        context.SaveChanges();
                        // Xóa khuyến mãi tương ứng trong bảng KhuyenMai
                        XoaKM(MaKMHang);
                    }
                }
                ///Load Lại
                LoadKhuyenMai_SanPham();
                LoadKhuyenMai_Hang();

                // Thông báo thành công
                MessageBox.Show("Đã xóa khuyến mãi và các mục liên kết thành công!");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Hãy Chọn Giày hoặc Hãng Giày cần HỦY khuyến mãi");
            }
        }

        private void QLKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMai_SanPham();
            LoadKhuyenMai_Hang();
        }
    }
}
