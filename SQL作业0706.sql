SELECT student.studentname ѧ������,class.classname �꼶����,[subject].subjectname �γ�����,result.[date] ��������,result.result ���Գɼ�
from Student,class,[subject],result
where Student.class = class.class
AND Student.studentno = result.studentno
AND result.subjectid = [subject].subjectid
--GROUP BY class.classname,Student.studentname,[subject].subjectname,result.[date],result.result
AND result.[date] = (select MAX([date]) from result where Student.studentno = result.studentno
													AND result.subjectid = [subject].subjectid
													AND Student.class = class.class
					)
ORDER BY class.classname desc
GO

DECLARE @pas float
DECLARE @ave float
DECLARE @peo int
SET @peo = (SELECT COUNT(result) from result where subjectid = 1)
IF((SELECT SUM(result)/COUNT(result) from result where subjectid = 1) > 60)
	BEGIN
	SET @ave = (SELECT SUM(result)/COUNT(result) from result where subjectid = 1)
	END
ELSE
	BEGIN
	SET @ave = 60
	END
while(1=1)
BEGIN
IF(EXISTS(SELECT * from result where subjectid = 1 and result > 97))
BREAK
ELSE
UPDATE result SET result=(result+1) where subjectid = 1 and result < @ave 
END
SELECT * FROM result where subjectid = 1
SET @pas = (SELECT COUNT(result) from result where subjectid = 1 and result > 60)*100/(SELECT COUNT(result) from result where subjectid = 1)
PRINT'ͨ���ʣ�'+ CONVERT(nvarchar(50),@pas)
GO





