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
    public partial class UCmanageTeaching : UserControl
    {
        public UCmanageTeaching()
        {
            InitializeComponent();
        }

        connDB connect_DB = new connDB();
        private string sqlManageTeachingInfo = "select lophocphan.malhp as N'Mã lớp học',lophocphan.tenlophoc as N'Tên lớp học', giaovien.hotengv as N'Tên giáo viên' from lophocphan, phancong, giaovien where lophocphan.malhp=phancong.malhp and giaovien.magv = phancong.magv";

        private void showId()
        {
            connect_DB.dtIdTch.Rows.Clear();
            connect_DB.dtIdClass.Rows.Clear();

            string sqlIdTch = "Select magv from giaovien";
            string sqlIdClass = "select malhp from lophocphan where malhp not in (select malhp from phancong)";
            connect_DB.executeSqlShow(sqlIdTch, connect_DB.dtIdTch);
            cbbIdTch.DataSource = connect_DB.dtIdTch;
            cbbIdTch.ValueMember = "magv";

            connect_DB.executeSqlShow(sqlIdClass, connect_DB.dtIdClass);
            cbbIdClass.DataSource = connect_DB.dtIdClass;
            cbbIdClass.ValueMember = "malhp";
        }
        // Khi load
        private void UCmanageTeaching_Load(object sender, EventArgs e)
        {
            showId();
            connect_DB.executeSqlShow(sqlManageTeachingInfo, connect_DB.dtManageTeaching);
            dgvManageTeaching.DataSource = connect_DB.dtManageTeaching;
        }


        // Khi click vào phân công
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phân công giáo viên vào lớp học này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                divisionTch();
                showId();
            }
            else
            {
                return;
            }
        }

        private void divisionTch()
        {
            string sql_insert = "insert into phancong values('" + cbbIdTch.Text.Trim() + "','" + cbbIdClass.Text.Trim() + "')";
            connect_DB.executeSqlCommand(sql_insert, connect_DB.dtManageTeaching, sqlManageTeachingInfo);
        }

    }
}
