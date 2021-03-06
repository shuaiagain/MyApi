USE [demo2]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2021.03.11 17:12:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](20) NULL,
	[Sex] [bit] NOT NULL,
 CONSTRAINT [PK__Student__32C52B9955C5680D] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (1, N'aa', 0)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (2, N'bb', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (3, N'cc', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (4, N'dd', 0)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (5, N'ee', 0)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (6, N'gg', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (7, N'hh', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (8, N'ff', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (9, N'1', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (29, N'name9', 1)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Sex]) VALUES (58, N'name29', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
