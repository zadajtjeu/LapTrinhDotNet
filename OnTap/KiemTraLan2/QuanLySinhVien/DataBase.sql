use master
go
if(exists(select * from sysdatabases where name='QLSinhVien'))
	drop database QLSinhVien
go

/* Cau 1 */
-- Create database
use master
go
create database QLSinhVien
go

use QLSinhVien
go
-- create table
create table Khoa(
	MaKhoa nvarchar(10) not null primary key,
	TenKhoa nvarchar(30) not null
)
create table Lop(
	MaLop nvarchar(10) not null primary key,
	TenLop nvarchar(30) not null,
	SiSo int default 0,
	MaKhoa nvarchar(10) not null,
	constraint Lop_Khoa foreign key(MaKhoa) references Khoa(MaKhoa)
)
create table SinhVien(
	MaSV nvarchar(10) not null primary key,
	HoTen nvarchar(30) not null,
	NgaySinh date default '1970-01-01',
	GioiTinh bit default 0,
	MaLop nvarchar(10),
	constraint SinhVien_Lop foreign key(MaLop) references Lop(MaLop)
)

go

-- insert data

insert into Khoa values('CNTT', N'Công Nghệ Thông Tin'), ('OTO', N'Ô Tô')
insert into Lop values('KTPM', N'Kỹ Thuật Phần Mềm', 4, 'CNTT'),
						('OTO1', N'Ô Tô 1', 3, 'OTO')
insert into SinhVien values('SV01', N'Phùng Thế An', '10-22-1996', 0, 'KTPM'),
							('SV02', N'Đào Bá Đạt', '02-02-1997', 0, 'KTPM'),
							('SV03', N'Nghiêm Xuân Nghĩa', '05-12-1996', 0, 'OTO1'),
							('SV04', N'Hoàng Công Lý', '12-30-1996', 0, 'OTO1'),
							('SV05', N'Thế Văn Tài', '01-14-1998', 0, 'KTPM'),
							('SV06', N'Lưu Thị Mỹ Hạnh', '11-01-1995', 1, 'OTO1'),
							('SV07', N'Nguyễn Minh Trang', '06-21-1996', 1, 'KTPM')
go
--test
select * from Khoa
select * from Lop
select * from SinhVien
go
