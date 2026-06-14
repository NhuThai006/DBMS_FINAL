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

            int maDocGia;
            if (!int.TryParse(txtMaDocGia.Text.Trim(), out maDocGia))
            {
                MessageBox.Show("Mã độc giả phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TA_ThongTinDG handle = new TA_ThongTinDG();
                Dgv_ThongTinDG.AutoGenerateColumns = false;
                Dgv_ThongTinDG.DataSource = handle.GetData(maDocGia);
                Dgv_ThongTinDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            sp_ThongTinDauSachTableAdapter handle = new sp_ThongTinDauSachTableAdapter();
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
                if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maDocGia;
                if (!int.TryParse(txtMaDocGia.Text, out maDocGia))
                {
                    MessageBox.Show("Mã độc giả phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TA_ThongTinDG handle = new TA_ThongTinDG();
                var data = handle.GetData(maDocGia);

                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu hoặc danh sách rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dgv_ThongTinDG.DataSource = null;
                }
                else
                {
                    Dgv_ThongTinDG.DataSource = data;
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
            sp_ThongtinNguoilonQuahanTableAdapter handle = new sp_ThongtinNguoilonQuahanTableAdapter();
            dgvQuaHan.AutoGenerateColumns = false;
            dgvQuaHan.DataSource = handle.GetData();
            dgvQuaHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
