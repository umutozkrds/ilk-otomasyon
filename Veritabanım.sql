USE [Musteriler]
GO
/****** Object:  Table [dbo].[Tbl_musteri]    Script Date: 14.06.2023 19:17:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_musteri](
	[MusNo] [smallint] NULL,
	[MusAd] [varchar](25) NULL,
	[MusSoyad] [varchar](25) NULL,
	[MusBakiye] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Urun]    Script Date: 14.06.2023 19:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Urun](
	[UrunNo] [smallint] NULL,
	[UrunAd] [nvarchar](25) NULL,
	[UrunStok] [smallint] NULL,
	[UrunSatış] [smallint] NULL,
	[UrunGeliş] [smallint] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (1, N'Ahmet ', N'Tezcan', 7)
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (2, N'Selma', N'Bahar', 0)
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (3, N'Deniz', N'Sağdan', 0)
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (4, N'Caner', N'Dağlı', 0)
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (5, N'Ceren', N'Küçük', 0)
INSERT [dbo].[Tbl_musteri] ([MusNo], [MusAd], [MusSoyad], [MusBakiye]) VALUES (6, N'ebrar', N'küçü', 90)
GO
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (1, N'Ekmek', 50, 5, 3)
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (2, N'Su', 100, 3, 2)
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (3, N'Yumurta', 200, 2, 1)
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (4, N'Nutella', 25, 20, 10)
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (5, N'Dondurma', 30, 10, 5)
INSERT [dbo].[Tbl_Urun] ([UrunNo], [UrunAd], [UrunStok], [UrunSatış], [UrunGeliş]) VALUES (6, N'Çay', 50, 50, 30)
GO
