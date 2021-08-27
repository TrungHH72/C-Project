using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectQLSV_N12.Models;

namespace ProjectQLSV_N12.Controls
{
    public class teacherFunc
    {
        DataProvider data = new DataProvider();

        public DataTable getData(string query, DataTable dt)
        {
            dt = data.executeQuery(query);

            return dt;
        }

        public DataTable upgetData(string query, DataTable dt)
        {
            dt.Rows.Clear();
            dt = data.executeQuery(query);

            return dt;
        }

        public DataTable updateDatatable(string idClass, DataTable dt)
        {
            dt.Rows.Clear();
            string query1 = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and danhsachlhp.malhp = '{0}'", idClass);
            dt = data.executeQuery(query1);
            return dt;
        }

        public DataTable updateData(string idClass,string idSub, string idStd,int s1, int s2, DataTable dt)
        {
            string sql = String.Format("update diem set diemqt = '{0}', diemthi = '{1}' where mamh = '{2}' and masv = '{3}'", s1, s2, idSub, idStd);
            string load = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and danhsachlhp.malhp = '{0}'", idClass);
            string noti = "Bạn đã cập nhật điểm thành công";
            dt = data.executeNonQuery(sql, dt, load, noti);
            return dt;
        }
    }
}
