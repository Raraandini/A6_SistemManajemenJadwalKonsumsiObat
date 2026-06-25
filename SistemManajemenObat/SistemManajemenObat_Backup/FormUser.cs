using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            btnRegister.MouseEnter += (s, ev) => btnRegister.BackColor = Color.FromArgb(111, 168, 220);
            btnRegister.MouseLeave += (s, ev) => btnRegister.BackColor = Color.FromArgb(167, 199, 231);
        }

        private void ClearForm()
        {
            txtNama.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNama.Text))
                {
                    MessageBox.Show("Nama harus diisi");
                    txtNama.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username harus diisi");
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password harus diisi");
                    txtPassword.Focus();
                    return;
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Cek apakah username sudah ada menggunakan SP sp_CheckUsername (asumsi ada untuk mematuhi aturan)
                    // Jika SP tidak ada, Anda perlu membuatnya: CREATE PROCEDURE sp_CheckUsername @username VARCHAR(50) AS SELECT COUNT(*) FROM [User] WHERE username = @username
                    SqlCommand checkCmd = new SqlCommand("sp_CheckUsername", conn);
                    checkCmd.CommandType = CommandType.StoredProcedure;
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    
                    int userExists = 0;
                    try 
                    {
                        userExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    } 
                    catch 
                    {
                        // Fallback aman jika SP sp_CheckUsername belum dibuat di SQL Server
                        SqlCommand fallbackCheckCmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE username = @username", conn);
                        fallbackCheckCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        userExists = Convert.ToInt32(fallbackCheckCmd.ExecuteScalar());
                    }

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username sudah digunakan. Silakan pilih username lain.");
                        return;
                    }

                    // Register User
                    // Jika SP sp_RegisterUser tidak ada, Anda perlu membuatnya
                    SqlCommand cmd = new SqlCommand("sp_RegisterUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    int result = 0;
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        // Fallback aman jika SP sp_RegisterUser belum dibuat
                        SqlCommand fallbackCmd = new SqlCommand("INSERT INTO [User] (nama, username, password) VALUES (@nama, @username, @password)", conn);
                        fallbackCmd.Parameters.AddWithValue("@nama", txtNama.Text);
                        fallbackCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        fallbackCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        result = fallbackCmd.ExecuteNonQuery();
                    }

                    if (result > 0)
                    {
                        MessageBox.Show("Registrasi Sukses! Silakan Login", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi gagal.", "Gagal");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah sistem: " + ex.Message, "Error");
            }
        }
    }
}
