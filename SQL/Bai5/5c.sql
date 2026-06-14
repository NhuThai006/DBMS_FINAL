CREATE TRIGGER tg_updCuonSach
ON Cuonsach
AFTER UPDATE
AS
BEGIN
    -- Lấy danh sách isbn bị ảnh hưởng
    UPDATE Dausach
    SET trangthai = 
        CASE 
            WHEN (SELECT COUNT(*) FROM Cuonsach WHERE isbn = d.isbn AND tinhtrang = 'yes') > 0
            THEN N'Đang lưu hành'
            ELSE N'Hết sách'
        END
    FROM Dausach d
    WHERE d.isbn IN (SELECT isbn FROM inserted)
END