using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace SistemManajemenObat
{
    public partial class FormObat : Form
    {
        private int selectedIdObat = -1;

        private BindingSource bsObat = new BindingSource();

        private DataTable dtImportedExcel = null;

        public FormObat()
        {
            InitializeComponent();
        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            txtIdObat.ReadOnly = true;
            txtIdUser.ReadOnly = true;
            txtIdUser.Text = Session.IdUser.ToString();
            bindingNavigator1.BindingSource = bsObat;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(167, 199, 231);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            LoadData();
            txtSearch.KeyDown += delegate (object s, KeyEventArgs ev)
            {
                if (ev.KeyCode == Keys.Return)
                {
                    btnSearch.PerformClick();
                }
            };
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM vw_Obat WHERE id_user=@id_user", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();
                        bsObat.DataSource = dataTable;
                        dataGridView1.DataSource = bsObat;
                        if (dataGridView1.Columns.Contains("id_obat"))
                        {
                            dataGridView1.Columns["id_obat"].Visible = false;
                            dataGridView1.Columns["id_user"].Visible = false;
                            dataGridView1.Columns["nama_obat"].HeaderText = "Nama Obat";
                            dataGridView1.Columns["jumlah_stok"].HeaderText = "Jumlah Stok";
                        }
                        dataGridView1.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaObat.Text))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Jumlah Stok tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!int.TryParse(txtJumlahStok.Text, out var result))
            {
                MessageBox.Show("Jumlah Stok harus berupa angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (result < 0)
            {
                MessageBox.Show("Jumlah Stok tidak boleh negatif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Session.IdUser <= 0)
            {
                MessageBox.Show("Sesi login tidak valid. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("sp_InsertObat", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        sqlCommand.Parameters.AddWithValue("@nama_obat", txtNamaObat.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@jumlah_stok", result);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data obat berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat Insert: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdObat.Text) || !int.TryParse(txtIdObat.Text, out var result))
            {
                MessageBox.Show("Pilih data obat dari tabel terlebih dahulu sebelum mengupdate.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamaObat.Text))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Jumlah Stok tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!int.TryParse(txtJumlahStok.Text, out var result2))
            {
                MessageBox.Show("Jumlah Stok harus berupa angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (result2 < 0)
            {
                MessageBox.Show("Jumlah Stok tidak boleh negatif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("sp_UpdateObat", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@id_obat", result);
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        sqlCommand.Parameters.AddWithValue("@nama_obat", txtNamaObat.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@jumlah_stok", result2);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Data obat berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearForm();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdObat.Text) || !int.TryParse(txtIdObat.Text, out var result))
            {
                MessageBox.Show("Pilih data obat dari tabel terlebih dahulu sebelum menghapus.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus obat ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("sp_DeleteObat", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@id_obat", result);
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Data obat berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearForm();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Masukkan nama obat yang ingin dicari.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearch.Focus();
                return;
            }
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("sp_SearchObat", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@keyword", txtSearch.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        bsObat.DataSource = dataTable;
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Obat \"" + txtSearch.Text + "\" tidak ditemukan.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    DataGridViewRow currentRow = dataGridView1.CurrentRow;
                    if (dataGridView1.Columns.Contains("id_obat"))
                    {
                        txtIdObat.Text = currentRow.Cells["id_obat"].Value?.ToString();
                        txtIdUser.Text = currentRow.Cells["id_user"].Value?.ToString();
                        txtNamaObat.Text = currentRow.Cells["nama_obat"].Value?.ToString();
                        txtJumlahStok.Text = currentRow.Cells["jumlah_stok"].Value?.ToString();
                    }
                    else if (dataGridView1.Columns.Contains("Nama Obat"))
                    {
                        txtNamaObat.Text = currentRow.Cells["Nama Obat"].Value?.ToString();
                        txtJumlahStok.Text = currentRow.Cells["Jumlah Stok"].Value?.ToString();
                        txtIdObat.Clear();
                    }
                }
            }
            catch
            {
            }
        }

        private void ClearForm()
        {
            selectedIdObat = -1;
            txtIdObat.Clear();
            txtIdUser.Text = Session.IdUser.ToString();
            txtNamaObat.Clear();
            txtJumlahStok.Clear();
            txtSearch.Clear();
            bsObat.Position = -1;
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    string cmdText = "UPDATE Obat SET nama_obat='HACKED' WHERE nama_obat='" + txtNamaObat.Text + "'";
                    using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                    {
                        MessageBox.Show(sqlCommand.ExecuteNonQuery() + " baris terupdate", "Test Injection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    string cmdText = "IF OBJECT_ID('dbo.Obat_Backup') IS NOT NULL\r\n                    BEGIN\r\n                        DELETE FROM dbo.Obat WHERE id_user = @id_user;\r\n                        INSERT INTO dbo.Obat (id_user, nama_obat, jumlah_stok)\r\n                        SELECT id_user, nama_obat, jumlah_stok \r\n                        FROM dbo.Obat_Backup WHERE id_user = @id_user;\r\n                    END";
                    using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data berhasil direset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            if (Session.IdUser <= 0)
            {
                MessageBox.Show("Silakan login terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                ValidateNames = true
            })
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    using (FileStream fileStream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader self = ExcelReaderFactory.CreateReader(fileStream))
                        {
                            DataSet dataSet = self.AsDataSet(new ExcelDataSetConfiguration
                            {
                                ConfigureDataTable = (IExcelDataReader _) => new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true
                                }
                            });
                            dtImportedExcel = dataSet.Tables[0];
                            dataGridView1.DataSource = null;
                            dataGridView1.Columns.Clear();
                            dataGridView1.DataSource = dtImportedExcel;
                            MessageBox.Show("Data Excel berhasil dibaca! Silakan cek di tabel. \nJika sudah benar, klik 'Import To Database'.", "Preview Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membaca Excel! Pastikan file tidak sedang dibuka di aplikasi lain.\nDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btnImportToDatabase_Click(object sender, EventArgs e)
        {
            if (dtImportedExcel == null || dtImportedExcel.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data Excel yang siap disimpan. Silakan klik 'Import From Excel' terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Session.IdUser <= 0)
            {
                MessageBox.Show("Sesi login tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                using (SqlConnection sqlConnection = DatabaseHelper.GetConnection())
                {
                    sqlConnection.Open();
                    using (SqlTransaction trans = sqlConnection.BeginTransaction())
                    {
                        try
                        {
                            int num = 0;
                            foreach (DataRow row in dtImportedExcel.Rows)
                            {
                                string value = row[0].ToString();
                                int num2 = Convert.ToInt32(row[1]);
                                using (SqlCommand sqlCommand = new SqlCommand("sp_InsertObat", sqlConnection, trans))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.Parameters.AddWithValue("@id_user", Session.IdUser);
                                    sqlCommand.Parameters.AddWithValue("@nama_obat", value);
                                    sqlCommand.Parameters.AddWithValue("@jumlah_stok", num2);
                                    sqlCommand.ExecuteNonQuery();
                                    num++;
                                }
                            }
                            trans.Commit();
                            MessageBox.Show(num + " data obat berhasil disimpan ke Database secara massal!", "Import Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dtImportedExcel = null;
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Terjadi kesalahan saat menyimpan data massal, seluruh perubahan dibatalkan (Rollback).\nDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan ke Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

    }
}
