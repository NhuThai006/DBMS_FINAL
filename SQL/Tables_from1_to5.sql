USE ThuVienDB;
GO

-- Bắt buộc phải xóa các bảng này trước vì nó chứa khóa ngoại
DROP TABLE IF EXISTS QuaTrinhMuon;
DROP TABLE IF EXISTS Muon;
DROP TABLE IF EXISTS DangKy;

-- Lúc này mới xóa được các bảng sách
DROP TABLE IF EXISTS Cuonsach;
DROP TABLE IF EXISTS Dausach;
DROP TABLE IF EXISTS Tuasach;

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


--Cau 4a

DROP TABLE IF EXISTS QuaTrinhMuon;
DROP TABLE IF EXISTS Muon;
DROP TABLE IF EXISTS DangKy;
DROP TABLE IF EXISTS Treem;
DROP TABLE IF EXISTS Nguoilon;
DROP TABLE IF EXISTS DocGia;
GO

CREATE TABLE DocGia (
    ma_DocGia INT PRIMARY KEY,
    ho NVARCHAR(50),
    tenlot NVARCHAR(50),
    ten NVARCHAR(50),
    ngaysinh DATE
);

CREATE TABLE Nguoilon (
    ma_DocGia INT PRIMARY KEY,
    sonha NVARCHAR(50),
    duong NVARCHAR(100),
    quan NVARCHAR(50),
    dienthoai VARCHAR(15),
    han_sd DATE,
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

CREATE TABLE Treem (
    ma_DocGia INT PRIMARY KEY,
    ma_DocGia_nguoilon INT,
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia),
    FOREIGN KEY (ma_DocGia_nguoilon) REFERENCES Nguoilon(ma_DocGia)
);

CREATE TABLE DangKy (
    isbn VARCHAR(20),
    ma_DocGia INT,
    ngay_dk DATE,
    ghichu NVARCHAR(255),
    PRIMARY KEY (isbn, ma_DocGia),
    FOREIGN KEY (isbn) REFERENCES Dausach(isbn),
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

CREATE TABLE Muon (
    isbn VARCHAR(20),
    ma_cuonsach VARCHAR(20), 
    ma_DocGia INT,
    ngay_muon DATE,
    ngay_hethan DATE,
    PRIMARY KEY (isbn, ma_cuonsach),
    FOREIGN KEY (ma_cuonsach) REFERENCES Cuonsach(ma_cuonsach), 
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

-- Đã sửa: Khóa ngoại trỏ đúng vào 'ma_cuonsach'
CREATE TABLE QuaTrinhMuon (
    isbn VARCHAR(20),
    ma_cuonsach VARCHAR(20), 
    ngay_muon DATE,
    ma_DocGia INT,
    ngay_hethan DATE,
    ngay_tra DATE,
    tien_muon DECIMAL(18, 2),
    tien_datra DECIMAL(18, 2),
    tien_datcoc DECIMAL(18, 2),
    ghichu NVARCHAR(255),
    PRIMARY KEY (isbn, ma_cuonsach, ngay_muon),
    FOREIGN KEY (ma_cuonsach) REFERENCES Cuonsach(ma_cuonsach), 
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);
GO

INSERT INTO DocGia (ma_DocGia, ho, tenlot, ten, ngaysinh) VALUES
(1,  N'Nguyễn', N'Văn',      N'An',      '1985-03-15'),
(2,  N'Trần',   N'Thị',      N'Bình',    '1990-07-22'),
(3,  N'Lê',     N'Hoàng',    N'Cường',   '1978-11-05'),
(4,  N'Phạm',   N'Thị',      N'Dung',    '1995-01-30'),
(5,  N'Hoàng',  N'Minh',     N'Đức',     '1988-06-14'),
(6,  N'Vũ',     N'Thị',      N'Hà',      '1992-09-08'),
(7,  N'Đặng',   N'Quốc',     N'Hùng',    '1983-04-27'),
(8,  N'Bùi',    N'Thị',      N'Lan',     '1997-12-03'),
(9,  N'Đỗ',     N'Văn',      N'Minh',    '1975-08-19'),
(10, N'Ngô',    N'Thị',      N'Ngọc',    '1993-02-11'),
(11, N'Dương',  N'Thanh',    N'Phong',   '1986-05-25'),
(12, N'Lý',     N'Thị',      N'Quỳnh',   '1999-10-17'),
(13, N'Trịnh',  N'Văn',      N'Sơn',     '1980-07-09'),
--Trẻ em
(14, N'Nguyễn', N'Thị',      N'Thảo',    '2012-03-20'),
(15, N'Trần',   N'Văn',      N'Tú',      '2010-08-15'),
(16, N'Lê',     N'Thị',      N'Uyên',    '2014-11-02'),
(17, N'Phạm',   N'Minh',     N'Việt',    '2011-05-30'),
(18, N'Hoàng',  N'Thị',      N'Xuân',    '2013-01-25'),
(19, N'Vũ',     N'Văn',      N'Yên',     '2015-09-10'),
(20, N'Đặng',   N'Thị',      N'Zara',    '2009-04-18');
GO
 
INSERT INTO Nguoilon (ma_DocGia, sonha, duong, quan, dienthoai, han_sd) VALUES
(1,  N'12',  N'Nguyễn Huệ',      N'Quận 1',   '0901234561', '2027-03-15'),
(2,  N'45',  N'Lê Lợi',          N'Quận 1',   '0912345672', '2026-07-22'),
(3,  N'78',  N'Trần Hưng Đạo',   N'Quận 5',   '0923456783', '2028-11-05'),
(4,  N'23',  N'Đinh Tiên Hoàng', N'Quận Bình Thạnh', '0934567894', '2027-01-30'),
(5,  N'56',  N'Võ Thị Sáu',      N'Quận 3',   '0945678905', '2026-06-14'),
(6,  N'89',  N'Nam Kỳ Khởi Nghĩa',N'Quận 3',  '0956789016', '2029-09-08'),
(7,  N'34',  N'Cách Mạng Tháng 8',N'Quận 10',  '0967890127', '2027-04-27'),
(8,  N'67',  N'Lý Thường Kiệt',  N'Quận 10',  '0978901238', '2026-12-03'),
(9,  N'11',  N'Hai Bà Trưng',    N'Quận 1',   '0989012349', '2028-08-19'),
(10, N'99',  N'Pasteur',         N'Quận 3',   '0990123450', '2027-02-11'),
(11, N'42',  N'Nguyễn Đình Chiểu',N'Quận 3',  '0901234562', '2026-05-25'),
(12, N'75',  N'Điện Biên Phủ',   N'Quận Bình Thạnh','0912345673','2029-10-17'),
(13, N'18',  N'Lê Văn Sỹ',       N'Quận 3',   '0923456784', '2027-07-09');
GO
 

INSERT INTO Treem (ma_DocGia, ma_DocGia_nguoilon) VALUES
(14, 1),
(15, 2),
(16, 3),
(17, 4),
(18, 5),
(19, 6),
(20, 7);
GO
 INSERT INTO DangKy (isbn, ma_DocGia, ngay_dk, ghichu) VALUES
('ISB001', 1,  '2026-05-02', NULL),
('ISB003', 3,  '2026-05-05', NULL),
('ISB004', 5,  '2026-05-08', N'Ưu tiên sinh viên'),
('ISB005', 7,  '2026-05-10', NULL),
('ISB007', 14, '2026-05-13', N'Phụ huynh đã ký'),
('ISB009', 9,  '2026-05-16', NULL),
('ISB010', 2,  '2026-05-19', NULL),
('ISB012', 4,  '2026-05-22', NULL),
('ISB013', 16, '2026-05-25', NULL),
('ISB014', 11, '2026-05-28', NULL),
('ISB015', 6,  '2026-06-01', NULL),
('ISB016', 18, '2026-06-03', N'Trẻ em cần người lớn ký'),
('ISB019', 13, '2026-06-06', NULL),
('ISB020', 8,  '2026-06-09', NULL),
('ISB011', 20, '2026-06-11', N'Phụ huynh đã xác nhận');
GO
 

INSERT INTO Muon (isbn, ma_cuonsach, ma_DocGia, ngay_muon, ngay_hethan) VALUES
('ISB001', 'CS002', 2,  '2026-04-01', '2026-05-16'),
('ISB001', 'CS005', 10, '2026-06-03', '2026-06-24'),
('ISB003', 'CS012', 6,  '2026-06-05', '2026-06-26'),
('ISB004', 'CS016', 12, '2026-05-08', '2026-05-27'),
('ISB006', 'CS026', 15, '2026-06-07', '2026-06-28'),  
('ISB008', 'CS036', 1,  '2026-03-28', '2026-04-14'),  
('ISB010', 'CS047', 5,  '2026-06-08', '2026-06-29'),
('ISB016', 'CS076', 17, '2026-06-10', '2026-07-01');  
GO
 
INSERT INTO QuaTrinhMuon
    (isbn, ma_cuonsach, ngay_muon, ma_DocGia, ngay_hethan, ngay_tra,
     tien_muon, tien_datra, tien_datcoc, ghichu)
VALUES
-- Trả đúng hạn
('ISB001', 'CS003', '2026-01-05', 1,  '2026-01-26', '2026-01-20', 5000, 5000,  20000, NULL),
('ISB002', 'CS006', '2026-01-10', 3,  '2026-01-31', '2026-01-28', 5000, 5000,  20000, NULL),
('ISB003', 'CS011', '2026-02-01', 5,  '2026-02-22', '2026-02-18', 5000, 5000,  20000, NULL),
('ISB004', 'CS017', '2026-02-10', 7,  '2026-03-03', '2026-02-27', 5000, 5000,  20000, NULL),
('ISB005', 'CS021', '2026-02-15', 14, '2026-03-08', '2026-03-04', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISB006', 'CS027', '2026-03-01', 9,  '2026-03-22', '2026-03-19', 5000, 5000,  20000, NULL),
('ISB007', 'CS031', '2026-03-05', 11, '2026-03-26', '2026-03-21', 5000, 5000,  20000, NULL),
('ISB009', 'CS041', '2026-03-10', 2,  '2026-03-31', '2026-03-28', 5000, 5000,  20000, NULL),
('ISB010', 'CS046', '2026-03-15', 16, '2026-04-05', '2026-04-01', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISB012', 'CS056', '2026-04-01', 4,  '2026-04-22', '2026-04-19', 5000, 5000,  20000, NULL),
-- Trả trễ hạn (có phí phạt, 1500đ/ngày)
('ISB013', 'CS061', '2026-04-05', 6,  '2026-04-26', '2026-05-03', 5000, 15500, 20000, N'Trả trễ 7 ngày'),
('ISB014', 'CS066', '2026-04-10', 8,  '2026-05-01', '2026-05-10', 5000, 18500, 20000, N'Trả trễ 9 ngày'),
('ISB015', 'CS071', '2026-04-15', 18, '2026-05-06', '2026-05-15', 5000, 18500, 20000, N'Trả trễ 9 ngày - trẻ em'),
('ISB017', 'CS081', '2026-05-01', 10, '2026-05-22', '2026-06-02', 5000, 21500, 20000, N'Trả trễ 11 ngày'),
('ISB019', 'CS091', '2026-05-05', 20, '2026-05-26', '2026-06-05', 5000, 20000, 20000, N'Trả trễ 10 ngày - trẻ em'),
-- Thêm lượt đa dạng
('ISB008', 'CS037', '2026-01-20', 12, '2026-02-10', '2026-02-07', 5000, 5000,  20000, NULL),
('ISB011', 'CS051', '2026-02-20', 13, '2026-03-13', '2026-03-10', 5000, 5000,  20000, NULL),
('ISB016', 'CS077', '2026-03-20', 19, '2026-04-10', '2026-04-08', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISB018', 'CS086', '2026-04-20', 4,  '2026-05-11', '2026-05-09', 5000, 5000,  20000, NULL),
('ISB020', 'CS096', '2026-05-10', 17, '2026-05-31', '2026-06-04', 5000, 11500, 20000, N'Trả trễ 4 ngày - trẻ em');
GO