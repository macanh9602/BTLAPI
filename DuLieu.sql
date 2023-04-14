--create database DuLieu
use DuLieu

CREATE TABLE tblKhach
(
  Makhach VARCHAR(20) NOT NULL,
  Tenkhach VARCHAR(20) NULL,
  Diachi VARCHAR(20) NULL,
  Dienthoai VARCHAR(20) NULL,
  PRIMARY KEY (Makhach)
);
CREATE TABLE tblAdmin (
    ID_Admin VARCHAR(20),
    Ten_Admin VARCHAR(255),
	PRIMARY KEY (ID_Admin)
);
CREATE TABLE tblTaiKhoan (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TaiKhoan VARCHAR(255),
    MatKhau VARCHAR(255),
    Makhach VARCHAR(20),
	XacNhanMatKhau VARCHAR(255),
    ID_Admin VARCHAR(20),
    FOREIGN KEY (Makhach) REFERENCES tblKhach(Makhach),
    FOREIGN KEY (ID_Admin) REFERENCES tblAdmin(ID_Admin)
);

CREATE TABLE tHangSX (
	MaHangSX varchar(50) PRIMARY KEY,
	HangSX varchar(50),
);

CREATE TABLE tMauSac (
	MaMau varchar(50) PRIMARY KEY,
	TenMau varchar(50),
);
CREATE TABLE tDanhMucSP (
	MaSP varchar(50) PRIMARY KEY,
	TenSP varchar(50),
	MaMau varchar(50),
	Gia float,
	SoLuong float ,
	MaHangSX varchar(50),
	ThoiGianBH varchar(50),
	GioiThieu varchar(500),
	MaAnh varchar(50),
	Anh varchar(50),
	FOREIGN KEY (MaMau) REFERENCES tMauSac(MaMau),
	FOREIGN KEY (MaHangSX) REFERENCES tHangSX(MaHangSX)
);
CREATE TABLE tAnhSP (
	MaSP varchar(50) not null,
	TenFileAnh varchar(100) not null,
	CONSTRAINT PK_tAnhSP PRIMARY KEY CLUSTERED (MaSP, TenFileAnh)

);
