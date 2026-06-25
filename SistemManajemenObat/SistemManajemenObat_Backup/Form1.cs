using System;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tampilkan nama user yang sedang login
            this.Text = "Dashboard — Selamat datang, " + Session.NamaUser + "!";
        }

        private Form activeForm = null;

        private void LoadForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            LoadForm(new FormObat());
        }

        private void btnJadwalKonsumsi_Click(object sender, EventArgs e)
        {
            LoadForm(new FormJadwalKonsumsi());
        }

        private void btnRiwayatKonsumsi_Click(object sender, EventArgs e)
        {
            LoadForm(new FormRiwayatKonsumsi());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoadForm(new FormUser());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.IdUser = 0;
            Session.NamaUser   = string.Empty;
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}

