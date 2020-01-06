create PROCEDURE Productos_X_Familia
@IdFamilia int
AS 
BEGIN
SELECT isnull(productos.id_producto,0)id_producto, isnull(productos.descripcion_producto,'')descripcion_producto, 
       isnull(productos.precio, 0)precio,
       isnull(productos.codigo_interno,'')codigo_interno, 
       isnull(productos.codigo,'')codigo, FamiliaProducto.CodigoFamilia AS IdFamilia,          
       FamiliaProducto.Familia
FROM   productos RIGHT OUTER JOIN
       FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia
where  FamiliaProducto.CodigoFamilia=@IdFamilia
END