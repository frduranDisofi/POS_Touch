create procedure RPT_FormaPago
@FechaIni datetime,
@FechaFin datetime,
@Tipo int
as
--Tipo 1 Delivery, 2 Tarjeta, 3 Cantado, 4 Todos
begin
If @Tipo=1
SELECT ISNULL(FolioBoleta.FolioBoleta, 0) AS id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, 
       cabecera_doc.efectivo, FamiliaProducto.Familia, usuarios.usuario, detalle.descripcion Producto
FROM   usuarios RIGHT OUTER JOIN
       cabecera_doc LEFT OUTER JOIN
       FolioBoleta ON cabecera_doc.id_doc = FolioBoleta.NroTicket ON usuarios.id = cabecera_doc.IdUsuario LEFT OUTER JOIN
       detalle ON cabecera_doc.id_doc = detalle.id_doc_cab LEFT OUTER JOIN
       FamiliaProducto RIGHT OUTER JOIN
       productos ON FamiliaProducto.CodigoFamilia = productos.CodigoFamilia ON detalle.codigo = productos.id_producto
WHERE  (cabecera_doc.Eliminado = 0) and (cabecera_doc.fecha_emision>=@FechaIni) and 
       (cabecera_doc.fecha_emision<=@FechaFin) and (cabecera_doc.forma_pago='Delivery')

If @Tipo=2
SELECT ISNULL(FolioBoleta.FolioBoleta, 0) AS id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, 
       cabecera_doc.efectivo, FamiliaProducto.Familia, usuarios.usuario, detalle.descripcion Producto
FROM   usuarios RIGHT OUTER JOIN
       cabecera_doc LEFT OUTER JOIN
       FolioBoleta ON cabecera_doc.id_doc = FolioBoleta.NroTicket ON usuarios.id = cabecera_doc.IdUsuario LEFT OUTER JOIN
       detalle ON cabecera_doc.id_doc = detalle.id_doc_cab LEFT OUTER JOIN
       FamiliaProducto RIGHT OUTER JOIN
       productos ON FamiliaProducto.CodigoFamilia = productos.CodigoFamilia ON detalle.codigo = productos.id_producto
WHERE  (cabecera_doc.Eliminado = 0) and (cabecera_doc.fecha_emision>=@FechaIni) and 
       (cabecera_doc.fecha_emision<=@FechaFin) and (cabecera_doc.forma_pago='Tarjeta')
       
If @Tipo=3
SELECT ISNULL(FolioBoleta.FolioBoleta, 0) AS id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, 
       cabecera_doc.efectivo, FamiliaProducto.Familia, usuarios.usuario, detalle.descripcion Producto
FROM   usuarios RIGHT OUTER JOIN
       cabecera_doc LEFT OUTER JOIN
       FolioBoleta ON cabecera_doc.id_doc = FolioBoleta.NroTicket ON usuarios.id = cabecera_doc.IdUsuario LEFT OUTER JOIN
       detalle ON cabecera_doc.id_doc = detalle.id_doc_cab LEFT OUTER JOIN
       FamiliaProducto RIGHT OUTER JOIN
       productos ON FamiliaProducto.CodigoFamilia = productos.CodigoFamilia ON detalle.codigo = productos.id_producto
WHERE  (cabecera_doc.Eliminado = 0) and (cabecera_doc.fecha_emision>=@FechaIni) and 
       (cabecera_doc.fecha_emision<=@FechaFin) and (cabecera_doc.forma_pago='Contado')
       
If @Tipo=4
SELECT ISNULL(FolioBoleta.FolioBoleta, 0) AS id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, 
       cabecera_doc.efectivo, FamiliaProducto.Familia, usuarios.usuario, detalle.descripcion Producto
FROM   usuarios RIGHT OUTER JOIN
       cabecera_doc LEFT OUTER JOIN
       FolioBoleta ON cabecera_doc.id_doc = FolioBoleta.NroTicket ON usuarios.id = cabecera_doc.IdUsuario LEFT OUTER JOIN
       detalle ON cabecera_doc.id_doc = detalle.id_doc_cab LEFT OUTER JOIN
       FamiliaProducto RIGHT OUTER JOIN
       productos ON FamiliaProducto.CodigoFamilia = productos.CodigoFamilia ON detalle.codigo = productos.id_producto
WHERE  (cabecera_doc.Eliminado = 0) and (cabecera_doc.fecha_emision>=@FechaIni) and 
       (cabecera_doc.fecha_emision<=@FechaFin)
       
end
