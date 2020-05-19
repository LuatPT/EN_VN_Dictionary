USE [AV]
GO
create proc Test_TraTu
	@id nvarchar(100)
as
SELECT [id]
      ,[ques]
  FROM [dbo].[tblTest]

  WHERE [id] = @id



