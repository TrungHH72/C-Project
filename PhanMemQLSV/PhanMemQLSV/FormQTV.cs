using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQLSV.UCQTV;

namespace PhanMemQLSV
{
    public partial class FormQTV : Form
    {
        public FormQTV()
        {
            InitializeComponent();
        }

        // Khi form load
        private void FormQTV_Load(object sender, EventArgs e)
        {
            UCManageAC uc = new UCManageAC();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void manageAccount_Click(object sender, EventArgs e)
        {
            lbTitleTop.Text = manageAccount.Text;
            pnlContainer.Controls.Clear();
            UCManageAC uc = new UCManageAC();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void manageTeacher_Click(object sender, EventArgs e)
        {
            lbTitleTop.Text = manageTeacher.Text;
            pnlContainer.Controls.Clear();
            UCmanageTeacher uc = new UCmanageTeacher();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            lbTitleTop.Text = manageStudent.Text;
            pnlContainer.Controls.Clear();
            UCmanageStudent uc = new UCmanageStudent();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void manageTeaching_Click(object sender, EventArgs e)
        {
            lbTitleTop.Text = manageTeaching.Text;
            pnlContainer.Controls.Clear();
            UCmanageTeaching uc = new UCmanageTeaching();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void manageClassroom_Click(object sender, EventArgs e)
        {
            lbTitleTop.Text = manageClassroom.Text;
            pnlContainer.Controls.Clear();
            UCmanageClassroom uc = new UCmanageClassroom();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        // Khi click vào nút đăng xuất
        private void btnLogOut_Click(object sender, EventArgs e)
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
