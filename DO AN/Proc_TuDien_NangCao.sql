USE [TuDienAVData]
GO
create proc TuDien_NangCao
	@eng nvarchar(50)
as

SELECT [ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[TuDienAV]
  WHERE @eng like '%'+English+'%'