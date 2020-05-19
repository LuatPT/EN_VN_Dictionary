USE [AV]
GO
create proc AV_Sua
	@English nvarchar(max),
	@VN nvarchar(max),
	@id nvarchar(max),
	@shortVn nvarchar(max)
as
UPDATE [dbo].[tblAnhViet]
   SET
	English = @English,
	VN = @VN,
	id = @id,
	shortVn = @shortVn
 WHERE English = @English


