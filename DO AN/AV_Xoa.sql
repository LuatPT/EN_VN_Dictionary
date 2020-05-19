USE [AV]
GO
CREATE proc AV_Xoa
	@English nvarchar(max)
as
DELETE FROM [dbo].[tblAnhViet]
      WHERE English = @English


