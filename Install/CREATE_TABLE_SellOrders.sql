USE [66bit_Burse]
GO

/****** Object:  Table [dbo].[SellOrders]    Script Date: 08.11.2016 15:29:56 ******/
DROP TABLE [dbo].[SellOrders]
GO

/****** Object:  Table [dbo].[SellOrders]    Script Date: 08.11.2016 15:29:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SellOrders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SellDate] [datetimeoffset](7) NULL,
	[SellPrice] [decimal](15, 2) NULL,
	[NumbersToSell] [bigint] NULL,
	[SellComment] [nvarchar](4000) NULL,
 CONSTRAINT [PK_SellOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


