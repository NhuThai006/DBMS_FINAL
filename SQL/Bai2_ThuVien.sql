USE ThuVienDB;
GO

-- 1. Dọn dẹp sạch sẽ
DROP PROCEDURE IF EXISTS sp_ThongTinDauSach;
DROP TABLE IF EXISTS Cuonsach;
DROP TABLE IF EXISTS Dausach;
DROP TABLE IF EXISTS Tuasach;
GO

-- 2. Cấu trúc bảng
CREATE TABLE Tuasach (
	ma_tuasach varchar(10) primary key,
	tua_sach nvarchar(100),
	tacgia nvarchar(100),
	tomtat nvarchar(max)
);

CREATE TABLE Dausach (
	isbn varchar(20) primary key,
	ma_tuasach varchar(10) references Tuasach(ma_tuasach),
	ngon_ngu nvarchar(50),
	bia nvarchar(100),
	trangthai nvarchar(20)
);

CREATE TABLE Cuonsach (
    isbn varchar(20) references Dausach(isbn),
	ma_cuonsach varchar(20) primary key,
	tinhtrang varchar(20)
);
GO

INSERT INTO Tuasach VALUES ('TS001', N'Lập trình Python cơ bản', N'Nguyễn Văn A', N'Sách giúp người mới bắt đầu hiểu rõ về Python');
INSERT INTO Tuasach VALUES ('TS002', N'Lập trình Java nâng cao', N'Trần Văn B', N'Đi sâu vào OOP và các mẫu thiết kế Java');
INSERT INTO Tuasach VALUES ('TS003', N'Cấu trúc dữ liệu và giải thuật', N'Lê Minh C', N'Nền tảng thuật toán cho sinh viên CNTT');
INSERT INTO Tuasach VALUES ('TS004', N'Trí tuệ nhân tạo (AI) toàn tập', N'Phạm Thị D', N'Khám phá Machine Learning và Deep Learning');
INSERT INTO Tuasach VALUES ('TS005', N'Cơ sở dữ liệu SQL Server', N'Hoàng Văn E', N'Thiết kế và quản trị CSDL quan hệ');
INSERT INTO Tuasach VALUES ('TS006', N'Lập trình C++ chuẩn', N'Vũ Trọng F', N'Từ cơ bản đến lập trình hướng đối tượng C++');
INSERT INTO Tuasach VALUES ('TS007', N'Mạng máy tính và bảo mật', N'Đinh Hữu G', N'Kiến trúc mạng TCP/IP và an toàn thông tin');
INSERT INTO Tuasach VALUES ('TS008', N'Lập trình Web với ReactJS', N'Ngô Tấn H', N'Xây dựng giao diện Web hiện đại');
INSERT INTO Tuasach VALUES ('TS009', N'Phát triển ứng dụng Mobile', N'Bùi Xuân K', N'Lập trình Android và iOS với Flutter');
INSERT INTO Tuasach VALUES ('TS010', N'Toán rời rạc và ứng dụng', N'Lý Thảo M', N'Toán học dành cho khoa học máy tính');
INSERT INTO Tuasach VALUES ('TS011', N'Nhập môn Hệ điều hành', N'Châu Tấn N', N'Nguyên lý hoạt động của Windows và Linux');
INSERT INTO Tuasach VALUES ('TS012', N'Công nghệ Kỹ thuật Phần mềm', N'Đoàn Văn P', N'Quy trình phát triển phần mềm chuẩn Agile');
INSERT INTO Tuasach VALUES ('TS013', N'Xử lý ảnh kỹ thuật số', N'Trịnh Quang Q', N'Computer Vision và nhận diện khuôn mặt');
INSERT INTO Tuasach VALUES ('TS014', N'Phân tích dữ liệu với Pandas', N'Hồ Kim R', N'Khai phá dữ liệu cho Data Science');
INSERT INTO Tuasach VALUES ('TS015', N'Nhập môn Internet of Things', N'Thái Ngọc S', N'Lập trình vi điều khiển và hệ thống nhúng');
GO

-- ==========================================
-- 3. NHẬP 20 ĐẦU SÁCH (Chia theo Ngôn ngữ và Loại bìa)
-- ==========================================
INSERT INTO Dausach VALUES ('ISB001', 'TS001', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB002', 'TS001', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB003', 'TS002', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB004', 'TS003', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB005', 'TS004', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB006', 'TS004', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB007', 'TS005', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB008', 'TS006', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB009', 'TS007', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB010', 'TS008', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB011', 'TS009', N'Tiếng Anh', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB012', 'TS010', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB013', 'TS011', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB014', 'TS012', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB015', 'TS013', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB016', 'TS013', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB017', 'TS014', N'Tiếng Anh', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB018', 'TS014', N'Tiếng Việt', N'Bìa cứng', N'Tạm ngưng');
INSERT INTO Dausach VALUES ('ISB019', 'TS015', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISB020', 'TS015', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
GO

-- ==========================================
-- 4. NHẬP 100 CUỐN SÁCH VẬT LÝ (CS001 -> CS100)
-- ==========================================
-- ISB001 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB001', 'CS001', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB001', 'CS002', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB001', 'CS003', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB001', 'CS004', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB001', 'CS005', 'da muon');

-- ISB002 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB002', 'CS006', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB002', 'CS007', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB002', 'CS008', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB002', 'CS009', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB002', 'CS010', 'chua muon');

-- ISB003 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB003', 'CS011', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB003', 'CS012', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB003', 'CS013', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB003', 'CS014', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB003', 'CS015', 'chua muon');

-- ISB004 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB004', 'CS016', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB004', 'CS017', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB004', 'CS018', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB004', 'CS019', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB004', 'CS020', 'da muon');

-- ISB005 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB005', 'CS021', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB005', 'CS022', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB005', 'CS023', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB005', 'CS024', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB005', 'CS025', 'chua muon');

-- ISB006 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB006', 'CS026', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB006', 'CS027', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB006', 'CS028', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB006', 'CS029', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB006', 'CS030', 'da muon');

-- ISB007 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB007', 'CS031', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB007', 'CS032', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB007', 'CS033', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB007', 'CS034', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB007', 'CS035', 'chua muon');

-- ISB008 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB008', 'CS036', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB008', 'CS037', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB008', 'CS038', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB008', 'CS039', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB008', 'CS040', 'chua muon');

-- ISB009 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB009', 'CS041', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB009', 'CS042', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB009', 'CS043', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB009', 'CS044', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB009', 'CS045', 'chua muon');

-- ISB010 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB010', 'CS046', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB010', 'CS047', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB010', 'CS048', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB010', 'CS049', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB010', 'CS050', 'da muon');

-- ISB011 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB011', 'CS051', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB011', 'CS052', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB011', 'CS053', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB011', 'CS054', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB011', 'CS055', 'chua muon');

-- ISB012 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB012', 'CS056', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB012', 'CS057', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB012', 'CS058', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB012', 'CS059', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB012', 'CS060', 'da muon');

-- ISB013 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB013', 'CS061', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB013', 'CS062', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB013', 'CS063', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB013', 'CS064', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB013', 'CS065', 'chua muon');

-- ISB014 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB014', 'CS066', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB014', 'CS067', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB014', 'CS068', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB014', 'CS069', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB014', 'CS070', 'da muon');

-- ISB015 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB015', 'CS071', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB015', 'CS072', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB015', 'CS073', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB015', 'CS074', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB015', 'CS075', 'chua muon');

-- ISB016 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB016', 'CS076', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB016', 'CS077', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB016', 'CS078', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB016', 'CS079', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB016', 'CS080', 'da muon');

-- ISB017 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB017', 'CS081', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB017', 'CS082', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB017', 'CS083', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB017', 'CS084', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB017', 'CS085', 'chua muon');

-- ISB018 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB018', 'CS086', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB018', 'CS087', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB018', 'CS088', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB018', 'CS089', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB018', 'CS090', 'da muon');

-- ISB019 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB019', 'CS091', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB019', 'CS092', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB019', 'CS093', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB019', 'CS094', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB019', 'CS095', 'chua muon');

-- ISB020 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISB020', 'CS096', 'da muon');
INSERT INTO Cuonsach VALUES ('ISB020', 'CS097', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB020', 'CS098', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB020', 'CS099', 'chua muon');
INSERT INTO Cuonsach VALUES ('ISB020', 'CS100', 'da muon');
GO

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