﻿create database QLKS
--THEM DEFAULT CHO CAC MÃ
use QLKS
create table PHONG(
	MAPHONG VARCHAR(9) PRIMARY KEY,
	TENPHONG VARCHAR(10),
	MALOAI INT CHECK (MALOAI>0 AND MALOAI<3) REFERENCES LOAIPHONG(MALOAI),
	GIATHUE INT,
	SOTANG INT CHECK(SOTANG>1 AND SOTANG<6)
)
CREATE TABLE LOAIPHONG(
	MALOAI INT CHECK (MALOAI>0 AND MALOAI<3) PRIMARY KEY,
	TENLOAI NVARCHAR(30),
	GHICHU NVARCHAR(30),
)
CREATE TABLE NHANVIEN(
	MANHANVIEN VARCHAR(8) PRIMARY KEY,
	PASS VARCHAR(30),
	HOTEN NVARCHAR(50),
	CHUCVU NVARCHAR(20),
	GIOITINH NVARCHAR(6) CHECK(GIOITINH=N'Nam' or GIOITINH=N'Nữ'),
	AVATAR NVARCHAR(200), --G.Hải sửa varchar(200) --> nvarchar(200)
	NGAYSINH DATE,
	SODIENTHOAI VARCHAR(12),
	DEL BIT--G.Hải thêm
)
CREATE TABLE KHACHHANG(
	MAKHACHHANG VARCHAR(8) PRIMARY KEY,
	TENKHACHHANG NVARCHAR(50),
	GIOITINH NVARCHAR(6) CHECK(GIOITINH=N'Nam' or GIOITINH=N'Nữ'),
	SOCMT VARCHAR(13),
	SODIENTHOAIKH VARCHAR(12),
)

CREATE TABLE THUEPHONG(
	MATHUE VARCHAR(8) PRIMARY KEY,
	MAKHACHHANG VARCHAR(8) REFERENCES KHACHHANG(MAKHACHHANG),
	MAPHONG VARCHAR(9) REFERENCES PHONG(MAPHONG),
	NGAYVAO DATE,
	NGAYRA DATE,
	--TRANGTHAI INT CHECK(TRANGTHAI=0 and TRANGTHAI=1) --0 da thanh toan ,1 chua thanh toan
	TRANGTHAI INT CHECK(TRANGTHAI=0 or TRANGTHAI=1) --G.Hải sửa 
)
--ALTER TABLE dbo.THUEPHONG DROP CONSTRAINT CK__THUEPHONG__TRANG__1FCDBCEB
--ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT CHECK_THUEPHONG_TRANGTHAI CHECK (TRANGTHAI=0 OR TRANGTHAI=1)

CREATE TABLE DICHVU(
	MADICHVU VARCHAR(10) PRIMARY KEY  DEFAULT 'DV1111',
	TENDICHVU NVARCHAR(30),
	GIATIEN INT,
	DEL BIT --G.Hải thêm
)

CREATE TABLE SUDUNGDICHVU(
	MASD VARCHAR(8) PRIMARY KEY,
	MATHUE VARCHAR(8) REFERENCES THUEPHONG(MATHUE),
	MADICHVU VARCHAR(10) REFERENCES DICHVU(MADICHVU),
	NGAYSUDUNG DATE,
	DONGIA INT,
)
CREATE TABLE THANHTOAN(
	MATHUE VARCHAR(8) PRIMARY KEY REFERENCES THUEPHONG(MATHUE), --G.Hải sửa (thêm khóa chính)
	THANHTIEN INT,
	NGAYTHANHTOAN DATE,
	NHANVIENGIAODICH VARCHAR(8) REFERENCES dbo.NHANVIEN(MANHANVIEN)--G.Hải sửa (thêm Reference)
)
delete from phong
select * from PHONG
INSERT INTO LOAIPHONG VALUES(1,N'Phòng Thường',N'Phòng gồm 1 giường đôi')
INSERT INTO LOAIPHONG VALUES(2,N'Phòng VIP',N'Phòng gồm 2 giường đôi')
insert into PHONG values('P201','Phòng 201' ,1,2000,2)
insert into PHONG values('P202','Phòng 202' ,1,2200,2)
insert into PHONG values('P203','Phòng 203' ,1,2200,2)
insert into PHONG values('P204','Phòng 204' ,1,2000,2)
insert into PHONG values('P205','Phòng 205' ,1,2200,2)
insert into PHONG values('P206','Phòng 206' ,1,2200,2)
insert into PHONG values('P207','Phòng 207' ,1,2000,2)
insert into PHONG values('P208','Phòng 208' ,1,2200,2)
insert into PHONG values('P209','Phòng 209' ,1,2200,2)
insert into PHONG values('P210','Phòng 210' ,1,2000,2)
insert into PHONG values('P211','Phòng 211' ,1,2200,2)
insert into PHONG values('P212','Phòng 212' ,1,2200,2)

insert into PHONG values('P301','Phòng 301' ,1,2000,3)
insert into PHONG values('P302','Phòng 302' ,1,2200,3)
insert into PHONG values('P303','Phòng 303' ,1,2200,3)
insert into PHONG values('P304','Phòng 304' ,1,2000,3)
insert into PHONG values('P305','Phòng 305' ,1,2200,3)
insert into PHONG values('P306','Phòng 306' ,1,2200,3)
insert into PHONG values('P307','Phòng 307' ,1,2000,3)
insert into PHONG values('P308','Phòng 308' ,1,2200,3)
insert into PHONG values('P309','Phòng 309' ,1,2200,3)
insert into PHONG values('P310','Phòng 310' ,1,2000,3)

insert into PHONG values('P401','Phòng 401' ,1,2000,4)
insert into PHONG values('P402','Phòng 402' ,1,2200,4)
insert into PHONG values('P403','Phòng 403' ,1,2200,4)
insert into PHONG values('P404','Phòng 404' ,1,2000,4)
insert into PHONG values('P405','Phòng 405' ,1,2200,4)
insert into PHONG values('P406','Phòng 406' ,1,2200,4)
insert into PHONG values('P407','Phòng 407' ,1,2000,4)
insert into PHONG values('P408','Phòng 408' ,1,2200,4)
insert into PHONG values('P409','Phòng 409' ,1,2200,4)
insert into PHONG values('P410','Phòng 410' ,1,2000,4)
insert into PHONG values('P411','Phòng 411' ,1,2200,4)
insert into PHONG values('P412','Phòng 412' ,1,3000,4)

insert into PHONG values('P501','Phòng 501' ,2,5000,5)
insert into PHONG values('P502','Phòng 502' ,2,5200,5)
insert into PHONG values('P503','Phòng 503' ,2,5200,5)
insert into PHONG values('P504','Phòng 504' ,2,5000,5)
insert into PHONG values('P505','Phòng 505' ,2,5200,5)
insert into PHONG values('P506','Phòng 506' ,2,5200,5)
insert into PHONG values('P507','Phòng 507' ,2,5000,5)
insert into PHONG values('P508','Phòng 508' ,2,5200,5)
insert into PHONG values('P509','Phòng 509' ,2,5200,5)
insert into PHONG values('P510','Phòng 510' ,2,5000,5)

insert into KHACHHANG VALUES('KH12345',N'Trương Quang Hải',N'Nam',N'Thanh Hóa','0967125182')
insert into KHACHHANG VALUES('KH12346',N'Trương Quang Hải',N'Nam',N'Thanh Hóa','0967125182')
insert into KHACHHANG VALUES('KH12347',N'Trương Quang Hải',N'Nam',N'Thanh Hóa','0967125182')
insert into THUEPHONG VALUES('TP12350','KH12345','P201','20180405','20180420',1)
insert into THUEPHONG VALUES('TP12351','KH12346','P202','20180405','20180420',1)
insert into THUEPHONG VALUES('TP12352','KH12347','P303','20180405','20180420',1)
insert into THUEPHONG VALUES('TP12353','KH12345','P301','20180405','20180420',1)
insert into THUEPHONG VALUES('TP12357','KH12345','P302','20180405','20180420',1)
insert into THUEPHONG VALUES('TP12358','KH12345','P304','20180405','20180415',1)
select count(TENPHONG) FROM PHONG 
select tenphong from THUEPHONG RIGHT JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG  WHERE THUEPHONG.MAPHONG is null and PHONG.SOTANG=3 and phong.MAPHONG='P302' ORDER BY TENPHONG
select tenphong from THUEPHONG INNER JOIN PHONG ON NGAYRA>cast(getdate() as date) AND THUEPHONG.MAPHONG=PHONG.MAPHONG and PHONG.SOTANG=2 and phong.MAPHONG='P202'
INSERT INTO NHANVIEN VALUES('NV1234','112233',N'Lê Văn A',N'Lễ Tân','Nam',N'../img/2.jpg','19970514','0967123456',0)--G.Hải thêm "0" vào cuối, thêm "N" vào trước avata
INSERT INTO NHANVIEN VALUES('ADMIN','123456',N'Trương Quang Hải',N'Quản Lý','Nam',N'../img/1.png','19970214','0967125182',0)--G.Hải thêm "0" vào cuối, thêm "N" vào trước avata
INSERT INTO NHANVIEN VALUES('1','1',N'Trương Quang Hải',N'Quản Lý','Nam',N'../img/1.png','19970214','0967125182',0)--G.Hải thêm "0" vào cuối, thêm "N" vào trước avata
select * from nhanvien
select * from thuephong where mathue='TP12346'
delete from thuephong where mathue='TP12346'
select mathue from thuephong order by mathue desc
select makhachhang from khachhang order by makhachhang asc
select * from khachhang
select * from thuephong
delete from thuephong where maphong in (select maphong from phong where tenphong= 'Phòng 202')
select makhachhang from khachhang order by makhachhang desc
select manhanvien from nhanvien order by manhanvien asc
SELECT * FROM THUEPHONG INNER JOIN PHONG ON PHONG.MAPHONG=THUEPHONG.MAPHONG AND PHONG.TENPHONG='Phòng 201'
UPDATE THUEPHONG SET TRANGTHAI=0 WHERE MAPHONG IN (SELECT MAPHONG FROM PHONG WHERE TENPHONG='Phòng 201')
select tenphong from THUEPHONG INNER JOIN PHONG ON NGAYRA>cast(getdate() as date) AND THUEPHONG.MAPHONG=PHONG.MAPHONG and PHONG.SOTANG=3 and phong.MAPHONG='P304'
select tenphong from THUEPHONG RIGHT JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG and THUEPHONG.TRANGTHAI=1 where THUEPHONG.MAPHONG is null and PHONG.SOTANG=3 and phong.MAPHONG='P304'
--qua ngay doi trang thai
--LAY SO PHONG
GO
create proc PRO_SELECT_SOPHONG @TANGSO INT
AS
BEGIN
	select count(TENPHONG) FROM PHONG WHERE SOTANG=@TANGSO
END
--LAY TEN PHONG
GO
create proc PRO_SELECT_TENPHONG @TANGSO INT
AS
BEGIN
	select TENPHONG	 FROM PHONG WHERE SOTANG=@TANGSO
END
GO
 create proc PRO_SELECT_TENPHONG1 @TANGSO INT
AS
BEGIN
	select TENPHONG	 FROM PHONG inner join THUEPHONG ON PHONG.MAPHONG=THUEPHONG.MAPHONG WHERE SOTANG=@TANGSO AND TRANGTHAI=1 
END
--LAY PHONG DANG THUE
GO
CREATE PROC PROC_SELECT_PHONGDANGTHUE @TANGSO INT
AS
BEGIN
	select tenphong from THUEPHONG INNER JOIN PHONG ON NGAYRA>=cast(getdate() as date) AND THUEPHONG.MAPHONG=PHONG.MAPHONG and THUEPHONG.TRANGTHAI=1 and PHONG.SOTANG= @tangso  order by tenphong
END
--lay phong tra muon 
GO
CREATE PROC PROC_SELECT_PHONGTHUEMUON @TANGSO INT
AS
BEGIN
	SELECT TENPHONG FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG AND THUEPHONG.NGAYRA<CAST(GETDATE() AS DATE) and THUEPHONG.TRANGTHAI=1  AND PHONG.SOTANG = @tangso order by tenphong
END
-- LAY PHONG DAT TRUOC
GO
CREATE PROC PROC_SELECT_PHONGDATTRUOC @TANGSO INT
AS
BEGIN
	SELECT TENPHONG FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG AND THUEPHONG.NGAYVAO>CAST(GETDATE() AS DATE) and THUEPHONG.TRANGTHAI=1 AND PHONG.SOTANG= @tangso  order by tenphong
END
--lay phong dang thue
GO
create PROC PROC_SELECT_PHONGDANGTHUE1 @TANGSO INT,@MAPHONG VARCHAR(10)
AS
BEGIN 
	select tenphong from THUEPHONG RIGHT JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG and THUEPHONG.TRANGTHAI=1 where THUEPHONG.MAPHONG is null and PHONG.SOTANG= @TANGSO and phong.MAPHONG=@MAPHONG
END
--lay phong dang o
GO
create proc PROC_SELECT_PHONGDANGO1 @TANGSO INT,@MAPHONG VARCHAR(10)
AS
BEGIN
	select tenphong from THUEPHONG INNER JOIN PHONG ON NGAYRA>=cast(getdate() as date) AND THUEPHONG.MAPHONG=PHONG.MAPHONG and THUEPHONG.TRANGTHAI=1 and PHONG.SOTANG=@TANGSO and phong.MAPHONG=@MAPHONG
END
--lay phong tra muon
GO
create PROC PROC_SELECT_PHONGTRAMUON1 @TANGSO INT,@MAPHONG VARCHAR(10)
AS
BEGIN
	SELECT TENPHONG FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG AND THUEPHONG.NGAYRA<CAST(GETDATE() AS DATE) and THUEPHONG.TRANGTHAI=1  AND PHONG.SOTANG=@TANGSO  and phong.MAPHONG=@MAPHONG
END
--lay phong dat coc truoc
GO
create PROC PROC_SELECT_PHONGDATCOCTRUOC1 @TANGSO INT,@MAPHONG VARCHAR(10)
AS
BEGIN
	SELECT TENPHONG FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG AND THUEPHONG.NGAYVAO>CAST(GETDATE() AS DATE) and THUEPHONG.TRANGTHAI=1 AND PHONG.SOTANG=@TANGSO and phong.MAPHONG=@MAPHONG
END
--lay ma nhan vien
GO
create proc PROC_SELECT_MANHANVIEN 
AS
BEGIN
	select manhanvien from nhanvien order by manhanvien asc
END
--THEM NHAN VIEN
GO
ALTER PROC PROC_INSERT_NHANVIEN @MANV VARCHAR(8),@PASS VARCHAR(30),@HOTEN NVARCHAR(50),@CHUCVU NVARCHAR(20),@GIOITINH NVARCHAR(6),@AVATAR NVARCHAR(200),@NGAYSINH DATE,@PHONE VARCHAR(12) --G.Hải sửa @avatar varchar --> nvarchar
AS
BEGIN
	INSERT INTO NHANVIEN VALUES(@MANV,@PASS,@HOTEN,@CHUCVU,@GIOITINH,@AVATAR,@NGAYSINH,@PHONE,0)
END
GO
--lay loai phong
CREATE PROC PROC_SELECT_MALOAIPHONG @TENPHONG NVARCHAR(20)
AS 
BEGIN 
	SELECT TENLOAI FROM LOAIPHONG INNER JOIN PHONG ON LOAIPHONG.MALOAI=PHONG.MALOAI WHERE PHONG.TENPHONG=@TENPHONG
END
--them dich vu

GO
CREATE proc PROC_INSERT_THEMDV @MADICHVU VARCHAR(10),@TENDICHVU NVARCHAR(30),@GIATIEN INT
AS
BEGIN
	INSERT INTO DICHVU VALUES(@MADICHVU,@TENDICHVU,@GIATIEN,0)--G.Hải thêm 0
END

--lay ma dich vu
GO
create proc PROC_INSERT_MADICHVU
AS
BEGIN
	SELECT MADICHVU FROM DICHVU order by MADICHVU asc
END
--lay ten dich vu
GO
create proc PROC_SELECT_TENDICHVU
AS
BEGIN
	SELECT TENDICHVU FROM DICHVU ORDER BY TENDICHVU ASC
END
--lay ma nhan vien
GO
create PROC PROC_SELECT_HOTEN @MANHANVIEN VARCHAR(8)
AS
BEGIN 
	SELECT HOTEN FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN
END
--LAY CHUC VU NHAN VIEN 
GO
create PROC PROC_SELECT_CHUCVU @MANHANVIEN VARCHAR(8)
AS
BEGIN 
	SELECT CHUCVU FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN
END

--LAY AVATAR
GO
create PROC PROC_SELECT_AVATAR @MANHANVIEN VARCHAR(8)
AS
BEGIN 
	SELECT AVATAR FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN
END

--tao thu tuc them trang thai
GO
CREATE PROC PROC_INSERT_TRANGTHAI @MATHUE VARCHAR(8),@MAPHONG VARCHAR(9),@TRANGTHAI INT
AS
BEGIN
	insert into THUEPHONG(MATHUE,MAPHONG,TRANGTHAI) values(@MATHUE,@MAPHONG,@TRANGTHAI)
END

--tao update them thong tin thue phong
GO
create proc PROC_UPDATE_THUEPHONG @MAKHACHHANG VARCHAR(8),@NGAYVAO DATE,@NGAYRA DATE,@MATHUE VARCHAR(9)
AS
BEGIN 
	UPDATE THUEPHONG 
	SET MAKHACHHANG=@MAKHACHHANG, NGAYVAO=@NGAYVAO,NGAYRA=@NGAYRA
	WHERE MAKHACHHANG=NULL
END
GO
CREATE PROC PROC_SELECT_LOAIPHONG @TENPHONG NVARCHAR(10)
AS
BEGIN
	select TENLOAI FROM PHONG INNER JOIN LOAIPHONG ON PHONG.MALOAI=LOAIPHONG.MALOAI WHERE TENPHONG =@TENPHONG
END
GO
create proc PROC_SELECT_NGAYVAO @TENPHONG NVARCHAR(10)
AS
BEGIN
	SELECT NGAYVAO FROM THUEPHONG INNER JOIN PHONG ON PHONG.MAPHONG=THUEPHONG.MAPHONG WHERE PHONG.TENPHONG=@TENPHONG
END
GO
create proc PROC_SELECT_NGAYRA @TENPHONG NVARCHAR(10)
AS
BEGIN
	SELECT NGAYRA FROM THUEPHONG INNER JOIN PHONG ON PHONG.MAPHONG=THUEPHONG.MAPHONG WHERE PHONG.TENPHONG=@TENPHONG
END
GO
create proc PROC_SELECT_GIATIEN @TENPHONG NVARCHAR(10)
AS
BEGIN
	select GIATHUE FROM PHONG WHERE TENPHONG=@TENPHONG
END 
select * from phong
GO
CREATE proc PROC_INSERT_THANHTOAN @MATHUE VARCHAR(8),@THANHTIEN INT,@NGAYTHANHTOAN DATE, @NHANVIENGIAODICH VARCHAR(8)
AS
BEGIN
	INSERT INTO THANHTOAN VALUES(@MATHUE,@THANHTIEN,@NGAYTHANHTOAN,@NHANVIENGIAODICH)
END
--lay ma thue theo ten phong
GO
create proc PROC_SELECT_MATHUE @TENPHONG NVARCHAR(10)
AS
BEGIN
	SELECT MATHUE FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG AND PHONG.TENPHONG=@TENPHONG
END

select * from thanhtoan

--dua ngay lay so tien
GO
create proc PROC_SELECT_TONGTIEN @NGAYTHANHTOAN DATE
AS
BEGIN
	SELECT sum(THANHTIEN) FROM THANHTOAN WHERE NGAYTHANHTOAN = @NGAYTHANHTOAN
END
GO
create proc PROC_SELECT_TONGTIEN1 
AS
BEGIN
	SELECT SUM(THANHTIEN) FROM THANHTOAN
END
GO
CREATE PROC PROC_SELECT_SOPHONG @NGAYTHANHTOAN DATE
AS
BEGIN
	SELECT COUNT(MATHUE) FROM THANHTOAN WHERE NGAYTHANHTOAN=@NGAYTHANHTOAN
END
GO
CREATE PROC PROC_SELECT_SOPHONG1
AS
BEGIN
	SELECT COUNT(MATHUE) FROM THANHTOAN
END
GO
CREATE PROC PROC_SELECT_THEMDICHVU @TENPHONG NVARCHAR(10),@MASD VARCHAR(8),@TENDICHVU NVARCHAR(80),@NGAYSUDUNG DATE
AS
BEGIN
	DECLARE @MATHUE VARCHAR(8)
	DECLARE @DONGIA INT 
	DECLARE @MADICHVU VARCHAR(8)
	SELECT @MADICHVU=MADICHVU FROM DICHVU WHERE TENDICHVU=@TENDICHVU
	select @MATHUE=MATHUE FROM THUEPHONG INNER JOIN PHONG ON THUEPHONG.MAPHONG =PHONG.MAPHONG WHERE PHONG.TENPHONG=@TENPHONG 
	SELECT @DONGIA=GIATIEN FROM DICHVU WHERE MADICHVU=@MADICHVU
	INSERT INTO SUDUNGDICHVU VALUES(@MASD,@MATHUE,@MADICHVU,@NGAYSUDUNG,@DONGIA)
END
GO
CREATE PROC PROC_SELECT_MASD 
AS
BEGIN 
	SELECT MASD FROM SUDUNGDICHVU ORDER BY MASD ASC
END
--tong don gia dich vu 
GO
create proc PROC_SELECT_DONGIADV @TENPHONG NVARCHAR(10)
AS
BEGIN
	select SUM(DONGIA) FROM SUDUNGDICHVU INNER JOIN THUEPHONG ON SUDUNGDICHVU.MATHUE=THUEPHONG.MATHUE INNER JOIN PHONG ON THUEPHONG.MAPHONG=PHONG.MAPHONG WHERE PHONG.TENPHONG=@TENPHONG and THUEPHONG.TRANGTHAI=1
END

EXEC PRO_SELECT_SOPHONG 2
EXEC PRO_SELECT_TENPHONG 2
EXEC PRO_SELECT_TENPHONG1 3
EXEC PROC_SELECT_PHONGDANGTHUE 2
EXEC PROC_SELECT_PHONGTHUEMUON 2
EXEC PROC_SELECT_PHONGDATTRUOC 2
EXEC PROC_SELECT_PHONGDANGTHUE1 3, 'P304'
EXEC PROC_SELECT_PHONGDANGO1 
EXEC PROC_SELECT_PHONGTRAMUON1 3,'P301'
EXEC PROC_SELECT_PHONGDATCOCTRUOC1 3,'P301'
EXEC PROC_SELECT_MANHANVIEN 
exec PROC_INSERT_NHANVIEN '2','1',N'Trương Quang Hải',N'Quản lý','NAM',N'../img/1.png','19970214','0967125182' --thêm "N" vào trước avata
EXEC PROC_SELECT_MALOAIPHONG N'Phòng 202'
EXEC PROC_INSERT_MADICHVU
EXEC PROC_SELECT_TENDICHVU
DROP PROC PROC_UPDATE_THUEPHONG
-------------------------------------------------------G Hải-------------------------------------------------------
GO
EXECUTE IUD_NHANVIEN '',N'',N'',N'','','','',N''
GO
CREATE PROCEDURE IUD_NHANVIEN(
@maNV VARCHAR(8),
@hoTen NVARCHAR(50),
@chucVu NVARCHAR(20),
@gioiTinh NVARCHAR(6),
@avt NVARCHAR(200),
@NS DATE,
@SDT VARCHAR(12),
@Statement NVARCHAR(20)='' )
AS
BEGIN
	IF @Statement ='Select'
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE MANHANVIEN= @maNV
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.NHANVIEN
		VALUES  ( @maNV , -- MANHANVIEN - varchar(8)
		          '1' , -- PASS - varchar(30)
		          @hoTen , -- HOTEN - nvarchar(50)
		          @chucVu , -- CHUCVU - nvarchar(20)
		          @gioiTinh , -- GIOITINH - nvarchar(6)
		          @avt , -- AVATAR - varchar(200)
		          @NS , -- NGAYSINH - date
		          @SDT,  -- SODIENTHOAI - varchar(12)
				  0
		        )
	END
	IF @Statement ='Update'
	BEGIN
		UPDATE dbo.NHANVIEN 
		SET HOTEN=@hoTen,CHUCVU=@chucVu,GIOITINH=@gioiTinh,AVATAR=@avt,NGAYSINH=@NS,SODIENTHOAI=@SDT
		WHERE MANHANVIEN=@maNV
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.NHANVIEN 
		SET DEL=1
		WHERE MANHANVIEN=@maNV
	END
	IF @Statement='Show'
	BEGIN
			UPDATE dbo.NHANVIEN 
		SET DEL=0
		WHERE MANHANVIEN=@maNV
	END
	IF @Statement ='Delete'
	BEGIN
		DELETE FROM dbo.THANHTOAN WHERE NHANVIENGIAODICH=@maNV
		DELETE FROM dbo.NHANVIEN WHERE MANHANVIEN=@maNV
	END
END
GO
CREATE PROCEDURE IUD_DICHVU (
@maDV VARCHAR(10),
@tenDV NVARCHAR(30),
@giaTien INT,
@Statement NVARCHAR(20)='' )
AS
BEGIN
	IF @Statement = 'Select'
	BEGIN
		SELECT * FROM dbo.DICHVU WHERE MADICHVU=@maDV
	END
	IF @Statement ='Insert'
	BEGIN
		INSERT INTO dbo.DICHVU
		VALUES  ( @maDV , -- MADICHVU - varchar(10)
			      @tenDV , -- TENDICHVU - nvarchar(30)
				  @giaTien , -- SOLUONG - int
				0  -- DEL - INT
				)
	END
	IF @Statement = 'Hide'
	BEGIN
		UPDATE dbo.DICHVU SET DEL=1 WHERE MADICHVU=@maDV
	END
	IF @Statement ='Show'
	BEGIN
		UPDATE dbo.DICHVU SET DEL=0 WHERE MADICHVU=@maDV
	END
	IF @Statement = 'Update'
	BEGIN
		UPDATE dbo.DICHVU SET TENDICHVU=@tenDV,GIATIEN=@giaTien WHERE MADICHVU=@maDV
	END
	IF @Statement='Delete'
	BEGIN
		DELETE FROM dbo.SUDUNGDICHVU WHERE MADICHVU =@maDV
		DELETE FROM dbo.DICHVU WHERE MADICHVU=@maDV
	END
END
UPDATE dbo.DICHVU SET TENDICHVU= N'3consoi' WHERE MADICHVU='DV0001'