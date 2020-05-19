USE [TuDienAVData]
GO
create proc TuDien_Xoa
	@ID nvarchar(50)
as

DELETE FROM [dbo].[TuDienAV]
      WHERE [ID] = @ID



