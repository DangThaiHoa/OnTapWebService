create proc sp_InsertNhanVien @manv nchar(10),@hoten nvarchar(50),@gioitinh bit,@ngaysinh datetime,@diachi nvarchar(50),@hinhanh image, @madv nchar(10)
as
begin
insert into NHANVIEN values(@manv ,@hoten , @gioitinh ,@ngaysinh ,@diachi ,@hinhanh ,@madv)
end