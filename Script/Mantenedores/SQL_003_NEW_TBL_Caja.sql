USE [delivery]
GO

/****** Object:  Table [dbo].[Caja]    Script Date: 17-10-2019 0:58:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Caja](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Accion] [varchar](50) NULL,
	[Id_Usuario] [int] NULL,
	[Monto] [int] NULL,
	[Fecha] [datetime] NULL,
	[Glosa] [varchar](100) NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


