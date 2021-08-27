using ProjectQLSV_N12.Views.ucTeacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQLSV_N12.Views;
using ProjectQLSV_N12.Controls;
using ProjectQLSV_N12.Models;

namespace ProjectQLSV_N12.Views
{
    public partial class fTeacherSystem : Form
    {
        public fTeacherSystem()
        {
            InitializeComponent();
        }

        public UCUpdateScore ucUpdateScore = new UCUpdateScore();
        public UCSearchStudent ucSearchStudent = new UCSearchStudent();

        // Khi form load
        private void fTeacherSystem_Load(object sender, EventArgs e)
        {
            ucUpdateScore.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucUpdateScore);
            lbTitleTop.Text = studyScore.Text;
        }


        private void studyScore_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = studyScore.Text;
            ucUpdateScore.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucUpdateScore);
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = searchStudent.Text;
            ucSearchStudent.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucSearchStudent);
        }

        // Khi click vào nút đăng xuất
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
