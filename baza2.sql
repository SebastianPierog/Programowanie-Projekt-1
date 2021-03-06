USE [dbPizza]
GO
/****** Object:  Table [dbo].[Pizze]    Script Date: 03.06.2020 08:53:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizze](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa Pizzy] [nvarchar](50) NULL,
	[Ilosc] [varchar](50) NULL,
	[Cena Jednostkowa] [varchar](50) NULL,
	[Składniki] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pizze] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
