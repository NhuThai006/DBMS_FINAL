using QuanLyThuVien;
using QuanLyThuVien.ThuVienDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_final
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter handle = new QueriesTableAdapter();
            var kq = handle.sp_TinhTongHaiSo(int.Parse(txtSoA.Text), int.Parse(txtSoB.Text));
            txtKetQua.Text = kq.ToString();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
        }
    }
}
