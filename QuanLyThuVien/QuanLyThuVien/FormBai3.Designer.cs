namespace DBMS_final
{
    partial class FormBai3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNamSinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTinhTuoi = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.txtKetQuaTuoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTitle.Location = new System.Drawing.Point(45, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhập năm sinh của độc giả";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNamSinh.BorderRadius = 8;
            this.txtNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamSinh.DefaultText = "";
            this.txtNamSinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamSinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamSinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamSinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamSinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtNamSinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNamSinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtNamSinh.Location = new System.Drawing.Point(180, 88);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtNamSinh.PlaceholderText = "Ví dụ: 2005";
            this.txtNamSinh.SelectedText = "";
            this.txtNamSinh.Size = new System.Drawing.Size(615, 48);
            this.txtNamSinh.TabIndex = 1;
            this.txtNamSinh.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnTinhTuoi
            // 
            this.btnTinhTuoi.Animated = true;
            this.btnTinhTuoi.BorderRadius = 8;
            this.btnTinhTuoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTuoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTuoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTuoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhTuoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnTinhTuoi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTinhTuoi.ForeColor = System.Drawing.Color.White;
            this.btnTinhTuoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnTinhTuoi.Location = new System.Drawing.Point(180, 165);
            this.btnTinhTuoi.Name = "btnTinhTuoi";
            this.btnTinhTuoi.Size = new System.Drawing.Size(615, 48);
            this.btnTinhTuoi.TabIndex = 2;
            this.btnTinhTuoi.Text = "⚡ TÍNH TUỔI NGAY";
            this.btnTinhTuoi.Click += new System.EventHandler(this.btnTinhTuoi_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblResultTitle.Location = new System.Drawing.Point(45, 260);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(214, 25);
            this.lblResultTitle.TabIndex = 3;
            this.lblResultTitle.Text = "Số tuổi độc giả hiện tại:";
            // 
            // txtKetQuaTuoi
            // 
            this.txtKetQuaTuoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtKetQuaTuoi.BorderRadius = 8;
            this.txtKetQuaTuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKetQuaTuoi.DefaultText = "";
            this.txtKetQuaTuoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtKetQuaTuoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtKetQuaTuoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtKetQuaTuoi.Enabled = false;
            this.txtKetQuaTuoi.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtKetQuaTuoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtKetQuaTuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtKetQuaTuoi.Location = new System.Drawing.Point(180, 317);
            this.txtKetQuaTuoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtKetQuaTuoi.Name = "txtKetQuaTuoi";
            this.txtKetQuaTuoi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtKetQuaTuoi.PlaceholderText = "Chưa có dữ liệu tính toán...";
            this.txtKetQuaTuoi.SelectedText = "";
            this.txtKetQuaTuoi.Size = new System.Drawing.Size(615, 60);
            this.txtKetQuaTuoi.TabIndex = 4;
            this.txtKetQuaTuoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKetQuaTuoi.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 616);
            this.Controls.Add(this.txtKetQuaTuoi);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.btnTinhTuoi);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBai3";
            this.Text = "FormBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtNamSinh;
        private Guna.UI2.WinForms.Guna2Button btnTinhTuoi;
        private System.Windows.Forms.Label lblResultTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtKetQuaTuoi; // Đã đổi tên chuẩn đối tượng đồng bộ file .cs
    }
}