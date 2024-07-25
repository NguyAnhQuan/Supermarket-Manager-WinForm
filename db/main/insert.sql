USE QuanLySieuThi

-- INSERT INTO NhaCungCap
INSERT INTO NhaCungCap (Mncc, Ten, DiaChi, Sdt, HopTac) 
VALUES 
('NCC001', 'Công ty TNHH A', '123 Đường ABC, Quận Cầu Giấy, TP.Hà Nội', '0901234561', 1),
('NCC002', 'Công ty TNHH B', '456 Đường XYZ, Quận Nam Từ liêm, TP.Hà Nội', '0901234562', 1),
('NCC003', 'Công ty TNHH C', '789 Đường LMN, Quận Cầu Giấy, TP.Hà Nội', '0901234563', 1),
('NCC004', 'Công ty TNHH D', '321 Đường DEF, Quận Bắc Từ liêm, TP.Hà Nội', '0901234564', 1),
('NCC005', 'Công ty TNHH E', '654 Đường UVW, Quận Thanh Xuân, TP.Hà Nội', '0901234565', 1);

-- INSERT INTO KhachHang
INSERT INTO KhachHang (Mkh, HoTen, DiaChi, Sdt, HangKhach) 
VALUES 
('KH001', 'Nguyễn Văn A', '10 Đường PQR, Quận Long Biên, TP.Hà Nội', '0909876541', 0),
('KH002', 'Trần Thị B', '20 Đường STU, Quận Cầu Giấy, TP.Hà Nội', '0909876542', 0),
('KH003', 'Lê Văn C', '30 Đường WXY, Quận Nam Từ liêm, TP.Hà Nội', '0909876543', 0),
('KH004', 'Phạm Thị D', '40 Đường GHI, Quận Bắc Từ Liêm, TP.Hà Nội', '0909876544', 0),
('KH005', 'Hoàng Văn E', '50 Đường JKL, Quận Cầu Giấy, TP.Hà Nội', '0909876545', 0);

-- INSERT INTO NhanVien
INSERT INTO NhanVien (Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong) 
VALUES 
('NV001', '0987654321', '1990-01-01', '5 Đường MNZ, Quận Cầu Giấy, TP.Hà Nội', 'Nguyễn Thị A', 'Nữ', 'Nhân viên bán hàng', 8000000),
('NV002', '0987654322', '1995-05-05', '15 Đường OPQ, Quận Cầu Giấy, TP.Hà Nội', 'Trần Văn B', 'Nam', 'Nhân viên kho', 9000000),
('NV003', '0987654323', '1988-12-10', '25 Đường RST, Quận Bắc Từ Liêm, TP.Hà Nội', 'Lê Thị C', 'Nữ', 'Quản lý', 12000000),
('NV004', '0987654324', '1986-07-20', '35 Đường WXY, Quận Tây Hồ, TP.Hà Nội', 'Phạm Văn D', 'Nam', 'Nhân viên bán hàng', 8000000),
('Admin', '0987254324', '1986-07-20', '3 Đường EXY, Quận Tây Hồ, TP.Hà Nội', 'Nguyễn Anh QUân', 'Nam', 'Chuyên Viên Tổng', 20000000),
('NV005', '0987654325', '1993-03-15', '45 Đường UVW, Quận Long Biên, TP.Hà Nội', 'Hoàng Thị E', 'Nữ', 'Kế toán', 10000000);

-- INSERT INTO DangNhap
INSERT INTO DangNhap (Mdn, Mnv, GioVao, GioRa, MatKhau) 
VALUES 
('DN001', 'NV001', '08:00:00', '17:00:00', 'Nv1'),
('DN002', 'NV002', '08:30:00', '18:00:00', 'Nv2'),
('DN003', 'NV003', '09:00:00', '18:30:00', 'abc'),
('DN004', 'NV004', '09:30:00', '19:00:00', 'xyz'),
('DN005', 'NV005', '10:00:00', '19:30:00', '123@'),
('admin', 'Admin', '00:00:00', '23:59:59', 'admin');

-- INSERT INTO SanPham
INSERT INTO SanPham (Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai) 
VALUES 
('SP001', 'NCC001', 'Sữa óc chó', 100, 50000, '2024-05-01', '2025-05-01', 0, 'Sữa'),
('SP002', 'NCC002', 'Omo matic', 150, 75000, '2024-05-02', '2025-05-02', 0, 'Nước Giặt'),
('SP003', 'NCC003', '333', 200, 100000, '2024-05-03', '2025-05-03', 0, 'Bia'),
('SP004', 'NCC004', 'Nước mắm ông tây', 120, 80000, '2024-05-04', '2025-05-04', 0, 'Gia Vị'),
('SP005', 'NCC005', 'Habeco', 180, 90000, '2024-05-05', '2025-05-05', 0, 'Bia');

-- INSERT INTO UuDai
INSERT INTO UuDai (Mud, Mkh, Ten) 
VALUES 
('UD001', 'KH001', '5%'),
('UD002', 'KH002', '10%'),
('UD003', 'KH003', 'Chủ nhật giảm 20%'),
('UD004', 'KH004', 'lần đầu mua giảm 15%'),
('UD005', 'KH005', 'Habeco giảm 08%');

-- INSERT INTO HoaDon
INSERT INTO HoaDon (Mhd, NgayXuat, Msp, SoLuong, DonGia, ThanhTien, Mkh, Mnv) 
VALUES 
('HD001', '2024-05-31 08:00:00', 'SP001', 2, 50000, 100000, 'KH001', 'NV001'),
('HD002', '2024-05-31 08:30:00', 'SP002', 3, 75000, 225000, 'KH002', 'NV002'),
('HD003', '2024-05-31 09:00:00', 'SP003', 4, 100000, 400000, 'KH003', 'NV003'),
('HD004', '2024-05-31 09:30:00', 'SP004', 1, 80000, 80000, 'KH004', 'NV004'),
('HD005', '2024-05-31 10:00:00', 'SP005', 5, 90000, 450000, 'KH005', 'NV005');

-- INSERT INTO KhoNX
INSERT INTO KhoNX (Mnx, Msp, Mncc, SoLuong, TongGia) 
VALUES 
('KX001', 'SP001', 'NCC001', 100, 5000000),
('KX002', 'SP002', 'NCC002', 150, 11250000),
('KN003', 'SP003', 'NCC003', 200, 20000000),
('KN004', 'SP004', 'NCC004', 120, 9600000),
('KX005', 'SP005', 'NCC005', 180, 16200000);

-- INSERT INTO NganSach
INSERT INTO NganSach (Mns, Ten, Tien, Mhd, Msp, TienNS, Mnx) 
VALUES 
('NS001', 'Bán', 100000000, NULL, NULL, 50000000, 'KX001'),
('NS002', 'Bán', 150000000, NULL, NULL, 75000000, 'KX002'),
('NS003', 'Nhập', 200000000, NULL, NULL, 100000000, 'KN003'),
('NS004', 'Nhập', 120000000, NULL, NULL, 60000000, 'KN004'),
('NS005', 'Bán', 180000000, NULL, NULL, 90000000, 'KX005');
