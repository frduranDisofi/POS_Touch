ALTER procedure GetFamiliaProducto
as
begin
SELECT FamiliaProducto.CodigoFamilia, FamiliaProducto.Familia, 
       isnull(FamiliaFoto.FotoNombre,'SinFoto.JPG')FotoNombre
FROM   FamiliaProducto LEFT OUTER JOIN
       FamiliaFoto ON FamiliaProducto.CodigoFamilia = FamiliaFoto.FamiliaId
ORDER BY FamiliaProducto.Familia
end	