use master
go

if(exists(select * from sysdatabases where name='MusicDB'))
	drop database MusicDB
go

use master 
create database MusicDB
go

use MusicDB
go





/* Table 


Artist(ArtistID, ArtistName)
Music(MusicID, MusicTitle, Album, DatePublic, ArtistID)

*/

create table Artist(
	ArtistID nchar(10) not null primary key,
	ArtistName nvarchar(50)
)

create table Music(
	MusicID nchar(10) not null primary key,
	MusicTitle nvarchar(50),
	Album nvarchar(50),
	DatePublic DateTime,
	ArtistID nchar(10) not null references Artist(ArtistID)
)

go

insert into Artist values('CS1', N'Bích Phương'),('CS2', N'Hương Giang'),
('CS3', N'Trúc Nhân'),('CS4', N'Thanh Duy'),('CS5', N'Hồ Quang Hiếu')
insert into Music values('S01', N'Một cú lừa', N'Một cú lừa', '06/22/2020', 'CS1'),
('S02', N'Để Mỵ nói cho mà nghe', N'Hoàng', '02/01/2020', 'CS1'),
('S03', N'EM đã thấy anh cùng người ấy', N'ATENA', '11/19/2019', 'CS2'),
('S04', N'Sáng mắt chưa', N'Sáng mắt chưa', '01/21/2020', 'CS3'),
('S05', N'Tự mình', N'Tự mình', '05/12/2016', 'CS4'),
('S06', N'Hahaha', N'Hahaha', '12/21/2015', 'CS4'),
('S07', N'Con bướm xuân', N'Con bướm xuân', '01/06/2014', 'CS5')
go