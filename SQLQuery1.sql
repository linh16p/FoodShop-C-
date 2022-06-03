Create database quanlybanhang
use quanlybanhang
create table khach(
makh Char(30) not null primary key,
hotenkh nvarchar(30),
diachi nvarchar(30),
dienthoai float)

create table sanpham(
masp char(30) not null primary key,
tensp nvarchar(30),
khuyenmai float,
gia float,
soluong int)

-- bang them moi
---------------------------------------------------
create table nhanvien(
idnv int identity(1,1) not null primary key,
tennv nvarchar(500),
sdt float,
diachi nvarchar(500),
email varchar(500) unique,
trangthai bit default 1
)

-- dung mo ra
create table luongnv(
idluong int identity(1,1) not null primary key,
foreign key(idnv) references nhanvien(idnv),
luong float,
ngaybatdaulam datetime,
traluong datetime
)
-- chua dung duoc

create table taikhoan(
idtk int identity(1,1) not null primary key,
username varchar(256) unique,
passw varchar(500),
roles bit default 0,
trangthai bit default 1
)

create table dangnhap(
idnv int foreign key(idnv) references nhanvien(idnv),
idtk int foreign key(idtk) references taikhoan(idtk)
)
---------------------------------------------------------
---------------------------------------------------------

create table hoadon(
mahd int identity(1,1) not null primary key,
makh char(30),
idnv int foreign key (idnv) references nhanvien(idnv),
ngaynhap datetime,
foreign key (makh) references khach(makh))

create table chitiethoadon(
mahd int,
masp char(30),
soluongmua int,
tongtien float,
foreign key (mahd) references hoadon(mahd),
foreign key (masp) references sanpham(masp))

insert into khach values('1', N'huong', N'viet nam', 0123456789)
insert into khach values('45', N'hung', N'viet nam', 0123456759)
insert into sanpham values('1', N'gà rán',0.05, 28000, 50),('2', N'hamburger',0.02,30000,50),('3', N'Doney Keybap',0.01,20000,50)

INSERT INTO dbo.nhanvien(tennv,sdt,diachi,email,trangthai)VALUES(N'huong',122434454,N'ha noi','huong@gmail.com',1)

INSERT INTO dbo.taikhoan(username,passw,roles,trangthai)VALUES('huong','1234',1,1)
INSERT INTO dbo.dangnhap(idnv,idtk)VALUES(1,1)

SELECT * FROM dbo.khach
SELECT * FROM dbo.sanpham
SELECT * FROM dbo.nhanvien
SELECT * FROM dbo.taikhoan
SELECT * FROM dbo.dangnhap
SELECT * FROM dbo.hoadon
select * from chitiethoadon