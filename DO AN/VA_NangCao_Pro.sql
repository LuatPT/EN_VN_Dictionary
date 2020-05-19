use AV
Create proc VA_NangCao_Pro
	@eng nvarchar(max)
as
SELECT [English]
      ,[VN]
  FROM [dbo].tblVietAnh
	where  English like ''+@eng+'%'
