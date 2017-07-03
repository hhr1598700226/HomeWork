use master
go

IF EXISTS(SELECT * FROM sysdatabases where NAME = 'MyApplicant')
DROP DATABASE MyApplicant

CREATE DATABASE MyApplicant
ON
(
	NAME = 'MyApplicant',
	FILENAME = 'E:\SQLceshi\MyApplicant.mdf',
	SIZE = 5MB,
	FILEGROWTH = 10%
)
LOG ON 
(
	NAME = 'MyApplicantL',
	FILENAME = 'E:\SQLceshi\MyApplicantL.ldf',
	SIZE = 5MB,
	FILEGROWTH = 10%
)

USE MyApplicant
go
--IF EXISTS(SELECT * FROM sysobjects where NAME = 'Position')
--DROP TABLE Position
CREATE TABLE Position
(
	PositionId INT PRIMARY KEY(PositionId),
	PositionName NVARCHAR(50) NOT NULL,
	Password NVARCHAR(50) NOT NULL,
	TypeId INT NOT NULL,
	AuthorityID INT NOT NULL
)
CREATE TABLE [Type]
(
	TypeId INT PRIMARY KEY(TypeId),
	[Function] NVARCHAR(50) NOT NULL,
	AuthorityID INT NOT NULL
)
CREATE TABLE Authority
(
	AuthorityID INT PRIMARY KEY(AuthorityID),
	Authority NVARCHAR(MAX) NOT NULL
)
CREATE TABLE Applicants
(
	ApplicantsId INT PRIMARY KEY(ApplicantsId),
	ApplicantsName NVARCHAR(50) NOT NULL,
	SelectPostId INT NOT NULL,
	ResumeId INT NOT NULL,
	Question1ID INT NOT NULL,
	Question2ID INT NOT NULL
)
CREATE TABLE SelectPost
(
	SelectPostId INT PRIMARY KEY(SelectPostId),
	SelectPostRedate DATETIME NOT NULL,
	SelectPostDeadline DATETIME NOT NULL,
	TypePostId INT NOT NULL
)
CREATE TABLE TypePost
(
	TypePostId INT PRIMARY KEY(TypePostId),
	TypeName NVARCHAR(50) NOT NULL,
	TypeDescription NVARCHAR(50) NOT NULL,
	TypeRule NVARCHAR(50) NOT NULL,
	CommendNum INT NOT NULL
)
CREATE TABLE [Resume]
(
	ResumeId INT PRIMARY KEY(ResumeId),
	PeopBaseInfoId INT NOT NULL,
	PeopWorkExpId INT NOT NULL,
	PeopEduExId INT NOT NULL,
	PeopBaseSkillId INT NOT NULL,
	PeopFmilId INT NOT NULL,
	PeopSelfIntroId INT NOT NULL,
	Fraction INT NOT NULL
)
CREATE TABLE PeopBase
(
	PeopBaseInfoId INT PRIMARY KEY(PeopBaseInfoId),
	Name NVARCHAR(50) NOT NULL,
	Gender CHAR(2) CHECK(Gender = 'ÄÐ' OR Gender = 'Å®'),
	Age INT CHECK(Age > 0),
	Height INT CHECK(Height > 0),
	IdCard INT CHECK(LEN(IdCard) = 18 OR LEN(IdCard) = 15),
	TypeCardId INT NOT NULL,
	IsMarry CHAR(2) CHECK(IsMarry = 'ÊÇ' OR IsMarry = '·ñ'),
	WorkTime INT NOT NULL,
	Salary INT NOT NULL,
	[Address] NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Phone INT NOT NULL
)
CREATE TABLE TypeCard
(
	TypeCardId INT PRIMARY KEY(TypeCardId),
	Name NVARCHAR(50) NOT NULL
)
CREATE TABLE PeopWorkExp
(
	PeopWorkExpId INT PRIMARY KEY(PeopWorkExpId),
	[Time] INT NOT NULL,
	CompName NVARCHAR(50) NOT NULL,
	Industry NVARCHAR(50) NOT NULL,
	Nature NVARCHAR(50) NOT NULL,
	Position NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL
)
CREATE TABLE PeopEduEx
(
	PeopEduExId INT PRIMARY KEY(PeopEduExId),
	[Time] INT NOT NULL,
	School NVARCHAR(50) NOT NULL,
	[Type] NVARCHAR(50) NOT NULL,
	Degree NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL
)
CREATE TABLE PeopBaseSkill
(
	PeopBaseSkillId INT PRIMARY KEY(PeopBaseSkillId),
	Name NVARCHAR(50) NOT NULL,
	Degree NVARCHAR(50) NOT NULL,
	[Certificate] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(50) NOT NULL
)
CREATE TABLE PeopFmil
(
	PeopFmilId INT PRIMARY KEY(PeopFmilId),
	Name NVARCHAR(50) NOT NULL,
	Age INT CHECK(Age > 0),
	Relation NVARCHAR(50) NOT NULL,
	WorkPlace NVARCHAR(50) NOT NULL,
	Position NVARCHAR(50) NOT NULL
)
CREATE TABLE PeopSelfIntro
(
	PeopSelfIntroId INT PRIMARY KEY(PeopSelfIntroId),
	SelfEvaluation NVARCHAR(MAX) NOT NULL
)
CREATE TABLE Question1
(
	Question1ID INT PRIMARY KEY(Question1ID),
	Question1_1 NVARCHAR(MAX) NOT NULL,
	Question1_2 NVARCHAR(MAX) NOT NULL,
	Question1_3 NVARCHAR(MAX) NOT NULL,
	Question1_4 NVARCHAR(MAX) NOT NULL,
	Question1_5 NVARCHAR(MAX) NOT NULL
)
CREATE TABLE Question2
(
	Question2ID INT PRIMARY KEY(Question2ID),
	Question2_1 NVARCHAR(MAX) NOT NULL,
	Question2_2 NVARCHAR(MAX) NOT NULL,
	Question2_3 NVARCHAR(MAX) NOT NULL,
	Question2_4 NVARCHAR(MAX) NOT NULL,
	Question2_5 NVARCHAR(MAX) NOT NULL
)
CREATE TABLE Answer1
(
	Question1ID INT PRIMARY KEY(Question1ID),
	Answer1_1 NVARCHAR(MAX) NOT NULL,
	Answer1_2 NVARCHAR(MAX) NOT NULL,
	Answer1_3 NVARCHAR(MAX) NOT NULL,
	Answer1_4 NVARCHAR(MAX) NOT NULL,
	Answer1_5 NVARCHAR(MAX) NOT NULL,
	RESULT INT NOT NULL
)
CREATE TABLE Answer2
(
	Question1ID INT PRIMARY KEY(Question1ID),
	Answer2_1 NVARCHAR(MAX) NOT NULL,
	Answer2_2 NVARCHAR(MAX) NOT NULL,
	Answer2_3 NVARCHAR(MAX) NOT NULL,
	Answer2_4 NVARCHAR(MAX) NOT NULL,
	Answer2_5 NVARCHAR(MAX) NOT NULL,
	RESULT INT NOT NULL
)
CREATE TABLE QuestionBox
(
	QuestionID INT PRIMARY KEY(QuestionID),
	[Type] NVARCHAR(50) NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Question NVARCHAR(MAX) NOT NULL,
	IsMulSel CHAR(2) CHECK(IsMulSel = 'ÊÇ' OR IsMulSel = '·ñ'),
	Answer NVARCHAR(MAX) NOT NULL,
)