namespace ParkingApp2._0
{
    partial class FrmPricipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpFormularioDeLogin = new GroupBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            btnSair = new Button();
            btnEntrar = new Button();
            grpFormularioDeLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpFormularioDeLogin
            // 
            grpFormularioDeLogin.Controls.Add(txtSenha);
            grpFormularioDeLogin.Controls.Add(txtUsuario);
            grpFormularioDeLogin.Controls.Add(lblSenha);
            grpFormularioDeLogin.Controls.Add(lblUsuario);
            grpFormularioDeLogin.Controls.Add(btnSair);
            grpFormularioDeLogin.Controls.Add(btnEntrar);
            grpFormularioDeLogin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFormularioDeLogin.Location = new Point(12, 7);
            grpFormularioDeLogin.Name = "grpFormularioDeLogin";
            grpFormularioDeLogin.Size = new Size(458, 200);
            grpFormularioDeLogin.TabIndex = 0;
            grpFormularioDeLogin.TabStop = false;
            grpFormularioDeLogin.Text = "Formulário De Login :";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 116);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(310, 26);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(29, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(310, 26);
            txtUsuario.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(29, 95);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 18);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha :";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 31);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 18);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário :";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(358, 160);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(277, 160);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 219);
            Controls.Add(grpFormularioDeLogin);
            Name = "FrmPricipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            grpFormularioDeLogin.ResumeLayout(false);
            grpFormularioDeLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFormularioDeLogin;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnSair;
        private Button btnEntrar;
    }
}
