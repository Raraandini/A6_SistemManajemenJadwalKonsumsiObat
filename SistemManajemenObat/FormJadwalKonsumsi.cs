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
    public partial class FormJadwalKonsumsi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public FormJadwalKonsumsi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormJadwalKonsumsi_Load(object sender, EventArgs e)
        {
            txtIdJadwal.ReadOnly = true;
            txtIdJadwal.BackColor = Color.LightGray;

            dtpWaktuMinum.Format = DateTimePickerFormat.Time;
            dtpWaktuMinum.ShowUpDown = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            btnLoad.Click += btnLoad_Click;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }
        // Tambahkan method-method ini di bawah FormJadwalKonsumsi_Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("id_jadwal", "ID Jadwal");
                dataGridView1.Columns.Add("id_obat", "ID Obat");
                dataGridView1.Columns.Add("waktu_minum", "Waktu Minum");
                dataGridView1.Columns.Add("dosis", "Dosis");

                string query = "SELECT * FROM JadwalKonsumsi";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["id_jadwal"].ToString(),
                        reader["id_obat"].ToString(),
                        reader["waktu_minum"].ToString(),
                        reader["dosis"].ToString()
                    );
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("Gagal menampilkan data: " + ex.Message); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = @"INSERT INTO JadwalKonsumsi (id_obat, waktu_minum, dosis) VALUES (@id_obat, @waktu_minum, @dosis)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_obat", txtIdObat.Text);
                cmd.Parameters.AddWithValue("@waktu_minum", dtpWaktuMinum.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@dosis", txtDosis.Text);
                if (cmd.ExecuteNonQuery() > 0) { btnLoad.PerformClick(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = @"UPDATE JadwalKonsumsi SET id_obat=@id_obat, waktu_minum=@waktu_minum, dosis=@dosis WHERE id_jadwal=@id_jadwal";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_jadwal", txtIdJadwal.Text);
                cmd.Parameters.AddWithValue("@id_obat", txtIdObat.Text);
                cmd.Parameters.AddWithValue("@waktu_minum", dtpWaktuMinum.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@dosis", txtDosis.Text);
                if (cmd.ExecuteNonQuery() > 0) { btnLoad.PerformClick(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "DELETE FROM JadwalKonsumsi WHERE id_jadwal=@id_jadwal";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_jadwal", txtIdJadwal.Text);
                if (cmd.ExecuteNonQuery() > 0) { btnLoad.PerformClick(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        



    }
}
