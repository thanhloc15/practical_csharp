Use FUH_COMPANY
Go
Create proc sp_Insert_tblDeparment
	@depNum			int,
	@depName		nvarchar(50),
	@mgrSSN			DECIMAL,
	@mgrAssDate		datetime					
As
INSERT INTO tblDepartment
VALUES  ( @depNum, @depName, @mgrSSN, @mgrAssDate )
GO


Use FUH_COMPANY
Go
Create proc sp_Update_tblDeparment
	@depNum			int,
	@depName		nvarchar(50),
	@mgrSSN			DECIMAL,
	@mgrAssDate		datetime					
As
UPDATE tblDepartment SET depName=@depName, mgrSSN=@mgrSSN, mgrAssDate=@mgrAssDate WHERE depNum=@depNum
GO


Use FUH_COMPANY
Go
Drop proc sp_Delete_tblDeparment
GO


Use FUH_COMPANY
Go
Create proc sp_Delete_tblDeparment
@depNum INT
AS
DELETE FROM dbo.tblDepLocation WHERE depNum=@depNum
UPDATE dbo.tblEmployee SET depNum = NULL WHERE depNum=@depNum
UPDATE dbo.tblProject SET depNum = NULL WHERE depNum=@depNum
DELETE FROM dbo.tblDepartment WHERE depNum=@depNum

EXEC dbo.sp_Delete_tblDeparment @depNum = 5 -- int
