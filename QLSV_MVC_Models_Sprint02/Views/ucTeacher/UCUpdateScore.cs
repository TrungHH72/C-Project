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

namespace ProjectQLSV_N12.Views.ucTeacher
{
    public partial class UCUpdateScore : UserControl
    {
        public UCUpdateScore()
        {
            InitializeComponent();
        }

        DataTable getIdClass = new DataTable();
        DataTable listStdClass = new DataTable();
        teacherFunc tchFunc = new teacherFunc();
        string idSub, idClass;

        private void refreshInput()
        {
            tbIdStd.Text = tbNameStudent.Text = tbNameSubject.Text = tbScore1.Text = tbScore2.Text = "";
        }

        // Khi form load
        private void UCUpdateScore_Load(object sender, EventArgs e)
        {
            string query = String.Format("select malhp from phancong where magv = '{0}'", getInfoAccount.username.TrimEnd());
            getIdClass = tchFunc.getData(query, getIdClass);
            cbbIdClass.DataSource = getIdClass;
            cbbIdClass.ValueMember = "malhp";

            string query1 = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and danhsachlhp.malhp = '{0}'", cbbIdClass.SelectedValue.ToString().TrimEnd());
            listStdClass = tchFunc.getData(query1, listStdClass);

            dgvUpdateScore.DataSource = listStdClass;
            dgvUpdateScore.Columns[0].HeaderText = "Mã sinh viên";
            dgvUpdateScore.Columns[1].HeaderText = "Họ tên sinh viên";
            dgvUpdateScore.Columns[2].HeaderText = "Mã môn học";
            dgvUpdateScore.Columns[3].HeaderText = "Tên môn học";
            dgvUpdateScore.Columns[4].HeaderText = "Điểm quá trình";
            dgvUpdateScore.Columns[5].HeaderText = "Điểm thi";
        }

        private void cbbIdClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClass = cbbIdClass.Text;
            updateTableShow(idClass);
        }

        private void updateTableShow(string idC)
        {
            listStdClass = tchFunc.updateDatatable(idC, listStdClass);
            dgvUpdateScore.DataSource = listStdClass;
        }

        private void dgvUpdateScore_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdStd.Text = dgvUpdateScore.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                tbNameStudent.Text = dgvUpdateScore.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                idSub = dgvUpdateScore.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                tbNameSubject.Text = dgvUpdateScore.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                if (dgvUpdateScore.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == null)
                {
                    tbScore1.Text = "";
                }
                else tbScore1.Text = dgvUpdateScore.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                if(dgvUpdateScore.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == null)
                {
                    tbScore2.Text = "";
                }
                else tbScore2.Text = dgvUpdateScore.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            }
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            
            // Show thông báo
            if (MessageBox.Show("Bạn muốn cập nhật điểm cho sinh viên này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes
                // Thực hiện hàm cập nhật điểm
                listStdClass = tchFunc.updateData(cbbIdClass.Text.Trim(), idSub, tbIdStd.Text, Convert.ToInt32(tbScore1.Text), Convert.ToInt32(tbScore2.Text), listStdClass);
                refreshInput();
            }
            else
            {
                // Nếu người dùng chọn No
                // Không thực hiện edit
                return;
            }
        }

    }
}
