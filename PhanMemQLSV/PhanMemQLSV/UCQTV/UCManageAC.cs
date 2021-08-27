using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQLSV.UCQTV
{
    public partial class UCManageAC : UserControl
    {
        public UCManageAC()
        {
            InitializeComponent();
        }

        private connDB connect_db = new connDB();
        private string sql_load = "select * from taikhoan where loaitk = 1 union select * from taikhoan where loaitk = 2 ";
        int ltk;
        bool isValid;

        // Khi user control quản lý tài khoản được load
        private void UCManageAC_Load(object sender, EventArgs e)
        {
            connect_db.executeSqlShow(sql_load, connect_db.dtManageAccount);
            dgvAccount.DataSource = connect_db.dtManageAccount;
            dgvAccount.Columns[0].HeaderText = "Mã tài khoản";
            dgvAccount.Columns[1].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns[2].HeaderText = "Mật khẩu";
            dgvAccount.Columns[3].HeaderText = "Loại tài khoản";

            cbbTypeAccount.SelectedIndex = 0;
        }

        private void cbbTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            showIdNeedAccount();
        }

        private void showIdNeedAccount()
        {
            connect_db.dtIdStd.Rows.Clear();
            connect_db.dtIdTch.Rows.Clear();
            if (cbbTypeAccount.SelectedIndex == 0)
            {
                lbIdUs.Text = "Mã giáo viên";
                string sql = "select magv from giaovien where magv not in (select tentk from taikhoan)";
                connect_db.executeSqlShow(sql, connect_db.dtIdTch);
                cbbIdUser.DataSource = connect_db.dtIdTch;
                cbbIdUser.ValueMember = "magv";
            }
            if (cbbTypeAccount.SelectedIndex == 1)
            {
                lbIdUs.Text = "Mã sinh viên";
                string sql = "select top 10 masv from sinhvien where masv not in (select tentk from taikhoan)";
                connect_db.executeSqlShow(sql, connect_db.dtIdStd);
                cbbIdUser.DataSource = connect_db.dtIdStd;
                cbbIdUser.ValueMember = "masv";
            }
        }

        private void cbbIdUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUsername.Text = cbbIdUser.Text.Trim();
        }

        // Khi click vào nút Tạo tài khoản
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbIdAccount.TextLength > 0 && tbPassword.TextLength > 0)
            {
                if (cbbTypeAccount.SelectedIndex == 0) ltk = 1;
                if (cbbTypeAccount.SelectedIndex == 1) ltk = 2;
                if(MessageBox.Show("Bạn muốn tạo tài khoản","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    createAccount();
                    showIdNeedAccount();
                    cbbTypeAccount.SelectedIndex = 0;
                    tbIdAccount.Text = tbPassword.Text = "";
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void createAccount()
        {
            if (isValidId())
            {
                MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng nhập lại mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIdAccount.Focus();
                isValid = false;
            }
            else
            {
                string sql_insert = "insert into taikhoan values ('" + tbIdAccount.Text + "','" + tbUsername.Text + "','" + tbPassword.Text + "'," + ltk + ")";
                connect_db.executeSqlCommand(sql_insert, connect_db.dtManageAccount, sql_load);
            }
        }

        private bool isValidId()
        {
            foreach (DataRow row in connect_db.dtManageAccount.Rows)
            {
                if (row[0].ToString().Trim() == tbIdAccount.Text)
                {
                    isValid = true;
                    break;
                }
            }

            return isValid;
        }
    }
}
