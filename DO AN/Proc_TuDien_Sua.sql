USE [TuDienAVData]
GO
create proc TuDien_Sua
	@ID nvarchar(50)
    ,@English nvarchar(100)
    ,@ShortVN nvarchar(100)
    ,@VN nvarchar(max)
as

UPDATE [dbo].[TuDienAV]
   SET [ID] = @ID
      ,[English] = @English
      ,[ShortVN] = @ShortVN
      ,[VN] = @VN
 WHERE @ID = [ID]



