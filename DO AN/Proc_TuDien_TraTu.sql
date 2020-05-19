USE [TuDienAVData]
GO
create proc TuDien_TraTu
	@eng nvarchar(50)
as

SELECT [ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[TuDienAV]
WHERE [English] = @eng


