CREATE PROCEDURE [dbo].[EliminarProducto]
@Codigo int
AS
UPDATE  dbo.productos
SET    dbo.productos.Estado = 0
WHERE dbo.productos.id_producto	= @Codigo	

SELECT 'OK'