USE [demo2]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 2021.03.11 17:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](50) NULL,
 CONSTRAINT [PK__Subjects__AC1BA3A84C9ADFD6] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectId], [SubjectName]) VALUES (1, N'语文')
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName]) VALUES (2, N'数学')
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName]) VALUES (3, N'英语')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
