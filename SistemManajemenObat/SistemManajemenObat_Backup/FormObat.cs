using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormObat : Form
    {
        private readonly string connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";
        private int selectedIdObat = -1;

        public FormObat()
        {
            InitializeComponent();
        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            txtIdObat.ReadOnly = true;

            dataGridView1.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect         = false;
            dataGridView1.ReadOnly            = true;
            dataGridView1.AllowUserToAddRows  = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height  = 28;
            dataGridView1.BackgroundColor     = System.Drawing.Color.White;
            dataGridView1.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(167, 199, 231);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            btnLoad.Click   -= btnLoad_Click;
            btnLoad.Click   += btnLoad_Click;
            btnInsert.Click -= btnInsert_Click;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click -= btnSearch_Click;
            btnSearch.Click += btnSearch_Click;

            txtSearch.KeyDown += (s, ev) =>
            { if (ev.KeyCode == Keys.Enter) btnSearch.PerformClick(); };

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("id_obat",    "ID Obat");
                    dataGridView1.Columns.Add("id_user",    "ID User");
                    dataGridView1.Columns.Add("nama_obat",  "Nama Obat");
                    dataGridView1.Columns.Add("jumlah_stok","Jumlah Stok");
                    dataGridView1.Columns["id_obat"].Visible = false;
                    dataGridView1.Columns["id_user"].Visible = false;

                    SqlCommand    cmd    = new SqlCommand("SELECT * FROM Obat", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["id_obat"].ToString(),
                            reader["id_user"].ToString(),
                            reader["nama_obat"].ToString(),
                            reader["jumlah_stok"].ToString()
                        );
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) { ClearForm(); LoadData(); }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaObat.Text))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaObat.Focus(); return;
            }
            if (!int.TryParse(txtJumlahStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Jumlah Stok harus berupa angka positif.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahStok.Focus(); return;
            }
            if (Session.IdUser <= 0)
            {
                MessageBox.Show("Sesi login tidak valid. Silakan login ulang.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Obat (id_user, nama_obat, jumlah_stok) VALUES (@id_user, @nama_obat, @jumlah_stok)",
                        conn);
                    cmd.Parameters.AddWithValue("@id_user",     Session.IdUser);
                    cmd.Parameters.AddWithValue("@nama_obat",   txtNamaObat.Text.Trim());
                    cmd.Parameters.AddWithValue("@jumlah_stok", stok);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data obat berhasil ditambahkan.", "Sukses",
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
            if (selectedIdObat == -1)
            {
                MessageBox.Show("Pilih data obat dari tabel terlebih dahulu sebelum mengupdate.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (string.IsNullOrWhiteSpace(txtNamaObat.Text))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaObat.Focus(); return;
            }
            if (!int.TryParse(txtJumlahStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Jumlah Stok harus berupa angka positif.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahStok.Focus(); return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Obat SET nama_obat=@nama_obat, jumlah_stok=@jumlah_stok WHERE id_obat=@id_obat",
                        conn);
                    cmd.Parameters.AddWithValue("@nama_obat",   txtNamaObat.Text.Trim());
                    cmd.Parameters.AddWithValue("@jumlah_stok", stok);
                    cmd.Parameters.AddWithValue("@id_obat",     selectedIdObat);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data obat berhasil diperbarui.", "Sukses",
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
            if (selectedIdObat == -1)
            {
                MessageBox.Show("Pilih data obat dari tabel terlebih dahulu sebelum menghapus.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus obat ini? Jadwal dan riwayat terkait juga akan terhapus.",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Obat WHERE id_obat=@id_obat", conn);
                    cmd.Parameters.AddWithValue("@id_obat", selectedIdObat);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data obat berhasil dihapus.", "Sukses",
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Masukkan nama obat yang ingin dicari.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus(); return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("id_obat",    "ID Obat");
                    dataGridView1.Columns.Add("id_user",    "ID User");
                    dataGridView1.Columns.Add("nama_obat",  "Nama Obat");
                    dataGridView1.Columns.Add("jumlah_stok","Jumlah Stok");
                    dataGridView1.Columns["id_obat"].Visible = false;
                    dataGridView1.Columns["id_user"].Visible = false;

                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM Obat WHERE nama_obat LIKE @keyword", conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text.Trim() + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["id_obat"].ToString(),
                            reader["id_user"].ToString(),
                            reader["nama_obat"].ToString(),
                            reader["jumlah_stok"].ToString()
                        );
                    }
                    reader.Close();
                    if (dataGridView1.Rows.Count == 0)
                        MessageBox.Show("Obat \"" + txtSearch.Text + "\" tidak ditemukan.",
                            "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedIdObat     = Convert.ToInt32(row.Cells["id_obat"].Value);
            txtIdObat.Text     = row.Cells["id_obat"].Value?.ToString();
            txtIdUser.Text     = row.Cells["id_user"].Value?.ToString();
            txtNamaObat.Text   = row.Cells["nama_obat"].Value?.ToString();
            txtJumlahStok.Text = row.Cells["jumlah_stok"].Value?.ToString();
        }

        private void ClearForm()
        {
            selectedIdObat = -1;
            txtIdObat.Clear(); txtIdUser.Clear();
            txtNamaObat.Clear(); txtJumlahStok.Clear();
            txtSearch.Clear();
        }
    }
}
