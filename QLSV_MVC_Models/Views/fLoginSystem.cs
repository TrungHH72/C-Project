using ProjectQLSV_N12.Controls;
using ProjectQLSV_N12.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLSV_N12
{
    public partial class fLoginSystem : Form
    {
        public fLoginSystem()
        {
            InitializeComponent();
        }

        public fAdminSystem fAdmin = new fAdminSystem();
        public fTeacherSystem fTeacher = new fTeacherSystem();
        public fStudentSystem fStudent = new fStudentSystem();

        adminFunc admFunc = new adminFunc();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập vào form đăng nhập chưa
            if (tbUsername.TextLength > 0 && tbPassword.TextLength > 0)
            {
                // Nếu người dùng nhập dữ liệu rồi thì thực hiện hàm checkAccountValid()
                if (admFunc.checkAccountValid(tbUsername.Text, tbPassword.Text))
                {
                    // Nếu đăng nhập với loại tài khoản dành cho QTV thì
                    if(admFunc.dtAc.Rows[0][3].ToString() == "0")
                    {
                        // Ẩn Form đăng nhập
                        this.Hide();
                        // Thực hiện các chức năng trong form QTV
                        fAdmin.ShowDialog();
                        // Sau đó Show lại form đăng nhập
                        this.Show();
                        // Khi thực hiện nhấn nút đăng xuất trong form QTV thì reset lại phần nhập thông tin tài khoản
                        tbUsername.Text = tbPassword.Text = "";
                        tbUsername.Focus();
                    }

                    // Nếu đăng nhập với loại tài khoản dành cho giáo viên thì
                    if (admFunc.dtAc.Rows[0][3].ToString() == "1")
                    {
                        // Ẩn Form đăng nhập
                        this.Hide();
                        // Thực hiện các chức năng trong form Giáo viên
                        fTeacher.ShowDialog();
                        // Sau đó Show lại form đăng nhập
                        this.Show();
                        // Khi thực hiện nhấn nút đăng xuất trong form giáo viên thì reset lại phần nhập thông tin tài khoản
                        tbUsername.Text = tbPassword.Text = "";
                        tbUsername.Focus();
                    }

                    // Nếu đăng nhập với loại tài khoản dành cho sinh viên thì
                    if (admFunc.dtAc.Rows[0][3].ToString() == "2")
                    {
                        // Ẩn Form đăng nhập
                        this.Hide();
                        // Thực hiện các chức năng trong form Giáo viên
                        fStudent.ShowDialog();
                        // Sau đó Show lại form đăng nhập
                        this.Show();
                        // Khi thực hiện nhấn nút đăng xuất trong form QTV thì reset lại phần nhập thông tin tài khoản
                        tbUsername.Text = tbPassword.Text = "";
                        tbUsername.Focus();
                    }
                }
                else
                {
                    // Nếu người dùng nhập sai thì hiện thông báo
                    MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Focus();
                    return;
                }
            }
            else
            {
                // Thực hiện thông báo
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
        }

        


        // Thực hiện thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLoginSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thông báo
            DialogResult rs = MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Thực hiện kiểm tra nếu người dùng không muốn thoát chương trình nữa
            // Cancel đóng chương trình
            if (rs == DialogResult.No) e.Cancel = true;
        }
    }
}
