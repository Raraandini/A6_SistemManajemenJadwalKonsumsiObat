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

      
    }
}
