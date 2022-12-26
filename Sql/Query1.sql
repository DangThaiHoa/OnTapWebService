create database qlnv
use qlnv


create table DONVI
(
MADV nchar(10) primary key,
TENDV nvarchar(50)
)

create table NHANVIEN
(
MANV nchar(10) primary key, 
HOTEN nvarchar(50), 
GIOITINH bit, 
NGAYSINH datetime, 
DIACHI nvarchar(50), 
HINHANH image, 
MADV nchar(10),
constraint fk foreign key (MADV) references DONVI(MADV)
)	

insert into DONVI Values('001', N'Phòng Bảo Vệ');
insert into DONVI Values('002', N'Phòng Quản Lý');
insert into DONVI Values('003', N'Phòng Kế Toán');