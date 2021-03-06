ALTER PROCEDURE Rpt_Boleta
@idventa int,
@Tipo nvarchar(20)
AS
BEGIN
if @Tipo='ImprimeBoleta'
begin
	SELECT        cabecera_doc.id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, d.descripcion, d.precio, d.total AS totaldetalle, d.cantidad, FolioBoleta.FolioBoleta, FolioBoleta.IdUsuario
	FROM            FolioBoleta RIGHT OUTER JOIN
							 cabecera_doc ON FolioBoleta.NroTicket = cabecera_doc.id_doc LEFT OUTER JOIN
							 detalle AS d ON cabecera_doc.id_doc = d.id_doc_cab
	WHERE        (FolioBoleta.FolioBoleta = @idventa)
end
else
begin
	SELECT        cabecera_doc.id_doc, cabecera_doc.forma_pago, cabecera_doc.fecha_emision, cabecera_doc.total, d.descripcion, d.precio, d.total AS totaldetalle, d.cantidad, FolioBoleta.FolioBoleta, FolioBoleta.IdUsuario
	FROM            FolioBoleta RIGHT OUTER JOIN
							 cabecera_doc ON FolioBoleta.NroTicket = cabecera_doc.id_doc LEFT OUTER JOIN
							 detalle AS d ON cabecera_doc.id_doc = d.id_doc_cab
	WHERE        (cabecera_doc.id_doc = @idventa)
end

declare @RUTEmpresa varchar(10)
declare @comuna varchar(300)
declare @DirOrigen  varchar(200)
declare @RznSoc varchar(200)
declare @Giro varchar(200)

select @RutEmpresa=valor_param from parametros where nombre_param='RUTEmpresa'
select @comuna=valor_param from parametros where nombre_param='ComunaOrigen'
select @DirOrigen=valor_param from parametros where nombre_param='DirOrigen'
select @RznSoc=valor_param from parametros where nombre_param='RznSoc'
select @Giro=valor_param from parametros where nombre_param='Giro'

select @RUTEmpresa as RUTEmpresa,
@RznSoc as RznSoc,
@Giro as Giro,
@DirOrigen as  Direccion,
@comuna as Comuna

end
