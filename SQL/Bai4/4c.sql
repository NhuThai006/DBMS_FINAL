USE ThuVienDB;
GO
DROP PROCEDURE IF EXISTS sp_ThongtinNguoilonDangmuon;
GO
CREATE PROCEDURE sp_ThongtinNguoilonDangmuon
AS 
BEGIN 
	SELECT DISTINCT 
		DG.ma_DocGia, DG.ho + N' '+ DG.tenlot + N' '+ DG.ten AS ho_va_ten, DG.ngaysinh,
        NL.sonha, NL.duong, NL.quan, NL.dienthoai, NL.han_sd
	FROM DocGia DG 
	JOIN Nguoilon NL ON DG.ma_DocGia  = NL.ma_DocGia
	JOIN Muon M ON DG.ma_DocGia = M.ma_DocGia 
END
GO