/*RESET CỘT ID

DBCC CHECKIDENT ('TRINHDO', NORESEED);	- Ktra cột đang ở stt thứ mấy
DBCC CHECKIDENT ('TRINHDO', RESEED, 0);	- Reset lại từ số stt 0

/*XÓA DỮ LIỆU MỚI UP TRONG TABLE
truncate table NHANVIEN