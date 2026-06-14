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
INSERT INTO Dausach VALUES ('ISBN001', 'TS001', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN002', 'TS001', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN003', 'TS002', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN004', 'TS003', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN005', 'TS004', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN006', 'TS004', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN007', 'TS005', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN008', 'TS006', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN009', 'TS007', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN010', 'TS008', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN011', 'TS009', N'Tiếng Anh', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN012', 'TS010', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN013', 'TS011', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN014', 'TS012', N'Tiếng Việt', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN015', 'TS013', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN016', 'TS013', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN017', 'TS014', N'Tiếng Anh', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN018', 'TS014', N'Tiếng Việt', N'Bìa cứng', N'Tạm ngưng');
INSERT INTO Dausach VALUES ('ISBN019', 'TS015', N'Tiếng Việt', N'Bìa mềm', N'Đang lưu hành');
INSERT INTO Dausach VALUES ('ISBN020', 'TS015', N'Tiếng Anh', N'Bìa cứng', N'Đang lưu hành');
GO

-- ==========================================
-- 4. NHẬP 100 CUỐN SÁCH VẬT LÝ (CS001 -> CS100)
-- ==========================================
-- ISBN001 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN001', 'CS001', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN001', 'CS002', 'no');
INSERT INTO Cuonsach VALUES ('ISBN001', 'CS003', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN001', 'CS004', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN001', 'CS005', 'no');

-- ISBN002 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN002', 'CS006', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN002', 'CS007', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN002', 'CS008', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN002', 'CS009', 'no');
INSERT INTO Cuonsach VALUES ('ISBN002', 'CS010', 'yes');

-- ISBN003 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN003', 'CS011', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN003', 'CS012', 'no');
INSERT INTO Cuonsach VALUES ('ISBN003', 'CS013', 'no');
INSERT INTO Cuonsach VALUES ('ISBN003', 'CS014', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN003', 'CS015', 'yes');

-- ISBN004 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN004', 'CS016', 'no');
INSERT INTO Cuonsach VALUES ('ISBN004', 'CS017', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN004', 'CS018', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN004', 'CS019', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN004', 'CS020', 'no');

-- ISBN005 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN005', 'CS021', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN005', 'CS022', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN005', 'CS023', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN005', 'CS024', 'no');
INSERT INTO Cuonsach VALUES ('ISBN005', 'CS025', 'yes');

-- ISBN006 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN006', 'CS026', 'no');
INSERT INTO Cuonsach VALUES ('ISBN006', 'CS027', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN006', 'CS028', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN006', 'CS029', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN006', 'CS030', 'no');

-- ISBN007 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN007', 'CS031', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN007', 'CS032', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN007', 'CS033', 'no');
INSERT INTO Cuonsach VALUES ('ISBN007', 'CS034', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN007', 'CS035', 'yes');

-- ISBN008 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN008', 'CS036', 'no');
INSERT INTO Cuonsach VALUES ('ISBN008', 'CS037', 'no');
INSERT INTO Cuonsach VALUES ('ISBN008', 'CS038', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN008', 'CS039', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN008', 'CS040', 'yes');

-- ISBN009 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN009', 'CS041', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN009', 'CS042', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN009', 'CS043', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN009', 'CS044', 'no');
INSERT INTO Cuonsach VALUES ('ISBN009', 'CS045', 'yes');

-- ISBN010 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN010', 'CS046', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN010', 'CS047', 'no');
INSERT INTO Cuonsach VALUES ('ISBN010', 'CS048', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN010', 'CS049', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN010', 'CS050', 'no');

-- ISBN011 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN011', 'CS051', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN011', 'CS052', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN011', 'CS053', 'no');
INSERT INTO Cuonsach VALUES ('ISBN011', 'CS054', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN011', 'CS055', 'yes');

-- ISBN012 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN012', 'CS056', 'no');
INSERT INTO Cuonsach VALUES ('ISBN012', 'CS057', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN012', 'CS058', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN012', 'CS059', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN012', 'CS060', 'no');

-- ISBN013 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN013', 'CS061', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN013', 'CS062', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN013', 'CS063', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN013', 'CS064', 'no');
INSERT INTO Cuonsach VALUES ('ISBN013', 'CS065', 'yes');

-- ISBN014 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN014', 'CS066', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN014', 'CS067', 'no');
INSERT INTO Cuonsach VALUES ('ISBN014', 'CS068', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN014', 'CS069', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN014', 'CS070', 'no');

-- ISBN015 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN015', 'CS071', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN015', 'CS072', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN015', 'CS073', 'no');
INSERT INTO Cuonsach VALUES ('ISBN015', 'CS074', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN015', 'CS075', 'yes');

-- ISBN016 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN016', 'CS076', 'no');
INSERT INTO Cuonsach VALUES ('ISBN016', 'CS077', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN016', 'CS078', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN016', 'CS079', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN016', 'CS080', 'no');

-- ISBN017 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN017', 'CS081', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN017', 'CS082', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN017', 'CS083', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN017', 'CS084', 'no');
INSERT INTO Cuonsach VALUES ('ISBN017', 'CS085', 'yes');

-- ISBN018 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN018', 'CS086', 'no');
INSERT INTO Cuonsach VALUES ('ISBN018', 'CS087', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN018', 'CS088', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN018', 'CS089', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN018', 'CS090', 'no');

-- ISBN019 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN019', 'CS091', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN019', 'CS092', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN019', 'CS093', 'no');
INSERT INTO Cuonsach VALUES ('ISBN019', 'CS094', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN019', 'CS095', 'yes');

-- ISBN020 (5 cuốn)
INSERT INTO Cuonsach VALUES ('ISBN020', 'CS096', 'no');
INSERT INTO Cuonsach VALUES ('ISBN020', 'CS097', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN020', 'CS098', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN020', 'CS099', 'yes');
INSERT INTO Cuonsach VALUES ('ISBN020', 'CS100', 'no');
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
    ma_DocGia VARCHAR(10) PRIMARY KEY,
    ho NVARCHAR(50),
    tenlot NVARCHAR(50),
    ten NVARCHAR(50),
    ngaysinh DATE
);

CREATE TABLE Nguoilon (
    ma_DocGia VARCHAR(10) PRIMARY KEY,
    sonha NVARCHAR(50),
    duong NVARCHAR(100),
    quan NVARCHAR(50),
    dienthoai VARCHAR(15),
    han_sd DATE,
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

CREATE TABLE Treem (
    ma_DocGia VARCHAR(10) PRIMARY KEY,
    ma_DocGia_nguoilon VARCHAR(10),
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia),
    FOREIGN KEY (ma_DocGia_nguoilon) REFERENCES Nguoilon(ma_DocGia)
);

CREATE TABLE DangKy (
    isbn VARCHAR(20),
    ma_DocGia VARCHAR(10),
    ngay_dk DATE,
    ghichu NVARCHAR(255),
    PRIMARY KEY (isbn, ma_DocGia),
    FOREIGN KEY (isbn) REFERENCES Dausach(isbn),
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

CREATE TABLE Muon (
    isbn VARCHAR(20),
    ma_cuonsach VARCHAR(20), 
    ma_DocGia VARCHAR(10),
    ngay_muon DATE,
    ngay_hethan DATE,
    PRIMARY KEY (isbn, ma_cuonsach),
    FOREIGN KEY (isbn) REFERENCES Dausach(isbn),         -- Thêm FK còn thiếu
    FOREIGN KEY (ma_cuonsach) REFERENCES Cuonsach(ma_cuonsach), 
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);

CREATE TABLE QuaTrinhMuon (
    isbn VARCHAR(20),
    ma_cuonsach VARCHAR(20), 
    ngay_muon DATE,
    ma_DocGia VARCHAR(10),
    ngay_hethan DATE,
    ngay_tra DATE,
    tien_muon DECIMAL(18, 2),
    tien_datra DECIMAL(18, 2),
    tien_datcoc DECIMAL(18, 2),
    ghichu NVARCHAR(255),
    PRIMARY KEY (isbn, ma_cuonsach, ngay_muon),
    FOREIGN KEY (isbn) REFERENCES Dausach(isbn),         -- Thêm FK còn thiếu
    FOREIGN KEY (ma_cuonsach) REFERENCES Cuonsach(ma_cuonsach), 
    FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);
GO

INSERT INTO DocGia (ma_DocGia, ho, tenlot, ten, ngaysinh) VALUES
('NL001', N'Nguyễn', N'Văn',      N'An',      '1985-03-15'),
('NL002', N'Trần',   N'Thị',      N'Bình',    '1990-07-22'),
('NL003', N'Lê',     N'Hoàng',    N'Cường',   '1978-11-05'),
('NL004', N'Phạm',   N'Thị',      N'Dung',    '1995-01-30'),
('NL005', N'Hoàng',  N'Minh',     N'Đức',     '1988-06-14'),
('NL006', N'Vũ',     N'Thị',      N'Hà',      '1992-09-08'),
('NL007', N'Đặng',   N'Quốc',     N'Hùng',    '1983-04-27'),
('NL008', N'Bùi',    N'Thị',      N'Lan',     '1997-12-03'),
('NL009', N'Đỗ',     N'Văn',      N'Minh',    '1975-08-19'),
('NL010', N'Ngô',    N'Thị',      N'Ngọc',    '1993-02-11'),
('NL011', N'Dương',  N'Thanh',    N'Phong',   '1986-05-25'),
('NL012', N'Lý',     N'Thị',      N'Quỳnh',   '1999-10-17'),
('NL013', N'Trịnh',  N'Văn',      N'Sơn',     '1980-07-09'),
--Trẻ em
('TE001', N'Nguyễn', N'Thị',      N'Thảo',    '2012-03-20'),
('TE002', N'Trần',   N'Văn',      N'Tú',      '2010-08-15'),
('TE003', N'Lê',     N'Thị',      N'Uyên',    '2014-11-02'),
('TE004', N'Phạm',   N'Minh',     N'Việt',    '2011-05-30'),
('TE005', N'Hoàng',  N'Thị',      N'Xuân',    '2013-01-25'),
('TE006', N'Vũ',     N'Văn',      N'Yên',     '2015-09-10'),
('TE007', N'Đặng',   N'Thị',      N'Zara',    '2009-04-18');
GO
 
INSERT INTO Nguoilon (ma_DocGia, sonha, duong, quan, dienthoai, han_sd) VALUES
('NL001', N'12',  N'Nguyễn Huệ',      N'Quận 1',   '0901234561', '2027-03-15'),
('NL002', N'45',  N'Lê Lợi',          N'Quận 1',   '0912345672', '2026-07-22'),
('NL003', N'78',  N'Trần Hưng Đạo',   N'Quận 5',   '0923456783', '2028-11-05'),
('NL004', N'23',  N'Đinh Tiên Hoàng', N'Quận Bình Thạnh', '0934567894', '2027-01-30'),
('NL005', N'56',  N'Võ Thị Sáu',      N'Quận 3',   '0945678905', '2026-06-14'),
('NL006', N'89',  N'Nam Kỳ Khởi Nghĩa',N'Quận 3',  '0956789016', '2029-09-08'),
('NL007', N'34',  N'Cách Mạng Tháng 8',N'Quận 10',  '0967890127', '2027-04-27'),
('NL008', N'67',  N'Lý Thường Kiệt',  N'Quận 10',  '0978901238', '2026-12-03'),
('NL009', N'11',  N'Hai Bà Trưng',    N'Quận 1',   '0989012349', '2028-08-19'),
('NL010', N'99',  N'Pasteur',         N'Quận 3',   '0990123450', '2027-02-11'),
('NL011', N'42',  N'Nguyễn Đình Chiểu',N'Quận 3',  '0901234562', '2026-05-25'),
('NL012', N'75',  N'Điện Biên Phủ',   N'Quận Bình Thạnh','0912345673','2029-10-17'),
('NL013', N'18',  N'Lê Văn Sỹ',       N'Quận 3',   '0923456784', '2027-07-09');
GO
 

INSERT INTO Treem (ma_DocGia, ma_DocGia_nguoilon) VALUES
('TE001', 'NL001'),
('TE002', 'NL002'),
('TE003', 'NL003'),
('TE004', 'NL004'),
('TE005', 'NL005'),
('TE006', 'NL006'),
('TE007', 'NL007');
GO
 INSERT INTO DangKy (isbn, ma_DocGia, ngay_dk, ghichu) VALUES
('ISBN001', 'NL001',  '2026-05-02', NULL),
('ISBN003', 'NL003',  '2026-05-05', NULL),
('ISBN004', 'NL005',  '2026-05-08', N'Ưu tiên sinh viên'),
('ISBN005', 'NL007',  '2026-05-10', NULL),
('ISBN007', 'TE001', '2026-05-13', N'Phụ huynh đã ký'),
('ISBN009', 'NL009',  '2026-05-16', NULL),
('ISBN010', 'NL002',  '2026-05-19', NULL),
('ISBN012', 'NL004',  '2026-05-22', NULL),
('ISBN013', 'TE003', '2026-05-25', NULL),
('ISBN014', 'NL011', '2026-05-28', NULL),
('ISBN015', 'NL006',  '2026-06-01', NULL),
('ISBN016', 'TE005', '2026-06-03', N'Trẻ em cần người lớn ký'),
('ISBN019', 'NL013', '2026-06-06', NULL),
('ISBN020', 'NL008',  '2026-06-09', NULL),
('ISBN011', 'TE007', '2026-06-11', N'Phụ huynh đã xác nhận');
GO
 

INSERT INTO Muon (isbn, ma_cuonsach, ma_DocGia, ngay_muon, ngay_hethan) VALUES
-- Dữ liệu cũ giữ lại
('ISBN001', 'CS002', 'NL002',  '2026-04-01', '2026-05-16'),
('ISBN001', 'CS005', 'NL010', '2026-06-03', '2026-06-24'),
('ISBN003', 'CS012', 'NL006',  '2026-06-05', '2026-06-26'),
('ISBN004', 'CS016', 'NL012', '2026-05-08', '2026-05-27'),
('ISBN008', 'CS036', 'NL001',  '2026-03-28', '2026-04-14'),
('ISBN010', 'CS047', 'NL005',  '2026-06-08', '2026-06-29'),

-- ============================
-- 4 CẶP NGƯỜI LỚN + TRẺ EM CÙNG MƯỢN
-- ============================

-- Cặp 1: NL002 (đã có) + TE002 (bảo lãnh bởi NL002)
('ISBN006', 'CS026', 'TE002', '2026-06-07', '2026-06-28'),

-- Cặp 2: NL004 + TE004 (bảo lãnh bởi NL004)
('ISBN003', 'CS013', 'NL004', '2026-06-10', '2026-07-01'),
('ISBN016', 'CS076', 'TE004', '2026-06-10', '2026-07-01'),

-- Cặp 3: NL005 (đã có CS047) + TE005 (bảo lãnh bởi NL005)
('ISBN012', 'CS057', 'TE005', '2026-06-11', '2026-07-02'),

-- Cặp 4: NL003 + TE003 (bảo lãnh bởi NL003)
('ISBN013', 'CS062', 'NL003', '2026-06-12', '2026-07-03'),
('ISBN014', 'CS068', 'TE003', '2026-06-12', '2026-07-03');
GO
 
INSERT INTO QuaTrinhMuon
    (isbn, ma_cuonsach, ngay_muon, ma_DocGia, ngay_hethan, ngay_tra,
     tien_muon, tien_datra, tien_datcoc, ghichu)
VALUES
-- Trả đúng hạn
('ISBN001', 'CS003', '2026-01-05', 'NL001',  '2026-01-26', '2026-01-20', 5000, 5000,  20000, NULL),
('ISBN002', 'CS006', '2026-01-10', 'NL003',  '2026-01-31', '2026-01-28', 5000, 5000,  20000, NULL),
('ISBN003', 'CS011', '2026-02-01', 'NL005',  '2026-02-22', '2026-02-18', 5000, 5000,  20000, NULL),
('ISBN004', 'CS017', '2026-02-10', 'NL007',  '2026-03-03', '2026-02-27', 5000, 5000,  20000, NULL),
('ISBN005', 'CS021', '2026-02-15', 'TE001', '2026-03-08', '2026-03-04', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISBN006', 'CS027', '2026-03-01', 'NL009',  '2026-03-22', '2026-03-19', 5000, 5000,  20000, NULL),
('ISBN007', 'CS031', '2026-03-05', 'NL011', '2026-03-26', '2026-03-21', 5000, 5000,  20000, NULL),
('ISBN009', 'CS041', '2026-03-10', 'NL002',  '2026-03-31', '2026-03-28', 5000, 5000,  20000, NULL),
('ISBN010', 'CS046', '2026-03-15', 'TE003', '2026-04-05', '2026-04-01', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISBN012', 'CS056', '2026-04-01', 'NL004',  '2026-04-22', '2026-04-19', 5000, 5000,  20000, NULL),
-- Trả trễ hạn (có phí phạt, 1500đ/ngày)
('ISBN013', 'CS061', '2026-04-05', 'NL006',  '2026-04-26', '2026-05-03', 5000, 15500, 20000, N'Trả trễ 7 ngày'),
('ISBN014', 'CS066', '2026-04-10', 'NL008',  '2026-05-01', '2026-05-10', 5000, 18500, 20000, N'Trả trễ 9 ngày'),
('ISBN015', 'CS071', '2026-04-15', 'TE005', '2026-05-06', '2026-05-15', 5000, 18500, 20000, N'Trả trễ 9 ngày - trẻ em'),
('ISBN017', 'CS081', '2026-05-01', 'NL010', '2026-05-22', '2026-06-02', 5000, 21500, 20000, N'Trả trễ 11 ngày'),
('ISBN019', 'CS091', '2026-05-05', 'TE007', '2026-05-26', '2026-06-05', 5000, 20000, 20000, N'Trả trễ 10 ngày - trẻ em'),
-- Thêm lượt đa dạng
('ISBN008', 'CS037', '2026-01-20', 'NL012', '2026-02-10', '2026-02-07', 5000, 5000,  20000, NULL),
('ISBN011', 'CS051', '2026-02-20', 'NL013', '2026-03-13', '2026-03-10', 5000, 5000,  20000, NULL),
('ISBN016', 'CS077', '2026-03-20', 'TE006', '2026-04-10', '2026-04-08', 5000, 5000,  20000, N'Trẻ em mượn'),
('ISBN018', 'CS086', '2026-04-20', 'NL004',  '2026-05-11', '2026-05-09', 5000, 5000,  20000, NULL),
('ISBN020', 'CS096', '2026-05-10', 'TE004', '2026-05-31', '2026-06-04', 5000, 11500, 20000, N'Trả trễ 4 ngày - trẻ em');
GO