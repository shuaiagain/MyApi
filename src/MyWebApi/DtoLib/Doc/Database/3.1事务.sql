--事务3
SET XACT_ABORT OFF
BEGIN TRANSACTION 
--BEGIN TRY
	
	DECLARE @Name VARCHAR(20)
	SET @Name = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--正常的数据
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@Name,1)
	
	--不正常的数据--sex不能为空--所以会报错
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

--END TRY 
--BEGIN CATCH
		
	SELECT 
		--错误代码
		ERROR_NUMBER() AS ErrorNumber,
		--错误严重级别，级别小于10 try catch 捕获不到
		ERROR_SEVERITY() AS ErrorSeverity,
		--错误状态码
		ERROR_STATE() AS ErrorState,
		--出现错误的存储过程或触发器名称
		ERROR_PROCEDURE() AS ErrorProcedure,
		--发生错误行
		ERROR_LINE() AS ErrorLine,
		--错误的具体消息
		ERROR_MESSAGE() AS ErrorMessage
	--事务开启此值+1，用来判断是否具有事务开启
	--IF(@@TRANCOUNT>0)
	--	ROLLBACK TRANSACTION
--END CATCH
COMMIT TRANSACTION

SELECT * FROM dbo.Student