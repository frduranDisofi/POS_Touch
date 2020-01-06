create procedure RPT_Productos
as
begin

SELECT     productos.id_producto, productos.descripcion_producto, productos.precio, productos.codigo_interno, productos.codigo, FamiliaProducto.Familia
FROM         productos INNER JOIN
                      FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia
                      
end