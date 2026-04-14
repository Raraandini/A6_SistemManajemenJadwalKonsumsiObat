using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
            if (DesignMode) return;

            SetupHoverEffects();
            
            btnLogout.Click += (s, e) => Application.Restart();
            btnObat.Click += (s, e) => OpenChildForm(new FormObat());
            btnJadwal.Click += (s, e) => OpenChildForm(new FormJadwalKonsumsi());
            btnRiwayat.Click += (s, e) => OpenChildForm(new FormRiwayatKonsumsi());
        }

        private void SetupHoverEffects()
        {
            // Efek hover untuk tombol Sidebar -> Warna #6FA8DC
            Button[] sidebarButtons = { btnLogout, btnObat, btnJadwal, btnRiwayat };
            foreach (var btn in sidebarButtons)
            {
                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(111, 168, 220); 
                btn.MouseLeave += (s, e) => btn.BackColor = Color.Transparent;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(244, 248, 251); // Soft Blue Background (#F4F8FB)
            
            // Apply Soft Blue to buttons in the child form dynamically to enforce styling
            ApplySoftBlueStyle(childForm);

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            lblStatus.Text = $"Ready - Membuka {childForm.Text}";
        }

        private void ApplySoftBlueStyle(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.FromArgb(167, 199, 231); // #A7C7E7
                    btn.ForeColor = Color.FromArgb(44, 62, 80);    // #2C3E50
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(111, 168, 220); // #6FA8DC
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(167, 199, 231);
                }
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(167, 199, 231);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.GridColor = Color.FromArgb(214, 230, 242);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(111, 168, 220);
                }
                ApplySoftBlueStyle(c);
            }
        }
    }
}
