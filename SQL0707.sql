USE Myschool
GO

SELECT Rent.*,RentClient.RentName as 户主
INTO #NET
FROM Rent,RentClient
WHERE Rent.RentId = RentClient.RentId
SELECT * FROM #NET
SELECT TOP 5 * from #NET where ID between 6 and 10
DROP TABLE #NET
GO

SELECT RentClient.RentName as 户主,Rent.区县,Rent.街道,Rent.户型,Rent.价格 INTO #NET
FROM Rent,RentClient
SELECT * FROM #NET where 户主 = '张三'
DROP TABLE #NET
GO

SELECT RentClient.RentName as 户主,Rent.区县,Rent.街道,Rent.户型,Rent.价格 INTO #NET
FROM Rent,RentClient
SELECT 区县,COUNT(街道) 街道数量 FROM #NET group by 区县 having COUNT(街道) > 1
DROP TABLE #NET
GO



SELECT Rent.时间,RentClient.RentName as 户主,Rent.区县,Rent.街道,Rent.户型,Rent.价格,数量 = 1
INTO #NET
FROM Rent,RentClient

INSERT INTO #NET VALUES('2009-1-2','合计',null,null,null,null,(SELECT COUNT(数量) from #NET where 时间 between '2009-1-1' and '2009-3-31'))
INSERT INTO #NET VALUES('2009-5-1','合计',null,null,null,null,(SELECT COUNT(数量) from #NET where 时间 between '2009-4-1' and '2009-6-30'))
INSERT INTO #NET VALUES('2009-8-1','合计',null,null,null,null,(SELECT COUNT(数量) from #NET where 时间 between '2009-7-1' and '2009-9-30'))
INSERT INTO #NET VALUES('2009-12-1','合计',null,null,null,null,(SELECT COUNT(数量) from #NET where 时间 between '2009-10-1' and '2009-12-31'))

SELECT 季度 = case
when 时间 between '2009-1-1' and '2009-3-31' then 1
when 时间 between '2009-4-1' and '2009-6-30' then 2
when 时间 between '2009-7-1' and '2009-9-30' then 3
when 时间 between '2009-10-1' and '2009-12-31' then 4
else '0'
END
,户主,区县,街道,户型,价格,数量
FROM #NET
order by 季度,户主



DROP TABLE #NET
GO