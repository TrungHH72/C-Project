using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLSV
{
    class connDB
    {
        private string chuoiketnoi = "Data Source=JAYPC; Initial Catalog=QuanLySinhVien; Integrated Security=True";
        private SqlConnection conn = null;
        // Lưu thông tin đăng nhập
        public DataTable dtAc = new DataTable();
        // Lưu danh sách tài khoản của sinh viên và giáo viên
        public DataTable dtManageAccount = new DataTable();
        // Lưu id của các sinh viên và giáo viên
        public DataTable dtIdTch = new DataTable();
        public DataTable dtIdStd = new DataTable();

        // Lưu danh sách thông tin giáo viên
        public DataTable dtManageTeacher = new DataTable();

        // Lưu danh sách thông tin sinh viên
        public DataTable dtManageStudent = new DataTable();

        // Lưu thông tin tên giáo viên, lớp phòng
        public DataTable dtNameTch = new DataTable();
        public DataTable dtNameClass = new DataTable();
        public DataTable dtNameClassroom = new DataTable();

        // Lưu danh sách mã lớp và mã phòng học có trong db
        public DataTable dtIdClass = new DataTable();
        public DataTable dtIdClassroom = new DataTable();

        // Lưu danh sách thông tin về phân công giảng dạy
        public DataTable dtManageTeaching = new DataTable();

        // Lưu danh sách thông tin về chỉ định phòng học
        public DataTable dtManageClassroom = new DataTable();

        public void executeSqlShow(string sql, DataTable dt)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
        }

        public void executeSqlCommand(string sql, DataTable dt, string sql_load)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery(); // Thực hiện câu lệnh trong chuỗi sql truyền vào
            MessageBox.Show("Thực hiện thành công");
            SqlDataAdapter da = new SqlDataAdapter(sql_load, conn);
            dt.Rows.Clear();
            da.Fill(dt);
            conn.Close();
        }
    }
}
