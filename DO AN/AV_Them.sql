USE [AV]
GO
CREATE PROC AV_Them
	@English nvarchar(max), 
    @VN nvarchar(max), 
    @id nvarchar(max), 
    @shortVn nvarchar(max)
as

INSERT INTO [dbo].[tblAnhViet]
           ([English]
           ,[VN]
           ,[id]
           ,[shortVn])
     VALUES
           (@English
           ,@VN
           ,@id
           ,@shortVn)


