USE [TuDienAVData]
GO
create proc TuDien_Them 
	@ID int
    ,@English nvarchar(100)
    ,@ShortVN nvarchar(100)
    ,@VN nvarchar(max)
as
INSERT INTO [dbo].[TuDienAV]
           ([ID]
           ,[English]
           ,[ShortVN]
           ,[VN])
     VALUES
           (@ID
           ,@English
           ,@ShortVN
           ,@VN)



