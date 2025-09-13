use [Qly_Nvien]
go 

set ansi_nulls on
go

set quoted_identifier on
go

create table [dbo].[BANGCONG_NHANVIEN_CHITIET](
	[ID] [int] not null,
	[MAKYCONG] [nvarchar](50) null,
	[MACTY] [int] null,
	[MANV] [nvarchar](50) null,
	[HOTEN] [nvarchar](50) null,
	[NGAY] [datetime] null,
	[THU] [nvarchar](50) null,
	[GIOVAO] [nvarchar](50) null,
	[GIORA] [nvarchar](50) null,
	[NGAYPHEP] [float] null,
	[CONGNGAYLE] [float] null,
	[CONGCHUNHAT] [float] null,
	[KYHIEU] [nvarchar](50) null,
	[GHICHU] [nvarchar](50) null,
	[CREATED_BY] [int] null,
	[CREATED_DATE] [datetime] null,
	[UPDATED_BY] [int] null,
	[UPDATED_DATE] [datetime] null,
	constraint [PK_BANGCONG_NHANVIEN_CT] primary key clustered
	(
		[ID] asc
	)WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF, IGNORE_DUP_KEY=OFF, ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON, OPTIMIZE_FOR_SEQUENTIAL_KEY=OFF) ON [PRIMARY]
)ON [PRIMARY]
go
