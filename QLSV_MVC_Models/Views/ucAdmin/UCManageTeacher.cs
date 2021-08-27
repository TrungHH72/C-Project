using ProjectQLSV_N12.Controls;
using ProjectQLSV_N12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLSV_N12.Views.ucAdmin
{
    public partial class UCManageTeacher : UserControl
    {
        public UCManageTeacher()
        {
            InitializeComponent();
        }

        DataProvider connectdb = new DataProvider();
        adminFunc adminFunc = new adminFunc();
        public DataTable listInfoTeacher = new DataTable();

        string gt;
        private string sqlTeacherInfo = "select * from giaovien";
        bool isValid = false;

        private void refreshInputTch()
        {
            tbHometowntch.Text = tbFullnameTch.Text = tbIdTch.Text = "";
            rbMale.Checked = rbFemale.Checked = false;
            dtpDateTch.Value = dtpDateTch.MinDate;
            btnAddTch.Enabled = true;
            tbIdTch.Enabled = true;
            btnDelTch.Enabled = btnEditTch.Enabled = false;
        }

        private void UCManageTeacher_Load(object sender, EventArgs e)
        {
            listInfoTeacher = connectdb.executeQuery(sqlTeacherInfo);
            dgvManageTch.DataSource = listInfoTeacher;
            dgvManageTch.Columns[0].HeaderText = "Mã giáo viên";
            dgvManageTch.Columns[1].HeaderText = "Họ tên";
            dgvManageTch.Columns[2].HeaderText = "Giới tính";
            dgvManageTch.Columns[3].HeaderText = "Năm sinh";
            dgvManageTch.Columns[4].HeaderText = "Quê quán";
            btnDelTch.Enabled = btnEditTch.Enabled = false;
        }

        private void dgvManageTch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdTch.Text = dgvManageTch.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdTch.Enabled = false; // Không thể sửa mã sinh viên

                tbFullnameTch.Text = dgvManageTch.Rows[e.RowIndex].Cells[1].Value.ToString();

                gt = dgvManageTch.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (gt == "Nam") rbMale.Checked = true;
                else rbFemale.Checked = true;

                dtpDateTch.Value = DateTime.Parse(dgvManageTch.Rows[e.RowIndex].Cells[3].Value.ToString());
                tbHometowntch.Text = dgvManageTch.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            // Enable:false nút Thêm và Sửa
            btnAddTch.Enabled = false;
            btnDelTch.Enabled = btnEditTch.Enabled = true;
        }

        // Khi click vào thêm
        private void btnAddTch_Click(object sender, EventArgs e)
        {
            gt = rbMale.Checked ? "Nam" : rbFemale.Checked ? "Nữ" : "";
            // Kiểm tra xem đã nhập đủ thông tin cần thiết của sinh viên chưa
            if (tbIdTch.Text != "" && tbFullnameTch.Text != "" && gt != "" && tbHometowntch.Text != "")
            {
                if (MessageBox.Show("Bạn muốn thêm thông tin giáo viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (isValidId())
                    {
                        MessageBox.Show("Mã giáo viên đã tồn tại. Vui lòng nhập lại mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbIdTch.Focus();
                        isValid = false;
                    }
                    else
                    {
                        listInfoTeacher = adminFunc.addInfoTeacher(tbIdTch.Text, tbFullnameTch.Text, gt, dtpDateTch.Value.ToString("yyyy/MM/dd"), tbHometowntch.Text, listInfoTeacher);

                        refreshInputTch();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                // Nếu chưa đủ thông tin thì thực hiện show thông báo và trở lại trạng thái vừa rồi để nhập thông tin tiếp
                MessageBox.Show("Bạn chưa nhập đủ thông tin sinh viên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Khi click vào nút sửa
        private void btnEditTch_Click(object sender, EventArgs e)
        {
            // Show thông báo
            if (MessageBox.Show("Bạn muốn sửa thông tin giáo viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gt = rbMale.Checked ? "Nam" : "Nữ";
                // Nếu người dùng chọn Yes
                adminFunc.editInfoTeacher(tbIdTch.Text, tbFullnameTch.Text, gt, dtpDateTch.Value.ToString("yyyy/MM/dd"), tbHometowntch.Text, listInfoTeacher);

                refreshInputTch();
            }
            else
            {
                // Nếu người dùng chọn No
                // Không thực hiện edit
                return;
            }
        }


        // Khi click vào nút xóa
        private void btnDelTch_Click(object sender, EventArgs e)
        {
            // Show thông báo
            if (MessageBox.Show("Bạn muốn xóa thông tin giáo viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes
                adminFunc.delInfoTeacher(tbIdTch.Text ,listInfoTeacher);

                refreshInputTch();
            }
            else
            {
                // Nếu người dùng chọn No
                // Không thực hiện xóa
                return;
            }
        }

        private bool isValidId()
        {
            foreach (DataRow row in listInfoTeacher.Rows)
            {
                if (row[0].ToString().Trim() == tbIdTch.Text)
                {
                    isValid = true;
                    break;
                }
            }

            return isValid;
        }
    }
}
