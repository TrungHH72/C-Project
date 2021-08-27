/*
taikhoan(matk,tentk,matkhau,loaitk)
sinhvien(masv,hotensv,gioitinh,ngaysinh,quequan,malop)
monhoc(mamh,tenmh)
phonghoc(maphonghoc,tenphonghoc)
giaovien(magv,hotengv,gioitinh,ngaysinh,quequan) =>> phancong(magv,malhp)
lophocphan(malhp,tenlophoc,maphonghoc,mamh)
*/
-- create database
create database QuanLySinhVien;
go
use QuanLySinhVien;
go

-- create table
create table taikhoan(
	matk char(10) not null primary key,
	tentk char(20) not null,
	matkhau char(20) not null,
	loaitk int
)
go

create table lop(
	malop char(15) not null primary key,
	tenlop nvarchar(50)
)
go

create table sinhvien(
	masv char(10) not null primary key,
	hotensv nvarchar(50) not null,
	gioitinh nvarchar(3),
	ngaysinh date,
	quequan nvarchar(50),
	malop char(15),

	foreign key (malop) references lop(malop)
)
go

create table monhoc(
	mamh char(15) not null primary key,
	tenmh nvarchar(50)
)
go

create table phonghoc(
	maphonghoc char(15) not null primary key,
	tenphonghoc char(20)
)
go

create table giaovien(
	magv char(15) not null primary key,
	hotengv nvarchar(50) not null,
	gioitinh nvarchar(3),
	ngaysinh date,
	quequan nvarchar(50)
)
go

create table lophocphan(
	malhp char(15) not null primary key,
	tenlophoc nvarchar(100),
	maphonghoc char(15),
	mamh char(15),

	foreign key (maphonghoc) references phonghoc(maphonghoc),
	foreign key (mamh) references monhoc(mamh)
)
go

create table phancong(
	magv char(15) not null,
	malhp char(15) not null,
	foreign key (magv) references giaovien(magv),
	foreign key (malhp) references lophocphan(malhp)
)
go

-- Insert data into table
insert into taikhoan values ('adm','admin','admin@',0);
go

insert into lop values('HT',N'Hệ thống thông tin'),('PM',N'Kỹ thuật phần mềm'),('TH',N'Công nghệ thông tin');
go

insert into sinhvien values('sv00',N'Nguyễn Thúy An',N'Nữ','2000/05/31',N'Hà Nội','TH'),
						   ('sv01',N'Nguyễn Bình An',N'Nam','2000/04/14',N'Hải Phòng','TH'),
						   ('sv02',N'Nguyễn Đức Minh',N'Nam','2000/09/27',N'Hải Dương','TH'),
						   ('sv03',N'Lê Bảo Châu',N'Nữ','2000/10/10',N'Ninh Bình','TH'),
						   ('sv04',N'Lê Nhật Minh',N'Nam','2000/11/12',N'Thanh Hóa','TH'),
						   ('sv05',N'Lê Đức Minh',N'Nam','2000/01/25',N'Quảng Ninh','TH'),
						   ('sv06',N'Phạm Diệp Anh',N'Nữ','2000/08/26',N'Hà Nội','TH'),
						   ('sv07',N'Phạm Diệu Anh',N'Nữ','2000/03/17',N'Sơn La','TH'),
						   ('sv08',N'Đặng Diễm Quỳnh',N'Nữ','2000/06/28',N'Thái Nguyên','TH'),
						   ('sv09',N'Đỗ Khôi Nguyên',N'Nam','2000/07/04',N'Hải Dương','TH');
go

insert into sinhvien values('sv10',N'Đỗ Phúc Thịnh',N'Nam','2000/09/19',N'Bình Định','PM'),
						   ('sv11',N'Đặng Trúc Lâm',N'Nữ','2000/03/16',N'Sóc Trăng','PM'),
						   ('sv12',N'Phạm Minh Thư',N'Nữ','2000/10/21',N'Hải Dương','PM'),
						   ('sv13',N'Hoàng Linh Chi',N'Nữ','2000/10/30',N'Hà Nội','PM'),
						   ('sv14',N'Nguyễn Minh Khang',N'Nam','2000/12/22',N'Hà Nội','PM'),
						   ('sv15',N'Trần Bảo Trân',N'Nữ','2000/04/24',N'Hà Nội','PM'),
						   ('sv16',N'Hoàng Gia Nguyên',N'Nam','2000/08/08',N'Hà Nội','PM'),
						   ('sv17',N'Đinh Thanh Thảo',N'Nữ','2000/07/11',N'Nghệ An','PM'),
						   ('sv18',N'Lê Quốc Bình',N'Nam','2000/09/15',N'Thanh Hóa','PM'),
						   ('sv19',N'Nguyễn Tuấn Anh',N'Nam','2000/02/12',N'Hải Dương','PM');
go

insert into sinhvien values('sv20',N'Lưu Minh Ánh',N'Nữ','2000/01/19',N'Bình Dương','HT'),
						   ('sv21',N'Nguyễn Minh Ánh',N'Nữ','2000/03/18',N'Hà Tĩnh','HT'),
						   ('sv22',N'Phạm Hoàng Yến',N'Nữ','2000/02/16',N'Hải Dương','HT'),
						   ('sv23',N'Đõ Gia Phúc',N'Nam','2000/05/17',N'Hà Nội','HT'),
						   ('sv24',N'Phạm Hùng Cường',N'Nam','2000/04/14',N'Hà Nội','HT'),
						   ('sv25',N'Trần Văn Nam',N'Nam','2000/07/15',N'Hải Dương','HT'),
						   ('sv26',N'Nguyễn Hoàng Gia An',N'Nam','2000/06/12',N'Hà Nội','HT'),
						   ('sv27',N'Đỗ Ðức Toàn',N'Nam','2000/08/11',N'Nghệ An','HT'),
						   ('sv28',N'Đỗ Mai Chi',N'Nữ','2000/10/13',N'Thanh Hóa','HT'),
						   ('sv29',N'Hoàng Hiếu Trung',N'Nam','2000/09/10',N'Hà Nội','HT');
go

insert into monhoc values('CSE488',N'An toàn và bảo mật thông tin'),('CSE481',N'Công nghệ phần mềm'),
						 ('CSE485',N'Công nghệ Web'),('CSE486',N'Hệ quản trị cơ sở dữ liệu'),
						 ('CSE381',N'Lập trình nâng cao'),('CSE391',N'Nền tảng phát triển Web'),
						 ('CSE282',N'Nhập môn lập trình khoa học dữ liệu'),('CSE480',N'Phân tích thiết kế hệ thống thông tin'),
						 ('CSE390',N'Thống kê ứng dụng'),('CSE492',N'Trí tuệ nhân tạo');
go

insert into phonghoc values('B301',N'Phòng 301 B5'),('B302',N'Phòng 302 B5'),
						   ('B303',N'Phòng 303 B5'),('B304',N'Phòng 304 B5'),
						   ('B305',N'Phòng 305 B5'),('B306',N'Phòng 306 B5'),
						   ('B307',N'Phòng 307 B5'),('B308',N'Phòng 308 B5'),
						   ('B309',N'Phòng 309 B5'),('B310',N'Phòng 310 B5'),('B311',N'Phòng 311 B5');
go

insert into giaovien values ('gv01',N'Hà Quang Dũng',N'Nam','1973/08/09',N'Hà Nội'),
							('gv02',N'Dương Thanh Mi',N'Nữ','1989/10/24',N'Hải Phòng'),
							('gv03',N'Nguyễn Tấn Trường',N'Nam','1984/02/08',N'Hưng Yên'),
							('gv04',N'Ngô Gia Minh',N'Nam','1991/11/21',N'Hà Nội'),
							('gv05',N'Đỗ Tuyết Dung',N'Nữ','1985/05/15',N'Hà Nội');
go

insert into lophocphan values('CSE488-HT',N'An toàn & bảo mật thông tin (HT)',null,'CSE488'),
							 ('CSE488-TH',N'An toàn & bảo mật thông tin (TH)',null,'CSE488'),
							 ('CSE488-PM',N'An toàn & bảo mật thông tin (PM)',null,'CSE488'),
							 ('CSE481-HT',N'Công nghệ phần mềm (HT)',null,'CSE481'),
							 ('CSE481-TH',N'Công nghệ phần mềm (TH)',null,'CSE481'),
							 ('CSE481-PM',N'Công nghệ phần mềm (PM)',null,'CSE481'),
							 ('CSE485-HT',N'Công nghệ web (HT)',null,'CSE485'),
							 ('CSE485-TH',N'Công nghệ web (TH)',null,'CSE485'),
							 ('CSE485-PM',N'Công nghệ web (PM)',null,'CSE485'),
							 ('CSE486-HT',N'Hệ quản trị cơ sở dữ liệu (HT)',null,'CSE486'),
							 ('CSE486-TH',N'Hệ quản trị cơ sở dữ liệu (TH)',null,'CSE486'),
							 ('CSE486-PM',N'Hệ quản trị cơ sở dữ liệu (PM)',null,'CSE486'),
							 ('CSE381-HT',N'Lập trình nâng cao (HT)',null,'CSE381'),
							 ('CSE381-TH',N'Lập trình nâng cao (TH)',null,'CSE381'),
							 ('CSE381-PM',N'Lập trình nâng cao (PM)',null,'CSE381'),
							 ('CSE391-HT',N'Nền tảng phát triển Web (HT)',null,'CSE391'),
							 ('CSE282-HT',N'Nhập môn lập trình khoa học dữ liệu (HT)',null,'CSE282'),
							 ('CSE480-HT',N'Phân tích thiết kế hệ thống thông tin (HT)',null,'CSE480'),
							 ('CSE480-TH',N'Phân tích thiết kế hệ thống thông tin (TH)',null,'CSE480'),
							 ('CSE480-PM',N'Phân tích thiết kế hệ thống thông tin (PM)',null,'CSE480'),
							 ('CSE390-HT',N'Thống kê ứng dụng (HT)',null,'CSE390'),
							 ('CSE390-TH',N'Thống kê ứng dụng (TH)',null,'CSE390'),
							 ('CSE390-PM',N'Thống kê ứng dụng (PM)',null,'CSE390'),
							 ('CSE492-HT',N'Trí tuệ nhân tạo (HT)',null,'CSE492'),
							 ('CSE492-TH',N'Trí tuệ nhân tạo (TH)',null,'CSE492'),
							 ('CSE492-PM',N'Trí tuệ nhân tạo (PM)',null,'CSE492');
go



select masv from sinhvien where masv not in (select tentk from taikhoan)

select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', giaovien.hotengv as N'Tên giáo viên'
from lophocphan,phancong,giaovien
where lophocphan.malhp=phancong.malhp and giaovien.magv =phancong.magv;

select malhp from lophocphan where malhp not in (select malhp from phancong)
select malhp from lophocphan where malhp not in (select malhp from phancong)
select * from phancong;

select * from lophocphan;
go
select* from phonghoc;

select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', phonghoc.tenphonghoc as N'Tên phòng học' from lophocphan, phonghoc where lophocphan.maphonghoc=phonghoc.maphonghoc

select malhp from lophocphan lp where maphonghoc not in (select maphonghoc from phonghoc where lp.maphonghoc = phonghoc.maphonghoc);