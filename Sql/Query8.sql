create proc sp_UpdateNhanVien @manv nchar(10),@hoten nvarchar(50),@gioitinh bit,@ngaysinh datetime,@diachi nvarchar(50),@hinhanh image, @madv nchar(10)
as
begin
update NHANVIEN set HOTEN = @hoten , GIOITINH = @gioitinh, NGAYSINH = @ngaysinh , DIACHI = @diachi , HINHANH = @hinhanh , MADV = @madv 
where MANV = @manv;
end