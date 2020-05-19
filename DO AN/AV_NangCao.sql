USE [AV]
GO
alter proc AV_NangCao
	@eng nvarchar(max)
as
SELECT TOP 20 [English]
      ,[VN]
      ,[id]
      ,[shortVn]
  FROM [dbo].[tblAnhViet]
Where English like ''+@eng+'%'


