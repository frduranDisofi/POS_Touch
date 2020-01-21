Create proc FamiliaProducto_Grabar
@Familia nvarchar(50)
as
begin
insert into FamiliaProducto 
(Familia)
values
(@Familia)

declare @Id int
select @Id=0

select @Id=max(CodigoFamilia) from FamiliaProducto

select @Id
end