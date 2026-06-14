CREATE TRIGGER tg_InfThongBao
ON Tuasach
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        PRINT N'Đã thêm mới tựa sách'
    END
END