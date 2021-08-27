using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectQLSV_N12.Models
{
    public class DataProvider
    {
        private string connectionStr = "Data Source=JAYPC; Initial Catalog=QuanLySinhVien; Integrated Security=True";


        public DataTable executeQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable executeNonQuery(string sql, DataTable dt, string sql_load, string notification)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery(); // Thực hiện câu lệnh trong chuỗi sql truyền vào
            MessageBox.Show(notification,"Thông báo thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlDataAdapter da = new SqlDataAdapter(sql_load, conn);
            dt.Rows.Clear();
            da.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
