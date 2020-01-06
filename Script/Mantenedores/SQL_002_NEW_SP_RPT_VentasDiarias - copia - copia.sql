USE [delivery]
GO

/****** Object:  StoredProcedure [dbo].[Get_VentasDiarias]    Script Date: 12-10-2019 22:08:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Get_VentasDiarias]
@fecha_ini datetime,
@fecha_fin datetime
AS
SELECT a.id_doc, a.forma_pago, a.fecha_emision, d.descripcion, a.total, 
a.efectivo
FROM            cabecera_doc AS a LEFT OUTER JOIN
                         detalle AS d ON a.id_doc = d.id_doc_cab
WHERE        (a.fecha_emision >= @fecha_ini) AND (a.fecha_emision <= @fecha_fin)
GO

