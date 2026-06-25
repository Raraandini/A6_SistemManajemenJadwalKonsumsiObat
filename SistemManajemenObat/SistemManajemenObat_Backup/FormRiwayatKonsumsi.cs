using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormRiwayatKonsumsi : Form
    {
        private string connStr =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public FormRiwayatKonsumsi()
        {
            InitializeComponent();
        }

        private void FormRiwayatKonsumsi_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly           = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.BackgroundColor    = System.Drawing.Color.White;
            dataGridView1.BorderStyle        = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(167, 199, 231);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT o.nama_obat,
                               r.waktu_konsumsi,
                               r.status_konsumsi
                        FROM RiwayatKonsumsi r
                        INNER JOIN Obat o ON r.id_obat = o.id_obat
                        ORDER BY r.waktu_konsumsi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["nama_obat"].HeaderText       = "Nama Obat";
                    dataGridView1.Columns["waktu_konsumsi"].HeaderText  = "Waktu Konsumsi";
                    dataGridView1.Columns["status_konsumsi"].HeaderText = "Status";

                    dataGridView1.Columns["nama_obat"].Width       = 220;
                    dataGridView1.Columns["waktu_konsumsi"].Width  = 220;
                    dataGridView1.Columns["status_konsumsi"].Width = 180;
                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblJudulRiwayat_Click(object sender, EventArgs e) { }
    }
}
