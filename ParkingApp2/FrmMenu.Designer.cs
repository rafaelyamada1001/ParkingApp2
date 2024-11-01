namespace ParkingApp2
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnAdicionarVeiculo = new System.Windows.Forms.Button();
            this.btnRemoverVeiculo = new System.Windows.Forms.Button();
            this.btnListarVeiculos = new System.Windows.Forms.Button();
            this.txtListarVeiculos = new System.Windows.Forms.Label();
            this.btnVagasLivres = new System.Windows.Forms.Button();
            this.txtVagasDisponiveis = new System.Windows.Forms.Label();
            this.btnSairMenu = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnSairMenu);
            this.grpMenu.Controls.Add(this.txtVagasDisponiveis);
            this.grpMenu.Controls.Add(this.btnVagasLivres);
            this.grpMenu.Controls.Add(this.txtListarVeiculos);
            this.grpMenu.Controls.Add(this.btnListarVeiculos);
            this.grpMenu.Controls.Add(this.btnRemoverVeiculo);
            this.grpMenu.Controls.Add(this.btnAdicionarVeiculo);
            this.grpMenu.Controls.Add(this.txtPlaca);
            this.grpMenu.Controls.Add(this.lblPlaca);
            this.grpMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 12);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(391, 369);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu :";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(13, 48);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(173, 18);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Insira a placa do veículo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(16, 76);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(272, 26);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnAdicionarVeiculo
            // 
            this.btnAdicionarVeiculo.Location = new System.Drawing.Point(16, 142);
            this.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            this.btnAdicionarVeiculo.Size = new System.Drawing.Size(165, 30);
            this.btnAdicionarVeiculo.TabIndex = 2;
            this.btnAdicionarVeiculo.Text = "Adicionar veículo";
            this.btnAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.btnAdicionarVeiculo.Click += new System.EventHandler(this.btnAdicionarVeiculo_Click);
            // 
            // btnRemoverVeiculo
            // 
            this.btnRemoverVeiculo.Location = new System.Drawing.Point(207, 142);
            this.btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            this.btnRemoverVeiculo.Size = new System.Drawing.Size(165, 30);
            this.btnRemoverVeiculo.TabIndex = 3;
            this.btnRemoverVeiculo.Text = "Remover Veiculo";
            this.btnRemoverVeiculo.UseVisualStyleBackColor = true;
            this.btnRemoverVeiculo.Click += new System.EventHandler(this.btnRemoverVeiculo_Click);
            // 
            // btnListarVeiculos
            // 
            this.btnListarVeiculos.Location = new System.Drawing.Point(16, 230);
            this.btnListarVeiculos.Name = "btnListarVeiculos";
            this.btnListarVeiculos.Size = new System.Drawing.Size(165, 30);
            this.btnListarVeiculos.TabIndex = 4;
            this.btnListarVeiculos.Text = "Listar Veículos";
            this.btnListarVeiculos.UseVisualStyleBackColor = true;
            this.btnListarVeiculos.Click += new System.EventHandler(this.btnListarVeiculos_Click);
            // 
            // txtListarVeiculos
            // 
            this.txtListarVeiculos.AutoSize = true;
            this.txtListarVeiculos.Location = new System.Drawing.Point(13, 209);
            this.txtListarVeiculos.Name = "txtListarVeiculos";
            this.txtListarVeiculos.Size = new System.Drawing.Size(217, 18);
            this.txtListarVeiculos.TabIndex = 5;
            this.txtListarVeiculos.Text = "Listar Veículos Estacionados :";
            // 
            // btnVagasLivres
            // 
            this.btnVagasLivres.Location = new System.Drawing.Point(16, 316);
            this.btnVagasLivres.Name = "btnVagasLivres";
            this.btnVagasLivres.Size = new System.Drawing.Size(165, 30);
            this.btnVagasLivres.TabIndex = 6;
            this.btnVagasLivres.Text = "Vagas Livres";
            this.btnVagasLivres.UseVisualStyleBackColor = true;
            this.btnVagasLivres.Click += new System.EventHandler(this.btnVagasLivres_Click);
            // 
            // txtVagasDisponiveis
            // 
            this.txtVagasDisponiveis.AutoSize = true;
            this.txtVagasDisponiveis.Location = new System.Drawing.Point(13, 295);
            this.txtVagasDisponiveis.Name = "txtVagasDisponiveis";
            this.txtVagasDisponiveis.Size = new System.Drawing.Size(146, 18);
            this.txtVagasDisponiveis.TabIndex = 7;
            this.txtVagasDisponiveis.Text = "Vagas Disponíveis :";
            // 
            // btnSairMenu
            // 
            this.btnSairMenu.Location = new System.Drawing.Point(293, 316);
            this.btnSairMenu.Name = "btnSairMenu";
            this.btnSairMenu.Size = new System.Drawing.Size(79, 30);
            this.btnSairMenu.TabIndex = 8;
            this.btnSairMenu.Text = "Sair";
            this.btnSairMenu.UseVisualStyleBackColor = true;
            this.btnSairMenu.Click += new System.EventHandler(this.btnSairMenu_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 393);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnListarVeiculos;
        private System.Windows.Forms.Button btnRemoverVeiculo;
        private System.Windows.Forms.Button btnAdicionarVeiculo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnSairMenu;
        private System.Windows.Forms.Label txtVagasDisponiveis;
        private System.Windows.Forms.Button btnVagasLivres;
        private System.Windows.Forms.Label txtListarVeiculos;
    }
}