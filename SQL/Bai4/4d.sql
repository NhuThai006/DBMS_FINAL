USE ThuVienDB;
GO
DROP PROCEDURE IF EXISTS sp_ThongtinNguoilonQuahan;
GO
CREATE PROCEDURE sp_ThongtinNguoilonQuahan
AS 
BEGIN 
	SELECT  
		DG.ma_DocGia, DG.ho, DG.tenlot, DG.ten, DG.ngaysinh,
        NL.sonha, NL.duong, NL.quan, NL.dienthoai, NL.han_sd
	FROM DocGia DG 
	JOIN Nguoilon NL ON DG.ma_DocGia  = NL.ma_DocGia
	JOIN Muon M ON DG.ma_DocGia = M.ma_DocGia 
	WHERE DATEDIFF (DAY, M.ngay_hethan, GETDATE())>= 14;
END
GO