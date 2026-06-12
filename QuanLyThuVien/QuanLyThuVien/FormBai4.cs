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
            TA_ThongTinDG handle = new TA_ThongTinDG();
            Dgv_ThongTinDG .DataSource = handle.GetData(int.Parse(txtMaDocGia.Text));

            if (Dgv_ThongTinDG.Columns.Contains("ma_DocGia"))
                Dgv_ThongTinDG.Columns["ma_DocGia"].HeaderText = "Mã Độc Giả";

            if (Dgv_ThongTinDG.Columns.Contains("ho"))
                Dgv_ThongTinDG.Columns["ho"].HeaderText = "Họ";

            if (Dgv_ThongTinDG.Columns.Contains("tenlot"))
                Dgv_ThongTinDG.Columns["tenlot"].HeaderText = "Tên Lót";

            if (Dgv_ThongTinDG.Columns.Contains("ten"))
                Dgv_ThongTinDG.Columns["ten"].HeaderText = "Tên";

            if (Dgv_ThongTinDG.Columns.Contains("ngaysinh"))
                Dgv_ThongTinDG.Columns["ngaysinh"].HeaderText = "Ngày Sinh";

            // 2. Chỉnh tiêu đề cho các cột của NGƯỜI LỚN
            if (Dgv_ThongTinDG.Columns.Contains("sonha"))
                Dgv_ThongTinDG.Columns["sonha"].HeaderText = "Số Nhà";

            if (Dgv_ThongTinDG.Columns.Contains("duong"))
                Dgv_ThongTinDG.Columns["duong"].HeaderText = "Đường";

            if (Dgv_ThongTinDG.Columns.Contains("quan"))
                Dgv_ThongTinDG.Columns["quan"].HeaderText = "Quận";

            if (Dgv_ThongTinDG.Columns.Contains("dienthoai"))
                Dgv_ThongTinDG.Columns["dienthoai"].HeaderText = "Điện Thoại";

            if (Dgv_ThongTinDG.Columns.Contains("han_sd"))
                Dgv_ThongTinDG.Columns["han_sd"].HeaderText = "Hạn Sử Dụng";

            // 3. Chỉnh tiêu đề cho các cột của TRẺ EM
            if (Dgv_ThongTinDG.Columns.Contains("ma_DocGia_nguoilon"))
                Dgv_ThongTinDG.Columns["ma_DocGia_nguoilon"].HeaderText = "Mã ĐG Người Lớn";

            // Tự động căn chỉnh độ rộng các cột cho đẹp mắt
            Dgv_ThongTinDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            sp_ThongTinDauSachTableAdapter handle = new sp_ThongTinDauSachTableAdapter();
            dgvThongTinSach.DataSource = handle.GetData(txtISBN.Text);

            dgvThongTinSach.Columns["isbn"].HeaderText = "Mã ISBN";
            dgvThongTinSach.Columns["tua_sach"].HeaderText = "Tên tựa sách";
            dgvThongTinSach.Columns["tacgia"].HeaderText = "Tên tác giả";
            dgvThongTinSach.Columns["ngon_ngu"].HeaderText = "Ngôn ngữ";
            dgvThongTinSach.Columns["SoLuong"].HeaderText = "Số lượng";

            //Giãn đều
            dgvThongTinSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Cách giữa
            dgvThongTinSach.Columns["isbn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongTinSach.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {

        }

        private void btnLietKeDangMuon_Click(object sender, EventArgs e)
        {
            sp_ThongtinNguoilonDangmuonTableAdapter handle = new sp_ThongtinNguoilonDangmuonTableAdapter();
            dgvDangMuon.DataSource = handle.GetData();
            dgvDangMuon.Columns["ma_DocGia"].HeaderText = "Mã Độc Giả";
            dgvDangMuon.Columns["ho"].HeaderText = "Họ";
            dgvDangMuon.Columns["tenlot"].HeaderText = "Tên Lót";
            dgvDangMuon.Columns["ten"].HeaderText = "Tên";
            dgvDangMuon.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDangMuon.Columns["sonha"].HeaderText = "Số Nhà";
            dgvDangMuon.Columns["duong"].HeaderText = "Đường";
            dgvDangMuon.Columns["quan"].HeaderText = "Quận";
            dgvDangMuon.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dgvDangMuon.Columns["han_sd"].HeaderText = "Hạn Sử Dụng";
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
    }
}
