using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQLSV_N12.Controls;
using ProjectQLSV_N12.Models;

namespace ProjectQLSV_N12.Views.ucStudent
{
    public partial class UCResultStudy : UserControl
    {
        public UCResultStudy()
        {
            InitializeComponent();
        }

        DataTable resultStudent = new DataTable();
        DataTable getInfoStd = new DataTable();
        studentFunc stdFunc = new studentFunc();


        private void UCResultStudy_Load(object sender, EventArgs e)
        {
            string query = String.Format("select sinhvien.masv, sinhvien.hotensv, lop.tenlop, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien, diem, lop, monhoc where sinhvien.masv = diem.masv and sinhvien.malop = lop.malop and monhoc.mamh = diem.mamh and diem.duyet = 1 and sinhvien.masv = '{0}'", getInfoAccount.username.Trim());
            resultStudent = stdFunc.getData(query, resultStudent);
            dgvShowRs.DataSource = resultStudent;
            dgvShowRs.Columns[0].HeaderText = "Mã sinh viên";
            dgvShowRs.Columns[1].HeaderText = "Họ tên sinh viên";
            dgvShowRs.Columns[2].HeaderText = "Tên lớp";
            dgvShowRs.Columns[3].HeaderText = "Tên môn học";
            dgvShowRs.Columns[4].HeaderText = "Điểm quá trình";
            dgvShowRs.Columns[5].HeaderText = "Điểm thi";

            if(resultStudent.Rows.Count == 0)
            {
                string query1 = String.Format("select sinhvien.masv, sinhvien.hotensv, lop.tenlop from sinhvien,lop where sinhvien.masv = '{0}' and sinhvien.malop = lop.malop", getInfoAccount.username.Trim());
                getInfoStd = stdFunc.getData(query1, getInfoStd);
                tbIdStd.Text = getInfoStd.Rows[0][0].ToString().Trim();
                tbNameStd.Text = getInfoStd.Rows[0][1].ToString().Trim();
                tbNameClass.Text = getInfoStd.Rows[0][2].ToString().Trim();
            }
            else
            {
                tbIdStd.Text = resultStudent.Rows[0][0].ToString().Trim();
                tbNameStd.Text = resultStudent.Rows[0][1].ToString().Trim();
                tbNameClass.Text = resultStudent.Rows[0][2].ToString().Trim();
            }
        }
    }
}
