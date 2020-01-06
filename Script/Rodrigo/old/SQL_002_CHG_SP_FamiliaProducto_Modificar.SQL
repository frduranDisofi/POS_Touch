ALTER procedure FamiliaProducto_Modificar
@CodigoFamilia int,
@FamiliaProducto nvarchar(50)
as
begin
update FamiliaProducto
set Familia=@FamiliaProducto
where CodigoFamilia=@CodigoFamilia

delete FamiliaFoto where FamiliaId=@CodigoFamilia
select 'OK'
end