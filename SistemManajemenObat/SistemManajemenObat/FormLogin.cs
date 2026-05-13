using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-Q1UQHI44\\MEILANULFIA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_user, nama FROM [User] WHERE username=@usr AND password=@pwd";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usr", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string nama   = reader["nama"].ToString();
                        int    idUser = Convert.ToInt32(reader["id_user"]);
                        Session.IdUser   = idUser;
                        Session.NamaUser = nama;
                        MessageBox.Show($"Selamat Datang, {nama}!", "Login Berhasil");
                        Form1 dashboard = new Form1();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah sistem: " + ex.Message, "Error");
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
