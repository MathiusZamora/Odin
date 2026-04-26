namespace ODIN
{
    partial class FrmLogin
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
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblSubtitulo);
            panelPrincipal.Controls.Add(lblUsuario);
            panelPrincipal.Controls.Add(txtUsuario);
            panelPrincipal.Controls.Add(lblClave);
            panelPrincipal.Controls.Add(txtClave);
            panelPrincipal.Controls.Add(btnIngresar);
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Location = new Point(44, 56);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(350, 438);
            panelPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(118, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 80, 140);
            lblTitulo.Location = new Point(83, 173);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "ODIN";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(83, 218);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(201, 19);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Gestión de Tickets e Incidencias";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(52, 244);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 19);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(52, 267);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(246, 25);
            txtUsuario.TabIndex = 4;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClave.Location = new Point(52, 305);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(84, 19);
            lblClave.TabIndex = 5;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.Location = new Point(52, 328);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(246, 25);
            txtClave.TabIndex = 6;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(40, 167, 69);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(52, 375);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(114, 42);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(184, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(438, 506);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ODIN - Iniciar Sesión";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // === DECLARACIÓN DE CONTROLES ===
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
    }
}