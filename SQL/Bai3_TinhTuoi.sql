DROP PROCEDURE if EXISTS sp_TinhTuoi;
GO
USE ThuVienDB
GO
CREATE PROCEDURE sp_TinhTuoi
	@BirthYear int
AS
	BEGIN 
	SELECT (YEAR(GETDATE()) - @BirthYear) AS Tuoi;
END
