namespace ParkingApp2._0
{
    partial class FrmMenu
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
            grpMenu = new GroupBox();
            btnRelatorio = new Button();
            btnSairMenu = new Button();
            btnVagasLivres = new Button();
            btnListarVeiculos = new Button();
            btnRemoverVeiculo = new Button();
            btnAdicionarVeiculo = new Button();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            grpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnRelatorio);
            grpMenu.Controls.Add(btnSairMenu);
            grpMenu.Controls.Add(btnVagasLivres);
            grpMenu.Controls.Add(btnListarVeiculos);
            grpMenu.Controls.Add(btnRemoverVeiculo);
            grpMenu.Controls.Add(btnAdicionarVeiculo);
            grpMenu.Controls.Add(txtPlaca);
            grpMenu.Controls.Add(lblPlaca);
            grpMenu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMenu.Location = new Point(12, 12);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(442, 423);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menu :";
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(227, 245);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(176, 31);
            btnRelatorio.TabIndex = 7;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += button1_Click;
            // 
            // btnSairMenu
            // 
            btnSairMenu.Location = new Point(361, 385);
            btnSairMenu.Name = "btnSairMenu";
            btnSairMenu.Size = new Size(75, 23);
            btnSairMenu.TabIndex = 6;
            btnSairMenu.Text = "Sair";
            btnSairMenu.UseVisualStyleBackColor = true;
            btnSairMenu.Click += btnSairMenu_Click;
            // 
            // btnVagasLivres
            // 
            btnVagasLivres.Location = new Point(22, 327);
            btnVagasLivres.Name = "btnVagasLivres";
            btnVagasLivres.Size = new Size(176, 34);
            btnVagasLivres.TabIndex = 5;
            btnVagasLivres.Text = "Vagas Livres";
            btnVagasLivres.UseVisualStyleBackColor = true;
            btnVagasLivres.Click += btnVagasLivres_Click;
            // 
            // btnListarVeiculos
            // 
            btnListarVeiculos.Location = new Point(22, 245);
            btnListarVeiculos.Name = "btnListarVeiculos";
            btnListarVeiculos.Size = new Size(176, 31);
            btnListarVeiculos.TabIndex = 4;
            btnListarVeiculos.Text = "Listar Veículos";
            btnListarVeiculos.UseVisualStyleBackColor = true;
            btnListarVeiculos.Click += btnListarVeiculos_Click;
            // 
            // btnRemoverVeiculo
            // 
            btnRemoverVeiculo.Location = new Point(227, 155);
            btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            btnRemoverVeiculo.Size = new Size(176, 32);
            btnRemoverVeiculo.TabIndex = 3;
            btnRemoverVeiculo.Text = "Remover Veículo";
            btnRemoverVeiculo.UseVisualStyleBackColor = true;
            btnRemoverVeiculo.Click += btnRemoverVeiculo_Click;
            // 
            // btnAdicionarVeiculo
            // 
            btnAdicionarVeiculo.Location = new Point(22, 155);
            btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            btnAdicionarVeiculo.Size = new Size(176, 32);
            btnAdicionarVeiculo.TabIndex = 2;
            btnAdicionarVeiculo.Text = "Adicionar Veículo";
            btnAdicionarVeiculo.UseVisualStyleBackColor = true;
            btnAdicionarVeiculo.Click += btnAdicionarVeiculo_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(22, 86);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(381, 26);
            txtPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(22, 54);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(186, 18);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Digite a placa do veículo :";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 447);
            Controls.Add(grpMenu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMenu;
        private Button btnSairMenu;
        private Button btnVagasLivres;
        private Button btnListarVeiculos;
        private Button btnRemoverVeiculo;
        private Button btnAdicionarVeiculo;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private Button btnRelatorio;
    }
}