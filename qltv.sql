CREATE DATABASE [QLTV]
GO
USE [QLTV]
GO

CREATE TABLE [dbo].[tblDocGia](
	[MaDG] [varchar](10) NOT NULL,
	[TenDG] [nvarchar](30) NULL,
	[GioiTinhDG] [nvarchar](5) NULL,
	[NgaySinhDG] [varchar](10) NULL,
	[SDTDG] [varchar](20) NULL,
	[DiaChiDG] [nvarchar](50) NULL,
	[LoaiDG] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](30) NULL,
	[TenTaiKhoanDG] [varchar](10) NULL,
	[MatKhauDG] [varchar](20) NULL,
 CONSTRAINT [pk_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHSPhieuMuon]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHSPhieuMuon](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaDG] [varchar](10) NULL,
	[MaSach] [varchar](10) NULL,
	[NgayMuon] [nvarchar](10) NULL,
	[NgayTra] [nvarchar](10) NULL,
	[SLMuon] [int] NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](75) NULL,
 CONSTRAINT [pk_tblMuonTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSach](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[ChuDe] [nvarchar](30) NULL,
	[TacGia] [nvarchar](30) NULL,
	[NXB] [nvarchar](30) NULL,
	[NamXB] [int] NULL,
	[SLNhap] [int] NULL,
	[DonGia] [int] NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[Ghichu] [nvarchar](30) NULL,
 CONSTRAINT [pk_tblSach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblThuThu]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblThuThu](
	[MaTT] [varchar](10) NOT NULL,
	[TenTT] [nvarchar](30) NULL,
	[GioiTinhTT] [nvarchar](5) NULL,
	[NgaySinhTT] [varchar](10) NULL,
	[SDTTT] [int] NULL,
	[DiaChiTT] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](30) NULL,
	[TenTaiKhoanTT] [varchar](10) NULL,
	[MatKhauTT] [varchar](20) NULL,
 CONSTRAINT [pk_tblThuThu] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinhDG], [NgaySinhDG], [SDTDG], [DiaChiDG], [LoaiDG], [GhiChu], [TenTaiKhoanDG], [MatKhauDG]) VALUES (N'DG001', N'Nguyễn Văn Linh', N'Nam', N'05/09/2019', N'099876540', N'123 Hồ Tùng Mậu', N'Sinh viên', N'1', N'DG001', N'1234')
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinhDG], [NgaySinhDG], [SDTDG], [DiaChiDG], [LoaiDG], [GhiChu], [TenTaiKhoanDG], [MatKhauDG]) VALUES (N'DG002', N'Nguyễn Văn Tiến', N'Nam', N'05/09/2019', N'0987654321', N'1 Hoàng Quốc Việt', N'Sinh viên', N'..', N'DG002', N'1234')
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinhDG], [NgaySinhDG], [SDTDG], [DiaChiDG], [LoaiDG], [GhiChu], [TenTaiKhoanDG], [MatKhauDG]) VALUES (N'DG003', N'Nguyễn Tuấn Anh', N'Nam', N'05/09/2019', N'0987654321', N'2 Hoàng Quốc Việt', N'Sinh viên', N'..', N'DG003', N'1234')
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinhDG], [NgaySinhDG], [SDTDG], [DiaChiDG], [LoaiDG], [GhiChu], [TenTaiKhoanDG], [MatKhauDG]) VALUES (N'DG004', N'áda', N'Nam', N'09/05/2019', N'0987654321', N'1', N'Sinh viên', N'', N'DG004', N'a')
INSERT [dbo].[tblHSPhieuMuon] ([MaPhieu], [MaDG], [MaSach], [NgayMuon], [NgayTra], [SLMuon], [TinhTrang], [GhiChu]) VALUES (N'MP004', N'DG003', N'MS005', N'09/05/2019', N'30/05/2019', 1, N'Mới ', N'1 quyển')
INSERT [dbo].[tblHSPhieuMuon] ([MaPhieu], [MaDG], [MaSach], [NgayMuon], [NgayTra], [SLMuon], [TinhTrang], [GhiChu]) VALUES (N'MP005', N'DG002', N'MS002', N'09/05/2019', N'30/05/2019', 1, N'Mới ', N'1 quyển lập trình')
INSERT [dbo].[tblHSPhieuMuon] ([MaPhieu], [MaDG], [MaSach], [NgayMuon], [NgayTra], [SLMuon], [TinhTrang], [GhiChu]) VALUES (N'MP006', N'DG004', N'MS006', N'07/05/2019', N'08/05/2019', 1, N'Mới ', N'')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS001', N'Lập trình Windown', N'Lập trình', N'Nguyễn Xuân Nam', N'NXB Hồng Bàng', 2000, 101, 50000, N'Cũ', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS002', N'Lập trình Web', N'Lập trình', N'Lê Hồng Nhân', N'NXB Giáo Dục', 2001, 101, 50000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS003', N'Lập trình HDT', N'Lập trình', N'Nguyễn Đức Phương', N'NXB Hồng Bàng', 2000, 101, 30000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS004', N'Lập trình SQL', N'Lập trình', N'Nguyễn Xuân Nam', N'NXB Hồng Bàng', 2004, 101, 40000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS005', N'Thiết bị công nghệ hiện đại', N'Công nghệ', N'Trần Xuân Bách', N'NXB Thanh Niên', 2004, 100, 60000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS006', N'Khoa học quanh ta', N'Công nghệ', N'Trần Văn Chung', N'NXB Giáo Dục', 2002, 100, 40000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS007', N'Úng dụng công nghệ', N'Công nghệ', N'Nguyễn Hoài Nhâm', N'NXB Hồng Bàng', 2009, 101, 50000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS008', N'Bạn và Tôi', N'Tiểu thuyết', N'Lệ Thu', N'NXB Trẻ', 2007, 100, 50000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS009', N'Ngày Ấy', N'Tiểu thuyết', N'Nguyễn Hoài Nhớ', N'NXB Thanh Niên', 2010, 101, 40000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS010', N'Tôi đi tìm tôi', N'Tiểu thuyết', N'Phạm Đức', N'NXB Thanh Niên', 2004, 101, 20000, N'Mới', N'...')
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [ChuDe], [TacGia], [NXB], [NamXB], [SLNhap], [DonGia], [TinhTrang], [Ghichu]) VALUES (N'MS011', N'Lập trình', N'Lập trình', N'Nguyễn Hữu Thắng', N'NXB Kim Đồng', 2000, 100, 80000, N'Mới', N'không')
INSERT [dbo].[tblThuThu] ([MaTT], [TenTT], [GioiTinhTT], [NgaySinhTT], [SDTTT], [DiaChiTT], [GhiChu], [TenTaiKhoanTT], [MatKhauTT]) VALUES (N'TT001', N'Nguyễn Hữu Thắng', N'Nam', N'18-01-1999', 987569301, N'hà nội', N'hihi', N'admin', N'1234')
INSERT [dbo].[tblThuThu] ([MaTT], [TenTT], [GioiTinhTT], [NgaySinhTT], [SDTTT], [DiaChiTT], [GhiChu], [TenTaiKhoanTT], [MatKhauTT]) VALUES (N'TT002', N'Nguyễn Hữu Thắng', N'Nam', N'18/01/1999', 987569301, N'Hà Nội', N'  ', N'TT002', N'1234')
INSERT [dbo].[tblThuThu] ([MaTT], [TenTT], [GioiTinhTT], [NgaySinhTT], [SDTTT], [DiaChiTT], [GhiChu], [TenTaiKhoanTT], [MatKhauTT]) VALUES (N'TT003', N'1', N'Nữ', N'09/05/2019', 1, N'1', N'1', N'TT003', N'1')
ALTER TABLE [dbo].[tblHSPhieuMuon]  WITH CHECK ADD  CONSTRAINT [fk_tblMuonTra_tblDocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[tblDocGia] ([MaDG])
GO
ALTER TABLE [dbo].[tblHSPhieuMuon] CHECK CONSTRAINT [fk_tblMuonTra_tblDocGia]
GO
ALTER TABLE [dbo].[tblHSPhieuMuon]  WITH CHECK ADD  CONSTRAINT [fk_tblMuonTra_tblSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblHSPhieuMuon] CHECK CONSTRAINT [fk_tblMuonTra_tblSach]
GO
/****** Object:  StoredProcedure [dbo].[Sp_QlDGQuaHan]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_QlDGQuaHan] as SELECT 
 d.TenDG as 'Tên Độc Giả',  
 count(d.TenDG) as 'Số lượng sách'
 from tblHSPhieuMuon p
 Inner join tblDocGia d on p.MaDG = d.MaDG
 where CONVERT (datetime, NgayTra, 103) < getdate()
  group by  d.TenDG
GO
/****** Object:  StoredProcedure [dbo].[Sp_QlMuonTra]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_QlMuonTra] as
 SELECT d.TenDG,d.SDTDG,d.NgaySinhDG,s.TenSach,s.ChuDe,s.TinhTrang,s.Ghichu,p.NgayMuon,p.NgayTra FROM tblHSPhieuMuon p 
 INNER JOIN tblDocGia d on p.MaDG = d.MaDG 
 INNER JOIN tblSach s on p.MaSach = s.MaSach
GO
/****** Object:  StoredProcedure [dbo].[Sp_QlSachQuaHan]    Script Date: 5/14/2019 2:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_QlSachQuaHan] as SELECT
 p.MaPhieu as 'Mã Phiếu',
 d.TenDG as 'Tên Độc Giả',
 d.SDTDG as 'Số Điện Thoại',
 s.TenSach as 'Tên Sách',
 NgayMuon as 'Ngày Mượn',
 NgayTra as 'Ngày Trả',
 p.GhiChu as 'Ghi Chú'
 from tblHSPhieuMuon p
 Inner join tblDocGia d on p.MaDG = d.MaDG
 inner join tblSach s on p.MaSach = s.MaSach
 where CONVERT (datetime, NgayTra, 103) < getdate()
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
