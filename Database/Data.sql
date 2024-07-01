Use QLBanHang
Go

-- Thêm dữ liệu vào bảng LoaiKhachHang
INSERT INTO LoaiKhachHang (TenLoaiKH) VALUES
(N'Phổ Thông'),
(N'Đồng'),
(N'Bạc'),
(N'Vàng'),
(N'Kim Cương');

-- Thêm 10 khách hàng với loại "Phổ Thông" (giả sử MaLoaiKH của "Phổ Thông" là 1)
INSERT INTO KhachHang (Ten, TenDangNhap, MatKhau, Email, SDT, DiaChi, MaLoaiKH)
SELECT N'Tên ' + CAST(number AS NVARCHAR(10)), 'tendangnhap' + CAST(number AS NVARCHAR(10)), 'matkhau' + CAST(number AS NVARCHAR(10)), 'email' + CAST(number AS NVARCHAR(10)) + '@example.com', '0123456789', N'Địa chỉ ' + CAST(number AS NVARCHAR(10)), 1
FROM (VALUES(1),(2),(3),(4),(5),(6),(7),(8),(9),(10)) AS numbers(number);

-- Thêm 3 hãng giày vào bảng HangGiay
INSERT INTO HangGiay (TenHang) VALUES
('Nike'),
('Jordan'),
('NewBalance');

-- Tạo sản phẩm cho hãng giày Nike
INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'Nike Air Force 1',
    size.Size,
    10, -- Số lượng mỗi size
    100.00, -- Giá
    N'Mô tả sản phẩm Nike Air Force 1'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'Nike';

INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'Nike Zoom Bella',
    size.Size,
    10, -- Số lượng mỗi size
    120.00, -- Giá
    N'Mô tả sản phẩm Nike Zoom Bella'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'Nike';


-- Tạo sản phẩm cho hãng giày Jordan
INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'Jordan Air 1 Low',
    size.Size,
    10, -- Số lượng mỗi size
    150.00, -- Giá
    N'Mô tả sản phẩm Jordan Air 1 Low'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'Jordan';

INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'Jordan Legarcy 212',
    size.Size,
    10, -- Số lượng mỗi size
    180.00, -- Giá
    N'Mô tả sản phẩm Jordan Legarcy 212'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'Jordan';


-- Tạo sản phẩm cho hãng giày New Balance
INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'New Balance 1 Low',
    size.Size,
    10, -- Số lượng mỗi size
    130.00, -- Giá
    N'Mô tả sản phẩm New Balance 1 Low'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'New Balance';

INSERT INTO SanPham (MaHangGiay, TenSP, Size, SoLuong, Gia, MoTaSP)
SELECT 
    hg.MaHangGiay,
    'New Balance Moon Classic',
    size.Size,
    10, -- Số lượng mỗi size
    140.00, -- Giá
    N'Mô tả sản phẩm New Balance Moon Classic'
FROM 
    HangGiay hg
CROSS JOIN 
    (VALUES(38),(39),(40),(41),(42),(43),(44),(45)) AS size(Size)
WHERE 
    hg.TenHang = 'New Balance';
-- Lấy ngày hiện tại
DECLARE @NgayBatDau DATE = GETDATE();

-- Tính ngày kết thúc (1 tháng sau)
DECLARE @NgayKetThuc DATE = DATEADD(MONTH, 1, @NgayBatDau);

-- Thêm khuyến mãi vào bảng KhuyenMai
INSERT INTO KhuyenMai (Ten, NgayBatDau, NgayKetThuc, GiaTri) 
VALUES (N'Khuyến mãi 20%', @NgayBatDau, @NgayKetThuc, 0.2);

-- Tạo Khách Hàng Mua Hàng
INSERT INTO KhachHang (Ten, TenDangNhap, MatKhau, Email, SDT, DiaChi, MaLoaiKH)
VALUES (N'Nguyễn Văn A', 'abc1234', 'abc1234', 'a@gmail.com', '0376334987', 'Sài Gòn', 1);
INSERT INTO KhachHang (Ten, TenDangNhap, MatKhau, Email, SDT, DiaChi, MaLoaiKH)
VALUES ('Nguyen Thi B', 'abcd1234', 'abcd1234', 'b@gmail.com', '0868842825', 'Sài Gòn', 1);


Use QLBanHang
go

-- Tạo khuyến mãi mới với giá trị là 20%
DECLARE @MaKhuyenMai INT;
INSERT INTO KhuyenMai (Ten, NgayBatDau, NgayKetThuc, GiaTri) 
VALUES (N'Khuyến mãi 20%', GETDATE(), DATEADD(MONTH, 1, GETDATE()), 0.2);
SET @MaKhuyenMai = SCOPE_IDENTITY();

-- Thêm khuyến mãi cho sản phẩm có id = 1
INSERT INTO KhuyenMai_SanPham (MaSanPham, MaKhuyenMai) VALUES (1, @MaKhuyenMai);

-- Tạo đơn hàng
DECLARE @MaDonHang INT;
INSERT INTO DonHang (MaKH, TongTien, NgayTao, TrangThai)
VALUES (11, 0, GETDATE(), N'Đang Duyệt');
SET @MaDonHang = SCOPE_IDENTITY();

-- Tạo chi tiết đơn hàng cho sản phẩm có id = 1
DECLARE @GiaCuoiCung FLOAT;
SELECT @GiaCuoiCung = Gia - (Gia * 0.2) FROM SanPham WHERE MaSanPham = 1;

INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, SoLuong, TongTienSP)
VALUES (@MaDonHang, 1, 2, @GiaCuoiCung * 2);

-- Cập nhật tổng tiền của đơn hàng
UPDATE DonHang
SET TongTien = (
    SELECT SUM(ChiTietDonHang.TongTienSP) -- Tính tổng tiền cho từng sản phẩm trong đơn hàng
    FROM ChiTietDonHang
    INNER JOIN SanPham ON ChiTietDonHang.MaSanPham = SanPham.MaSanPham
    WHERE ChiTietDonHang.MaDonHang = DonHang.MaDonHang
)
WHERE MaDonHang = @MaDonHang; -- Chỉ cập nhật cho đơn hàng có mã là @MaDonHang

INSERT INTO QuanTriVien (TenDangNhap, MatKhau)
VALUES ('admin', 'admin');
