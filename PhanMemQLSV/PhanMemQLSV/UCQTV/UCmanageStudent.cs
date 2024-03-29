﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLSV.UCQTV
{
    public partial class UCmanageStudent : UserControl
    {
        public UCmanageStudent()
        {
            InitializeComponent();
        }

        connDB connect_DB = new connDB();

        string gt;
        private string sqlStudentInfo = "select * from sinhvien order by malop";
        bool isValid = false;

        private void refreshInput()
        {
            tbHometownStd.Text = tbFullnameStd.Text = tbIdStd.Text = "";
            rbMale.Checked = rbFemale.Checked = false;
            dtpDateStd.Value = dtpDateStd.MinDate;
            btnAddStd.Enabled = true;
            tbIdStd.Enabled = true;
            btnDelStd.Enabled = btnEditStd.Enabled = false;
        }

        // Khi load
        private void UCmanageStudent_Load(object sender, EventArgs e)
        {
            connect_DB.executeSqlShow(sqlStudentInfo, connect_DB.dtManageStudent);
            dgvManageStd.DataSource = connect_DB.dtManageStudent;
            dgvManageStd.Columns[0].HeaderText = "Mã sinh viên";
            dgvManageStd.Columns[1].HeaderText = "Họ tên";
            dgvManageStd.Columns[2].HeaderText = "Giới tính";
            dgvManageStd.Columns[3].HeaderText = "Năm sinh";
            dgvManageStd.Columns[4].HeaderText = "Quê quán";
            dgvManageStd.Columns[5].HeaderText = "Mã lớp";
            btnDelStd.Enabled = btnEditStd.Enabled = false;

            string sql_idClass = "Select * from lop";
            connect_DB.executeSqlShow(sql_idClass, connect_DB.dtIdClass);
            cbbIdClass.DataSource = connect_DB.dtIdClass;
            cbbIdClass.ValueMember = "malop";
        }
        private void dgvManageStd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdStd.Text = dgvManageStd.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdStd.Enabled = false; // Không thể sửa mã sinh viên

                tbFullnameStd.Text = dgvManageStd.Rows[e.RowIndex].Cells[1].Value.ToString();

                gt = dgvManageStd.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (gt == "Nam") rbMale.Checked = true;
                else rbFemale.Checked = true;

                dtpDateStd.Value = DateTime.Parse(dgvManageStd.Rows[e.RowIndex].Cells[3].Value.ToString());
                tbHometownStd.Text = dgvManageStd.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbIdClass.Text = dgvManageStd.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            // Enable:false nút Thêm và Sửa
            btnAddStd.Enabled = false;
            btnDelStd.Enabled = btnEditStd.Enabled = true;
        }

        // Khi click vào thêm
        private void btnAddStd_Click(object sender, EventArgs e)
        {
            gt = rbMale.Checked ? "Nam" : rbFemale.Checked ? "Nữ" : "";
            // Kiểm tra xem đã nhập đủ thông tin cần thiết của sinh viên chưa
            if (tbIdStd.Text != "" && tbFullnameStd.Text != "" && gt != "" && tbHometownStd.Text != "")
            {
                // Nếu đủ rồi thì thực hiện hàm AddStd()
                AddStd();
            }
            else
            {
                // Nếu chưa đủ thông tin thì thực hiện show thông báo và trở lại trạng thái vừa rồi để nhập thông tin tiếp
                MessageBox.Show("Bạn chưa nhập đủ thông tin sinh viên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddStd()
        {
            if (MessageBox.Show("Bạn muốn thêm thông tin sinh viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (isValidId())
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập lại mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbIdStd.Focus();
                    isValid = false;
                }
                else
                {
                    string sql_insert = "insert into sinhvien values ('" + tbIdStd.Text + "',N'" + tbFullnameStd.Text + "',N'" + gt + "','" + dtpDateStd.Value.ToString("yyyy/MM/dd") + "',N'" + tbHometownStd.Text + "','" + cbbIdClass.Text.Trim() + "')";
                    connect_DB.executeSqlCommand(sql_insert, connect_DB.dtManageStudent, sqlStudentInfo);
                    refreshInput();
                }
            }
            else
            {
                return;
            }
        }

        private bool isValidId()
        {
            foreach (DataRow row in connect_DB.dtManageStudent.Rows)
            {
                if (row[0].ToString().Trim() == tbIdStd.Text)
                {
                    isValid = true;
                    break;
                }
            }

            return isValid;
        }

        // Khi click vào sửa
        private void btnEditStd_Click(object sender, EventArgs e)
        {
            // Show thông báo
            if (MessageBox.Show("Bạn muốn sửa thông tin sinh viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes
                // Thực hiện hàm EditStd
                EditStd();
            }
            else
            {
                // Nếu người dùng chọn No
                // Không thực hiện edit
                return;
            }
        }

        private void EditStd()
        {
            gt = rbMale.Checked ? "Nam" : "Nữ";
            string sql_update = "update sinhvien set hotensv = N'" + tbFullnameStd.Text + "', gioitinh=N'" + gt + "',ngaysinh='" + dtpDateStd.Value.ToString("yyyy/MM/dd") + "',quequan=N'" + tbHometownStd.Text + "',malop='" + cbbIdClass.Text.Trim() + "' where masv='" + tbIdStd.Text + "'";
            connect_DB.executeSqlCommand(sql_update, connect_DB.dtManageStudent, sqlStudentInfo);
            refreshInput();
        }

        // Khi click vào nút xóa
        private void btnDelStd_Click(object sender, EventArgs e)
        {
            // Show thông báo
            if (MessageBox.Show("Bạn muốn xóa thông tin giáo viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes
                // Thực hiện hàm DelStd
                DelStd();
            }
            else
            {
                // Nếu người dùng chọn No
                // Không thực hiện xóa
                return;
            }
        }

        private void DelStd()
        {
            string sql_delete = "delete from sinhvien where masv = '" + tbIdStd.Text + "'";
            connect_DB.executeSqlCommand(sql_delete, connect_DB.dtManageStudent, sqlStudentInfo);
            refreshInput();
        }
    }
}
