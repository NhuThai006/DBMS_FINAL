namespace DBMS_final
{
    partial class FormBai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKetNoi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExec_Del = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaCuonSach_Del = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExec_Ins = new Guna.UI2.WinForms.Guna2Button();
            this.txtISBN_Ins = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCuonSach_Ins = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtISBN_Upd = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExec_Upd = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExec_ThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.txtTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTuaSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.txtLogTerminal = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlResultContainer = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTruocKhi = new System.Windows.Forms.Label();
            this.dgvTruocKhi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblSauKhi = new System.Windows.Forms.Label();
            this.dgvSauKhi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnlResultContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruocKhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSauKhi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Animated = true;
            this.btnKetNoi.BorderRadius = 6;
            this.btnKetNoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKetNoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKetNoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKetNoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKetNoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnKetNoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnKetNoi.ForeColor = System.Drawing.Color.White;
            this.btnKetNoi.Location = new System.Drawing.Point(20, 15);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(264, 42);
            this.btnKetNoi.TabIndex = 0;
            this.btnKetNoi.Text = "KẾT NỐI CSDL THƯ VIỆN";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(210, 45);
            this.guna2TabControl1.Location = new System.Drawing.Point(20, 75);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(965, 195);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(210, 45);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnExec_Del);
            this.tabPage1.Controls.Add(this.txtMaCuonSach_Del);
            this.tabPage1.Location = new System.Drawing.Point(214, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage1.Size = new System.Drawing.Size(747, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TRIGGER 5.1 (DEL)";
            // 
            // btnExec_Del
            // 
            this.btnExec_Del.Animated = true;
            this.btnExec_Del.BorderRadius = 6;
            this.btnExec_Del.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnExec_Del.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExec_Del.ForeColor = System.Drawing.Color.White;
            this.btnExec_Del.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnExec_Del.Location = new System.Drawing.Point(20, 76);
            this.btnExec_Del.Name = "btnExec_Del";
            this.btnExec_Del.Size = new System.Drawing.Size(415, 44);
            this.btnExec_Del.TabIndex = 1;
            this.btnExec_Del.Text = "CHẠY GIẢ LẬP XÓA MƯỢN SÁCH";
            this.btnExec_Del.Click += new System.EventHandler(this.btnExec_Del_Click);
            // 
            // txtMaCuonSach_Del
            // 
            this.txtMaCuonSach_Del.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtMaCuonSach_Del.BorderRadius = 6;
            this.txtMaCuonSach_Del.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCuonSach_Del.DefaultText = "";
            this.txtMaCuonSach_Del.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtMaCuonSach_Del.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaCuonSach_Del.ForeColor = System.Drawing.Color.Black;
            this.txtMaCuonSach_Del.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtMaCuonSach_Del.Location = new System.Drawing.Point(20, 19);
            this.txtMaCuonSach_Del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCuonSach_Del.Name = "txtMaCuonSach_Del";
            this.txtMaCuonSach_Del.PlaceholderText = "Nhập mã cuốn sách muốn xóa mượn (VD: CS002)...";
            this.txtMaCuonSach_Del.SelectedText = "";
            this.txtMaCuonSach_Del.Size = new System.Drawing.Size(415, 42);
            this.txtMaCuonSach_Del.TabIndex = 0;
            this.txtMaCuonSach_Del.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnExec_Ins);
            this.tabPage2.Controls.Add(this.txtISBN_Ins);
            this.tabPage2.Controls.Add(this.txtMaCuonSach_Ins);
            this.tabPage2.Location = new System.Drawing.Point(214, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage2.Size = new System.Drawing.Size(747, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRIGGER 5.2 (INS)";
            // 
            // btnExec_Ins
            // 
            this.btnExec_Ins.Animated = true;
            this.btnExec_Ins.BorderRadius = 6;
            this.btnExec_Ins.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnExec_Ins.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExec_Ins.ForeColor = System.Drawing.Color.White;
            this.btnExec_Ins.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnExec_Ins.Location = new System.Drawing.Point(20, 76);
            this.btnExec_Ins.Name = "btnExec_Ins";
            this.btnExec_Ins.Size = new System.Drawing.Size(415, 44);
            this.btnExec_Ins.TabIndex = 2;
            this.btnExec_Ins.Text = "CHẠY GIẢ LẬP THÊM PHIẾU MƯỢN";
            this.btnExec_Ins.Click += new System.EventHandler(this.btnExec_Ins_Click);
            // 
            // txtISBN_Ins
            // 
            this.txtISBN_Ins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtISBN_Ins.BorderRadius = 6;
            this.txtISBN_Ins.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN_Ins.DefaultText = "";
            this.txtISBN_Ins.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtISBN_Ins.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISBN_Ins.ForeColor = System.Drawing.Color.Black;
            this.txtISBN_Ins.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtISBN_Ins.Location = new System.Drawing.Point(455, 20);
            this.txtISBN_Ins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtISBN_Ins.Name = "txtISBN_Ins";
            this.txtISBN_Ins.PlaceholderText = "ISBN (VD: ISBN001)...";
            this.txtISBN_Ins.SelectedText = "";
            this.txtISBN_Ins.Size = new System.Drawing.Size(200, 42);
            this.txtISBN_Ins.TabIndex = 1;
            this.txtISBN_Ins.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtMaCuonSach_Ins
            // 
            this.txtMaCuonSach_Ins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtMaCuonSach_Ins.BorderRadius = 6;
            this.txtMaCuonSach_Ins.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCuonSach_Ins.DefaultText = "";
            this.txtMaCuonSach_Ins.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtMaCuonSach_Ins.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaCuonSach_Ins.ForeColor = System.Drawing.Color.Black;
            this.txtMaCuonSach_Ins.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtMaCuonSach_Ins.Location = new System.Drawing.Point(20, 20);
            this.txtMaCuonSach_Ins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCuonSach_Ins.Name = "txtMaCuonSach_Ins";
            this.txtMaCuonSach_Ins.PlaceholderText = "Mã cuốn sách (VD: CS003)...";
            this.txtMaCuonSach_Ins.SelectedText = "";
            this.txtMaCuonSach_Ins.Size = new System.Drawing.Size(415, 42);
            this.txtMaCuonSach_Ins.TabIndex = 0;
            this.txtMaCuonSach_Ins.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.cmbTinhTrang);
            this.tabPage3.Controls.Add(this.txtISBN_Upd);
            this.tabPage3.Controls.Add(this.btnExec_Upd);
            this.tabPage3.Location = new System.Drawing.Point(214, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(747, 187);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TRIGGER 5.3 (UPD)";
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cmbTinhTrang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmbTinhTrang.BorderRadius = 6;
            this.cmbTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cmbTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cmbTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.cmbTinhTrang.ItemHeight = 36;
            this.cmbTinhTrang.Location = new System.Drawing.Point(455, 20);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(179, 42);
            this.cmbTinhTrang.TabIndex = 2;
            // 
            // txtISBN_Upd
            // 
            this.txtISBN_Upd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtISBN_Upd.BorderRadius = 6;
            this.txtISBN_Upd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN_Upd.DefaultText = "";
            this.txtISBN_Upd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtISBN_Upd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISBN_Upd.ForeColor = System.Drawing.Color.Black;
            this.txtISBN_Upd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtISBN_Upd.Location = new System.Drawing.Point(20, 20);
            this.txtISBN_Upd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtISBN_Upd.Name = "txtISBN_Upd";
            this.txtISBN_Upd.PlaceholderText = "Nhập mã ISBN (VD: ISBN001)...";
            this.txtISBN_Upd.SelectedText = "";
            this.txtISBN_Upd.Size = new System.Drawing.Size(415, 42);
            this.txtISBN_Upd.TabIndex = 1;
            this.txtISBN_Upd.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnExec_Upd
            // 
            this.btnExec_Upd.Animated = true;
            this.btnExec_Upd.BorderRadius = 6;
            this.btnExec_Upd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnExec_Upd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExec_Upd.ForeColor = System.Drawing.Color.White;
            this.btnExec_Upd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnExec_Upd.Location = new System.Drawing.Point(20, 76);
            this.btnExec_Upd.Name = "btnExec_Upd";
            this.btnExec_Upd.Size = new System.Drawing.Size(415, 44);
            this.btnExec_Upd.TabIndex = 0;
            this.btnExec_Upd.Text = "CHẠY GIẢ LẬP SỬA TÌNH TRẠNG SÁCH";
            this.btnExec_Upd.Click += new System.EventHandler(this.btnExec_Upd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnExec_ThongBao);
            this.tabPage4.Controls.Add(this.txtTacGia);
            this.tabPage4.Controls.Add(this.txtTenTuaSach);
            this.tabPage4.Location = new System.Drawing.Point(214, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(747, 187);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TRIGGER 5.4 (INFO)";
            // 
            // btnExec_ThongBao
            // 
            this.btnExec_ThongBao.Animated = true;
            this.btnExec_ThongBao.BorderRadius = 6;
            this.btnExec_ThongBao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnExec_ThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExec_ThongBao.ForeColor = System.Drawing.Color.White;
            this.btnExec_ThongBao.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnExec_ThongBao.Location = new System.Drawing.Point(160, 76);
            this.btnExec_ThongBao.Name = "btnExec_ThongBao";
            this.btnExec_ThongBao.Size = new System.Drawing.Size(415, 44);
            this.btnExec_ThongBao.TabIndex = 2;
            this.btnExec_ThongBao.Text = "CHẠY THAO TÁC BẢNG TỰA SÁCH";
            this.btnExec_ThongBao.Click += new System.EventHandler(this.btnExec_ThongBao_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtTacGia.BorderRadius = 6;
            this.txtTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTacGia.DefaultText = "";
            this.txtTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtTacGia.Location = new System.Drawing.Point(405, 20);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PlaceholderText = "Tên tác giả...";
            this.txtTacGia.SelectedText = "";
            this.txtTacGia.Size = new System.Drawing.Size(200, 42);
            this.txtTacGia.TabIndex = 1;
            this.txtTacGia.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtTenTuaSach
            // 
            this.txtTenTuaSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtTenTuaSach.BorderRadius = 6;
            this.txtTenTuaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTuaSach.DefaultText = "";
            this.txtTenTuaSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtTenTuaSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTuaSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenTuaSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtTenTuaSach.Location = new System.Drawing.Point(128, 20);
            this.txtTenTuaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTuaSach.Name = "txtTenTuaSach";
            this.txtTenTuaSach.PlaceholderText = "Tên tựa sách mới...";
            this.txtTenTuaSach.SelectedText = "";
            this.txtTenTuaSach.Size = new System.Drawing.Size(200, 42);
            this.txtTenTuaSach.TabIndex = 0;
            this.txtTenTuaSach.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // pnlResultContainer
            // 
            this.pnlResultContainer.Controls.Add(this.splitContainer1);
            this.pnlResultContainer.Location = new System.Drawing.Point(20, 278);
            this.pnlResultContainer.Name = "pnlResultContainer";
            this.pnlResultContainer.Size = new System.Drawing.Size(965, 160);
            this.pnlResultContainer.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTruocKhi);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTruocKhi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSauKhi);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSauKhi);
            this.splitContainer1.Size = new System.Drawing.Size(965, 160);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTruocKhi
            // 
            this.lblTruocKhi.AutoSize = true;
            this.lblTruocKhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTruocKhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblTruocKhi.Location = new System.Drawing.Point(3, 5);
            this.lblTruocKhi.Name = "lblTruocKhi";
            this.lblTruocKhi.Size = new System.Drawing.Size(187, 21);
            this.lblTruocKhi.TabIndex = 1;
            this.lblTruocKhi.Text = "📋 TRƯỚC KHI TRIGGER:";
            // 
            // dgvTruocKhi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTruocKhi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTruocKhi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTruocKhi.ColumnHeadersHeight = 30;
            this.dgvTruocKhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTruocKhi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTruocKhi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvTruocKhi.Location = new System.Drawing.Point(3, 30);
            this.dgvTruocKhi.Name = "dgvTruocKhi";
            this.dgvTruocKhi.ReadOnly = true;
            this.dgvTruocKhi.RowHeadersVisible = false;
            this.dgvTruocKhi.RowHeadersWidth = 51;
            this.dgvTruocKhi.RowTemplate.Height = 26;
            this.dgvTruocKhi.Size = new System.Drawing.Size(472, 127);
            this.dgvTruocKhi.TabIndex = 0;
            this.dgvTruocKhi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTruocKhi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvTruocKhi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.dgvTruocKhi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvTruocKhi.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvTruocKhi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvTruocKhi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvTruocKhi.ThemeStyle.RowsStyle.Height = 26;
            this.dgvTruocKhi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.dgvTruocKhi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            // 
            // lblSauKhi
            // 
            this.lblSauKhi.AutoSize = true;
            this.lblSauKhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSauKhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblSauKhi.Location = new System.Drawing.Point(3, 5);
            this.lblSauKhi.Name = "lblSauKhi";
            this.lblSauKhi.Size = new System.Drawing.Size(174, 21);
            this.lblSauKhi.TabIndex = 1;
            this.lblSauKhi.Text = "✅ SAU KHI TRIGGER:";
            // 
            // dgvSauKhi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSauKhi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSauKhi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSauKhi.ColumnHeadersHeight = 30;
            this.dgvSauKhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSauKhi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSauKhi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvSauKhi.Location = new System.Drawing.Point(3, 30);
            this.dgvSauKhi.Name = "dgvSauKhi";
            this.dgvSauKhi.ReadOnly = true;
            this.dgvSauKhi.RowHeadersVisible = false;
            this.dgvSauKhi.RowHeadersWidth = 51;
            this.dgvSauKhi.RowTemplate.Height = 26;
            this.dgvSauKhi.Size = new System.Drawing.Size(477, 127);
            this.dgvSauKhi.TabIndex = 0;
            this.dgvSauKhi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSauKhi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvSauKhi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.dgvSauKhi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvSauKhi.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSauKhi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvSauKhi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvSauKhi.ThemeStyle.RowsStyle.Height = 26;
            this.dgvSauKhi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.dgvSauKhi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLogTitle.Location = new System.Drawing.Point(16, 443);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(346, 23);
            this.lblLogTitle.TabIndex = 2;
            this.lblLogTitle.Text = "NHẬT KÝ HỆ THỐNG (TRANSACTION LOG):";
            // 
            // txtLogTerminal
            // 
            this.txtLogTerminal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtLogTerminal.BorderRadius = 8;
            this.txtLogTerminal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogTerminal.DefaultText = "";
            this.txtLogTerminal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtLogTerminal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtLogTerminal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.txtLogTerminal.Enabled = false;
            this.txtLogTerminal.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtLogTerminal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.txtLogTerminal.Location = new System.Drawing.Point(20, 468);
            this.txtLogTerminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogTerminal.Multiline = true;
            this.txtLogTerminal.Name = "txtLogTerminal";
            this.txtLogTerminal.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtLogTerminal.PlaceholderText = "Hệ thống đang sẵn sàng thử nghiệm...";
            this.txtLogTerminal.ReadOnly = true;
            this.txtLogTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogTerminal.SelectedText = "";
            this.txtLogTerminal.Size = new System.Drawing.Size(965, 142);
            this.txtLogTerminal.TabIndex = 3;
            this.txtLogTerminal.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // FormBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 616);
            this.Controls.Add(this.pnlResultContainer);
            this.Controls.Add(this.txtLogTerminal);
            this.Controls.Add(this.lblLogTitle);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.btnKetNoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBai5";
            this.Text = "FormBai5";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.pnlResultContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruocKhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSauKhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnKetNoi;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnExec_Del;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCuonSach_Del;
        private Guna.UI2.WinForms.Guna2Button btnExec_Ins;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN_Ins;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCuonSach_Ins;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button btnExec_Upd;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTinhTrang;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN_Upd;
        private Guna.UI2.WinForms.Guna2Button btnExec_ThongBao;
        private Guna.UI2.WinForms.Guna2TextBox txtTacGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTuaSach;
        private System.Windows.Forms.Label lblLogTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtLogTerminal;
        private System.Windows.Forms.Panel pnlResultContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTruocKhi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTruocKhi;
        private System.Windows.Forms.Label lblSauKhi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSauKhi;
    }
}