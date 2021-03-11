BEGIN
	--inner join
	SELECT
		sl.StockLogId,
		slp.StockLogId
	FROM JM_System.dbo.St_StockLog sl
	INNER JOIN JM_System.dbo.St_StockLogPrice slp ON slp.StockLogId = sl.StockLogId
	WHERE 1=1
	--left-join
	SELECT
		sl.StockLogId,
		slp.StockLogId
	FROM JM_System.dbo.St_StockLog sl
	LEFT JOIN JM_System.dbo.St_StockLogPrice slp ON slp.StockLogId = sl.StockLogId
	WHERE 1=1
	--right-join
	SELECT
		sl.StockLogId,
		slp.StockLogId
	FROM JM_System.dbo.St_StockLogPrice sl
	RIGHT JOIN JM_System.dbo.St_StockLog slp ON slp.StockLogId = sl.StockLogId
	WHERE 1=1
	--full-join-�����ű�������Ӳ�ѯʱ�����������ұ�������û��ƥ�����
	SELECT
		sl.StockLogId,
		slp.StockLogId
	FROM JM_System.dbo.St_StockLogPrice sl
	FULL JOIN JM_System.dbo.St_StockLog slp ON slp.StockLogId = sl.StockLogId
	WHERE 1=1
	--��������
	SELECT
		sl.StockLogId,
		slp.StockLogId
	FROM JM_System.dbo.St_StockLogPrice sl,JM_System.dbo.St_StockLog slp
	WHERE 1=1
END


--union--union-all
--union--union-all
--union
SELECT 1 AS a,
	   2 AS b,
	   3 AS c
UNION 
SELECT 1 AS a,
       2 AS c,
	   3 AS d
--union-all--�����ظ���������
SELECT 1 AS a,
	   2 AS b,
	   3 AS c
UNION ALL
SELECT 1 AS a,
       2 AS c,
	   3 AS d
--�����

SELECT
	--ROW_NUMBER()OVER(ORDER BY sl.StockLogId)AS Row_Num,
	ROW_NUMBER()OVER(ORDER BY sl.StockId) RowNum,
	sl.StockId,
	sl.StockLogId
INTO #TempA
FROM JM_System.dbo.St_StockLog sl
WHERE 1=1
ORDER BY sl.StockLogId

SELECT * FROM #TempA  te
WHERE 1=1
ORDER BY te.RowNum

