namespace DBMS_final
{
    partial class FormBai1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSoA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoB = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTinhTong = new Guna.UI2.WinForms.Guna2Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTitle.Location = new System.Drawing.Point(45, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhập các số nguyên cần tính";
            // 
            // txtSoA
            // 
            this.txtSoA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtSoA.BorderRadius = 8;
            this.txtSoA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoA.DefaultText = "";
            this.txtSoA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtSoA.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSoA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSoA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtSoA.Location = new System.Drawing.Point(171, 75);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtSoA.PlaceholderText = "Số thứ nhất (A)";
            this.txtSoA.SelectedText = "";
            this.txtSoA.Size = new System.Drawing.Size(290, 48);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtSoB.BorderRadius = 8;
            this.txtSoB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoB.DefaultText = "";
            this.txtSoB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtSoB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSoB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.txtSoB.Location = new System.Drawing.Point(538, 75);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtSoB.PlaceholderText = "Số thứ hai (B)";
            this.txtSoB.SelectedText = "";
            this.txtSoB.Size = new System.Drawing.Size(290, 48);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Animated = true;
            this.btnTinhTong.BorderRadius = 8;
            this.btnTinhTong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnTinhTong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTinhTong.ForeColor = System.Drawing.Color.White;
            this.btnTinhTong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnTinhTong.Location = new System.Drawing.Point(188, 168);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(615, 48);
            this.btnTinhTong.TabIndex = 3;
            this.btnTinhTong.Text = "THỰC THI PHÉP TÍNH";
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblKetQua.Location = new System.Drawing.Point(45, 260);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(148, 25);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả hiển thị";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtKetQua.BorderRadius = 8;
            this.txtKetQua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKetQua.DefaultText = "";
            this.txtKetQua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtKetQua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtKetQua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtKetQua.Enabled = false;
            this.txtKetQua.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtKetQua.Location = new System.Drawing.Point(188, 306);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtKetQua.PlaceholderText = "Bấm thực thi để xem kết quả...";
            this.txtKetQua.SelectedText = "";
            this.txtKetQua.Size = new System.Drawing.Size(615, 60);
            this.txtKetQua.TabIndex = 5;
            this.txtKetQua.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 616);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBai1";
            this.Text = "FormBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSoA;
        private Guna.UI2.WinForms.Guna2TextBox txtSoB;
        private Guna.UI2.WinForms.Guna2Button btnTinhTong;
        private System.Windows.Forms.Label lblKetQua;
        private Guna.UI2.WinForms.Guna2TextBox txtKetQua;
    }
}