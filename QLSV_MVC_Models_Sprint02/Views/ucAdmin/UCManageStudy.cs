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

namespace ProjectQLSV_N12.Views.ucAdmin
{
    public partial class UCManageStudy : UserControl
    {
        public UCManageStudy()
        {
            InitializeComponent();
        }

        DataTable getIdClass = new DataTable();
        DataTable listScoreUpdating = new DataTable();
        DataTable listScoreUpdated = new DataTable();
        adminFunc admFunc = new adminFunc();
        string idSub, idClass;
        private void refreshInput()
        {
            tbIdStd.Text = tbNameStudent.Text = tbNameSubject.Text = tbScore1.Text = tbScore2.Text = "";
        }


        private void UCManageStudy_Load(object sender, EventArgs e)
        {
            string query = String.Format("select malhp from lophocphan");
            getIdClass = admFunc.getData(query, getIdClass);
            cbbIdClass.DataSource = getIdClass;
            cbbIdClass.ValueMember = "malhp";

            string query1 = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 0 and danhsachlhp.malhp = '{0}'", cbbIdClass.SelectedValue.ToString().TrimEnd());
            listScoreUpdating = admFunc.getData(query1, listScoreUpdating);
            dgvScoreUpdating.DataSource = listScoreUpdating;
            dgvScoreUpdating.Columns[0].HeaderText = "Mã sinh viên";
            dgvScoreUpdating.Columns[1].HeaderText = "Họ tên sinh viên";
            dgvScoreUpdating.Columns[2].HeaderText = "Mã môn học";
            dgvScoreUpdating.Columns[3].HeaderText = "Tên môn học";
            dgvScoreUpdating.Columns[4].HeaderText = "Điểm quá trình";
            dgvScoreUpdating.Columns[5].HeaderText = "Điểm thi";

            string query2 = string.Format("select sinhvien.hotensv, monhoc.tenmh, diem.diemqt, diem.diemthi, (diem.diemqt*0.4 + diem.diemthi*0.6) as N'Điểm' from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 1 and danhsachlhp.malhp = '{0}'", cbbIdClass.SelectedValue.ToString().TrimEnd());
            listScoreUpdated = admFunc.getData(query2, listScoreUpdated);
            dgvScoreUpdated.DataSource = listScoreUpdated;
            dgvScoreUpdated.Columns[0].HeaderText = "Họ tên sinh viên";
            dgvScoreUpdated.Columns[1].HeaderText = "Tên môn học";
            dgvScoreUpdated.Columns[2].HeaderText = "Điểm quá trình";
            dgvScoreUpdated.Columns[3].HeaderText = "Điểm thi";
        }

        private void cbbIdClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClass = cbbIdClass.Text;
            updateTableShow(idClass);
        }

        private void updateTableShow(string idC)
        {
            string query1 = String.Format("select sinhvien.masv, sinhvien.hotensv, monhoc.mamh, monhoc.tenmh, diem.diemqt, diem.diemthi from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 0 and danhsachlhp.malhp = '{0}'", idC);
            listScoreUpdating = admFunc.updateDatatable(query1, listScoreUpdating);
            dgvScoreUpdating.DataSource = listScoreUpdating;

            string query2 = string.Format("select sinhvien.hotensv, monhoc.tenmh, diem.diemqt, diem.diemthi, (diem.diemqt*0.4 + diem.diemthi*0.6) as N'Điểm' from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 1 and danhsachlhp.malhp = '{0}'", idC);
            listScoreUpdated = admFunc.updateDatatable(query2, listScoreUpdated);
            dgvScoreUpdated.DataSource = listScoreUpdated;
        }

        private void dgvScoreUpdating_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdStd.Text = dgvScoreUpdating.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                tbNameStudent.Text = dgvScoreUpdating.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                idSub = dgvScoreUpdating.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                tbNameSubject.Text = dgvScoreUpdating.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                if (dgvScoreUpdating.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == null)
                {
                    tbScore1.Text = "";
                }
                else tbScore1.Text = dgvScoreUpdating.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                if (dgvScoreUpdating.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == null)
                {
                    tbScore2.Text = "";
                }
                else tbScore2.Text = dgvScoreUpdating.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            }
        }

        private void btnAcceptScore_Click(object sender, EventArgs e)
        {
            // Show thông báo
            if (MessageBox.Show("Bạn muốn duyệt điểm cho sinh viên này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes
                // Thực hiện hàm cập nhật điểm
                listScoreUpdating = admFunc.updateData(cbbIdClass.Text.Trim(), idSub, tbIdStd.Text, listScoreUpdating);
                string query2 = string.Format("select sinhvien.hotensv, monhoc.tenmh, diem.diemqt, diem.diemthi, (diem.diemqt*0.4 + diem.diemthi*0.6) as N'Điểm' from sinhvien,danhsachlhp,monhoc,lophocphan,diem where sinhvien.masv = danhsachlhp.masv and danhsachlhp.malhp = lophocphan.malhp and diem.mamh = monhoc.mamh and diem.masv = sinhvien.masv and lophocphan.mamh = monhoc.mamh and diem.duyet = 1 and danhsachlhp.malhp = '{0}'", cbbIdClass.Text.Trim());
                listScoreUpdated = admFunc.updateDatatable(query2, listScoreUpdated);
                dgvScoreUpdated.DataSource = listScoreUpdated;
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
