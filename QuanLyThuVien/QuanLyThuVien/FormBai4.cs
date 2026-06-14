using QuanLyThuVien.ThuVienDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_final
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }

        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TA_ThongTinDG handle = new TA_ThongTinDG();
                var data = handle.GetData(txtMaDocGia.Text.Trim());
                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng, vui lòng nhập đúng quy định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dgv_ThongTinDG.DataSource = null;
                }
                else
                {
                    Dgv_ThongTinDG.AutoGenerateColumns = false;
                    Dgv_ThongTinDG.DataSource = data;
                    Dgv_ThongTinDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            TA_TTDauSach handle = new TA_TTDauSach();
            var data = handle.GetData(txtISBN.Text);
            dgvThongTinSach.AutoGenerateColumns = false;
            dgvThongTinSach.DataSource = data;
            dgvThongTinSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hiển thị số lượng sách vào Stats Card
            if (data != null && data.Rows.Count > 0 && !data.Rows[0].IsNull("SoLuong"))
            {
                lblB_CountNum.Text = data.Rows[0]["SoLuong"].ToString();
            }
            else
            {
                lblB_CountNum.Text = "0";
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {

        }

        private void btnLietKeDangMuon_Click(object sender, EventArgs e)
        {
            sp_ThongtinNguoilonDangmuonTableAdapter handle = new sp_ThongtinNguoilonDangmuonTableAdapter();
            dgvDangMuon.AutoGenerateColumns = false;
            dgvDangMuon.DataSource = handle.GetData();
            dgvDangMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLietKeCapMuon_Click(object sender, EventArgs e)
        {
            try
            { 
                TA_NLBaoLanh handle = new TA_NLBaoLanh();
                var data = handle.GetData();

                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Không có người lớn nào đang có trẻ em bảo lãnh cùng mượn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCapMuon.DataSource = null;
                }
                else
                {
                    dgvCapMuon.AutoGenerateColumns = false;
                    dgvCapMuon.DataSource = data;
                    dgvCapMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_ThongTinDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLietKeQuahan_Click(object sender, EventArgs e)
        {
            TA_NLQuaHan handle = new TA_NLQuaHan();
            dgvQuaHan.AutoGenerateColumns = false;
            dgvQuaHan.DataSource = handle.GetData();
            dgvQuaHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
