create procedure GetUltimofolioInterno
as
begin
declare @Ult int
select @ult = max(NroFolio)  from FolioInterno

select @Ult
end
go
create procedure ResetarFolioInterno
as
begin
delete FolioInterno

select 'OK'
end
