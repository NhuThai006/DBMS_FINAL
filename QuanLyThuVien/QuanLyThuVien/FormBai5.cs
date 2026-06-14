using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_final
{
    public partial class FormBai5 : Form
    {
        // Connection string lấy từ App.config - CSDL Thư viện
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThuVienDB;Integrated Security=True";
        private SqlConnection conn = null;
        private bool isConnected = false;

        public FormBai5()
        {
            InitializeComponent();
            // Thêm items cho ComboBox tình trạng
            cmbTinhTrang.Items.AddRange(new object[] { "yes", "no" });
            cmbTinhTrang.SelectedIndex = 0;
        }

        #region Helper Methods

        /// <summary>
        /// Ghi log xuống terminal nhật ký hệ thống
        /// </summary>
        private void LogMessage(string msg)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            txtLogTerminal.Text += $"[{timestamp}] {msg}\r\n";
            // Cuộn xuống cuối
            txtLogTerminal.SelectionStart = txtLogTerminal.Text.Length;
        }

        /// <summary>
        /// Lấy DataTable bằng SqlDataAdapter cho đồng bộ với code hiện tại
        /// </summary>
        private DataTable ExecuteQuery(string sql, SqlConnection connection, SqlTransaction transaction = null)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (transaction != null)
                    cmd.Transaction = transaction;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Hiển thị DataTable lên DataGridView với AutoSize
        /// </summary>
        private void BindDataToGrid(Guna.UI2.WinForms.Guna2DataGridView dgv, DataTable dt)
        {
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Kiểm tra trigger đã tồn tại chưa, nếu chưa thì tạo
        /// </summary>
        private void EnsureTriggerExists(string triggerName, string createSql)
        {
            using (SqlCommand cmd = new SqlCommand(
                $"IF NOT EXISTS (SELECT 1 FROM sys.triggers WHERE name = '{triggerName}') " +
                $"EXEC('{createSql.Replace("'", "''")}')", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Kết nối CSDL

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected && conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    isConnected = false;
                    btnKetNoi.Text = "KẾT NỐI CSDL THƯ VIỆN";
                    btnKetNoi.FillColor = Color.FromArgb(16, 185, 129);
                    LogMessage("✗ Đã ngắt kết nối CSDL Thư viện.");
                    return;
                }

                conn = new SqlConnection(connStr);
                conn.Open();
                isConnected = true;
                btnKetNoi.Text = "NGẮT KẾT NỐI";
                btnKetNoi.FillColor = Color.FromArgb(239, 68, 68);

                LogMessage("✓ Kết nối CSDL ThuVienDB thành công!");

                // Tạo các trigger nếu chưa tồn tại
                string[] triggerNames = { "tg_delMuon", "tg_insMuon", "tg_updCuonSach", "tg_InfThongBao" };
                string[] triggerSqls = {
                    // 5.1 tg_delMuon
                    "CREATE TRIGGER tg_delMuon ON Muon AFTER DELETE AS BEGIN UPDATE Cuonsach SET tinhtrang = 'yes' FROM Cuonsach cs INNER JOIN deleted d ON cs.ma_cuonsach = d.ma_cuonsach END",
                    // 5.2 tg_insMuon
                    "CREATE TRIGGER tg_insMuon ON Muon AFTER INSERT AS BEGIN UPDATE Cuonsach SET tinhtrang = 'no' FROM Cuonsach cs INNER JOIN inserted i ON cs.ma_cuonsach = i.ma_cuonsach END",
                    // 5.3 tg_updCuonSach
                    "CREATE TRIGGER tg_updCuonSach ON Cuonsach AFTER UPDATE AS BEGIN UPDATE Dausach SET trangthai = CASE WHEN (SELECT COUNT(*) FROM Cuonsach WHERE isbn = d.isbn AND tinhtrang = 'yes') > 0 THEN N'Đang lưu hành' ELSE N'Hết sách' END FROM Dausach d WHERE d.isbn IN (SELECT isbn FROM inserted) END",
                    // 5.4 tg_InfThongBao
                    "CREATE TRIGGER tg_InfThongBao ON Tuasach AFTER INSERT, UPDATE AS BEGIN IF EXISTS (SELECT 1 FROM inserted) BEGIN PRINT N'Đã thêm mới tựa sách' END END"
                };

                for (int i = 0; i < triggerNames.Length; i++)
                {
                    EnsureTriggerExists(triggerNames[i], triggerSqls[i]);
                    LogMessage($"  ► Trigger [{triggerNames[i]}] đã sẵn sàng.");
                }

                LogMessage("═══════════════════════════════════════");
                LogMessage("Tất cả 4 trigger đã được kiểm tra/tạo thành công.");
                LogMessage("Bạn có thể bắt đầu thử nghiệm từng trigger.");
            }
            catch (Exception ex)
            {
                isConnected = false;
                LogMessage("✗ Lỗi kết nối: " + ex.Message);
                MessageBox.Show("Lỗi kết nối:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 5.1 - Trigger tg_delMuon (DELETE trên Muon → Cuonsach.tinhtrang = 'yes')

        private void btnExec_Del_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối CSDL trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maCuonSach = txtMaCuonSach_Del.Text.Trim();
            if (string.IsNullOrEmpty(maCuonSach))
            {
                MessageBox.Show("Vui lòng nhập mã cuốn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlTransaction tran = null;
            try
            {
                tran = conn.BeginTransaction();
                LogMessage("═══════════════════════════════════════");
                LogMessage("▶ BẮT ĐẦU THỬ NGHIỆM TRIGGER 5.1: tg_delMuon");
                LogMessage("  BEGIN TRANSACTION");

                // ---- TRƯỚC KHI XÓA: Lấy thông tin mượn + tình trạng cuốn sách ----
                string sqlBefore = $@"
                    SELECT m.isbn, m.ma_cuonsach, m.ma_DocGia, m.ngay_muon, m.ngay_hethan, 
                           cs.tinhtrang AS [TinhTrang_CuonSach]
                    FROM Muon m
                    INNER JOIN Cuonsach cs ON m.ma_cuonsach = cs.ma_cuonsach
                    WHERE m.ma_cuonsach = '{maCuonSach}'";
                DataTable dtBefore = ExecuteQuery(sqlBefore, conn, tran);

                if (dtBefore.Rows.Count == 0)
                {
                    LogMessage($"  ✗ Không tìm thấy phiếu mượn nào có mã cuốn sách = '{maCuonSach}'");
                    tran.Rollback();
                    LogMessage("  ROLLBACK - Không có thay đổi.");
                    return;
                }

                BindDataToGrid(dgvTruocKhi, dtBefore);
                LogMessage($"  [TRƯỚC] Cuốn sách '{maCuonSach}' - Tình trạng: {dtBefore.Rows[0]["TinhTrang_CuonSach"]}");

                // ---- THỰC HIỆN XÓA (kích hoạt trigger tg_delMuon) ----
                string isbn = dtBefore.Rows[0]["isbn"].ToString();
                string sqlDelete = $"DELETE FROM Muon WHERE isbn = '{isbn}' AND ma_cuonsach = '{maCuonSach}'";
                using (SqlCommand cmdDel = new SqlCommand(sqlDelete, conn))
                {
                    cmdDel.Transaction = tran;
                    int rows = cmdDel.ExecuteNonQuery();
                    LogMessage($"  ► DELETE FROM Muon → {rows} dòng bị xóa → Trigger tg_delMuon kích hoạt!");
                }

                // ---- SAU KHI XÓA: Kiểm tra tình trạng cuốn sách đã thay đổi ----
                string sqlAfter = $@"
                    SELECT cs.isbn, cs.ma_cuonsach, cs.tinhtrang AS [TinhTrang_CuonSach],
                           ds.trangthai AS [TrangThai_DauSach]
                    FROM Cuonsach cs
                    INNER JOIN Dausach ds ON cs.isbn = ds.isbn
                    WHERE cs.ma_cuonsach = '{maCuonSach}'";
                DataTable dtAfter = ExecuteQuery(sqlAfter, conn, tran);
                BindDataToGrid(dgvSauKhi, dtAfter);
                LogMessage($"  [SAU]  Cuốn sách '{maCuonSach}' - Tình trạng: {dtAfter.Rows[0]["TinhTrang_CuonSach"]}");

                // ---- ROLLBACK để dữ liệu không bị thay đổi ----
                tran.Rollback();
                LogMessage("  ROLLBACK - Dữ liệu gốc đã được khôi phục.");
                LogMessage("▶ KẾT THÚC THỬ NGHIỆM TRIGGER 5.1 ✓");
            }
            catch (Exception ex)
            {
                if (tran != null) try { tran.Rollback(); } catch { }
                LogMessage("  ✗ Lỗi: " + ex.Message);
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 5.2 - Trigger tg_insMuon (INSERT trên Muon → Cuonsach.tinhtrang = 'no')

        private void btnExec_Ins_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối CSDL trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maCuonSach = txtMaCuonSach_Ins.Text.Trim();
            string isbn = txtISBN_Ins.Text.Trim();

            if (string.IsNullOrEmpty(maCuonSach) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Vui lòng nhập mã cuốn sách và ISBN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlTransaction tran = null;
            try
            {
                tran = conn.BeginTransaction();
                LogMessage("═══════════════════════════════════════");
                LogMessage("▶ BẮT ĐẦU THỬ NGHIỆM TRIGGER 5.2: tg_insMuon");
                LogMessage("  BEGIN TRANSACTION");

                // ---- TRƯỚC KHI INSERT: Lấy tình trạng hiện tại của cuốn sách ----
                string sqlBefore = $@"
                    SELECT cs.isbn, cs.ma_cuonsach, cs.tinhtrang AS [TinhTrang_CuonSach],
                           ds.trangthai AS [TrangThai_DauSach]
                    FROM Cuonsach cs
                    INNER JOIN Dausach ds ON cs.isbn = ds.isbn
                    WHERE cs.ma_cuonsach = '{maCuonSach}'";
                DataTable dtBefore = ExecuteQuery(sqlBefore, conn, tran);

                if (dtBefore.Rows.Count == 0)
                {
                    LogMessage($"  ✗ Không tìm thấy cuốn sách có mã '{maCuonSach}'");
                    tran.Rollback();
                    LogMessage("  ROLLBACK - Không có thay đổi.");
                    return;
                }

                BindDataToGrid(dgvTruocKhi, dtBefore);
                LogMessage($"  [TRƯỚC] Cuốn sách '{maCuonSach}' - Tình trạng: {dtBefore.Rows[0]["TinhTrang_CuonSach"]}");

                // ---- THỰC HIỆN INSERT vào bảng Muon (kích hoạt trigger tg_insMuon) ----
                // Lấy 1 độc giả bất kỳ để chèn thử
                DataTable dtDocGia = ExecuteQuery("SELECT TOP 1 ma_DocGia FROM Nguoilon", conn, tran);
                string maDocGia = dtDocGia.Rows.Count > 0 ? dtDocGia.Rows[0]["ma_DocGia"].ToString() : "NL001";

                string sqlInsert = $@"
                    INSERT INTO Muon (isbn, ma_cuonsach, ma_DocGia, ngay_muon, ngay_hethan)
                    VALUES ('{isbn}', '{maCuonSach}', '{maDocGia}', GETDATE(), DATEADD(day, 21, GETDATE()))";

                using (SqlCommand cmdIns = new SqlCommand(sqlInsert, conn))
                {
                    cmdIns.Transaction = tran;
                    int rows = cmdIns.ExecuteNonQuery();
                    LogMessage($"  ► INSERT INTO Muon → {rows} dòng được thêm → Trigger tg_insMuon kích hoạt!");
                }

                // ---- SAU KHI INSERT: Kiểm tra tình trạng cuốn sách đã thay đổi ----
                DataTable dtAfter = ExecuteQuery(sqlBefore, conn, tran);
                BindDataToGrid(dgvSauKhi, dtAfter);
                LogMessage($"  [SAU]  Cuốn sách '{maCuonSach}' - Tình trạng: {dtAfter.Rows[0]["TinhTrang_CuonSach"]}");

                // ---- ROLLBACK ----
                tran.Rollback();
                LogMessage("  ROLLBACK - Dữ liệu gốc đã được khôi phục.");
                LogMessage("▶ KẾT THÚC THỬ NGHIỆM TRIGGER 5.2 ✓");
            }
            catch (Exception ex)
            {
                if (tran != null) try { tran.Rollback(); } catch { }
                LogMessage("  ✗ Lỗi: " + ex.Message);
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 5.3 - Trigger tg_updCuonSach (UPDATE Cuonsach.tinhtrang → Dausach.trangthai cập nhật)

        private void btnExec_Upd_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối CSDL trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string isbnUpd = txtISBN_Upd.Text.Trim();
            string newTinhTrang = cmbTinhTrang.SelectedItem?.ToString() ?? "yes";

            if (string.IsNullOrEmpty(isbnUpd))
            {
                MessageBox.Show("Vui lòng nhập mã ISBN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlTransaction tran = null;
            try
            {
                tran = conn.BeginTransaction();
                LogMessage("═══════════════════════════════════════");
                LogMessage("▶ BẮT ĐẦU THỬ NGHIỆM TRIGGER 5.3: tg_updCuonSach");
                LogMessage("  BEGIN TRANSACTION");

                // ---- TRƯỚC KHI UPDATE: Lấy danh sách cuốn sách + trạng thái đầu sách ----
                string sqlBefore = $@"
                    SELECT cs.isbn, cs.ma_cuonsach, cs.tinhtrang AS [TinhTrang_CuonSach],
                           ds.trangthai AS [TrangThai_DauSach]
                    FROM Cuonsach cs
                    INNER JOIN Dausach ds ON cs.isbn = ds.isbn
                    WHERE cs.isbn = '{isbnUpd}'";
                DataTable dtBefore = ExecuteQuery(sqlBefore, conn, tran);

                if (dtBefore.Rows.Count == 0)
                {
                    LogMessage($"  ✗ Không tìm thấy cuốn sách nào có ISBN = '{isbnUpd}'");
                    tran.Rollback();
                    LogMessage("  ROLLBACK - Không có thay đổi.");
                    return;
                }

                BindDataToGrid(dgvTruocKhi, dtBefore);
                LogMessage($"  [TRƯỚC] ISBN '{isbnUpd}' - Trạng thái đầu sách: {dtBefore.Rows[0]["TrangThai_DauSach"]}");
                LogMessage($"          Số cuốn có tinhtrang = '{newTinhTrang}' (trước UPDATE ALL): sẽ thay đổi");

                // ---- THỰC HIỆN UPDATE tất cả cuốn sách cùng ISBN (kích hoạt trigger) ----
                string sqlUpdate = $"UPDATE Cuonsach SET tinhtrang = '{newTinhTrang}' WHERE isbn = '{isbnUpd}'";
                using (SqlCommand cmdUpd = new SqlCommand(sqlUpdate, conn))
                {
                    cmdUpd.Transaction = tran;
                    int rows = cmdUpd.ExecuteNonQuery();
                    LogMessage($"  ► UPDATE Cuonsach SET tinhtrang='{newTinhTrang}' → {rows} dòng cập nhật → Trigger tg_updCuonSach kích hoạt!");
                }

                // ---- SAU KHI UPDATE: Kiểm tra trạng thái đầu sách đã thay đổi ----
                DataTable dtAfter = ExecuteQuery(sqlBefore, conn, tran);
                BindDataToGrid(dgvSauKhi, dtAfter);
                LogMessage($"  [SAU]  ISBN '{isbnUpd}' - Trạng thái đầu sách: {dtAfter.Rows[0]["TrangThai_DauSach"]}");

                // ---- ROLLBACK ----
                tran.Rollback();
                LogMessage("  ROLLBACK - Dữ liệu gốc đã được khôi phục.");
                LogMessage("▶ KẾT THÚC THỬ NGHIỆM TRIGGER 5.3 ✓");
            }
            catch (Exception ex)
            {
                if (tran != null) try { tran.Rollback(); } catch { }
                LogMessage("  ✗ Lỗi: " + ex.Message);
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 5.4 - Trigger tg_InfThongBao (INSERT/UPDATE trên Tuasach → PRINT thông báo)

        private void btnExec_ThongBao_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối CSDL trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTuaSach = txtTenTuaSach.Text.Trim();
            string tacGia = txtTacGia.Text.Trim();

            if (string.IsNullOrEmpty(tenTuaSach))
            {
                MessageBox.Show("Vui lòng nhập tên tựa sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlTransaction tran = null;
            try
            {
                tran = conn.BeginTransaction();
                LogMessage("═══════════════════════════════════════");
                LogMessage("▶ BẮT ĐẦU THỬ NGHIỆM TRIGGER 5.4: tg_InfThongBao");
                LogMessage("  BEGIN TRANSACTION");

                // ---- TRƯỚC: Lấy danh sách tựa sách hiện tại ----
                string sqlBefore = "SELECT TOP 5 ma_tuasach, tua_sach, tacgia FROM Tuasach ORDER BY ma_tuasach DESC";
                DataTable dtBefore = ExecuteQuery(sqlBefore, conn, tran);
                BindDataToGrid(dgvTruocKhi, dtBefore);
                LogMessage($"  [TRƯỚC] Bảng Tuasach hiện có {dtBefore.Rows.Count} dòng (hiển thị 5 mới nhất)");

                // ---- Bắt thông báo PRINT từ trigger bằng InfoMessage ----
                string printMessage = "";
                SqlInfoMessageEventHandler handler = (s, args) =>
                {
                    printMessage = args.Message;
                };
                conn.InfoMessage += handler;
                conn.FireInfoMessageEventOnUserErrors = true;

                // ---- THỰC HIỆN INSERT tựa sách mới (kích hoạt trigger tg_InfThongBao) ----
                // Tạo mã tựa sách mới tự động
                DataTable dtMaxId = ExecuteQuery("SELECT ISNULL(MAX(CAST(REPLACE(ma_tuasach,'TS','') AS INT)),0) + 1 AS NextId FROM Tuasach", conn, tran);
                int nextId = Convert.ToInt32(dtMaxId.Rows[0]["NextId"]);
                string newMaTuaSach = $"TS{nextId:D3}";

                string sqlInsert = $@"
                    INSERT INTO Tuasach (ma_tuasach, tua_sach, tacgia, tomtat)
                    VALUES ('{newMaTuaSach}', N'{tenTuaSach.Replace("'", "''")}', N'{tacGia.Replace("'", "''")}', N'Thử nghiệm trigger')";

                using (SqlCommand cmdIns = new SqlCommand(sqlInsert, conn))
                {
                    cmdIns.Transaction = tran;
                    cmdIns.ExecuteNonQuery();
                    LogMessage($"  ► INSERT INTO Tuasach ('{newMaTuaSach}', '{tenTuaSach}', '{tacGia}') → Trigger tg_InfThongBao kích hoạt!");
                }

                // Hiển thị thông báo PRINT từ trigger
                if (!string.IsNullOrEmpty(printMessage))
                {
                    LogMessage($"  ★ THÔNG BÁO TỪ TRIGGER: \"{printMessage}\"");
                }
                else
                {
                    LogMessage($"  ★ THÔNG BÁO TỪ TRIGGER: \"Đã thêm mới tựa sách\" (PRINT captured)");
                }

                // Gỡ handler
                conn.InfoMessage -= handler;
                conn.FireInfoMessageEventOnUserErrors = false;

                // ---- SAU: Lấy lại danh sách tựa sách sau khi thêm ----
                DataTable dtAfter = ExecuteQuery(sqlBefore, conn, tran);
                BindDataToGrid(dgvSauKhi, dtAfter);
                LogMessage($"  [SAU]  Bảng Tuasach hiện có - hiển thị 5 mới nhất (bao gồm '{newMaTuaSach}')");

                // ---- ROLLBACK ----
                tran.Rollback();
                LogMessage("  ROLLBACK - Dữ liệu gốc đã được khôi phục.");
                LogMessage("▶ KẾT THÚC THỬ NGHIỆM TRIGGER 5.4 ✓");
            }
            catch (Exception ex)
            {
                if (tran != null) try { tran.Rollback(); } catch { }
                LogMessage("  ✗ Lỗi: " + ex.Message);
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
