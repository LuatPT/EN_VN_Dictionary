USE [AV]
GO

create proc Test_Them
	@id nvarchar(100),
	@ques nvarchar(max)
as
INSERT INTO [dbo].[tblTest]
           ([id]
           ,[ques])
     VALUES
           (@id
		   ,@ques
		   )
	


