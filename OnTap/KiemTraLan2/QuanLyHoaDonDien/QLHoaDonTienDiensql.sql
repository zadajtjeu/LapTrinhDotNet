use master
go
if(exists(select * from sysdatabases where name='QLHoaDonDien'))
	drop database QLHoaDonDien
go

create database QLHoaDonDien
go
use QLHoaDonDien
go
/* Quản lý hóa đơn tiền điện *
HoaDonTienDien(MaHD, MaKH, ChiSoCu, NgayDoCSCu, ChiSoMoi, NgayDoCSMoi)
KhachHang(MaKH, TenKH [,DiaChi, SoHoKhau,...])
*/

create table KhachHang(
	MaKH nchar(10) not null primary key,
	HoTen nvarchar(50)
)
create table HoaDonTienDien(
	MaHD nchar(10) not null primary key,
	MaKH nchar(10) references KhachHang(MaKH),
	ChiSoCu int,
	NgayCu DateTime,
	ChiSoMoi int,
	NgayMoi DateTime
)

go

insert into KhachHang values
('KH1', N'Trần Văn Anh'), ('KH2', N'Trần Văn Em')
insert into HoaDonTienDien values
('D001', 'KH1', 12, '01/01/2020', 190, '02/01/2020'),
('D002', 'KH2', 142, '01/01/2020', 354, '01/30/2020'),
('D003', 'KH1', 190, '02/01/2020', 281, '03/01/2020'),
('D004', 'KH2', 354, '01/30/2020', 465, '03/01/2020')
go