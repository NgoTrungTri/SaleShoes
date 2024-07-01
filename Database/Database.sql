USE QLBanHang;
GO

-- Tạo bảng LoaiKhachHang
CREATE TABLE LoaiKhachHang (
    MaLoaiKH INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiKH NVARCHAR(20)
);

CREATE TABLE QuanTriVien (
	ID INT IDENTITY(1,1) PRIMARY KEY, 
    TenDangNhap VARCHAR(100) UNIQUE,
    MatKhau  VARCHAR(100)
);

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY, 
    Ten NVARCHAR(50) NOT NULL,
    TenDangNhap VARCHAR(100) UNIQUE,
    MatKhau  VARCHAR(100),
    Email VARCHAR(50) UNIQUE,
    SDT VARCHAR(15),
    DiaChi VARCHAR(255),
    MaLoaiKH INT,
    CONSTRAINT unique_email UNIQUE (Email),
    CONSTRAINT unique_tendangnhap UNIQUE (TenDangNhap),
    FOREIGN KEY(MaLoaiKH) REFERENCES dbo.LoaiKhachHang(MaLoaiKH)
);

-- Tạo bảng DonHang
CREATE TABLE DonHang (
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,  
    TongTien DOUBLE PRECISION ,
    NgayTao DATE,
    TrangThai NVARCHAR(20), 
	MaKH INT,
    FOREIGN KEY(MaKH) REFERENCES dbo.KhachHang(MaKH)
);

-- Tạo bảng HangGiay
CREATE TABLE HangGiay (
    MaHangGiay INT IDENTITY(1,1) PRIMARY KEY,
    TenHang NVARCHAR(50) 
);

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
    MaHangGiay INT,
    TenSP NVARCHAR(50),
    Size INT,
    SoLuong INT,
    Gia DOUBLE PRECISION NOT NULL,
	HinhAnh IMAGE NULL,
    MoTaSP NVARCHAR(50) NULL,
    FOREIGN KEY(MaHangGiay) REFERENCES dbo.HangGiay(MaHangGiay)
);

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT, -- Đổi kiểu dữ liệu thành INT để khớp với MaDonHang trong DonHang
    MaSanPham INT,
	SoLuong INT,
    TongTienSP DOUBLE PRECISION,
    FOREIGN KEY(MaDonHang) REFERENCES dbo.DonHang(MaDonHang),
    FOREIGN KEY(MaSanPham) REFERENCES dbo.SanPham(MaSanPham)
);

-- Tạo bảng DanhGia
CREATE TABLE DanhGia (
    MaDanhGia INT IDENTITY(1,1) PRIMARY KEY,
    NoiDung NVARCHAR(100),
    MaKH INT,
    MaSanPham INT,
    FOREIGN KEY(MaKH) REFERENCES dbo.KhachHang(MaKH),
    FOREIGN KEY(MaSanPham) REFERENCES dbo.SanPham(MaSanPham)
);

-- Tạo bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaKhuyenMai INT IDENTITY(1,1) PRIMARY KEY,
    Ten NVARCHAR(50),
    NgayBatDau DATE, 
    NgayKetThuc DATE,
    GiaTri FLOAT
);

-- Tạo bảng KhuyenMai_SanPham
CREATE TABLE KhuyenMai_SanPham (
	Id INT IDENTITY(1,1) PRIMARY KEY,
    MaKhuyenMai INT,
    MaSanPham INT,
    FOREIGN KEY(MaKhuyenMai) REFERENCES dbo.KhuyenMai(MaKhuyenMai),
    FOREIGN KEY(MaSanPham) REFERENCES dbo.SanPham(MaSanPham)
);

-- Tạo bảng KhuyenMai_Hang
CREATE TABLE KhuyenMai_Hang (
	Id INT IDENTITY(1,1) PRIMARY KEY,
    MaKhuyenMai INT,
    MaHangGiay INT,
    FOREIGN KEY(MaKhuyenMai) REFERENCES dbo.KhuyenMai(MaKhuyenMai),
    FOREIGN KEY(MaHangGiay) REFERENCES dbo.HangGiay(MaHangGiay)
);
