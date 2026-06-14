USE ThuVienDB
GO
CREATE OR ALTER PROCEDURE sp_DocGiaCoTreEmMuon
AS
BEGIN
		SELECT DG.ma_DocGia, DG.ho + N' ' + DG.tenlot + N' ' + DG.ten AS ho_va_ten,
		NL.sonha +N', '+ NL.duong + N' '+ NL.quan AS diachi, NL.dienthoai, NL.han_sd
		FROM DocGia DG JOIN Nguoilon NL ON DG.ma_DocGia = NL.ma_DocGia
		WHERE 
			NL.ma_DocGia IN (SELECT ma_DocGia From Muon)
			AND EXISTS(
				SELECT 1 FROM Treem TE
				WHERE 
					TE.ma_DocGia IN(SELECT ma_DocGia FROM Muon) 
					AND TE.ma_DocGia_nguoilon = NL.ma_DocGia
			)
END
