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
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnTinhTuoi_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter handle = new QueriesTableAdapter();
            var kq = handle.sp_TinhTuoi(int.Parse(txtNamSinh.Text));
            txtKetQuaTuoi.Text = kq.ToString();
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
