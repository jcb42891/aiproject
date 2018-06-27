IF OBJECT_ID(N'dbo.SystemUser_CheckLogin', N'P') IS NULL
	EXEC ('CREATE PROC dbo.SystemUser_CheckLogin AS SET NOCOUNT ON;')
GO

ALTER PROCEDURE SystemUser_CheckLogin

@a_Username nvarchar(50),
@a_Password nvarchar(50)

AS

SELECT * FROM SystemUser
WHERE Username = @a_Username AND Password = @a_Password