using ProjectQLSV_N12.Views.ucStudent;
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
    public partial class fStudentSystem : Form
    {
        public fStudentSystem()
        {
            InitializeComponent();
        }

        public UCResultStudy uCResultStudy = new UCResultStudy();

        private void fStudentSystem_Load(object sender, EventArgs e)
        {
            uCResultStudy.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uCResultStudy);
            lbTitleTop.Text = resultStudy.Text;
        }

        private void resultStudy_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            lbTitleTop.Text = resultStudy.Text;
            uCResultStudy.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uCResultStudy);
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
