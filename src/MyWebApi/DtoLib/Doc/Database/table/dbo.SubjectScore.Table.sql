USE [demo2]
GO
/****** Object:  Table [dbo].[SubjectScore]    Script Date: 2021.03.11 17:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectScore](
	[SubjectId] [int] NULL,
	[StudentId] [int] NULL,
	[Score] [decimal](4, 2) NULL,
	[SubjectScoreId] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectScoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SubjectScore] ON 

INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (1, 1, CAST(60.00 AS Decimal(4, 2)), 1)
INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (1, 2, CAST(70.00 AS Decimal(4, 2)), 2)
INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (1, 3, CAST(80.00 AS Decimal(4, 2)), 3)
INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (2, 1, CAST(66.00 AS Decimal(4, 2)), 4)
INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (3, 1, CAST(77.00 AS Decimal(4, 2)), 5)
INSERT [dbo].[SubjectScore] ([SubjectId], [StudentId], [Score], [SubjectScoreId]) VALUES (2, 2, CAST(80.00 AS Decimal(4, 2)), 6)
SET IDENTITY_INSERT [dbo].[SubjectScore] OFF
