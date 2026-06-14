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
            if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập năm sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int namSinh;
            if (!int.TryParse(txtNamSinh.Text.Trim(), out namSinh))
            {
                MessageBox.Show("Năm sinh phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (namSinh > DateTime.Now.Year)
            {
                MessageBox.Show("Năm sinh không được lớn hơn năm hiện tại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QueriesTableAdapter handle = new QueriesTableAdapter();
            var kq = handle.sp_TinhTuoi(namSinh);
            if (kq != null)
            {
                txtKetQuaTuoi.Text = kq.ToString();
            }
            else
            {
                txtKetQuaTuoi.Text = "Lỗi truy xuất CSDL";
            }
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
