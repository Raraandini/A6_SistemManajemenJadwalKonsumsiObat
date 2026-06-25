using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormRekapObat : Form
    {
        private DataTable dtRekap;

        public FormRekapObat()
        {
            InitializeComponent();
        }

        private void FormRekapObat_Load(object sender, EventArgs e)
        {
            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;
            LoadData();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Obat WHERE id_user=@id_user AND nama_obat LIKE @nama";
                    
                    if (cbStatus.SelectedIndex == 1) // Stok Aman (>= 10)
                    {
                        query += " AND jumlah_stok >= 10";
                    }
                    else if (cbStatus.SelectedIndex == 2) // Stok Menipis (< 10)
                    {
                        query += " AND jumlah_stok < 10";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", Session.IdUser);
                        cmd.Parameters.AddWithValue("@nama", "%" + txtCari.Text.Trim() + "%");
                        
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dtRekap = new DataTable();
                        da.Fill(dtRekap);
                        
                        dgvRekapObat.DataSource = dtRekap;
                        if (dgvRekapObat.Columns.Contains("id_obat"))
                        {
                            dgvRekapObat.Columns["id_obat"].Visible = false;
                            dgvRekapObat.Columns["id_user"].Visible = false;
                            dgvRekapObat.Columns["nama_obat"].HeaderText = "Nama Obat";
                            dgvRekapObat.Columns["jumlah_stok"].HeaderText = "Jumlah Stok";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            if (dtRekap != null && dtRekap.Rows.Count > 0)
            {
                FormCetakObat frmCetak = new FormCetakObat(dtRekap);
                frmCetak.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tidak ada data untuk dicetak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

