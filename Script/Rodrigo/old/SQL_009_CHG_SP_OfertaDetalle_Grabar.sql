ALTER procedure OfertaDetalle_Grabar
@Idoferta int,
@Linea int,
@IdProducto int,
@Cantidad int,
@Precio int
as
begin
DECLARE @Articulo nvarchar(80),@Codigo nvarchar(30),@FamiliaId nvarchar(20)
SELECT @Articulo=descripcion_producto,@Codigo=p.codigo,@FamiliaId=p.CodigoFamilia 
FROM dbo.productos p WHERE p.id_producto=@IdProducto

DECLARE @Familia nvarchar(40)
SELECT @Familia=Familia FROM dbo.FamiliaProducto fp WHERE fp.CodigoFamilia=@FamiliaId


INSERT INTO dbo.OfertaDetalle
(   IdOferta, Descripcion_Producto, Precio, Codigo_interno, Codigo, CodigoFamilia, Familia, idproducto,Linea,Cantidad)
VALUES
(   @Idoferta, -- IdOferta - int
    @Articulo, -- Descripcion_Producto - nvarchar
    @Precio, -- Precio - numeric
    '', -- Codigo_interno - nchar
    @Codigo, -- Codigo - nvarchar
    @FamiliaId, -- CodigoFamilia - nvarchar
    @Familia, -- Familia - nvarchar
    @IdProducto, -- idproducto - int
	@Linea,
	@Cantidad
)

select 'OK'
END
