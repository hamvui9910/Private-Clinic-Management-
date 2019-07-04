USE [master]
GO
/****** Object:  Database [DBPCM]    Script Date: 6/27/2019 1:49:13 PM ******/
WHILE EXISTS(select NULL from sys.databases where name='DBPCM')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'DBPCM') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTC]
END
GO
CREATE DATABASE [DBPCM]
GO
USE [DBPCM]
GO
/****** Object:  Table [dbo].[DanhSachBenhNhan]    Script Date: 6/27/2019 1:49:14 PM ******/
CREATE TABLE [dbo].[DanhSachBenhNhan](
	[BN_maBN] [char](10) NOT NULL,
	[BN_hoten] [varchar](50) NOT NULL,
	[BN_gioitinh] [char](5) NOT NULL,
	[BN_namsinh] [char](4) NOT NULL,
	[BN_diachi] [varchar](50) NOT NULL,
	[BN_sdt] [char](10) NOT NULL,
	[BN_ngaykham] [char](10) NOT NULL,
	[BN_loaibenh] [varchar](50) NULL,
	[BN_trieuchung] [varchar](100) NULL,
 CONSTRAINT [PK_DanhSachBenhNhan] PRIMARY KEY CLUSTERED 
(
	[BN_maBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/27/2019 1:49:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [int] IDENTITY(1,1) NOT NULL,
	[tongcong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 6/27/2019 1:49:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[maQD] [char](5) NOT NULL,
	[tenQD] [char](10) NOT NULL,
	[noidung] [varchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE Thuoc
(
	ID int identity(1,1) PRIMARY KEY NOT NULL,
	tenThuoc varchar(50) NOT NULL,
	giaThuoc decimal NOT NULL
)

SET IDENTITY_INSERT [dbo].[Thuoc] ON
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (1,'Paracetamol','500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (2,'Alaxan','910');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (3,'Decolgen','1250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (4,'Hapacol Codein','25000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (5,'Panadol Extra','1200');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (6,'Phosphalugel','4000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (7,'Yumangel','4250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (8,'Gastropulgite','4000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (9,'Gaviscon','5625');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (10,'Trimafort','5500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (11,'Penicillin','3000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (12,'Amoxillin','1000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (13,'Aspirin','575');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (14,'Codein Sunfat','700');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (15,'Pepto-Bismol','400000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (16,'Domperidon','400');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (17,'Maalox','875');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (18,'Carbotrim','2000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (19,'Floctafenine','1250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (20,'Tramadol','500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (21,'Opioid Morphin','1150000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (22,'Fentanyl','9600');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (23,'Oxycontin','5000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (24,'Naproxen','1400');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (25,'Acetaminophen','700');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (26,'Efferalgan','3000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (27,'Tiffy','900');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (28,'Yuraf','9000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (29,'Yuraf','330');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [giaThuoc]) VALUES (30,'E-cox 90','3500');
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
GO

CREATE TABLE HoaDon
(
	maHD char(6) PRIMARY KEY NOT NULL,
	ngaytao smalldatetime NOT NULL,
	tenBN varchar(50) NOT NULL,
	tienthuoc decimal NOT NULL,
	tongcong decimal NOT NULL
)
