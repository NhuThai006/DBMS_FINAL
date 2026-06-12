
-- 4. Tạo Stored Procedure
CREATE PROCEDURE sp_ThongTinDauSach
	@isbn varchar(20) 
AS 
BEGIN 
	SELECT 
		DS.isbn,
		TS.tua_sach,
		TS.tacgia,
		TS.tomtat,
		DS.ngon_ngu,
		DS.bia,
		DS.trangthai,
		COUNT(CS.ma_cuonsach) AS SoLuong
	FROM Dausach DS 
	JOIN Tuasach TS ON DS.ma_tuasach = TS.ma_tuasach
	LEFT JOIN Cuonsach CS ON DS.isbn = CS.isbn AND CS.tinhtrang = 'chua muon'
	WHERE DS.isbn = @isbn
	GROUP BY 
		DS.isbn, 
		TS.tua_sach, 
		TS.tacgia, 
		TS.tomtat, 
		DS.ngon_ngu, 
		DS.bia, 
		DS.trangthai
END
GO