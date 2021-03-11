--Begin Transaction：标记事务开始。
--Commit Transaction：事务已经成功执行，数据已经处理妥当。
--Rollback Transaction：数据处理过程中出错，回滚到没有处理之前的数据状态，或回滚到事务内部的保存点。
--Save Transaction：事务内部设置的保存点，就是事务可以不全部回滚，只回滚到这里，保证事务内部不出错的前提下。


SELECT * FROM dbo.Student
--SELECT * FROM dbo.Subjects
--SELECT * FROM dbo.SubjectScore

--事务1
BEGIN TRANSACTION 
BEGIN TRY
	
	DECLARE @Name VARCHAR(20)
	SET @Name = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--正常的数据
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@Name,1)
	
	--不正常的数据--sex不能为空--所以会报错
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

END TRY 
BEGIN CATCH
		
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
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION

	--IF( @@ERROR > 0)
	--BEGIN
	--	ROLLBACK TRANSACTION
	--END

END CATCH
IF(@@TRANCOUNT>0)
 COMMIT TRANSACTION

--事务2
--事务2
BEGIN TRAN
BEGIN TRY
	
	DECLARE @NameTwo VARCHAR(20)
	SET @NameTwo = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--正常的数据
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@NameTwo,1)
	
	SAVE TRAN SaveTranOne
	
	--不正常的数据--sex不能为空--所以会报错
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

	--不正常的数据--sex不能为空--所以会报错
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('mm',0)

END TRY
BEGIN CATCH
 SELECT ERROR_NUMBER() AS ErrorNumber,
		ERROR_SEVERITY() AS ErrorSeverity,
		ERROR_STATE()AS ErrorState,
		ERROR_LINE() AS ErrorLine,
		ERROR_MESSAGE() AS ErrorMessage

	IF(@@TRANCOUNT>0)
		ROLLBACK TRAN SaveTranOne

END CATCH
PRINT(@@TRANCOUNT)
IF(@@TRANCOUNT>0)
	COMMIT TRAN

SELECT * FROM dbo.Student