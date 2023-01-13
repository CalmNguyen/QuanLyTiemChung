create database QuanLytiemChung;

use QuanLyTiemChung;

create table LichLamViec(
	MaNV varchar(10),
	Ngay Date,
	Ca nvarchar(10),
	constraint PK_LichLamViec primary key (MaNV, Ngay, Ca)
);

create table LichRanh(
	MaNV varchar(10),
	Ngay Date,
	Ca nvarchar(10),
	constraint PK_LichRanh primary key (MaNV, Ngay, Ca)
);

create table NhanVien(
	MaNV varchar(10),
	Password varchar(20),
	NgaySinh Date,
	ViTri nvarchar(20),
	BangCap nvarchar(20),
	DiaChi nvarchar(50),
	Phone varchar(10),
	Email varchar(50),
	Luong float,
	TrungTam nvarchar(50)
	constraint PK_NhanVien primary key (MaNV)
);

create table PhieuDangKy(
	MaPDK varchar(10),
	NgayLap Date,
	GoiVaccine varchar(10),
	NgayTiem Date,
	NVGhiNhan varchar(10),
	MaKH varchar(10)
	constraint PK_PhieuDangKy primary key (MaPDK)
);



create table HoaDonThanhToan(
	MaHDTT varchar(10),
	MaPDK varchar(10),
	NgayLap date,
	LoaiThanhToan nvarchar(50),
	SoDotThanhToan int,
	NgayThanhToanTiepTheo date,
	ThanhTienMoiDot float,
	PhuongThucGuiTien nvarchar(50),
	TongTien float,
	TongTienDaThanhToan float,
	KhachHang varchar(10),
	constraint PK_HoaDonThanhToan primary key (MaHDTT)
);

create table KhachHang(
	MaKH varchar(10),
	HoTenKH nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(50),
	SDT varchar(10),
	constraint PK_KhachHang primary key (MaKH)
);

create table XacNhanThanhToan(
	MaXNTT varchar(10),
	MaHDTT varchar(10),
	DotThanhToan int,
	ThanhTien float,
	NgayThanhToan date,
	NgayThanhToanTiepTheo date,
	TongTienChuaTT float,
	constraint PK_XacNhanThanhToan primary key (MaXNTT)
);

create table TreEm(
	MaKH varchar(10),
	HoTenNguoiGiamHo nvarchar(50),
	QuanHe nvarchar(50),
	SDTNguoiGiamHo varchar(10),
	constraint PK_TreEm primary key (MaKH)
);



create table DanhSachDatMuaVaccine(
	MaKH varchar(10),
	TenVaccine nvarchar(50),
	SoLuong int,
	DuocDuyet nvarchar(50),
	MaPDH varchar(10)
	constraint PK_DanhSachDatMuaVaccine primary key (MaKH)
);




create table PhieuDatHang(
	MaPDH varchar(10),
	NgayLap date,
	NgayGui date,
	NhaCungCap nvarchar(50),
	TongSoLuongDatMua int,
	TenVaccine nvarchar(50),
	constraint PK_PhieuDatHang primary key (MaPDH)
);

CREATE TABLE DanhSachCacGoiTiem (
	MaGoiVaccine VARCHAR(10),
	TenVaccine NVARCHAR(50),
	GhiChu NVARCHAR(50)
	CONSTRAINT PK_DanhSachVaccine PRIMARY KEY (MaGoiVaccine)
);

--foreign key

alter table LichLamViec
add constraint fk_LichLamViec_NhanVien foreign key (MaNV) references NhanVien(MaNV)
on delete no action;

alter table LichRanh 
add constraint fk_LichRanh_NhanVien foreign key (MaNV) references NhanVien(MaNV)
on delete no action;

alter table PhieuDangKy
add constraint fk_PhieuDangKy_NhanVien foreign key (NVGhiNhan) references NhanVien(MaNV)
on delete no action;

alter table PhieuDangKy
add constraint fk_PhieuDangKy_KhachHang foreign key (MaKH) references KhachHang(MaKH)
on delete no action;

alter table PhieuDangKy
add constraint fk_PhieuDangKy_DanhSachCacGoiTiem foreign key (GoiVaccine) references DanhSachCacGoiTiem(MaGoiVaccine)
on delete no action;


alter table HoaDonThanhToan
add constraint fk_HoaDonThanhToan_PhieuDangKy foreign key (MaPDK) references PhieuDangKy(MaPDK)
on delete no action;

alter table HoaDonThanhToan
add constraint fk_HoaDonThanhToan_KhachHang foreign key (KhachHang) references KhachHang(MaKH)
on delete no action;


alter table XacNhanThanhToan
add constraint fk_XacNhanThanhToan_HoaDonThanhToan foreign key (MaHDTT) references HoaDonThanhToan(MaHDTT)
on delete no action;

alter table TreEm
add constraint fk_TreEm_KhachHang foreign key (MaKH) references KhachHang(MaKH)
on delete no action;

alter table DanhSachDatMuaVaccine
add constraint fk_DanhSachDatMuaVaccine_KhachHang foreign key (MaKH) references KhachHang(MaKH)
on delete no action;


alter table DanhSachDatMuaVaccine
add constraint fk_DanhSachDatMuaVaccine_PhieuDatHang foreign key (MaPDH) references PhieuDatHang(MaPDH)
on delete no action;

--data
insert into NhanVien(MaNV, Password, NgaySinh, ViTri, BangCap, DiaChi, Phone, Email, Luong, TrungTam) values ('NV000001', 'thai2001', '28-03-2001', N'Tiep tan', N'Đại học', N'Quận Gò Vấp - TP HCM','0342999555', 'fdasfd@gmail.com', 5000000, N'Trung Tâm 1');
insert into NhanVien(MaNV, Password, NgaySinh, ViTri, BangCap, DiaChi, Phone, Email, Luong, TrungTam) values ('NV000002', 'thai2001', '28-03-2001', N'Y/ Bac si', N'Đại học',N'Quận Gò Vấp - TP HCM', '0342992555', 'aa@gmail.com', 10000000, N'Trung Tâm 1');
insert into NhanVien(MaNV, Password, NgaySinh, ViTri, BangCap, DiaChi, Phone, Email, Luong, TrungTam) values ('NV000003', 'thai2001', '28-03-2001', N'Ke toan', N'Đại học',N'Quận Gò Vấp - TP HCM', '0342999255', 'ffsa@gmail.com', 5000000, N'Trung Tâm 1');
insert into NhanVien(MaNV, Password, NgaySinh, ViTri, BangCap, DiaChi, Phone, Email, Luong, TrungTam) values ('NV000004', 'thai2001', '28-03-2001', N'Dieu hanh', N'Đại học',N'Quận Gò Vấp - TP HCM', '0342999655', 'fd123fd@gmail.com', 10000000, N'Trung Tâm 1');
insert into NhanVien(MaNV, Password, NgaySinh, ViTri, BangCap, DiaChi, Phone, Email, Luong, TrungTam) values ('NV000005', 'thai2001', '28-03-2001', N'Quan ly', N'Đại học',N'Quận Gò Vấp - TP HCM', '0342999515', 'fda321@gmail.com', 20000000, N'Trung Tâm 1');

insert into LichLamViec(MaNV, Ngay, Ca) values ('NV000001' , '2022-06-13', N'Tối');
insert into LichLamViec(MaNV, Ngay, Ca) values ('NV000001' , '2022-06-14', N'Sáng');
insert into LichLamViec(MaNV, Ngay, Ca) values ('NV000002' , '2022-06-13', N'Tối');
insert into LichLamViec(MaNV, Ngay, Ca) values ('NV000002' , '2022-06-13', N'Chiều');

insert into LichRanh(MaNV, Ngay, Ca) values ('NV000001' , '2022-06-16', N'Tối');
insert into LichRanh(MaNV, Ngay, Ca) values ('NV000002' , '2022-06-15', N'Sáng');
insert into LichRanh(MaNV, Ngay, Ca) values ('NV000001' , '2022-06-16', N'Chiều');

INSERT INTO DanhSachCacGoiTiem VALUES ('V01', 'Abdala', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V02', 'Pfizer', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V03', 'Johnson & Johnson', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V04', 'Moderna', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V05', 'AstraZeneca', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V06', 'Sputnik-V', NULL);
INSERT INTO DanhSachCacGoiTiem VALUES ('V07', 'VeroCell', NULL);

insert into KhachHang(MaKH) values('KH1')
insert into KhachHang(MaKH) values('KH2')
insert into KhachHang(MaKH) values('KH3')

insert into DanhSachDatMuaVaccine(MaKH, TenVaccine, SoLuong, DuocDuyet) values ('KH1' , N'VeroCellPlus', 2, N'Chua duoc duyet');
insert into DanhSachDatMuaVaccine(MaKH, TenVaccine, SoLuong, DuocDuyet) values ('KH2' , N'VeroCellPlus', 2, N'Chua duoc duyet');
insert into DanhSachDatMuaVaccine(MaKH, TenVaccine, SoLuong, DuocDuyet) values ('KH3' , N'VeroCellPlus1', 2, N'Chua duoc duyet');


