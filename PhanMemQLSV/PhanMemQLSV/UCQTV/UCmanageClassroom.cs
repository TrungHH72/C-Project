using System;
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
    public partial class UCmanageClassroom : UserControl
    {
        public UCmanageClassroom()
        {
            InitializeComponent();
        }

        connDB connect_DB = new connDB();
        private string sqlManageClassroomInfo = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', phonghoc.tenphonghoc as N'Tên phòng học' from lophocphan, phonghoc where lophocphan.maphonghoc=phonghoc.maphonghoc";

        private void showId()
        {
            connect_DB.dtIdClass.Rows.Clear();
            connect_DB.dtIdClassroom.Rows.Clear();

            string sqlIdClass = "select malhp from lophocphan lp where maphonghoc not in (select maphonghoc from phonghoc where lp.maphonghoc = phonghoc.maphonghoc)";
            string sqlIdClassroom = "select maphonghoc from phonghoc";
            connect_DB.executeSqlShow(sqlIdClass, connect_DB.dtIdClass);
            cbbIdClass.DataSource = connect_DB.dtIdClass;
            cbbIdClass.ValueMember = "malhp";

            connect_DB.executeSqlShow(sqlIdClassroom, connect_DB.dtIdClassroom);
            cbbIdClassroom.DataSource = connect_DB.dtIdClassroom;
            cbbIdClassroom.ValueMember = "maphonghoc";
        }

        private void UCmanageClassroom_Load(object sender, EventArgs e)
        {
            showId();
            connect_DB.executeSqlShow(sqlManageClassroomInfo, connect_DB.dtManageClassroom);
            dgvManageClassroom.DataSource = connect_DB.dtManageClassroom;
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn cập nhật phòng học cho lớp học này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                setClassroom();
                showId();
            }
            else
            {
                return;
            }
        }

        private void setClassroom()
        {
            string sql_update = "update lophocphan set maphonghoc = '"+cbbIdClassroom.Text.Trim()+"' where malhp = '"+cbbIdClass.Text.Trim()+"'";
            connect_DB.executeSqlCommand(sql_update, connect_DB.dtManageClassroom, sqlManageClassroomInfo);
        }
    }
}
