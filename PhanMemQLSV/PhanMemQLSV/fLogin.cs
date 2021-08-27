using System;
using System.Windows.Forms;

namespace PhanMemQLSV
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private connDB connect_db = new connDB();
        private FormQTV formQTV = new FormQTV();

        // Khi click vào nút đăng nhập
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập vào form đăng nhập chưa
            if(tbUsername.TextLength > 0 && tbPassword.TextLength > 0)
            {
                // Nếu người dùng nhập dữ liệu rồi thì thực hiện hàm checkAccountValid()
                checkAccountValid();
            }
            else
            {
                // Thực hiện thông báo
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
        }

        private void checkAccountValid()
        {
            string sqlAccount = "select * from taikhoan where tentk = '"+tbUsername.Text+ "' and matkhau = '"+tbPassword.Text+"'";
            connect_db.executeSqlShow(sqlAccount, connect_db.dtAc);

            // Thực hiện kiểm tra
            if(connect_db.dtAc.Rows.Count > 0)
            {
                // Nếu thông tin tài khoản người dùng nhập đúng thì kiểm tra loại tài khoản
                if(connect_db.dtAc.Rows[0][3].ToString() == "0") // Tài khoản admin
                {
                    // Ẩn Form đăng nhập
                    this.Hide();
                    // Thực hiện các chức năng trong form QTV
                    formQTV.ShowDialog();
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
                tbUsername.Text = tbPassword.Text = "";
                return;
            }
        }

        // Khi click vào nút thoát
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            // Thực hiện đóng chương trình
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thông báo
            DialogResult rs = MessageBox.Show("Bạn muốn thoát chương trình","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Thực hiện kiểm tra nếu người dùng không muốn thoát chương trình nữa
            // Cancel đóng chương trình
            if (rs == DialogResult.No) e.Cancel = true;
        }
    }
}
