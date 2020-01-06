USE [delivery]
GO

/****** Object:  StoredProcedure [dbo].[RptCerrarCaja]    Script Date: 14-11-2019 0:08:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RptCerrarCaja]
@IdUsuario int,
@IdCaja int
AS

SELECT Id,Accion,Id_Usuario,Monto,Fecha,Glosa,(SELECT isnull(sum(monto),0) FROM dbo.RetiroCaja rc WHERE Id_Usuario=@IdUsuario AND IdCaja=@IdCaja) MontoRetiro
 FROM caja WHERE id = @IdCaja AND Id_Usuario = @IdUsuario

SELECT        
isnull(cd.id_doc,0) AS id_doc, 
isnull(cd.forma_pago,'') AS forma_pago, 
isnull(cd.fecha_emision,'') AS fecha_emision, 
isnull(cd.total,0) AS total, 
isnull(cd.efectivo,0) AS efectivo, 
isnull(usuarios.usuario,'') AS usuarios, 
isnull(cd.IdCaja,0) AS IdCaja

FROM            cabecera_doc AS cd LEFT OUTER JOIN
                         usuarios ON cd.IdUsuario = usuarios.id
WHERE cd.IdCaja=@IdCaja AND cd.IdUsuario=@IdUsuario

SELECT 
isnull(rc.Id,0) AS Id, 
isnull(rc.IdUsuario,0) AS IdUsuario, 
isnull(rc.Monto,0) AS Monto, 
isnull(rc.Glosa,'') AS Glosa, 
isnull(rc.IdCaja,0) AS IdCaja 

FROM dbo.RetiroCaja rc WHERE rc.IdCaja=@IdCaja AND rc.IdUsuario=@IdUsuario

GO


