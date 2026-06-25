namespace SistemManajemenObat
{
    partial class FormRekapObat
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dgvRekapObat = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekapObat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCari);
            this.panelTop.Controls.Add(this.txtCari);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.cbStatus);
            this.panelTop.Controls.Add(this.btnTampil);
            this.panelTop.Controls.Add(this.btnCetak);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(12, 33);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(85, 13);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Nama Obat:";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(103, 30);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(150, 20);
            this.txtCari.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(269, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status Stok:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Semua Data",
            "Stok Aman (>= 10)",
            "Stok Menipis (< 10)"});
            this.cbStatus.Location = new System.Drawing.Point(340, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(506, 28);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(90, 25);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(602, 28);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(90, 25);
            this.btnCetak.TabIndex = 5;
            this.btnCetak.Text = "Cetak Rekap";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // dgvRekapObat
            // 
            this.dgvRekapObat.AllowUserToAddRows = false;
            this.dgvRekapObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRekapObat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRekapObat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRekapObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRekapObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRekapObat.RowTemplate.Height = 28;
            this.dgvRekapObat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRekapObat.EnableHeadersVisualStyles = false;
            this.dgvRekapObat.Location = new System.Drawing.Point(0, 80);
            this.dgvRekapObat.Name = "dgvRekapObat";
            this.dgvRekapObat.ReadOnly = true;
            this.dgvRekapObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRekapObat.Size = new System.Drawing.Size(800, 470);
            this.dgvRekapObat.TabIndex = 1;
            // 
            // FormRekapObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvRekapObat);
            this.Controls.Add(this.panelTop);
            this.Name = "FormRekapObat";
            this.Text = "Rekap Data Obat";
            this.Load += new System.EventHandler(this.FormRekapObat_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekapObat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dgvRekapObat;
    }
}