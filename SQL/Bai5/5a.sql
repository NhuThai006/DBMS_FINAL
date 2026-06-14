CREATE TRIGGER tg_delMuon
ON Muon
AFTER DELETE
AS
BEGIN
    UPDATE Cuonsach
    SET tinhtrang = 'yes'
    FROM Cuonsach cs
    INNER JOIN deleted d ON cs.ma_cuonsach = d.ma_cuonsach
END