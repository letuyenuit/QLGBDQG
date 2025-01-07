USE [master]
CREATE DATABASE [QuanLyGiaiBongDa]
USE [QuanLyGiaiBongDa]
CREATE TABLE [dbo].[MuaGiai] (
	[MaMuaGiai] [VARCHAR](50) PRIMARY KEY,
	[TenMuaGiai] [VARCHAR](50) UNIQUE NOT NULL,
	[ThoiGianBatDauMuaGiai] [DATETIME] NOT NULL,
	[ThoiGianKetThucMuaGiai] [DATETIME] NOT NULL,
	CONSTRAINT ck_mg_tg CHECK (ThoiGianKetThucMuaGiai > ThoiGianBatDauMuaGiai)
)
CREATE TABLE [dbo].[Account] (
	[MaTK] [VARCHAR](50) PRIMARY KEY,
	[TenTK] [VARCHAR](50) UNIQUE NOT NULL,
	[MatKhau] [VARCHAR](50) NOT NULL
)
CREATE TABLE [dbo].[SanNha] (
	[MaSanNha] [VARCHAR](50) PRIMARY KEY,
	[TenSanNha] [NVARCHAR](50) NOT NULL,
	[DiaChi] [NVARCHAR](100) NOT NULL,
	[SucChua] [bigint] NOT NULL,
)
CREATE TABLE [dbo].[LoaiCauThu] (
	[MaLoaiCT] [VARCHAR](50) PRIMARY KEY,
	[TenLoai] [NVARCHAR](50) UNIQUE NOT NULL
)
CREATE TABLE [dbo].[LoaiBanThang] (
	[MaLoaiBT] [VARCHAR](50) PRIMARY KEY,
	[TenLoai] [NVARCHAR](50) UNIQUE NOT NULL,
)
CREATE TABLE [dbo].[QuyDinhDoiBong] (
	[MaQuyDinh] [VARCHAR](50) PRIMARY KEY,
	[SoLuongCauThuToiThieu] [INT] NOT NULL,
	[SoLuongCauThuToiDa] [INT] NOT NULL,
	[SoLuongCauThuToiDaNuocNgoai] [INT] NOT NULL,
	[SoTuoiToiThieu] [INT] NOT NULL,
	[SoTuoiToiDa] [INT] NOT NULL,
	[ThoiDiemGhiBanToiDa] [INT] NOT NULL,
	CONSTRAINT ck_qd_tuoi CHECK (0 < SoTuoiToiThieu AND SoTuoiToiThieu < SoTuoiToiDa),
	CONSTRAINT ck_slct CHECK (SoLuongCauThuToiThieu > 0 AND SoLuongCauThuToiThieu < SoLuongCauThuToiDa),
	CONSTRAINT ck_slct_nc CHECK (SoLuongCauThuToiDaNuocNgoai > 0)
);
CREATE TABLE [dbo].[DoiBong] (
	[MaDoiBong] [VARCHAR](50) PRIMARY KEY,
	[TenDoiBong] [NVARCHAR](50) UNIQUE NOT NULL,
	[ThoiGianThanhLap] [DATETIME] NOT NULL,
	[MaSanNha] [VARCHAR](50) NULL,
	FOREIGN KEY ([MaSanNha]) REFERENCES [dbo].[SanNha]([MaSanNha]) ON DELETE SET NULL,
	CONSTRAINT Ck_SanNha UNIQUE ([MaSanNha])
)
CREATE TABLE [dbo].[CauThu] (
	[MaCT] [VARCHAR] (50) PRIMARY KEY,
	[TenCT] [NVARCHAR](50) NOT NULL,
	[NgaySinh] [DATE] NOT NULL, 
	[MaDoiBong] [VARCHAR](50) NOT NULL,
	[MaLoaiCT] [VARCHAR](50) NOT NULL, 
	[GhiChu] [NVARCHAR](200) NULL,
	[SoAo] [INT] NOT NULL,
    FOREIGN KEY ([MaDoiBong]) REFERENCES [dbo].[DoiBong]([MaDoiBong]),
	FOREIGN KEY ([MaLoaiCT]) REFERENCES [dbo].[LoaiCauThu]([MaLoaiCT]),
	CONSTRAINT ct_unique_db_soao UNIQUE ([MaDoiBong], [SoAo])
)
CREATE TABLE [dbo].[DangKiThiDau] (
	[MaThiDau] [VARCHAR](50) PRIMARY KEY,
	[TenThiDau] [NVARCHAR](50) UNIQUE NOT NULL,
	[MaDoiBong1] [VARCHAR](50) NOT NULL,
	[MaDoiBong2] [VARCHAR](50) NOT NULL,
	[ThoiGianThiDau] [DATE] NOT NULL,
	[ThoiLuongThiDau] [INT] NOT NULL,
	[LuotThiDau] tinyint NOT NULL,
	[MaSanNha] [VARCHAR](50),
	[MaMuaGiai] [VARCHAR](50) NOT NULL, 
	FOREIGN KEY ([MaDoiBong1]) REFERENCES [dbo].[DoiBong]([MaDoiBong]),
	FOREIGN KEY ([MaDoiBong2]) REFERENCES [dbo].[DoiBong]([MaDoiBong]),
	FOREIGN KEY ([MaSanNha]) REFERENCES [dbo].[SanNha]([MaSanNha]),
	FOREIGN KEY ([MaMuaGiai]) REFERENCES [dbo].[MuaGiai]([MaMuaGiai]),
	CONSTRAINT ck_unique_thi_dau UNIQUE ([MaDoiBong1],[MaDoiBong2],[ThoiGianThiDau],[LuotThiDau],[MaMuaGiai])
)
CREATE TABLE [dbo].[BanThang] (
	[MaBanThang] [VARCHAR](50) PRIMARY KEY,
	[TenBanThang] [NVARCHAR](50) UNIQUE NOT NULL,
	[MaCT] [VARCHAR](50) NOT NULL,
	[MaThiDau] [VARCHAR](50) NOT NULL,
	[MaLoaiBT] [VARCHAR](50) NOT NULL,
	[ThoiDiemGhiBan] [int] NOT NULL,
	FOREIGN KEY ([MaCT]) REFERENCES [dbo].[CauThu](MaCT),
	FOREIGN KEY ([MaLoaiBT]) REFERENCES [dbo].[LoaiBanThang](MaLoaiBT),
	FOREIGN KEY ([MaThiDau]) REFERENCES [dbo].[DangKiThiDau](MaThiDau),
)
CREATE TABLE [dbo].[KetQuaThiDau] (
	[MaKetQua] INT IDENTITY(1,1) PRIMARY KEY,
	[SoBanDoi1] INT NULL,
	[SoBanDoi2] INT NULL,
	[MaThiDau] [VARCHAR](50) NULL,
	FOREIGN KEY ([MaThiDau]) REFERENCES [dbo].[DangKiThiDau]([MaThiDau])
)


GO
CREATE TRIGGER trg_CheckCauThu
ON [dbo].[CauThu]
INSTEAD OF INSERT, UPDATE
AS 
BEGIN 
	
	DECLARE @MaCT VARCHAR(50), @MaDoiBong VARCHAR(50), @SoLuongCauThuMax INT
	,@SoLuongCauThuMin INT,@SoTuoiToiThieu INT, @SoTuoiToiDa INT, @TongCauThu INT
	,@TongCauThuNgoai INT, @TongCauThuNgoaiQuoc INT, @MaLoaiCT VARCHAR(50)
	, @NgaySinh DATE, @Tuoi INT;
	
	SELECT @MaDoiBong = MaDoiBong
	FROM inserted;

	SELECT @MaLoaiCT = MaLoaiCT
	FROM inserted;

	SELECT @NgaySinh = NgaySinh
	FROM inserted;

	SELECT @SoLuongCauThuMax = [SoLuongCauThuToiDa]
	FROM [dbo].[QuyDinhDoiBong];

	SELECT @SoLuongCauThuMin = [SoLuongCauThuToiThieu]
	FROM [dbo].[QuyDinhDoiBong];

	SELECT @TongCauThuNgoaiQuoc = [SoLuongCauThuToiDaNuocNgoai]
	FROM [dbo].[QuyDinhDoiBong];

	SELECT @SoTuoiToiThieu = [SoTuoiToiThieu]
	FROM [dbo].[QuyDinhDoiBong];

	SELECT @SoTuoiToiDa = [SoTuoiToiDa]
	FROM [dbo].[QuyDinhDoiBong];


	SELECT @TongCauThu = COUNT (*) FROM [dbo].[CauThu]
						 WHERE [dbo].[CauThu].[MaDoiBong] = @MaDoiBong
	SELECT @TongCauThuNgoai = COUNT (*) FROM [dbo].[CauThu]
						 INNER JOIN [dbo].[LoaiCauThu] ON [dbo].[LoaiCauThu].[MaLoaiCT] = [dbo].[CauThu].[MaLoaiCT]
						 INNER JOIN [dbo].[DoiBong] ON [dbo].[DoiBong].[MaDoiBong] = [dbo].[CauThu].[MaLoaiCT]
						 WHERE [dbo].[CauThu].[MaDoiBong] = @MaDoiBong AND [dbo].[CauThu].[MaLoaiCT] = 'MLCT002'

	IF  @TongCauThu >= @SoLuongCauThuMax
    BEGIN
        RAISERROR('Đội bóng đã đủ số lượng', 16, 1);
        ROLLBACK TRANSACTION;
		RETURN;
    END

	IF @TongCauThuNgoai >= @TongCauThuNgoaiQuoc
	BEGIN
		RAISERROR('Số lượng cầu thủ nhập tịch đã đủ.', 16, 1);
        ROLLBACK TRANSACTION;
		RETURN;
	END

	IF (DATEDIFF(YEAR, @NgaySinh, GETDATE()) < @SoTuoiToiThieu OR DATEDIFF(YEAR, @NgaySinh, GETDATE()) > @SoTuoiToiDa)
	BEGIN
		RAISERROR('Số tuổi không đúng quy định', 16, 1);
        ROLLBACK TRANSACTION;
		RETURN;
	END
END

GO
CREATE TRIGGER trg_DangKiThiDau
ON [dbo].[DangKiThiDau]
INSTEAD OF INSERT, UPDATE
AS
BEGIN

	DECLARE @MaDoiBong1 VARCHAR(50), @MaSanNha VARCHAR(50) , @ThoiDiemGhiBanToiDa INT , @ThoiLuongThiDau INT;

    SELECT @MaDoiBong1 = MaDoiBong1
    FROM inserted;

	SELECT @MaSanNha = sn.MaSanNha
	FROM [dbo].[DoiBong] AS db
	INNER JOIN [dbo].[SanNha] AS sn ON sn.MaSanNha = db.MaSanNha
	WHERE db.MaDoiBong = @MaDoiBong1

	SELECT @ThoiDiemGhiBanToiDa = ThoiDiemGhiBanToiDa
	FROM [dbo].[QuyDinhDoiBong]

	SELECT @ThoiLuongThiDau = ThoiLuongThiDau
	FROM inserted

	IF @ThoiLuongThiDau > @ThoiDiemGhiBanToiDa
	BEGIN 
		RAISERROR('Thời gian đã vượt qua thời gian ghi bàn tối đa quy định', 16, 1);
		ROLLBACK TRANSACTION;
		RETURN;
	END

	IF @MaSanNha IS NOT NULL
    BEGIN
		UPDATE [dbo].[DangKiThiDau]
		SET MaSanNha = @MaSanNha
		WHERE MaDoiBong1 = @MaDoiBong1

		RETURN;
    END

END;


GO
CREATE TRIGGER trg_KetQuaThiDau
ON [dbo].[BanThang]
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    DECLARE @MaThiDau VARCHAR(50),@MaThiDau_Check VARCHAR(50), @MaCT VARCHAR(50), @SoBanThangDoi1 int, @SoBanThangDoi2 int, @MaKetQua int , @ThoiDiemGhiBanToiDa INT, @ThoiDiemGhiBan INT;
    SELECT @MaThiDau = MaThiDau, @MaCT = MaCT
    FROM inserted;


	SELECT @ThoiDiemGhiBanToiDa = ThoiDiemGhiBanToiDa
	FROM [dbo].[QuyDinhDoiBong]

	SELECT @ThoiDiemGhiBan = ThoiDiemGhiBan
	FROM inserted
    
    SELECT @SoBanThangDoi1 =COUNT(*) FROM [dbo].[BanThang] BT
							JOIN [dbo].[DangKiThiDau] DKT ON BT.MaThiDau = DKT.MaThiDau
							JOIN [dbo].[CauThu] CT ON BT.MaCT = CT.MaCT
							WHERE DKT.MaDoiBong1 = CT.MaDoiBong
							AND DKT.MaThiDau = @MaThiDau;
    
    SELECT @SoBanThangDoi2 =COUNT(*) FROM [dbo].[BanThang] BT
							JOIN [dbo].[DangKiThiDau] DKT ON BT.MaThiDau = DKT.MaThiDau
							JOIN [dbo].[CauThu] CT ON BT.MaCT = CT.MaCT
							WHERE DKT.MaDoiBong2 = CT.MaDoiBong
							AND DKT.MaThiDau = @MaThiDau;

	SELECT @MaKetQua = MaKetQua FROM [dbo].[KetQuaThiDau]
					   INNER JOIN [dbo].[DangKiThiDau] AS dktd ON dktd.MaThiDau = @MaThiDau

	SELECT @MaThiDau_Check = MaThiDau FROM [dbo].KetQuaThiDau
						     WHERE MaThiDau = @MaThiDau

	IF @ThoiDiemGhiBan > @ThoiDiemGhiBanToiDa
	BEGIN 
		RAISERROR('Thời gian đã vượt qua thời gian ghi bàn tối đa quy định', 16, 1);
		ROLLBACK TRANSACTION;
		RETURN;
	END

	IF @MaThiDau_Check IS NOT NULL
	BEGIN
		UPDATE [dbo].[KetQuaThiDau]
		SET SoBanDoi1 = @SoBanThangDoi1,SoBanDoi2 = @SoBanThangDoi2, MaThiDau=@MaThiDau_Check
		WHERE MaThiDau = @MaThiDau_Check
		RETURN;
	END
	ELSE
	BEGIN
		INSERT [dbo].[KetQuaThiDau] (SoBanDoi1, SoBanDoi2, MaThiDau) VALUES (@SoBanThangDoi1, @SoBanThangDoi2, @MaThiDau)
		RETURN;
	END
END;




GO
INSERT INTO [dbo].[MuaGiai] 
    ([MaMuaGiai], [TenMuaGiai], [ThoiGianBatDauMuaGiai], [ThoiGianKetThucMuaGiai])
VALUES
    ('MG01', 'Premier League 2023/2024', '2023-08-01', '2024-05-20'),
    ('MG02', 'Premier League 2022/2023', '2022-08-01', '2023-05-20'),
    ('MG03', 'Premier League 2021/2022', '2021-08-01', '2022-05-22'),
    ('MG04', 'Premier League 2020/2021', '2020-09-12', '2021-05-23'),
    ('MG05', 'Premier League 2019/2020', '2019-08-09', '2020-07-26');


GO
INSERT INTO dbo.SanNha (MaSanNha, TenSanNha, DiaChi, SucChua)
VALUES
('MANU', 'Old Trafford', 'Manchester, England', 74879),
('MCI', 'Etihad Stadium', 'Manchester, England', 55397),
('LIV', 'Anfield', 'Liverpool, England', 54074),
('CHE', 'Stamford Bridge', 'London, England', 40635),
('ARS', 'Emirates Stadium', 'London, England', 60361),
('TOT', 'Tottenham Hotspur Stadium', 'London, England', 62507),
('MUN', 'Old Trafford', 'Manchester, England', 74879),
('NEW', 'St James Park', 'Newcastle, England', 52338),
('LEI', 'King Power Stadium', 'Leicester, England', 32312),
('AVL', 'Villa Park', 'Birmingham, England', 42790),
('WOL', 'Molineux Stadium', 'Wolverhampton, England', 31801),
('BHA', 'Amex Stadium', 'Falmer, England', 30750),
('WHU', 'London Stadium', 'London, England', 60000),
('CRY', 'Selhurst Park', 'London, England', 25900),
('SOU', 'St Mary Stadium', 'Southampton, England', 32550),
('EVE', 'Goodison Park', 'Liverpool, England', 39414),
('NOR', 'Carrow Road', 'Norwich, England', 27434),
('BUR', 'Turf Moor', 'Burnley, England', 22194),
('SHU', 'Bramall Lane', 'Sheffield, England', 32309),
('NOTF', 'Notting Ham City', 'NottingHam, England', 32309);

GO
INSERT INTO [dbo].[LoaiCauThu] (MaLoaiCT, TenLoai)
VALUES 
('MLCT001', N'Cầu Thủ Trong Nước'),
('MLCT002', N'Cầu Thủ Nhập Tịch');

GO
INSERT INTO [dbo].[LoaiBanThang] (MaLoaiBT, TenLoai)
VALUES 
('BT1', N'Bàn thắng từ sút bóng'),
('BT2', N'Bàn thắng đánh đầu'),
('BT3', N'Bàn thắng phạt đền');

GO
INSERT INTO [dbo].[QuyDinhDoiBong] (MaQuyDinh, SoLuongCauThuToiThieu, SoLuongCauThuToiDa, SoLuongCauThuToiDaNuocNgoai, SoTuoiToiThieu, SoTuoiToiDa, ThoiDiemGhiBanToiDa)
VALUES
('QD01', 15, 22, 3, 16, 40, 90);

GO
INSERT INTO [dbo].[DoiBong] (MaDoiBong, TenDoiBong, ThoiGianThanhLap, MaSanNha)
VALUES
('DB01', 'Manchester United', '1878-03-05', 'MANU'),
('DB02', 'Liverpool FC', '1892-06-03', 'LIV'),
('DB03', 'Chelsea FC', '1905-03-10', 'CHE'),
('DB04', 'Arsenal FC', '1886-10-01', 'ARS'),
('DB05', 'Manchester City', '1880-11-13', 'MCI');

GO
INSERT INTO [dbo].[CauThu] (MaCT, TenCT, NgaySinh, MaDoiBong, MaLoaiCT, GhiChu, SoAo)
VALUES
('CT01', 'Cristiano Ronaldo', '1990-02-05', 'DB01', 'MLCT001', 'Top scorer of all time', 10),
('CT02', 'Lionel Messi', '1991-06-24', 'DB02', 'MLCT001', 'Greatest playmaker of all time', 20),
('CT03', 'Neymar Jr.', '1992-02-05', 'DB03', 'MLCT001', 'Known for skillful dribbles', 23),
('CT04', 'Kylian Mbappe', '1993-12-20', 'DB04', 'MLCT001', 'World Cup winner at 19', 17),
('CT05', 'Kevin De Bruyne', '1994-06-28', 'DB05', 'MLCT002', 'Playmaker with exceptional vision', 7);

GO
INSERT INTO [dbo].[DangKiThiDau] 
    ([MaThiDau], [TenThiDau], [MaDoiBong1], [MaDoiBong2], [ThoiGianThiDau], [ThoiLuongThiDau],[LuotThiDau], [MaMuaGiai])
VALUES
	('TD02', 'CHE VS ARS Luot Ve', 'DB03', 'DB04', '2024-01-20 15:00:00',90,0, 'MG01')


GO
INSERT INTO [dbo].[Account] (MaTK,TenTK, MatKhau)
VALUES ('TK001', 'admin','admin')




--WITH MatchResults AS (
--    SELECT 
--        dk.MaDoiBong1 AS MaDoiBong,
--        SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
--        SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
--    FROM 
--        DangKiThiDau dk
--    LEFT JOIN 
--        BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong1 = bt.MaCT
--    LEFT JOIN 
--        BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong2 = bt2.MaCT
--    GROUP BY 
--        dk.MaDoiBong1

--    UNION ALL

--    SELECT 
--        dk.MaDoiBong2 AS MaDoiBong,
--        SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
--        SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
--    FROM 
--        DangKiThiDau dk
--    LEFT JOIN 
--        BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong2 = bt.MaCT
--    LEFT JOIN 
--        BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong1 = bt2.MaCT
--    GROUP BY 
--        dk.MaDoiBong2
--),
--AggregatedResults AS (
--    SELECT 
--        MaDoiBong,
--        SUM(BanThang) AS TongBanThang,
--        SUM(BanThua) AS TongBanThua,
--        SUM(BanThang - BanThua) AS HieuSo,
--        SUM(CASE WHEN BanThang > BanThua THEN 1 ELSE 0 END) AS SoTranThang,
--        SUM(CASE WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS SoTranHoa,
--        SUM(CASE WHEN BanThang < BanThua THEN 1 ELSE 0 END) AS SoTranThua,
--        SUM(CASE WHEN BanThang > BanThua THEN 3 WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS Diem
--    FROM 
--        MatchResults
--    GROUP BY 
--        MaDoiBong
--)
--SELECT 
--    ar.MaDoiBong,
--    db.TenDoiBong,
--    ar.SoTranThang,
--    ar.SoTranHoa,
--    ar.SoTranThua,
--    ar.TongBanThang,
--    ar.TongBanThua,
--    ar.HieuSo,
--    ar.Diem,
--    RANK() OVER (ORDER BY ar.Diem DESC, ar.HieuSo DESC, ar.TongBanThang DESC) AS Hang
--FROM 
--    AggregatedResults ar
--JOIN 
--    DoiBong db ON ar.MaDoiBong = db.MaDoiBong
--ORDER BY 
--    Hang;
