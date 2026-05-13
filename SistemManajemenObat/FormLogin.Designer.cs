namespace SistemManajemenObat
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle    = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin    = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnConnect  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(50, 40);
            this.lblTitle.Text      = "Sistem Manajemen Obat";

            // lblUsername
            this.lblUsername.AutoSize  = true;
            this.lblUsername.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblUsername.Location  = new System.Drawing.Point(50, 100);
            this.lblUsername.Text      = "Username";

            // lblPassword
            this.lblPassword.AutoSize  = true;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPassword.Location  = new System.Drawing.Point(50, 165);
            this.lblPassword.Text      = "Password";

            // txtUsername
            this.txtUsername.Font     = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(50, 122);
            this.txtUsername.Size     = new System.Drawing.Size(280, 27);

            // txtPassword
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location     = new System.Drawing.Point(50, 187);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(280, 27);

            // btnLogin
            this.btnLogin.BackColor             = System.Drawing.Color.FromArgb(167, 199, 231);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font                  = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor             = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnLogin.Location              = new System.Drawing.Point(50, 232);
            this.btnLogin.Size                  = new System.Drawing.Size(280, 40);
            this.btnLogin.Text                  = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.BackColor             = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font                  = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnRegister.ForeColor             = System.Drawing.Color.FromArgb(111, 168, 220);
            this.btnRegister.Location              = new System.Drawing.Point(50, 282);
            this.btnRegister.Size                  = new System.Drawing.Size(280, 28);
            this.btnRegister.Text                  = "Belum Punya Akun? Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnConnect
            this.btnConnect.BackColor             = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font                  = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnConnect.ForeColor             = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnConnect.Location              = new System.Drawing.Point(50, 316);
            this.btnConnect.Size                  = new System.Drawing.Size(280, 28);
            this.btnConnect.Text                  = "Tes Koneksi Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

            // FormLogin
            this.AutoScaleMode   = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor       = System.Drawing.Color.FromArgb(244, 248, 251);
            this.ClientSize      = new System.Drawing.Size(380, 390);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Login - Sistem Manajemen Obat";
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label  lblTitle;
        private System.Windows.Forms.Label  lblUsername;
        private System.Windows.Forms.Label  lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnConnect;
    }
}
