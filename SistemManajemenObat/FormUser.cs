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
    public partial class FormUser : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-8U71E72\\RARA;Initial Catalog=DBSistemManajemenObat;Integrated Security=True";

        public FormUser()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
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
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

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

                // Cek apakah username sudah ada
                string checkQuery = "SELECT COUNT(*) FROM [User] WHERE username = @username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                int userExists = (int)checkCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("Username sudah digunakan. Silakan pilih username lain.");
                    return;
                }

                string query = @"INSERT INTO [User] (nama, username, password) 
                                 VALUES (@nama, @username, @password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                int result = cmd.ExecuteNonQuery();

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
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah sistem: " + ex.Message, "Error");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
