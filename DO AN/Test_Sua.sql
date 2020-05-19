USE [AV]
GO

Create proc TuDien_Sua
	@id nvarchar(100),
	@ques nvarchar(max)
as
UPDATE [dbo].[tblTest]
   SET [id] = @id
      ,[ques] = @ques
 WHERE [id] = @id

