USE [QLGiaiBongDa]
GO
/****** Object:  Table [dbo].[DoiBong]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiBong](
	[MaDB] [nvarchar](50) NOT NULL,
	[TenDB] [nvarchar](200) NULL,
 CONSTRAINT [PK_DoiBong] PRIMARY KEY CLUSTERED 
(
	[MaDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanThang]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanThang](
	[MaBT] [nvarchar](50) NOT NULL,
	[MaTD] [nvarchar](50) NULL,
	[MaCT] [nvarchar](50) NULL,
	[ThoiDiem] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaDB] [nvarchar](50) NULL,
 CONSTRAINT [PK_BanThang] PRIMARY KEY CLUSTERED 
(
	[MaBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vThongKeBanThang]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vThongKeBanThang]
AS
SELECT DoiBong.*, (SELECT COUNT(*) FROM BanThang WHERE BanThang.MaDB = DoiBong.MaDB) AS SoBT FROM DoiBong
GO
/****** Object:  Table [dbo].[CauThu]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauThu](
	[MaCT] [nvarchar](50) NOT NULL,
	[MaDB] [nvarchar](50) NULL,
	[TenCT] [nvarchar](200) NULL,
	[NgaySinh] [datetime] NULL,
	[SoAo] [int] NULL,
	[ViTri] [nvarchar](100) NULL,
	[QuocTich] [nvarchar](100) NULL,
	[GhiBan] [int] NULL,
	[ThePhat] [int] NULL,
 CONSTRAINT [PK_CauThu] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrongTai]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrongTai](
	[MaTT] [nvarchar](50) NOT NULL,
	[TenTT] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
 CONSTRAINT [PK_TrongTai] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TranDau]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TranDau](
	[MaTD] [nvarchar](50) NOT NULL,
	[MaDoi1] [nvarchar](50) NULL,
	[MaDoi2] [nvarchar](50) NULL,
	[NgayGio] [datetime] NULL,
	[MaSan] [nvarchar](50) NULL,
	[VongDau] [nvarchar](100) NULL,
	[MaLoai] [nvarchar](50) NULL,
	[SoBTDoi1] [int] NULL,
	[SoBTDoi2] [int] NULL,
	[ThoiLuong] [int] NULL,
 CONSTRAINT [PK_TranDau] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThePhat]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThePhat](
	[MaTP] [nvarchar](50) NOT NULL,
	[MaTD] [nvarchar](50) NULL,
	[MaCT] [nvarchar](50) NULL,
	[MaTT] [nvarchar](50) NULL,
	[ThoiDiem] [int] NULL,
	[LoaiThe] [nvarchar](100) NULL,
	[MaDB] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThePhat] PRIMARY KEY CLUSTERED 
(
	[MaTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vThongKeThePhat]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vThongKeThePhat]
as
SELECT ThePhat.MaTP, TranDau.MaTD, DoiBong.TenDB, CauThu.TenCT, ThoiDiem, LoaiThe FROM ThePhat
INNER JOIN TranDau ON TranDau.MaTD = ThePhat.MaTD
INNER JOIN CauThu ON CauThu.MaCT = ThePhat.MaCT
INNER JOIN DoiBong ON DoiBong.MaDB = ThePhat.MaDB
INNER JOIN TrongTai ON TrongTai.MaTT = ThePhat.MaTT
GO
/****** Object:  Table [dbo].[BangXepHang]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangXepHang](
	[MaBXH] [nvarchar](50) NOT NULL,
	[MaDB] [nvarchar](50) NULL,
	[Thang] [int] NULL,
	[Hoa] [int] NULL,
	[Thua] [int] NULL,
	[Hang] [int] NULL,
 CONSTRAINT [PK_BangXepHang] PRIMARY KEY CLUSTERED 
(
	[MaBXH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTranDau]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTranDau](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiTranDau] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaTaiTro]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaTaiTro](
	[MaNTT] [nvarchar](50) NOT NULL,
	[TenNTT] [nvarchar](100) NULL,
 CONSTRAINT [PK_NhaTaiTro] PRIMARY KEY CLUSTERED 
(
	[MaNTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCongTrongTai]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCongTrongTai](
	[MaPC] [nvarchar](50) NOT NULL,
	[MaTD] [nvarchar](50) NULL,
	[MaTT] [nvarchar](50) NULL,
	[VaiTro] [nvarchar](100) NULL,
 CONSTRAINT [PK_PhanCongTrongTai] PRIMARY KEY CLUSTERED 
(
	[MaPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San](
	[MaSan] [nvarchar](50) NOT NULL,
	[TenSan] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SucChua] [int] NULL,
 CONSTRAINT [PK_San] PRIMARY KEY CLUSTERED 
(
	[MaSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/20/2024 08:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](20) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangXepHang] ([MaBXH], [MaDB], [Thang], [Hoa], [Thua], [Hang]) VALUES (N'BXH001', N'DB001', 0, 0, 0, 0)
GO
INSERT [dbo].[BanThang] ([MaBT], [MaTD], [MaCT], [ThoiDiem], [GhiChu], [MaDB]) VALUES (N'BT001', N'TD001', N'CT003', 0, N'', N'DB002')
GO
INSERT [dbo].[CauThu] ([MaCT], [MaDB], [TenCT], [NgaySinh], [SoAo], [ViTri], [QuocTich], [GhiBan], [ThePhat]) VALUES (N'CT001', N'DB001', N'Lê Tuấn', CAST(N'2000-05-07T00:00:00.000' AS DateTime), 1, N'Thủ Môn', N'Việt Nam', 0, 0)
INSERT [dbo].[CauThu] ([MaCT], [MaDB], [TenCT], [NgaySinh], [SoAo], [ViTri], [QuocTich], [GhiBan], [ThePhat]) VALUES (N'CT002', N'DB002', N'Hoàng Ngọc Hạnh', CAST(N'1995-05-07T00:00:00.000' AS DateTime), 3, N'Tiền Vệ', N'Việt Nam', 0, 0)
INSERT [dbo].[CauThu] ([MaCT], [MaDB], [TenCT], [NgaySinh], [SoAo], [ViTri], [QuocTich], [GhiBan], [ThePhat]) VALUES (N'CT003', N'DB002', N'Công Vinh', CAST(N'1997-07-01T00:00:00.000' AS DateTime), 2, N'Tiền Đạo', N'Việt Nam', 0, 0)
GO
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB001', N'Than Quảng Ninh')
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB002', N'Becamex Bình Dương')
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB003', N'SHB Đà Nẵng')
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB004', N'Gạch Đồng Tâm Long An')
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB005', N'QNK Quảng Nam')
INSERT [dbo].[DoiBong] ([MaDB], [TenDB]) VALUES (N'DB006', N'Đồng Tháp')
GO
INSERT [dbo].[LoaiTranDau] ([MaLoai], [TenLoai]) VALUES (N'L001', N'Lượt đi')
INSERT [dbo].[LoaiTranDau] ([MaLoai], [TenLoai]) VALUES (N'L002', N'Lượt về')
GO
INSERT [dbo].[NhaTaiTro] ([MaNTT], [TenNTT]) VALUES (N'N001', N'Công ty Minh Quân')
INSERT [dbo].[NhaTaiTro] ([MaNTT], [TenNTT]) VALUES (N'N002', N'Công ty nước giải khát Chương Dương')
INSERT [dbo].[NhaTaiTro] ([MaNTT], [TenNTT]) VALUES (N'N003', N'Bia BIVA')
GO
INSERT [dbo].[PhanCongTrongTai] ([MaPC], [MaTD], [MaTT], [VaiTro]) VALUES (N'PC001', N'TD001', N'TT001', N'Trọng Tài Chính')
GO
INSERT [dbo].[San] ([MaSan], [TenSan], [DiaChi], [SucChua]) VALUES (N'S001', N'Sân Quảng Ninh', N'Quảng Ninh', 3000)
INSERT [dbo].[San] ([MaSan], [TenSan], [DiaChi], [SucChua]) VALUES (N'S002', N'Sân Nghệ An', N'Nghệ An', 4000)
INSERT [dbo].[San] ([MaSan], [TenSan], [DiaChi], [SucChua]) VALUES (N'S003', N'Sân Đồng Tháp', N'Đồng Tháp', 3500)
INSERT [dbo].[San] ([MaSan], [TenSan], [DiaChi], [SucChua]) VALUES (N'S004', N'Sân Đồng Nai', N'Đồng Nai', 4000)
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [MatKhau]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[ThePhat] ([MaTP], [MaTD], [MaCT], [MaTT], [ThoiDiem], [LoaiThe], [MaDB]) VALUES (N'TP001', N'TD001', N'CT003', N'TT001', 0, N'Thẻ Vàng', N'DB002')
GO
INSERT [dbo].[TranDau] ([MaTD], [MaDoi1], [MaDoi2], [NgayGio], [MaSan], [VongDau], [MaLoai], [SoBTDoi1], [SoBTDoi2], [ThoiLuong]) VALUES (N'TD001', N'DB001', N'DB002', CAST(N'2024-05-13T01:41:34.000' AS DateTime), N'S001', N'Vòng 1', N'L001', 0, 0, 90)
INSERT [dbo].[TranDau] ([MaTD], [MaDoi1], [MaDoi2], [NgayGio], [MaSan], [VongDau], [MaLoai], [SoBTDoi1], [SoBTDoi2], [ThoiLuong]) VALUES (N'TD002', N'DB001', N'DB003', CAST(N'2024-05-13T01:41:34.000' AS DateTime), N'S001', N'Vòng 1', N'L001', 0, 0, 90)
GO
INSERT [dbo].[TrongTai] ([MaTT], [TenTT], [NgaySinh]) VALUES (N'TT001', N'Quốc Trọng', CAST(N'1975-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TrongTai] ([MaTT], [TenTT], [NgaySinh]) VALUES (N'TT002', N'Tuấn Khanh', CAST(N'1987-05-02T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_BanThang_CauThu] FOREIGN KEY([MaCT])
REFERENCES [dbo].[CauThu] ([MaCT])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_BanThang_CauThu]
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_BanThang_TranDau] FOREIGN KEY([MaTD])
REFERENCES [dbo].[TranDau] ([MaTD])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_BanThang_TranDau]
GO
ALTER TABLE [dbo].[CauThu]  WITH CHECK ADD  CONSTRAINT [FK_CauThu_DoiBong] FOREIGN KEY([MaDB])
REFERENCES [dbo].[DoiBong] ([MaDB])
GO
ALTER TABLE [dbo].[CauThu] CHECK CONSTRAINT [FK_CauThu_DoiBong]
GO
ALTER TABLE [dbo].[PhanCongTrongTai]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongTrongTai_TranDau] FOREIGN KEY([MaTD])
REFERENCES [dbo].[TranDau] ([MaTD])
GO
ALTER TABLE [dbo].[PhanCongTrongTai] CHECK CONSTRAINT [FK_PhanCongTrongTai_TranDau]
GO
ALTER TABLE [dbo].[PhanCongTrongTai]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongTrongTai_TrongTai] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrongTai] ([MaTT])
GO
ALTER TABLE [dbo].[PhanCongTrongTai] CHECK CONSTRAINT [FK_PhanCongTrongTai_TrongTai]
GO
ALTER TABLE [dbo].[ThePhat]  WITH CHECK ADD  CONSTRAINT [FK_ThePhat_CauThu] FOREIGN KEY([MaCT])
REFERENCES [dbo].[CauThu] ([MaCT])
GO
ALTER TABLE [dbo].[ThePhat] CHECK CONSTRAINT [FK_ThePhat_CauThu]
GO
ALTER TABLE [dbo].[ThePhat]  WITH CHECK ADD  CONSTRAINT [FK_ThePhat_TranDau] FOREIGN KEY([MaTD])
REFERENCES [dbo].[TranDau] ([MaTD])
GO
ALTER TABLE [dbo].[ThePhat] CHECK CONSTRAINT [FK_ThePhat_TranDau]
GO
ALTER TABLE [dbo].[ThePhat]  WITH CHECK ADD  CONSTRAINT [FK_ThePhat_TrongTai] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrongTai] ([MaTT])
GO
ALTER TABLE [dbo].[ThePhat] CHECK CONSTRAINT [FK_ThePhat_TrongTai]
GO
ALTER TABLE [dbo].[ThePhat]  WITH CHECK ADD  CONSTRAINT [FK_ThePhat_TrongTai1] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrongTai] ([MaTT])
GO
ALTER TABLE [dbo].[ThePhat] CHECK CONSTRAINT [FK_ThePhat_TrongTai1]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_DoiBong] FOREIGN KEY([MaDoi1])
REFERENCES [dbo].[DoiBong] ([MaDB])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_DoiBong]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_DoiBong1] FOREIGN KEY([MaDoi2])
REFERENCES [dbo].[DoiBong] ([MaDB])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_DoiBong1]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_LoaiTranDau] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiTranDau] ([MaLoai])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_LoaiTranDau]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_San] FOREIGN KEY([MaSan])
REFERENCES [dbo].[San] ([MaSan])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_San]
GO
