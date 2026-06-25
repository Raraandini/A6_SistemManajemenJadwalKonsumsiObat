using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormRiwayatKonsumsi : Form
    {
        private BindingSource bsRiwayat = new BindingSource();

        public FormRiwayatKonsumsi()
        {
            InitializeComponent();
        }

        private void FormRiwayatKonsumsi_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(167, 199, 231);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            bindingNavigator1.BindingSource = bsRiwayat;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_RiwayatKonsumsi ORDER BY waktu_konsumsi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bsRiwayat.DataSource = dt;
                    dataGridView1.DataSource = bsRiwayat;

                    dataGridView1.Columns["nama_obat"].HeaderText = "Nama Obat";
                    dataGridView1.Columns["waktu_konsumsi"].HeaderText = "Waktu Konsumsi";
                    dataGridView1.Columns["status_konsumsi"].HeaderText = "Status";

                    dataGridView1.Columns["nama_obat"].Width = 220;
                    dataGridView1.Columns["waktu_konsumsi"].Width = 220;
                    dataGridView1.Columns["status_konsumsi"].Width = 180;
                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
