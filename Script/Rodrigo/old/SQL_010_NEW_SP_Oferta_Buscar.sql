CREATE PROCEDURE Oferta_Buscar
@Id int
AS
BEGIN
SELECT        o.CodigoOferta, o.NombreOferta, o.PrecioOferta, o.idOferta, o.Activo, od.IdDetalleOferta, od.Descripcion_Producto, od.Precio, 
                         od.Codigo_interno, od.Codigo, od.CodigoFamilia, od.Familia, od.idproducto, od.Linea, od.Cantidad
FROM            Oferta AS o LEFT OUTER JOIN
                         OfertaDetalle AS od ON o.idOferta = od.IdOferta
WHERE        (o.idOferta = @Id)
END
