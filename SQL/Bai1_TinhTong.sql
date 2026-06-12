
USE ThuVienDB;
GO

DROP PROCEDURE IF EXISTS sp_TinhTongHaiSo;
GO

CREATE PROCEDURE sp_TinhTongHaiSo
	@SoA int,
	@SoB int
AS 
BEGIN 
	SELECT (@SoA + @SoB) AS ketqua;
END
GO