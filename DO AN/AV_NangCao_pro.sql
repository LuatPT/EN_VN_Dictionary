USE [AV]
GO

Create proc AV_NangCao_Pro
	@eng nvarchar(max)
as
SELECT [English]
      ,[VN]
      ,[id]
      ,[shortVn]
  FROM [dbo].[tblAnhViet]
	where English like ''+@eng+'%'


