namespace SistemManajemenObat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panelSidebar.Controls.Add(this.btnRiwayat);
            this.panelSidebar.Controls.Add(this.btnJadwal);
            this.panelSidebar.Controls.Add(this.btnObat);
            this.panelSidebar.Controls.Add(this.lblAppTitle);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 595);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRiwayat.Location = new System.Drawing.Point(0, 200);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRiwayat.Size = new System.Drawing.Size(200, 55);
            this.btnRiwayat.TabIndex = 3;
            this.btnRiwayat.Text = "Riwayat Konsumsi";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayatKonsumsi_Click);
            // 
            // btnJadwal
            // 
            this.btnJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJadwal.FlatAppearance.BorderSize = 0;
            this.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnJadwal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnJadwal.Location = new System.Drawing.Point(0, 145);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnJadwal.Size = new System.Drawing.Size(200, 55);
            this.btnJadwal.TabIndex = 2;
            this.btnJadwal.Text = "Jadwal Konsumsi";
            this.btnJadwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJadwal.UseVisualStyleBackColor = true;
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwalKonsumsi_Click);
            // 
            // btnObat
            // 
            this.btnObat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObat.FlatAppearance.BorderSize = 0;
            this.btnObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObat.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnObat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnObat.Location = new System.Drawing.Point(0, 90);
            this.btnObat.Name = "btnObat";
            this.btnObat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnObat.Size = new System.Drawing.Size(200, 55);
            this.btnObat.TabIndex = 1;
            this.btnObat.Text = "Data Obat";
            this.btnObat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObat.UseVisualStyleBackColor = true;
            this.btnObat.Click += new System.EventHandler(this.btnObat_Click);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(200, 90);
            this.lblAppTitle.TabIndex = 4;
            this.lblAppTitle.Text = "💊 Sistem\nManajemen\nObat";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "⏻  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 595);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1000, 25);
            this.panelStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready - Sistem Berjalan";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 595);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelStatus);
            this.Name = "Form1";
            this.Text = "Sistem Manajemen Obat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnJadwal;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblAppTitle;
    }
}

