USE [AV]
GO
create proc AV_TraTu
	@English nvarchar(max)
as
SELECT TOP 20 [English]
      ,[VN]
      ,[id]
      ,[shortVn]
  FROM [dbo].[tblAnhViet]
  Where English = @English


