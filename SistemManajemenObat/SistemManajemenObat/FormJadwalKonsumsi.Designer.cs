namespace SistemManajemenObat
{
    partial class FormJadwalKonsumsi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNamaObat       = new System.Windows.Forms.Label();
            this.cbNamaObat        = new System.Windows.Forms.ComboBox();
            this.lblWaktuMinum     = new System.Windows.Forms.Label();
            this.dtpWaktuMinum     = new System.Windows.Forms.DateTimePicker();
            this.lblJamMinum       = new System.Windows.Forms.Label();
            this.dtpJamMinum       = new System.Windows.Forms.DateTimePicker();
            this.lblDosis          = new System.Windows.Forms.Label();
            this.txtDosis          = new System.Windows.Forms.TextBox();
            this.lblStatusKonsumsi = new System.Windows.Forms.Label();
            this.cboStatus         = new System.Windows.Forms.ComboBox();
            this.btnLoad           = new System.Windows.Forms.Button();
            this.btnInsert         = new System.Windows.Forms.Button();
            this.btnUpdate         = new System.Windows.Forms.Button();
            this.btnDelete         = new System.Windows.Forms.Button();
            this.dataGridView1     = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Shared colors & font
            System.Drawing.Color btnColor = System.Drawing.Color.FromArgb(167, 199, 231);
            System.Drawing.Color btnFore  = System.Drawing.Color.FromArgb(44, 62, 80);
            System.Drawing.Font  btnFont  = new System.Drawing.Font(
                "Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font  lblFont  = new System.Drawing.Font("Segoe UI", 10F);

            // lblNamaObat
            this.lblNamaObat.AutoSize  = true;
            this.lblNamaObat.Font      = lblFont;
            this.lblNamaObat.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblNamaObat.Location  = new System.Drawing.Point(30, 30);
            this.lblNamaObat.Name      = "lblNamaObat";
            this.lblNamaObat.Text      = "Nama Obat";

            // cbNamaObat
            this.cbNamaObat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamaObat.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNamaObat.Location      = new System.Drawing.Point(170, 27);
            this.cbNamaObat.Name          = "cbNamaObat";
            this.cbNamaObat.Size          = new System.Drawing.Size(280, 25);

            // lblWaktuMinum
            this.lblWaktuMinum.AutoSize  = true;
            this.lblWaktuMinum.Font      = lblFont;
            this.lblWaktuMinum.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblWaktuMinum.Location  = new System.Drawing.Point(30, 75);
            this.lblWaktuMinum.Name      = "lblWaktuMinum";
            this.lblWaktuMinum.Text      = "Waktu Minum";

            // dtpWaktuMinum
            this.dtpWaktuMinum.Format       = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWaktuMinum.CustomFormat = "dd/MM/yyyy";
            this.dtpWaktuMinum.ShowUpDown   = true;
            this.dtpWaktuMinum.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpWaktuMinum.Location     = new System.Drawing.Point(170, 72);
            this.dtpWaktuMinum.Name         = "dtpWaktuMinum";
            this.dtpWaktuMinum.Size         = new System.Drawing.Size(200, 25);

            // lblJamMinum
            this.lblJamMinum.AutoSize  = true;
            this.lblJamMinum.Font      = lblFont;
            this.lblJamMinum.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblJamMinum.Location  = new System.Drawing.Point(30, 120);
            this.lblJamMinum.Name      = "lblJamMinum";
            this.lblJamMinum.Text      = "Jam Minum";

            // dtpJamMinum
            this.dtpJamMinum.Format       = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJamMinum.CustomFormat = "HH:mm:ss";
            this.dtpJamMinum.ShowUpDown   = true;
            this.dtpJamMinum.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpJamMinum.Location     = new System.Drawing.Point(170, 117);
            this.dtpJamMinum.Name         = "dtpJamMinum";
            this.dtpJamMinum.Size         = new System.Drawing.Size(160, 25);

            // lblDosis
            this.lblDosis.AutoSize  = true;
            this.lblDosis.Font      = lblFont;
            this.lblDosis.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblDosis.Location  = new System.Drawing.Point(30, 165);
            this.lblDosis.Name      = "lblDosis";
            this.lblDosis.Text      = "Dosis";

            // txtDosis
            this.txtDosis.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDosis.Location = new System.Drawing.Point(170, 162);
            this.txtDosis.Name     = "txtDosis";
            this.txtDosis.Size     = new System.Drawing.Size(280, 25);

            // lblStatusKonsumsi
            this.lblStatusKonsumsi.AutoSize  = true;
            this.lblStatusKonsumsi.Font      = lblFont;
            this.lblStatusKonsumsi.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblStatusKonsumsi.Location  = new System.Drawing.Point(30, 210);
            this.lblStatusKonsumsi.Name      = "lblStatusKonsumsi";
            this.lblStatusKonsumsi.Text      = "Status Konsumsi";

            // cboStatus
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.Location      = new System.Drawing.Point(170, 207);
            this.cboStatus.Name          = "cboStatus";
            this.cboStatus.Size          = new System.Drawing.Size(280, 25);

            // btnLoad
            this.btnLoad.BackColor               = btnColor;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font                    = btnFont;
            this.btnLoad.ForeColor               = btnFore;
            this.btnLoad.Location                = new System.Drawing.Point(30, 255);
            this.btnLoad.Name                    = "btnLoad";
            this.btnLoad.Size                    = new System.Drawing.Size(100, 34);
            this.btnLoad.Text                    = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // btnInsert
            this.btnInsert.BackColor               = btnColor;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font                    = btnFont;
            this.btnInsert.ForeColor               = btnFore;
            this.btnInsert.Location                = new System.Drawing.Point(140, 255);
            this.btnInsert.Name                    = "btnInsert";
            this.btnInsert.Size                    = new System.Drawing.Size(100, 34);
            this.btnInsert.Text                    = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            // btnUpdate
            this.btnUpdate.BackColor               = btnColor;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font                    = btnFont;
            this.btnUpdate.ForeColor               = btnFore;
            this.btnUpdate.Location                = new System.Drawing.Point(250, 255);
            this.btnUpdate.Name                    = "btnUpdate";
            this.btnUpdate.Size                    = new System.Drawing.Size(100, 34);
            this.btnUpdate.Text                    = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.BackColor               = btnColor;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font                    = btnFont;
            this.btnDelete.ForeColor               = btnFore;
            this.btnDelete.Location                = new System.Drawing.Point(360, 255);
            this.btnDelete.Name                    = "btnDelete";
            this.btnDelete.Size                    = new System.Drawing.Size(100, 34);
            this.btnDelete.Text                    = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dataGridView1
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Location        = new System.Drawing.Point(30, 305);
            this.dataGridView1.Name            = "dataGridView1";
            this.dataGridView1.Size            = new System.Drawing.Size(740, 250);

            // FormJadwalKonsumsi
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor     = System.Drawing.Color.FromArgb(244, 248, 251);
            this.ClientSize    = new System.Drawing.Size(820, 580);
            this.Name          = "FormJadwalKonsumsi";
            this.Text          = "Kelola Jadwal Konsumsi";
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatusKonsumsi);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.lblDosis);
            this.Controls.Add(this.dtpJamMinum);
            this.Controls.Add(this.lblJamMinum);
            this.Controls.Add(this.dtpWaktuMinum);
            this.Controls.Add(this.lblWaktuMinum);
            this.Controls.Add(this.cbNamaObat);
            this.Controls.Add(this.lblNamaObat);
            this.Load += new System.EventHandler(this.FormJadwalKonsumsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label           lblNamaObat;
        private System.Windows.Forms.ComboBox        cbNamaObat;
        private System.Windows.Forms.Label           lblWaktuMinum;
        private System.Windows.Forms.DateTimePicker  dtpWaktuMinum;
        private System.Windows.Forms.Label           lblJamMinum;
        private System.Windows.Forms.DateTimePicker  dtpJamMinum;
        private System.Windows.Forms.Label           lblDosis;
        private System.Windows.Forms.TextBox         txtDosis;
        private System.Windows.Forms.Label           lblStatusKonsumsi;
        private System.Windows.Forms.ComboBox        cboStatus;
        private System.Windows.Forms.Button          btnLoad;
        private System.Windows.Forms.Button          btnInsert;
        private System.Windows.Forms.Button          btnUpdate;
        private System.Windows.Forms.Button          btnDelete;
        private System.Windows.Forms.DataGridView    dataGridView1;
    }
}
