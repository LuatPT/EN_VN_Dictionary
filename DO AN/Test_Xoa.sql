USE [AV]
GO
create proc Test_Xoa
	@id nvarchar(100)
as
DELETE FROM [dbo].[tblTest]
      WHERE [id] = @id



