USE Myschool
GO

SELECT Rent.*,RentClient.RentName as ����
INTO #NET
FROM Rent,RentClient
WHERE Rent.RentId = RentClient.RentId
SELECT * FROM #NET
SELECT TOP 5 * from #NET where ID between 6 and 10
DROP TABLE #NET
GO

SELECT RentClient.RentName as ����,Rent.����,Rent.�ֵ�,Rent.����,Rent.�۸� INTO #NET
FROM Rent,RentClient
SELECT * FROM #NET where ���� = '����'
DROP TABLE #NET
GO

SELECT RentClient.RentName as ����,Rent.����,Rent.�ֵ�,Rent.����,Rent.�۸� INTO #NET
FROM Rent,RentClient
SELECT ����,COUNT(�ֵ�) �ֵ����� FROM #NET group by ���� having COUNT(�ֵ�) > 1
DROP TABLE #NET
GO



SELECT Rent.ʱ��,RentClient.RentName as ����,Rent.����,Rent.�ֵ�,Rent.����,Rent.�۸�,���� = 1
INTO #NET
FROM Rent,RentClient

INSERT INTO #NET VALUES('2009-1-2','�ϼ�',null,null,null,null,(SELECT COUNT(����) from #NET where ʱ�� between '2009-1-1' and '2009-3-31'))
INSERT INTO #NET VALUES('2009-5-1','�ϼ�',null,null,null,null,(SELECT COUNT(����) from #NET where ʱ�� between '2009-4-1' and '2009-6-30'))
INSERT INTO #NET VALUES('2009-8-1','�ϼ�',null,null,null,null,(SELECT COUNT(����) from #NET where ʱ�� between '2009-7-1' and '2009-9-30'))
INSERT INTO #NET VALUES('2009-12-1','�ϼ�',null,null,null,null,(SELECT COUNT(����) from #NET where ʱ�� between '2009-10-1' and '2009-12-31'))

SELECT ���� = case
when ʱ�� between '2009-1-1' and '2009-3-31' then 1
when ʱ�� between '2009-4-1' and '2009-6-30' then 2
when ʱ�� between '2009-7-1' and '2009-9-30' then 3
when ʱ�� between '2009-10-1' and '2009-12-31' then 4
else '0'
END
,����,����,�ֵ�,����,�۸�,����
FROM #NET
order by ����,����



DROP TABLE #NET
GO