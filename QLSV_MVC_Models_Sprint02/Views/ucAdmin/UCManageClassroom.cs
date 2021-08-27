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
    public partial class UCManageClassroom : UserControl
    {
        public UCManageClassroom()
        {
            InitializeComponent();
        }

        DataProvider connectdb = new DataProvider();
        adminFunc adminFunc = new adminFunc();
        public DataTable listInfoClassroom = new DataTable();

        DataTable idClass = new DataTable();
        DataTable idClassroom = new DataTable();

        string sqlInfoClassroom = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', phonghoc.tenphonghoc as N'Tên phòng học' from lophocphan, phonghoc where lophocphan.maphonghoc=phonghoc.maphonghoc";

        private void showId()
        {
            idClass.Rows.Clear();
            idClassroom.Rows.Clear();


            string sqlIdClass = "select malhp from lophocphan lp where maphonghoc not in (select maphonghoc from phonghoc where lp.maphonghoc = phonghoc.maphonghoc)";
            string sqlIdClassroom = "select maphonghoc from phonghoc";

            idClass = connectdb.executeQuery(sqlIdClass);
            cbbIdClass.DataSource = idClass;
            cbbIdClass.ValueMember = "malhp";

            idClassroom = connectdb.executeQuery(sqlIdClassroom);
            cbbIdClassroom.DataSource = idClassroom;
            cbbIdClassroom.ValueMember = "maphonghoc";
        }

        private void UCManageClassroom_Load(object sender, EventArgs e)
        {
            showId();
            listInfoClassroom = connectdb.executeQuery(sqlInfoClassroom);
            dgvManageClassroom.DataSource = listInfoClassroom;
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn cập nhật phòng học cho lớp học này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listInfoClassroom = adminFunc.setClassroom(cbbIdClass.Text.Trim(), cbbIdClassroom.Text.Trim(), listInfoClassroom);
                showId();
            }
            else
            {
                return;
            }
        }
    }
}
