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

        }

    }
}
