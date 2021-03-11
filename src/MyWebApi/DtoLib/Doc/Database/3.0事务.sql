--Begin Transaction���������ʼ��
--Commit Transaction�������Ѿ��ɹ�ִ�У������Ѿ������׵���
--Rollback Transaction�����ݴ�������г����ع���û�д���֮ǰ������״̬����ع��������ڲ��ı���㡣
--Save Transaction�������ڲ����õı���㣬����������Բ�ȫ���ع���ֻ�ع��������֤�����ڲ��������ǰ���¡�


SELECT * FROM dbo.Student
--SELECT * FROM dbo.Subjects
--SELECT * FROM dbo.SubjectScore

--����1
BEGIN TRANSACTION 
BEGIN TRY
	
	DECLARE @Name VARCHAR(20)
	SET @Name = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--����������
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@Name,1)
	
	--������������--sex����Ϊ��--���Իᱨ��
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

END TRY 
BEGIN CATCH
		
	SELECT 
		--�������
		ERROR_NUMBER() AS ErrorNumber,
		--�������ؼ��𣬼���С��10 try catch ���񲻵�
		ERROR_SEVERITY() AS ErrorSeverity,
		--����״̬��
		ERROR_STATE() AS ErrorState,
		--���ִ���Ĵ洢���̻򴥷�������
		ERROR_PROCEDURE() AS ErrorProcedure,
		--����������
		ERROR_LINE() AS ErrorLine,
		--����ľ�����Ϣ
		ERROR_MESSAGE() AS ErrorMessage
	--��������ֵ+1�������ж��Ƿ����������
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION

	--IF( @@ERROR > 0)
	--BEGIN
	--	ROLLBACK TRANSACTION
	--END

END CATCH
IF(@@TRANCOUNT>0)
 COMMIT TRANSACTION

--����2
--����2
BEGIN TRAN
BEGIN TRY
	
	DECLARE @NameTwo VARCHAR(20)
	SET @NameTwo = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--����������
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@NameTwo,1)
	
	SAVE TRAN SaveTranOne
	
	--������������--sex����Ϊ��--���Իᱨ��
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

	--������������--sex����Ϊ��--���Իᱨ��
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