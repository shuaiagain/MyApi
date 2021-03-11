SELECT
*
FROM demo2.dbo.Student
--
--ALTER TABLE dbo.Student DROP CONSTRAINT PK__Student__32C52B994BF71C95
--ALTER TABLE demo2.dbo.Student DROP COLUMN StudentId
--ALTER TABLE dbo.Student ADD StudentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY
--
INSERT INTO dbo.Student
( StudentName, Sex )
VALUES  ('ee', 0)
--
SELECT
	*
FROM demo2.dbo.Subjects
--
SELECT
	SubjectScoreId,
	*
FROM demo2.dbo.SubjectScore
--
ALTER TABLE dbo.SubjectScore DROP  PK__SubjectS__F2C3CA6F98C23426
ALTER TABLE dbo.SubjectScore DROP COLUMN SubjectScoreId
ALTER TABLE dbo.SubjectScore ADD SubjectScoreId INT IDENTITY(1,1) NOT NULL PRIMARY KEY
exec sp_helpindex SubjectScore

--INSERT INTO dbo.SubjectScore(SubjectId,StudentId,Score )
--VALUES(3,1,77 )

