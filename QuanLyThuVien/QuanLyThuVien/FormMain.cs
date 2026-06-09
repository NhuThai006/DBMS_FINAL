using System;
using System.Drawing;
using System.Windows.Forms;

namespace DBMS_final
{
    public partial class FormMain : Form
    {
        // Biến lưu trữ Form con đang hiển thị hiện tại để quản lý bộ nhớ
        private Form currentSubForm = null;

        public FormMain()
        {
            InitializeComponent();
            RegisterMenuEvents();
        }

        /// <summary>
        /// Sự kiện kích hoạt khi FormMain vừa nạp xong
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Tự động kích hoạt chọn Bài 1 ngay khi mở ứng dụng
            btnBai1.Checked = true;
            OpenSubForm(new FormBai1(), "BÀI 1: STORED PROCEDURE TÍNH TỔNG 2 SỐ NGUYÊN");
        }

        /// <summary>
        /// Đăng ký sự kiện Click cho hệ thống nút bấm Menu điều hướng
        /// </summary>
        private void RegisterMenuEvents()
        {
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            this.btnBai5.Click += new System.EventHandler(this.btnBai5_Click);
            this.btnBai6.Click += new System.EventHandler(this.btnBai6_Click);
        }

        /// <summary>
        /// Hàm chuyên dụng xử lý nhúng động Form con vào vùng pnlContent
        /// </summary>
        /// <param name="subForm">Đối tượng Form bài tập tương ứng</param>
        /// <param name="titleText">Tiêu đề hiển thị trên thanh Navbar</param>
        private void OpenSubForm(Form subForm, string titleText)
        {
            // 1. Nếu có Form con đang chạy trước đó, đóng và giải phóng bộ nhớ
            if (currentSubForm != null)
            {
                currentSubForm.Close();
                currentSubForm.Dispose();
            }

            // 2. Thiết lập Form con mới làm chủ thể hiện tại
            currentSubForm = subForm;

            // 3. Cấu hình thuộc tính để biến Form thành một Control phẳng nhúng
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            // 4. Cập nhật nhãn tiêu đề thanh Header
            lblTitle.Text = titleText;

            // 5. Dọn sạch vùng chứa cũ và nạp Form mới vào hiển thị
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(subForm);
            pnlContent.Tag = subForm;

            subForm.Show();
        }

        #region Các sự kiện Click điều hướng Menu bài tập

        private void btnBai1_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai1(), "BÀI 1: STORED PROCEDURE TÍNH TỔNG 2 SỐ NGUYÊN");
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai2(), "BÀI 2: TRA CỨU SÁCH CHƯA MƯỢN QUA MÃ ISBN");
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai3(), "BÀI 3: HÀM FUNCTION TÍNH TUỔI ĐỘC GIẢ");
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai4(), "BÀI 4: QUẢN LÝ CÁC STORED PROCEDURES THƯ VIỆN (A - E)");
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai5(), "BÀI 5: THỬ NGHIỆM TRANSACTION LOG TRIGGERS THƯ VIỆN");
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            OpenSubForm(new FormBai6(), "BÀI 6: HÀM FUNCTIONS TRÊN CSDL QUẢN LÝ ĐỀ ÁN");
        }

        #endregion
    }
}