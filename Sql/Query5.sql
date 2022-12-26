create proc sp_InsertDonVi @madv nchar(10),@tendv nvarchar(50)
as
begin
insert into DONVI values(@madv ,@tendv)
end