using ProjectQLSV_N12.Views.ucAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLSV_N12.Views
{
    public partial class fAdminSystem : Form
    {
        public fAdminSystem()
        {
            InitializeComponent();
        }

        public UCManageAccount ucManageAccount = new UCManageAccount();
        public UCManageTeacher ucManageTeacher = new UCManageTeacher();
        public UCManageStudent ucManageStudent = new UCManageStudent();
        public UCManageTeaching ucManageTeaching = new UCManageTeaching();
        public UCManageClassroom ucManageClassroom = new UCManageClassroom();
        public UCManageStudy ucManageStudy = new UCManageStudy();

        // Khi form dành cho quản trị viên load
        private void fAdminSystem_Load(object sender, EventArgs e)
        {
            ucManageAccount.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageAccount);
        }

        private void manageAccount_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageAccount.Text;
            ucManageAccount.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageAccount);
        }

        private void manageTeacher_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageTeacher.Text;
            ucManageTeacher.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageTeacher);
        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageStudent.Text;
            ucManageStudent.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageStudent);
        }

        private void manageTeaching_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageTeaching.Text;
            ucManageTeaching.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageTeaching);
        }

        private void manageClassroom_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageClassroom.Text;
            ucManageClassroom.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageClassroom);
        }

        private void btnManageStudy_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = manageClassroom.Text;
            ucManageStudy.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucManageStudy);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo
            DialogResult rs = MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Nếu user chọn yes
            if (rs == DialogResult.Yes)
            {
                // Đóng FormQTV sau đó quay trở lại form Đăng nhập
                this.Close();
            }
            // Nếu user chọn no
            if (rs == DialogResult.No) return;
        }

    }
}
