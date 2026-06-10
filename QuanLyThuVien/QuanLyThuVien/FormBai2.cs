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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            sp_ThongTinDauSachTableAdapter handle = new sp_ThongTinDauSachTableAdapter();
            dgvSach.DataSource = handle.GetData(txtISBN.Text);

            dgvSach.Columns["isbn"].HeaderText = "Mã ISBN";
            dgvSach.Columns["tua_sach"].HeaderText = "Tên tựa sách";
            dgvSach.Columns["tacgia"].HeaderText = "Tên tác giả";
            dgvSach.Columns["ngon_ngu"].HeaderText = "Ngôn ngữ";
            dgvSach.Columns["SoLuong"].HeaderText = "Số lượng";

            //Giãn đều
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Cách giữa
            dgvSach.Columns["isbn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSach.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            dgvSach.DataSource = null;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
