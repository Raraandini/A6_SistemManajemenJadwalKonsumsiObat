using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            btnLogin.MouseEnter += (s, ev) => btnLogin.BackColor = Color.FromArgb(111, 168, 220);
            btnLogin.MouseLeave += (s, ev) => btnLogin.BackColor = Color.FromArgb(167, 199, 231);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Koneksi berhasil terhubung dengan Database!",
                        "Status Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message,
                    "Status Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validasi diubah: Sekarang hanya mencegat Username yang kosong. 
            // Password sengaja boleh dibiarkan kosong agar demo SQL Injection lancar!
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Query ini sengaja dibiarkan rentan terhadap SQL Injection
                    string query = "SELECT id_user, nama FROM [User] WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) // Jika payload OR 1=1 memanipulasi logika, nilainya akan true
                            {
                                reader.Read();
                                Session.IdUser = Convert.ToInt32(reader["id_user"]);
                                Session.NamaUser = reader["nama"].ToString();

                                // Menampilkan pesan dan langsung menjebol masuk ke Dashboard
                                MessageBox.Show($"Selamat Datang!", "Login Sukses");
                                Form1 dashboard = new Form1();
                                this.Hide();
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database: " + ex.Message, "Error");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormUser frmRegister = new FormUser();
            this.Hide();
            frmRegister.ShowDialog();
            this.Show();
        }
    }
}
