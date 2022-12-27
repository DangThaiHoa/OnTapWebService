create proc sp_UpdateDonVi @madv nchar(10),@tendv nvarchar(50)
as
begin
update DONVI set TENDV = @tendv
where MADV = @madv;
end