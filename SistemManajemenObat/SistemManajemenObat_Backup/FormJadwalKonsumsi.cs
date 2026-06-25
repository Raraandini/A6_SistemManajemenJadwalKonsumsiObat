using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormJadwalKonsumsi : Form
    {
        private string connStr =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";
        private int selectedIdJadwal = -1;

        public FormJadwalKonsumsi()
        {
            InitializeComponent();
        }

        private void FormJadwalKonsumsi_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect         = false;
            dataGridView1.ReadOnly            = true;
            dataGridView1.AllowUserToAddRows  = false;
            dataGridView1.RowTemplate.Height  = 28;
            dataGridView1.BackgroundColor     = System.Drawing.Color.White;
            dataGridView1.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(167, 199, 231);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadComboBoxObat();

            cboStatus.Items.Clear();
            cboStatus.Items.Add("Telah diminum");
            cboStatus.Items.Add("Terlewat");
            cboStatus.SelectedIndex = -1;

            LoadData();
        }

        private void LoadComboBoxObat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT id_obat, nama_obat FROM Obat ORDER BY nama_obat", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbNamaObat.DataSource    = dt;
                    cbNamaObat.DisplayMember = "nama_obat";
                    cbNamaObat.ValueMember   = "id_obat";
                    cbNamaObat.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data obat: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT j.id_jadwal, o.nama_obat,
                               j.waktu_minum, j.dosis, j.status_konsumsi
                        FROM JadwalKonsumsi j
                        INNER JOIN Obat o ON j.id_obat = o.id_obat
                        ORDER BY j.waktu_minum ASC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataTable dtDisplay = new DataTable();
                    dtDisplay.Columns.Add("id_jadwal");
                    dtDisplay.Columns.Add("Nama Obat");
                    dtDisplay.Columns.Add("Waktu Konsumsi");
                    dtDisplay.Columns.Add("Dosis");
                    dtDisplay.Columns.Add("Status");

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime wm = Convert.ToDateTime(row["waktu_minum"]);
                        string waktuFormatted = wm.ToString(
                            "dddd, dd MMMM yyyy - HH:mm",
                            new CultureInfo("en-US"));
                        dtDisplay.Rows.Add(
                            row["id_jadwal"],
                            row["nama_obat"],
                            waktuFormatted,
                            row["dosis"],
                            row["status_konsumsi"]
                        );
                    }

                    dataGridView1.DataSource = dtDisplay;
                    dataGridView1.Columns["id_jadwal"].Visible     = false;
                    dataGridView1.Columns["Nama Obat"].Width       = 160;
                    dataGridView1.Columns["Waktu Konsumsi"].Width  = 230;
                    dataGridView1.Columns["Dosis"].Width           = 100;
                    dataGridView1.Columns["Status"].Width          = 140;
                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidasiInput()
        {
            if (cbNamaObat.SelectedIndex == -1 || cbNamaObat.SelectedValue == null)
            {
                MessageBox.Show("Pilih nama obat terlebih dahulu.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }
            if (string.IsNullOrWhiteSpace(txtDosis.Text))
            {
                MessageBox.Show("Dosis tidak boleh kosong. Contoh: 1 Tablet", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }
            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih status konsumsi terlebih dahulu.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }
            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e) { ClearForm(); LoadData(); }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    DateTime waktu = dtpWaktuMinum.Value.Date.Add(dtpJamMinum.Value.TimeOfDay);

                    SqlCommand cmd1 = new SqlCommand(@"
                        INSERT INTO JadwalKonsumsi (id_obat, waktu_minum, dosis, status_konsumsi)
                        VALUES (@idObat, @waktu, @dosis, @status)", conn);
                    cmd1.Parameters.AddWithValue("@idObat", cbNamaObat.SelectedValue);
                    cmd1.Parameters.AddWithValue("@waktu",  waktu);
                    cmd1.Parameters.AddWithValue("@dosis",  txtDosis.Text.Trim());
                    cmd1.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString());
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand(@"
                        INSERT INTO RiwayatKonsumsi (id_obat, waktu_konsumsi, status_konsumsi)
                        VALUES (@idObat, @waktu, @status)", conn);
                    cmd2.Parameters.AddWithValue("@idObat", cbNamaObat.SelectedValue);
                    cmd2.Parameters.AddWithValue("@waktu",  waktu);
                    cmd2.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString());
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Jadwal konsumsi berhasil ditambahkan.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat Insert: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIdJadwal == -1)
            {
                MessageBox.Show("Pilih jadwal dari tabel terlebih dahulu sebelum mengupdate.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!ValidasiInput()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    DateTime waktu = dtpWaktuMinum.Value.Date.Add(dtpJamMinum.Value.TimeOfDay);
                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE JadwalKonsumsi
                        SET id_obat=@idObat, waktu_minum=@waktu,
                            dosis=@dosis, status_konsumsi=@status
                        WHERE id_jadwal=@idJadwal", conn);
                    cmd.Parameters.AddWithValue("@idObat",   cbNamaObat.SelectedValue);
                    cmd.Parameters.AddWithValue("@waktu",    waktu);
                    cmd.Parameters.AddWithValue("@dosis",    txtDosis.Text.Trim());
                    cmd.Parameters.AddWithValue("@status",   cboStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@idJadwal", selectedIdJadwal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Jadwal konsumsi berhasil diperbarui.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat Update: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIdJadwal == -1)
            {
                MessageBox.Show("Pilih jadwal dari tabel terlebih dahulu sebelum menghapus.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (MessageBox.Show("Yakin ingin menghapus jadwal ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM JadwalKonsumsi WHERE id_jadwal=@idJadwal", conn);
                    cmd.Parameters.AddWithValue("@idJadwal", selectedIdJadwal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Jadwal konsumsi berhasil dihapus.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat Delete: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["id_jadwal"].Value == null) return;
            selectedIdJadwal = Convert.ToInt32(row.Cells["id_jadwal"].Value);

            string namaObat = row.Cells["Nama Obat"].Value?.ToString();
            if (!string.IsNullOrEmpty(namaObat))
                foreach (DataRowView item in cbNamaObat.Items)
                    if (item["nama_obat"].ToString() == namaObat)
                    { cbNamaObat.SelectedItem = item; break; }

            string waktuStr = row.Cells["Waktu Konsumsi"].Value?.ToString();
            if (!string.IsNullOrEmpty(waktuStr))
            {
                DateTime waktu;
                if (!DateTime.TryParseExact(waktuStr, "dddd, dd MMMM yyyy - HH:mm",
                    new CultureInfo("en-US"), DateTimeStyles.None, out waktu))
                    DateTime.TryParse(waktuStr, out waktu);
                if (waktu != DateTime.MinValue)
                { dtpWaktuMinum.Value = waktu.Date; dtpJamMinum.Value = waktu; }
            }

            txtDosis.Text = row.Cells["Dosis"].Value?.ToString() ?? string.Empty;

            string status = row.Cells["Status"].Value?.ToString();
            if (!string.IsNullOrEmpty(status))
                foreach (var item in cboStatus.Items)
                    if (item.ToString() == status)
                    { cboStatus.SelectedItem = item; break; }
        }

        private void ClearForm()
        {
            selectedIdJadwal         = -1;
            cbNamaObat.SelectedIndex = -1;
            dtpWaktuMinum.Value      = DateTime.Today;
            dtpJamMinum.Value        = DateTime.Now;
            txtDosis.Text            = string.Empty;
            cboStatus.SelectedIndex  = -1;
        }
    }
}
