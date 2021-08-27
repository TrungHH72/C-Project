using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQLSV_N12.Models;
using ProjectQLSV_N12.Controls;

namespace ProjectQLSV_N12.Views.ucAdmin
{
    public partial class UCManageAccount : UserControl
    {
        public UCManageAccount()
        {
            InitializeComponent();
        }

        DataProvider connectdb = new DataProvider();
        adminFunc adminFunc = new adminFunc();
        public DataTable listAccounts = new DataTable();
        DataTable idStd = new DataTable();
        DataTable idTch = new DataTable();

        public string sqlAccount = "select * from taikhoan where loaitk > 0 ";
        public string username, password,id;
        public int ltk;
        bool isValid;

        private void UCManageAccount_Load(object sender, EventArgs e)
        {
            listAccounts = connectdb.executeQuery(sqlAccount);
            dgvAccount.DataSource = listAccounts;
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
            idStd.Rows.Clear();
            idTch.Rows.Clear();
            if (cbbTypeAccount.SelectedIndex == 0)
            {
                lbIdUs.Text = "Mã giáo viên";
                string sql = "select magv from giaovien where magv not in (select tentk from taikhoan)";
                idTch = connectdb.executeQuery(sql);
                cbbIdUser.DataSource = idTch;
                cbbIdUser.ValueMember = "magv";
            }
            if (cbbTypeAccount.SelectedIndex == 1)
            {
                lbIdUs.Text = "Mã sinh viên";
                string sql = "select top 10 masv from sinhvien where masv not in (select tentk from taikhoan)";
                idStd = connectdb.executeQuery(sql);
                cbbIdUser.DataSource = idStd;
                cbbIdUser.ValueMember = "masv";
            }
        }

        private void cbbIdUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUsername.Text = cbbIdUser.Text.Trim();
        }


        // Khi click vào nút tạo tài khoản
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbIdAccount.TextLength > 0 && tbPassword.TextLength > 0)
            {
                if (cbbTypeAccount.SelectedIndex == 0) ltk = 1;
                if (cbbTypeAccount.SelectedIndex == 1) ltk = 2;
                if (MessageBox.Show("Bạn muốn tạo tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(!isValidId())
                    {
                        listAccounts.Rows.Clear();
                        listAccounts = adminFunc.createAccount(tbIdAccount.Text, tbUsername.Text.Trim(), tbPassword.Text, ltk, listAccounts);
                        showIdNeedAccount();
                        cbbTypeAccount.SelectedIndex = 0;
                        tbIdAccount.Text = tbPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng nhập lại mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbIdAccount.Focus();
                        isValid = false;
                    }
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

        private bool isValidId()
        {
            foreach (DataRow row in listAccounts.Rows)
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
