USE [66bit_Burse]
GO

/****** Object:  Table [dbo].[BurseTransactions]    Script Date: 08.11.2016 15:31:34 ******/
DROP TABLE [dbo].[BurseTransactions]
GO

/****** Object:  Table [dbo].[BurseTransactions]    Script Date: 08.11.2016 15:31:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BurseTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CompleteDate] [datetimeoffset](7) NULL,
	[NumbersToTransaction] [bigint] NULL,
	[TransactionPrice] [decimal](15, 2) NULL,
	[BuyDate] [datetimeoffset](7) NULL,
	[SellDate] [datetimeoffset](7) NULL,
	[BuyComment] [nvarchar](4000) NULL,
	[SellComment] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


