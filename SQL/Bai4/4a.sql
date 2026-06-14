
USE ThuVienDB;
GO

DROP PROCEDURE IF EXISTS sp_ThongtinDocGia;
GO

CREATE PROCEDURE sp_ThongTinDocGia
    @Ma VARCHAR(10)
AS
BEGIN
    IF EXISTS(SELECT 1 FROM Nguoilon WHERE ma_DocGia = @Ma)
        BEGIN
            SELECT 
                DG.ma_DocGia, DG.ho + N' '+ DG.tenlot + N' '+ DG.ten AS ho_va_ten, DG.ngaysinh,
                NL.sonha + N', '+  NL.duong +N', '+ NL.quan AS DiaChi, NL.dienthoai, NL.han_sd
            FROM
                DocGia DG JOIN Nguoilon NL ON DG.ma_DocGia = NL.ma_DocGia 
            WHERE 
                DG.ma_DocGia = @Ma
        END

     ELSE IF  EXISTS (SELECT 1 FROM Treem WHERE ma_DocGia = @Ma)
        BEGIN
            SELECT 
                DG.ma_DocGia, DG.ho + N' '+ DG.tenlot + N' '+ DG.ten AS ho_va_ten, DG.ngaysinh,
                T.ma_DocGia_nguoilon
            FROM
                DocGia DG JOIN Treem T ON DG.ma_DocGia = T.ma_DocGia 
            WHERE 
                DG.ma_DocGia = @Ma
        END
    ELSE
        BEGIN
            PRINT N'Không tìm thấy độc giả này';
        END
END