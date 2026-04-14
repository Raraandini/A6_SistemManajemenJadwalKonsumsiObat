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
    public partial class FormObat : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public FormObat()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            txtIdObat.ReadOnly = true;
            txtIdObat.BackColor = Color.LightGray;

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
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) btnSearch.PerformClick(); };
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
            txtIdObat.Clear();
            txtIdUser.Clear();
            txtNamaObat.Clear();
            txtJumlahStok.Clear();
            txtBatasMinimumStok.Clear();
            txtIdObat.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("id_obat", "ID Obat");
                dataGridView1.Columns.Add("id_user", "ID User");
                dataGridView1.Columns.Add("nama_obat", "Nama Obat");
                dataGridView1.Columns.Add("jumlah_stok", "Jumlah Stok");
                dataGridView1.Columns.Add("batas_minimum_stok", "Batas Min Stok");

                string query = "SELECT * FROM Obat";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["id_obat"].ToString(),
                        reader["id_user"].ToString(),
                        reader["nama_obat"].ToString(),
                        reader["jumlah_stok"].ToString(),
                        reader["batas_minimum_stok"].ToString()
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
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (string.IsNullOrEmpty(txtNamaObat.Text))
                {
                    MessageBox.Show("Nama Obat harus diisi");
                    txtNamaObat.Focus();
                    return;
                }

                string query = @"INSERT INTO Obat 
                                (id_user, nama_obat, jumlah_stok, batas_minimum_stok)
                                VALUES 
                                (@id_user, @nama_obat, @jumlah_stok, @batas_minimum_stok)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_user", txtIdUser.Text);
                cmd.Parameters.AddWithValue("@nama_obat", txtNamaObat.Text);
                cmd.Parameters.AddWithValue("@jumlah_stok", txtJumlahStok.Text);
                cmd.Parameters.AddWithValue("@batas_minimum_stok", txtBatasMinimumStok.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data obat berhasil ditambahkan");
                    ClearForm();
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        
    }
}
