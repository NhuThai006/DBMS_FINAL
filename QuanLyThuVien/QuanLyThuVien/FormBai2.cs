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
            dgvSach.AutoGenerateColumns = false;
            dgvSach.DataSource = handle.GetData(txtISBN.Text);
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
