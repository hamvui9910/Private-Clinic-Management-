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
CREATE DATABASE DBPCM
GO
USE DBPCM
GO
/****** Object:  Table [dbo].[DanhSachBenhNhan]    Script Date: 6/27/2019 1:49:14 PM ******/
CREATE TABLE DanhSachBenhNhan
(
	BN_maBN char(10) NOT NULL PRIMARY KEY,
	BN_hoten nvarchar(50) NOT NULL,
	BN_gioitinh char(5) NOT NULL,
	BN_namsinh char(4) NOT NULL,
	BN_diachi nvarchar(50) NOT NULL,
	BN_sdt char(10) NOT NULL,
	BN_ngaykham char(10) NOT NULL,
	BN_loaibenh nvarchar(50) NULL,
	BN_trieuchung nvarchar(100) NULL,
)

/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/27/2019 1:49:14 PM ******/
GO
CREATE TABLE HoaDon
(
	maHD char(6) PRIMARY KEY NOT NULL,
	ngaytao smalldatetime NULL,
	tenBN nvarchar(50) NULL,
	tienthuoc decimal(18, 0) NULL,
	tongcong decimal(18, 0) NULL,
	donviTinh nchar(10) NULL

)
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 6/27/2019 1:49:14 PM ******/

CREATE TABLE QuyDinh
(
	maQD char(5) NOT NULL,
	tenQD char(10) NOT NULL,
	noidung varchar(1000) NOT NULL,
)

GO

CREATE TABLE ThongKe
(
	id int identity(1,1) primary key not null,
	maHD char(6) NULL,
	maThuoc char(3) NULL,
	tenThuoc varchar(50) NULL,
	donviTinh nchar(10) NULL,
	soLuong int NULL,
	donGia decimal(18, 0) NULL,
	thanhTien decimal(18, 0) NULL
)

GO

CREATE TABLE Thuoc
(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	tenThuoc varchar(50) NOT NULL,
	donviTinh nchar(10) NOT NULL,
	giaThuoc decimal(10, 0) NOT NULL
)

SET IDENTITY_INSERT [dbo].[Thuoc] ON
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (1,'Paracetamol','viên','500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (2,'Alaxan','viên','910');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (3,'Decolgen','viên','1250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (4,'Hapacol Codein','chai','25000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (5,'Panadol Extra','viên','1200');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (6,'Phosphalugel','gói','4000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (7,'Yumangel','gói','4250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (8,'Gastropulgite','viên','4000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (9,'Gaviscon','chai','5625');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (10,'Trimafort','viên','5500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (11,'Penicillin','viên','3000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (12,'Amoxillin','viên','1000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (13,'Aspirin','viên','575');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (14,'Codein Sunfat','viên','700');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (15,'Pepto-Bismol','chai','400000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (16,'Domperidon','viên','400');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (17,'Maalox','viên','875');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (18,'Carbotrim','viên','2000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (19,'Floctafenine','viên','1250');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (20,'Tramadol','viên','500');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (21,'Opioid Morphin','viên','1150000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (22,'Fentanyl','viên','9600');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (23,'Oxycontin','chai','5000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (24,'Naproxen','viên','1400');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (25,'Acetaminophen','viên','700');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (26,'Efferalgan','viên','3000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (27,'Tiffy','viên','900');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (28,'Yuraf','viên','9000');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (29,'Coldacmin','viên','330');
INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES (30,'E-cox 90','viên','3500');
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
