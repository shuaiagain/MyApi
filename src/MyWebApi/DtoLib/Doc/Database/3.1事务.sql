--����3
SET XACT_ABORT OFF
BEGIN TRANSACTION 
--BEGIN TRY
	
	DECLARE @Name VARCHAR(20)
	SET @Name = 'name'+( SELECT CAST(MAX(st.StudentId)AS VARCHAR)  FROM dbo.Student st)
	--����������
	INSERT INTO dbo.Student(StudentName,Sex )VALUES(@Name,1)
	
	--������������--sex����Ϊ��--���Իᱨ��
	INSERT INTO dbo.Student(StudentName,Sex )VALUES('jj',NULL)

--END TRY 
--BEGIN CATCH
		
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
	--IF(@@TRANCOUNT>0)
	--	ROLLBACK TRANSACTION
--END CATCH
COMMIT TRANSACTION

SELECT * FROM dbo.Student