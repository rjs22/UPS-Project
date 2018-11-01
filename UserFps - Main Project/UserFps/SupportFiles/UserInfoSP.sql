---------------------------------------------------------
----This procedure is made to look for User that has-----
-------------------a device on db------------------------
------Returns 0 if the device to login matches-----------
----------with the device that is on db------------------
---------------------------------------------------------

Use FPSProj
Go
alter PROCEDURE User_Device_Match
@UserName nvarchar (250),
@Device nvarchar(250)

as
SET NOCOUNT ON
SET FMTONLY OFF

Begin

SELECT * into #tempTable
FROM UsersModel
WHERE TransactionSource != 'SII'
--and CONVERT(DATE, REC_CRT_TS) between '2015-09-01' and '2015-09-04'
and UserName != ' ' 
and DeviceID != ' ' 
order by CreatedDate asc


SELECT * INTO #ELEMENTtable from (
(select *, row_number() over (partition by UserName order by CreatedDate) AS LAST_ACTIVITY,
CASE WHEN TransactionSource IN ('IDC') THEN 1 ELSE 0 END AS NEWSESH
FROM #tempTable)
) as elementtable


SELECT * INTO #ROWTABLE from (
SELECT UserName, TransactionSource, DeviceID, newSesh, CreatedDate,
CASE WHEN LAST_ACTIVITY = '1' THEN NULL ELSE Convert(datetime, CreatedDate) - 1 END AS last_activity
from #ELEMENTtable
) as ROWTABLE

SELECT 
	 *,
		 RANK() OVER
			(PARTITION BY UserName, userSeshID ORDER BY CreatedDate ASC) AS Rnk,
		RANK() OVER
			(PARTITION BY UserName, TransactionSource, userSeshID ORDER BY CreatedDate ASC) AS Rnk2
		INTO #sourceRanksS
	FROM(
		 SELECT 
		 UserName,
		 TransactionSource,
		 DeviceID,
		 CreatedDate,
		 SUM(newSesh) OVER (PARTITION BY UserName) AS userSeshID
		 FROM( 
			SELECT m.*, foo.last_activity, foo.newSesh
			FROM #tempTable m
			LEFT JOIN (
				SELECT * 
				FROM #ROWTABLE
			--	WHERE CONVERT(DATE, REC_CRT_TS) = '2018-03-01'

			 ) foo
			 on m.UserName = foo.UserName 
			 and m.CreatedDate = foo.CreatedDate 
			 and m.TransactionSource = foo.TransactionSource
		     --WHERE m.LGN_USR_NR = '999ROA'
			 )bar
		) oof
	WHERE userSeshID > 0
	ORDER by UserName asc, CreatedDate asc

	
	SELECT a.*
	INTO #sourceRanksIDCC
	FROM #sourceRanksS a
		JOIN #sourceRanksS b
			on a.UserName = b.UserName
			and a.userSeshID = b.userSeshID
		WHERE b.TransactionSource = 'IDC' 
		--AND CONVERT(DATE, b.REC_CRT_TS) = '2014-02-18'
	order by a.UserName asc, a.CreatedDate asc
	

	SELECT * INTO #idcAndNextT FROM #sourceRanksIDCC WHERE Rnk <= 2


	If Exists (SELECT UserName, DeviceID 
				FROM #idcAndNextT 
				WHERE TransactionSource = 'IDC'
				and UserName = @UserName 
				and DeviceID = @Device)

		select 0 --match found
	
	Else

		select 1
	

End
GO









----THIS PROCEDURE is a simple version of the query above that only searches for user and device
--USE [FPSProj]
--GO

--/****** Object:  StoredProcedure [dbo].[usersInfo]    Script Date: 8/1/2018 9:47:13 AM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--CREATE Procedure [dbo].[usersInfo]
--@Username nvarchar(50),
--@Device nvarchar(50)
--as
--SET NOCOUNT OFF

--	if exists (select DeviceID from UsersModel where UserName = @Username and DeviceID = @Device)

--		select 0 --Device Exists

--	else

--		select 1 --Device Doesn't Exist
--GO

