using ProjectQLSV_N12.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLSV_N12.Views.ucTeacher
{
    public partial class UCSearchStudent : UserControl
    {
        public UCSearchStudent()
        {
            InitializeComponent();
        }

        DataTable listStudent = new DataTable();
        DataTable listIdClass = new DataTable();
        DataTable resultStudent = new DataTable();
        teacherFunc tchFunc = new teacherFunc();

        string idClass;

        private void UCSearchStudent_Load(object sender, EventArgs e)
        {
            string query = "select malop from lop";
            listIdClass = tchFunc.getData(query, listIdClass);
            cbbIdClass.DataSource = listIdClass;
            cbbIdClass.ValueMember = "malop";
        }


        private void cbbIdClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClass = cbbIdClass.Text;
            updateTableShow(idClass);
            dgvRsStudy.DataSource = null;
            tbIdStd.Text = tbNameClass.Text = tbNameStd.Text = "";
        }

        private void updateTableShow(string idC)
        {
            string query = String.Format("select sinhvien.masv as N'Mã sinh viên', sinhvien.hotensv as N'Tên sinh viên', lop.tenlop as N'Lớp' from sinhvien, lop where sinhvien.malop = lop.malop and sinhvien.malop = '{0}'", idC);
            listStudent = tchFunc.upgetData(query, listStudent);
            dgvListStd.DataSource = listStudent;
        }

        private void dgvListStd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdStd.Text = dgvListStd.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                tbNameStd.Text = dgvListStd.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                tbNameClass.Text = dgvListStd.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();

                upRsStd(tbIdStd.Text);
            }
        }

        private void upRsStd(string idStd)
        {
            string query = String.Format("select monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien, diem, lop, monhoc where sinhvien.masv = diem.masv and sinhvien.malop = lop.malop and monhoc.mamh = diem.mamh and diem.duyet = 1 and sinhvien.masv = '{0}'", idStd);
            resultStudent = tchFunc.getData(query, resultStudent);
            dgvRsStudy.DataSource = resultStudent;
            dgvRsStudy.Columns[0].HeaderText = "Tên môn học";
            dgvRsStudy.Columns[1].HeaderText = "Điểm quá trình";
            dgvRsStudy.Columns[2].HeaderText = "Điểm thi";
        }
    }
}
