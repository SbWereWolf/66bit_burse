USE [66bit_Burse]
GO

/****** Object:  Table [dbo].[BuyOrders]    Script Date: 08.11.2016 15:29:25 ******/
DROP TABLE [dbo].[BuyOrders]
GO

/****** Object:  Table [dbo].[BuyOrders]    Script Date: 08.11.2016 15:29:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BuyOrders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BuyDate] [datetimeoffset](7) NULL,
	[BuyPrice] [decimal](15, 2) NULL,
	[NumbersToBuy] [bigint] NULL,
	[BuyComment] [nvarchar](4000) NULL,
 CONSTRAINT [PK_BuyOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


