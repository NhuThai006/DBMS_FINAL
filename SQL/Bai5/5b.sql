CREATE TRIGGER tg_insMuon
ON Muon
AFTER INSERT
AS
BEGIN
    UPDATE Cuonsach
    SET tinhtrang = 'no'
    FROM Cuonsach cs
    INNER JOIN inserted i ON cs.ma_cuonsach = i.ma_cuonsach
END