namespace SistemManajemenObat
{
    partial class FormObat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblIdObat = new System.Windows.Forms.Label();
            this.lblNamaObat = new System.Windows.Forms.Label();
            this.lblJumlahStok = new System.Windows.Forms.Label();
            this.txtIdObat = new System.Windows.Forms.TextBox();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.txtJumlahStok = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdObat
            // 
            this.lblIdObat.Location = new System.Drawing.Point(0, 0);
            this.lblIdObat.Name = "lblIdObat";
            this.lblIdObat.Size = new System.Drawing.Size(100, 23);
            this.lblIdObat.TabIndex = 15;
            this.lblIdObat.Text = "ID Obat";
            this.lblIdObat.Visible = false;
            // 
            // lblNamaObat
            // 
            this.lblNamaObat.AutoSize = true;
            this.lblNamaObat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNamaObat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNamaObat.Location = new System.Drawing.Point(30, 30);
            this.lblNamaObat.Name = "lblNamaObat";
            this.lblNamaObat.Size = new System.Drawing.Size(80, 19);
            this.lblNamaObat.TabIndex = 11;
            this.lblNamaObat.Text = "Nama Obat";
            // 
            // lblJumlahStok
            // 
            this.lblJumlahStok.AutoSize = true;
            this.lblJumlahStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJumlahStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblJumlahStok.Location = new System.Drawing.Point(30, 70);
            this.lblJumlahStok.Name = "lblJumlahStok";
            this.lblJumlahStok.Size = new System.Drawing.Size(83, 19);
            this.lblJumlahStok.TabIndex = 9;
            this.lblJumlahStok.Text = "Jumlah Stok";
            // 
            // txtIdObat
            // 
            this.txtIdObat.Location = new System.Drawing.Point(0, 0);
            this.txtIdObat.Name = "txtIdObat";
            this.txtIdObat.Size = new System.Drawing.Size(100, 20);
            this.txtIdObat.TabIndex = 14;
            this.txtIdObat.Visible = false;
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaObat.Location = new System.Drawing.Point(170, 27);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(280, 25);
            this.txtNamaObat.TabIndex = 10;
            // 
            // txtJumlahStok
            // 
            this.txtJumlahStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlahStok.Location = new System.Drawing.Point(170, 67);
            this.txtJumlahStok.Name = "txtJumlahStok";
            this.txtJumlahStok.Size = new System.Drawing.Size(280, 25);
            this.txtJumlahStok.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLoad.Location = new System.Drawing.Point(30, 115);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 34);
            this.btnLoad.TabIndex = 7;
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
            this.btnInsert.Location = new System.Drawing.Point(140, 115);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 34);
            this.btnInsert.TabIndex = 6;
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
            this.btnUpdate.Location = new System.Drawing.Point(250, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 5;
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
            this.btnDelete.Location = new System.Drawing.Point(360, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(30, 168);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 19);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Cari Nama Obat:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(155, 165);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.Location = new System.Drawing.Point(435, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(30, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblIdUser
            // 
            this.lblIdUser.Location = new System.Drawing.Point(0, 0);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(100, 23);
            this.lblIdUser.TabIndex = 13;
            this.lblIdUser.Text = "ID User";
            this.lblIdUser.Visible = false;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(0, 0);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(100, 20);
            this.txtIdUser.TabIndex = 12;
            this.txtIdUser.Visible = false;
            // 
            // FormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(820, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtJumlahStok);
            this.Controls.Add(this.lblJumlahStok);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.lblNamaObat);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.txtIdObat);
            this.Controls.Add(this.lblIdObat);
            this.Name = "FormObat";
            this.Text = "Kelola Obat";
            this.Load += new System.EventHandler(this.FormObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label       lblIdObat;
        private System.Windows.Forms.Label       lblNamaObat;
        private System.Windows.Forms.Label       lblJumlahStok;
        private System.Windows.Forms.TextBox     txtIdObat;
        private System.Windows.Forms.TextBox     txtNamaObat;
        private System.Windows.Forms.TextBox     txtJumlahStok;
        private System.Windows.Forms.Button      btnLoad;
        private System.Windows.Forms.Button      btnInsert;
        private System.Windows.Forms.Button      btnUpdate;
        private System.Windows.Forms.Button      btnDelete;
        private System.Windows.Forms.Label       lblSearch;
        private System.Windows.Forms.TextBox     txtSearch;
        private System.Windows.Forms.Button      btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.TextBox txtIdUser;
    }
}
