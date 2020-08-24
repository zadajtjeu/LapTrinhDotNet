use master
go
if(exists(select * from sysdatabases where name='QLSACH'))
	drop database QLSACH
go

/* Cau 1 */
-- create database
use master
go
create database QLSACH
go

use QLSACH
go
-- create table
create table TG(
	MaTG nvarchar(10) not null primary key,
	TenTG nvarchar(30) not null
)
create table Sach(
	Masach nvarchar(10) not null primary key,
	tensach nvarchar(30) not null,
	slco int default 0,
	MaTG nvarchar(10) not null,
	ngayxb date,
	constraint Sach_TG foreign key(MaTG) references TG(MaTG)
)

go

-- insert data
insert into TG values('TG1', N'Tô Hoài'), ('TG2', N'Nguyễn Nhật Ánh')
go
insert into Sach values('H001', N'Dế mèn phưu lưu ký', 54, 'TG1', '02-21-2019'),
						('H002', N'Vợ chồng A Phủ', 100, 'TG1', '06-05-2018'),
						('H003', N'Cô gái đến từ hôm qua', 66, 'TG2', '05-12-2017'),
						('H004', N'Mắt biếc', 150, 'TG2', '12-16-2017'),
						('H005', N'Làm bạn với bầu trời', 22, 'TG2', '01-30-2018')
go