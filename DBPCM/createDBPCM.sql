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
USE [master]
GO
ALTER DATABASE [DBPCM] SET  READ_WRITE 
GO
