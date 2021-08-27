using ProjectQLSV_N12.Models;
using ProjectQLSV_N12.Views;
using ProjectQLSV_N12.Views.ucAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLSV_N12.Controls
{
    public class adminFunc
    {

        DataProvider data = new DataProvider();
        public DataTable dtAc = new DataTable();


        public bool checkAccountValid(string username, string password)
        {
            string sqlAccount = "select * from taikhoan where tentk = '" + username + "' and matkhau = '" + password + "'";
            dtAc = data.executeQuery(sqlAccount);

            // Thực hiện kiểm tra
            if (dtAc.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public DataTable createAccount(string id, string username, string password, int ltk, DataTable dt)
        {
            string noti = "Bạn đã tạo tài khoản thành công";
            string sql_account = "select * from taikhoan where loaitk > 0";
            string sql_insert = "insert into taikhoan values ('" + id + "','" + username + "','" + password + "'," + ltk + ")";
            dt = data.executeNonQuery(sql_insert, dt, sql_account, noti);

            return dt;
        }

        public DataTable addInfoTeacher(string id, string fullname, string sex, string dateborn, string hometown,DataTable dt)
        {
            string sql_insert = "insert into giaovien values ('" + id + "',N'" + fullname + "',N'" + sex + "','" + dateborn + "',N'" + hometown + "')";
            string noti = "Bạn đã thêm mới thông tin giáo viên thành công";
            string listInfo = "select * from giaovien";
            dt = data.executeNonQuery(sql_insert, dt, listInfo, noti);

            return dt;
        }

        public DataTable editInfoTeacher(string id, string fullname, string sex, string dateborn, string hometown, DataTable dt)
        {
            string sql_update = "update giaovien set hotengv = N'" + fullname + "', gioitinh=N'" + sex + "',ngaysinh='" + dateborn + "',quequan=N'" + hometown + "' where magv='" + id + "'";
            string noti = "Bạn đã sửa thông tin giáo viên thành công";
            string listInfo = "select * from giaovien";
            dt = data.executeNonQuery(sql_update, dt, listInfo, noti);

            return dt;
        }

        public DataTable delInfoTeacher(string id, DataTable dt)
        {
            string sql_del = "delete from giaovien where magv = '" + id + "'";
            string noti = "Bạn đã xóa thông tin giáo viên thành công";
            string listInfo = "select * from giaovien";
            dt = data.executeNonQuery(sql_del, dt, listInfo, noti);

            return dt;
        }

        public DataTable addInfoStudent(string id, string fullname, string sex, string dateborn, string hometown, string idClass, DataTable dt)
        {
            string sql_insert = "insert into sinhvien values ('" + id + "',N'" + fullname + "',N'" + sex + "','" + dateborn + "',N'" + hometown + "','" + idClass + "')";
            string noti = "Bạn đã thêm mới thông tin sinh viên thành công";
            string listInfo = "select * from sinhvien";
            dt = data.executeNonQuery(sql_insert, dt, listInfo, noti);

            return dt;
        }

        public DataTable editInfoStudent(string id, string fullname, string sex, string dateborn, string hometown, string idClass, DataTable dt)
        {
            string sql_update = "update sinhvien set hotensv = N'" + fullname + "', gioitinh=N'" + sex + "',ngaysinh='" + dateborn + "',quequan=N'" + hometown + "',malop='" + idClass + "' where masv='" + id + "'";
            string noti = "Bạn đã sửa thông tin sinh viên thành công";
            string listInfo = "select * from sinhvien";
            dt = data.executeNonQuery(sql_update, dt, listInfo, noti);

            return dt;
        }

        public DataTable delInfoStudent(string id, DataTable dt)
        {
            string sql_del = "delete from sinhvien where masv = '" + id + "'";
            string noti = "Bạn đã xóa thông tin sinh viên thành công";
            string listInfo = "select * from sinhvien";
            dt = data.executeNonQuery(sql_del, dt, listInfo, noti);

            return dt;
        }

        public DataTable divisionTeacher(string idTeacher, string idClass,DataTable dt)
        {
            string sql_insert = "insert into phancong values('" + idTeacher + "','" + idClass + "')";
            string noti = "Bạn đã phân công giáo viên dạy lớp học phần này thành công";
            string listInfo = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', giaovien.hotengv as N'Tên giáo viên' from lophocphan, phancong, giaovien where lophocphan.malhp=phancong.malhp and giaovien.magv = phancong.magv";
            dt = data.executeNonQuery(sql_insert, dt, listInfo, noti);

            return dt;
        }

        public DataTable setClassroom(string idClass, string idClassroom, DataTable dt)
        {
            string sql_insert = "update lophocphan set maphonghoc = '" + idClassroom + "' where malhp = '" + idClass + "'";
            string noti = "Bạn đã xếp phòng học cho lớp học phần này thành công";
            string listInfo = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', phonghoc.tenphonghoc as N'Tên phòng học' from lophocphan, phonghoc where lophocphan.maphonghoc=phonghoc.maphonghoc";
            dt = data.executeNonQuery(sql_insert, dt, listInfo, noti);

            return dt;
        }

        public DataTable getData(string query, DataTable dt)
        {
            dt = data.executeQuery(query);

            return dt;
        }

        public DataTable updateDatatable(string query, DataTable dt)
        {
            dt.Rows.Clear();
            dt = data.executeQuery(query);
            return dt;
        }

        public DataTable updateData(string idClass, string idSub, string idStd, DataTable dt)
        {
            string sql = String.Format("update diem set duyet = 1 where mamh = '{0}' and masv = '{1}'", idSub, idStd);
            string load = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 0 and danhsachlhp.malhp = '{0}'", idClass);
            string noti = "Bạn đã duyệt điểm thành công";
            dt = data.executeNonQuery(sql, dt, load, noti);
            return dt;
        }

    }
}
