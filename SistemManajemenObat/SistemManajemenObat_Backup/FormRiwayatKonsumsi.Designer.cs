namespace SistemManajemenObat
{
    partial class FormRiwayatKonsumsi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblJudulRiwayat = new System.Windows.Forms.Label();
            this.lblSubjudul     = new System.Windows.Forms.Label();
            this.dataGridView1   = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblJudulRiwayat
            this.lblJudulRiwayat.AutoSize  = true;
            this.lblJudulRiwayat.Font      = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudulRiwayat.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblJudulRiwayat.Location  = new System.Drawing.Point(30, 20);
            this.lblJudulRiwayat.Name      = "lblJudulRiwayat";
            this.lblJudulRiwayat.TabIndex  = 0;
            this.lblJudulRiwayat.Text      = "Riwayat Konsumsi Obat";

            // lblSubjudul
            this.lblSubjudul.AutoSize  = true;
            this.lblSubjudul.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubjudul.ForeColor = System.Drawing.Color.Gray;
            this.lblSubjudul.Location  = new System.Drawing.Point(30, 52);
            this.lblSubjudul.Name      = "lblSubjudul";
            this.lblSubjudul.TabIndex  = 1;
            this.lblSubjudul.Text      = "Data konsumsi obat yang telah tercatat";

            // dataGridView1
            // ✅ AutoGenerateColumns dibiarkan default (true) → kolom
            //    otomatis terbentuk dari DataTable yang di-fill di .cs
            // ✅ DataSource TIDAK diset di sini → diurus LoadData() di .cs
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 90);
            this.dataGridView1.Name     = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size     = new System.Drawing.Size(740, 400);
            this.dataGridView1.TabIndex = 2;

            // FormRiwayatKonsumsi
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(244, 248, 251);
            this.ClientSize          = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.lblJudulRiwayat);
            this.Controls.Add(this.lblSubjudul);
            this.Controls.Add(this.dataGridView1);
            this.Name  = "FormRiwayatKonsumsi";
            this.Text  = "Riwayat Konsumsi";
            this.Load += new System.EventHandler(this.FormRiwayatKonsumsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label        lblJudulRiwayat;
        private System.Windows.Forms.Label        lblSubjudul;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
