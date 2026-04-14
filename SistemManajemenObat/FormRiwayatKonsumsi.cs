using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormRiwayatKonsumsi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public FormRiwayatKonsumsi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormRiwayatKonsumsi_Load(object sender, EventArgs e)
        {
            txtIdRiwayat.ReadOnly = true;
            txtIdRiwayat.BackColor = Color.LightGray;

            dtpWaktuKonsumsi.Format = DateTimePickerFormat.Time;
            dtpWaktuKonsumsi.ShowUpDown = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;

            btnLoad.Click += btnLoad_Click;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtIdRiwayat.Clear();
            txtIdObat.Clear();
            dtpWaktuKonsumsi.Value = DateTime.Now;
            txtStatus.Clear();
            txtIdRiwayat.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("id_riwayat", "ID Riwayat");
                dataGridView1.Columns.Add("id_obat", "ID Obat");
                dataGridView1.Columns.Add("waktu_konsumsi", "Waktu Konsumsi");
                dataGridView1.Columns.Add("status", "Status");

                string query = "SELECT * FROM RiwayatKonsumsi";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["id_riwayat"].ToString(),
                        reader["id_obat"].ToString(),
                        reader["waktu_konsumsi"].ToString(),
                        reader["status"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIdRiwayat.Text = row.Cells["id_riwayat"].Value?.ToString();
                txtIdObat.Text = row.Cells["id_obat"].Value?.ToString();

                string waktuK = row.Cells["waktu_konsumsi"].Value?.ToString();
                if (TimeSpan.TryParse(waktuK, out TimeSpan ts))
                    dtpWaktuKonsumsi.Value = DateTime.Today.Add(ts);

                txtStatus.Text = row.Cells["status"].Value?.ToString();
            }
        }
    }
}
