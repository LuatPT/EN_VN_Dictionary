USE [TuDienAVData]
GO

CREATE proc [dbo].[TuDien_NangCao_Pro]
	@eng nvarchar(50)
as

SELECT [English]

  FROM [dbo].[TuDienAV]
  WHERE @eng like ''+English+'%'
