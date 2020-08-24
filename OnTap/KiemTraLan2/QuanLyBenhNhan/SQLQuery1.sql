use master
go
create database QLBenhNhan
go

use QLBenhNhan
go
/* CSDL Quản Lý Bệnh Nhân BV x*
KhoaKham(MaKhoa, TenKhoa)
BenhNhan(MaBN, HoTen, NgaySinh, GioiTinh, MaBHXH, MaKhoa)
*/

create table KhoaKham(
	MaKhoa nchar(10) not null primary key,
	TenKhoa nvarchar(50)
)
create table BenhNhan(
	MaBN nchar(10) not null primary key,
	HoTen nvarchar(50),
	NgaySinh DateTime,
	GioiTinh bit,
	MaBHXH nvarchar(15),
	MaKhoa nchar(10) not null references KhoaKham(MaKhoa)
)

go

insert into KhoaKham values
('K1', N'Huyết học và truyền máu'),
('K2', N'Khoa Sản'),
('K3', N'Bệnh Nhiệt đới'),
('K4', N'Khoa Nội'),
('K5', N'Khoa Nhi')
insert into BenhNhan values
('BN1', N'Nguyễn Quang Đại', '12/22/1987', 1, 'SV4013420877169', 'K1'),
('BN2', N'Hà Thị Liên', '01/13/1997', 0, 'SV4013420877169', 'K2'),
('BN3', N'Lê Quang Triều', '01/30/2016', 1, 'SV4013420877169', 'K5'),
('BN4', N'Đào Bá Thu', '06/15/1992', 0, 'SV4013420877169', 'K2'),
('BN5', N'Phạm Quang Núi', '03/12/2017', 1, 'SV4013420877169', 'K5'),
('BN6', N'Nguyễn Lan Hương', '05/30/1993', 0, 'SV4013420877169', 'K4'),
('BN7', N'Lê Thị Du', '07/29/1997', 0, 'SV4013420877169', 'K3'),
('BN8', N'Hà Vân Anh', '07/08/1995', 0, 'SV4013420877169', 'K3'),
('BN9', N'Nguyễn Thị Tuyết', '11/11/1994', 0, 'SV4013420877169', 'K2')
go