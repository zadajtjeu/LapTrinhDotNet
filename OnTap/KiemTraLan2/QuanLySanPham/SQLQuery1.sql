use master
go
if(exists(select * from sysdatabases where name = 'QLSP'))
	drop database QLSP
go

use master
go
create database QLSP
go

use QLSP
go


create table DanhMucSanPham(
	MaDM nchar(10) not null primary key,
	TenDM nvarchar(50)
)

create table SanPham(
	MaSP nchar(10) not null primary key,
	TenSP nvarchar(50),
	DonGia money,
	SoLuong int,
	MaDM nchar(10) not null references DanhMucSanPham(MaDM)
)

go


insert into DanhMucSanPham values
('DM1', N'Hàng điện tử'), 
('DM2', N'Hàng gia dụng'),
('DM3', N'Điện thoại - Laptop')

insert into SanPham values
('SP1', N'Android TV Sony 4K', 12000000, 12, 'DM1'),
('SP2', N'Dàn âm thanh SONY 0zz', 8900000, 10, 'DM1'),
('SP3', N'Micro có dây ACNOS', 149000, 20, 'DM1'),
('SP4', N'Samsung Galaxy Note 2', 30000000, 20, 'DM3'),
('SP5', N'Laptop Dell Inspiron 3590', 11000000, 10, 'DM3'),
('SP6', N'Samsung Galaxy Tab A Plus', 5000000, 21, 'DM3'),
('SP7', N'Nồi cơm điện SHARP', 349000, 30, 'DM2'),
('SP8', N'Điều Hòa Boss', 4000000, 25, 'DM2'),
('SP9', N'Quạt cây YANFAN', 2690000, 25, 'DM2'),
('SP10', N'Bếp ga DUXTON DG-795', 1300000, 12, 'DM2'),
('SP11', N'Lò vi sóng SHARP', 1100000, 52, 'DM2'),
('SP12', N'Máy xay sinh tố SUNHOUSE', 299000, 41, 'DM2')
go

select MaSP, TenSP, DonGia, SoLuong, TenDM from SanPham
inner join DanhMucSanPham on DanhMucSanPham.MaDM = SanPham.MaDM
go