namespace SistemManajemenObat
{
    partial class FormJadwalKonsumsi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdJadwal = new System.Windows.Forms.Label();
            this.lblIdObat = new System.Windows.Forms.Label();
            this.lblWaktuMinum = new System.Windows.Forms.Label();
            this.lblDosis = new System.Windows.Forms.Label();
            this.txtIdJadwal = new System.Windows.Forms.TextBox();
            this.txtIdObat = new System.Windows.Forms.TextBox();
            this.dtpWaktuMinum = new System.Windows.Forms.DateTimePicker();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdJadwal
            // 
            this.lblIdJadwal.AutoSize = true;
            this.lblIdJadwal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJadwal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblIdJadwal.Location = new System.Drawing.Point(30, 30);
            this.lblIdJadwal.Name = "lblIdJadwal";
            this.lblIdJadwal.Size = new System.Drawing.Size(68, 19);
            this.lblIdJadwal.TabIndex = 0;
            this.lblIdJadwal.Text = "ID Jadwal";
            // 
            // lblIdObat
            // 
            this.lblIdObat.AutoSize = true;
            this.lblIdObat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdObat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblIdObat.Location = new System.Drawing.Point(30, 70);
            this.lblIdObat.Name = "lblIdObat";
            this.lblIdObat.Size = new System.Drawing.Size(54, 19);
            this.lblIdObat.TabIndex = 1;
            this.lblIdObat.Text = "ID Obat";
            // 
            // lblWaktuMinum
            // 
            this.lblWaktuMinum.AutoSize = true;
            this.lblWaktuMinum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuMinum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblWaktuMinum.Location = new System.Drawing.Point(30, 110);
            this.lblWaktuMinum.Name = "lblWaktuMinum";
            this.lblWaktuMinum.Size = new System.Drawing.Size(96, 19);
            this.lblWaktuMinum.TabIndex = 2;
            this.lblWaktuMinum.Text = "Waktu Minum";
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDosis.Location = new System.Drawing.Point(30, 150);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(40, 19);
            this.lblDosis.TabIndex = 3;
            this.lblDosis.Text = "Dosis";
            // 
            // txtIdJadwal
            // 
            this.txtIdJadwal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJadwal.Location = new System.Drawing.Point(170, 27);
            this.txtIdJadwal.Name = "txtIdJadwal";
            this.txtIdJadwal.Size = new System.Drawing.Size(250, 25);
            this.txtIdJadwal.TabIndex = 4;
            // 
            // txtIdObat
            // 
            this.txtIdObat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdObat.Location = new System.Drawing.Point(170, 67);
            this.txtIdObat.Name = "txtIdObat";
            this.txtIdObat.Size = new System.Drawing.Size(250, 25);
            this.txtIdObat.TabIndex = 5;
            // 
            // dtpWaktuMinum
            // 
            this.dtpWaktuMinum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWaktuMinum.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWaktuMinum.ShowUpDown = true;
            this.dtpWaktuMinum.Location = new System.Drawing.Point(170, 107);
            this.dtpWaktuMinum.Name = "dtpWaktuMinum";
            this.dtpWaktuMinum.Size = new System.Drawing.Size(250, 25);
            this.dtpWaktuMinum.TabIndex = 6;
            // 
            // txtDosis
            // 
            this.txtDosis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosis.Location = new System.Drawing.Point(170, 147);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(250, 25);
            this.txtDosis.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLoad.Location = new System.Drawing.Point(130, 200);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 35);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnInsert.Location = new System.Drawing.Point(230, 200);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUpdate.Location = new System.Drawing.Point(330, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDelete.Location = new System.Drawing.Point(430, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 255);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormJadwalKonsumsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(820, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.dtpWaktuMinum);
            this.Controls.Add(this.txtIdObat);
            this.Controls.Add(this.txtIdJadwal);
            this.Controls.Add(this.lblDosis);
            this.Controls.Add(this.lblWaktuMinum);
            this.Controls.Add(this.lblIdObat);
            this.Controls.Add(this.lblIdJadwal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormJadwalKonsumsi";
            this.Text = "Kelola Jadwal Konsumsi";
            this.Load += new System.EventHandler(this.FormJadwalKonsumsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdJadwal;
        private System.Windows.Forms.Label lblIdObat;
        private System.Windows.Forms.Label lblWaktuMinum;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.TextBox txtIdJadwal;
        private System.Windows.Forms.TextBox txtIdObat;
        private System.Windows.Forms.DateTimePicker dtpWaktuMinum;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
