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
    public partial class UCManageTeaching : UserControl
    {
        public UCManageTeaching()
        {
            InitializeComponent();
        }

        DataProvider connectdb = new DataProvider();
        adminFunc adminFunc = new adminFunc();
        public DataTable listInfoTeaching = new DataTable();

        DataTable idTeacher = new DataTable();
        DataTable idClass = new DataTable();


        string sqlInfoTeaching = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', giaovien.hotengv as N'Tên giáo viên' from lophocphan, phancong, giaovien where lophocphan.malhp=phancong.malhp and giaovien.magv = phancong.magv";

        private void showId()
        {
            idTeacher.Rows.Clear();
            idClass.Rows.Clear();
            

            string sqlIdTch = "Select magv from giaovien";
            string sqlIdClass = "select malhp from lophocphan where malhp not in (select malhp from phancong)";

            idTeacher = connectdb.executeQuery(sqlIdTch);
            cbbIdTch.DataSource = idTeacher;
            cbbIdTch.ValueMember = "magv";

            idClass = connectdb.executeQuery(sqlIdClass);
            cbbIdClass.DataSource = idClass;
            cbbIdClass.ValueMember = "malhp";
        }

        private void UCManageTeaching_Load(object sender, EventArgs e)
        {
            showId();
            listInfoTeaching = connectdb.executeQuery(sqlInfoTeaching);
            dgvManageTeaching.DataSource = listInfoTeaching;
        }

        // Khi click vào phân công
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phân công giáo viên vào lớp học này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listInfoTeaching = adminFunc.divisionTeacher(cbbIdTch.Text.Trim(), cbbIdClass.Text.Trim(), listInfoTeaching);
                showId();
            }
            else
            {
                return;
            }
        }
    }
}
