use [Qly_Nvien]
go

set ansi_nulls on
go

set quoted_identifier on
go


create table [dbo].[KYCONGCHITIET](
	[MAKYCONG] [int] not null,
	[MANV] [int] not null,
	[HOTEN] [nvarchar](50) null,
	[MACTY] [nvarchar](4) null,
	[D1] [nvarchar](10) null,
	[D2] [nvarchar](10) null,
	[D3] [nvarchar](10) null,
	[D4] [nvarchar](10) null,
	[D5] [nvarchar](10) null,
	[D6] [nvarchar](10) null,
	[D7] [nvarchar](10) null,
	[D8] [nvarchar](10) null,
	[D9] [nvarchar](10) null,
	[D10] [nvarchar](10) null,
	[D11] [nvarchar](10) null,
	[D12] [nvarchar](10) null,
	[D13] [nvarchar](10) null,
	[D14] [nvarchar](10) null,
	[D15] [nvarchar](10) null,
	[D16] [nvarchar](10) null,
	[D17] [nvarchar](10) null,
	[D18] [nvarchar](10) null,
	[D19] [nvarchar](10) null,
	[D20] [nvarchar](10) null,
	[D21] [nvarchar](10) null,
	[D22] [nvarchar](10) null,
	[D23] [nvarchar](10) null,
	[D24] [nvarchar](10) null,
	[D25] [nvarchar](10) null,
	[D26] [nvarchar](10) null,
	[D27] [nvarchar](10) null,
	[D28] [nvarchar](10) null,
	[D29] [nvarchar](10) null,
	[D30] [nvarchar](10) null,
	[D31] [nvarchar](10) null,
	[NGAYCONG] [float] null,
	[NGAYPHEP] [float] null,
	[NGHIKHONGPHEP] [float] null,
	[CONGNGAYLE] [float] null,
	[CONGCHUNHAT] [float] null,
	[TONGNGAYCONG] [float] null,
	constraint [PK_KYCONGCHITIET_1] primary key clustered
	(
		[MAKYCONG] asc,
		[MANV] asc
	)WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF, IGNORE_DUP_KEY=OFF, ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON, OPTIMIZE_FOR_SEQUENTIAL_KEY=OFF) ON [PRIMARY]
)ON [PRIMARY]
go


