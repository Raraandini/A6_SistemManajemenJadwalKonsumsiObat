using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace SistemManajemenObat
{
    public partial class FormCetakObat : Form
    {
        private DataTable dtObat;

        public FormCetakObat()
        {
            InitializeComponent();
        }

        public FormCetakObat(DataTable dt) : this()
        {
            this.dtObat = dt;
            this.Load += FormCetakObat_Load;
        }

        private void FormCetakObat_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument report = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "ReportObat.rpt");
                
                // Cari ke atas jika tidak ada di folder build saat ini
                if (!File.Exists(reportPath))
                {
                    reportPath = Path.Combine(Application.StartupPath, @"..\..\ReportObat.rpt"); // Untuk bin\Debug
                    if (!File.Exists(reportPath))
                    {
                        reportPath = Path.Combine(Application.StartupPath, @"..\..\..\ReportObat.rpt"); // Untuk bin\x64\Debug
                    }
                }
                
                report.Load(reportPath);
                report.SetDataSource(dtObat);
                crViewer.ReportSource = report;
                crViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
