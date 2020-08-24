use master
go

if(exists(select * from sysdatabases where name='QLNV'))
	drop database QLNV
go

-- A.create database
USE MASTER
GO
create database QLNV

go

--B.create table
USE QLNV
GO
create table tblChucvu(
	MaCV nvarchar(2) not null primary key,
	TenCV nvarchar(30)
)

create table tblNhanVien(
	MaNV nvarchar(4) not null primary key,
	MaCV nvarchar(2),
	TenNV nvarchar(30),
	NgaySinh datetime,
	LuongCanBan float,
	NgayCong int,
	PhuCap float,
	constraint fk_NV_CV foreign key(MaCV) references tblChucVu(MaCV)
)

go
--C. insert data
insert into tblChucVu values ('BV',N'Bảo Vệ'), ('GD',N'Giám Đốc'),
							('HC',N'Hành Chính'), ('KT',N'Kế Toán'),
							('TQ',N'Thủ Quỹ'), ('VS',N'Vệ Sinh')
insert into tblNhanVien values ('NV01', 'GD', N'Nguyễn Văn An', '12/12/1977 12:00:00', 700000, 25, 500000),
								('NV02', 'BV', N'Bùi Văn Tí', '10/10/1978 12:00:00', 400000, 24, 100000),
								('NV03', 'KT', N'Trần Thanh Nhật', '9/9/1977 12:00:00', 600000, 26, 400000),
								('NV04', 'VS', N'Nguyễn Thị Út', '10/10/1980 12:00:00', 300000, 26, 300000),
								('NV05', 'HC', N'Lê Thị Hà', '10/10/1979 12:00:00', 500000, 27, 200000)
go

select * from tblChucvu
select * from tblNhanVien

go