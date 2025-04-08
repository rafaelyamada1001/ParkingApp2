namespace ParkingApp2._0
{
    partial class FrmParkingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParkingApp));
            lblTipoVeiculo = new Label();
            cmbTipoVeiculo = new ComboBox();
            btnRelatorio = new Button();
            btnSairMenu = new Button();
            btnRemoverVeiculo = new Button();
            btnAdicionarVeiculo = new Button();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            tbcGerenciador = new TabControl();
            tbpGerenciador = new TabPage();
            tbpFinanceiro = new TabPage();
            txtVagasCarros = new TextBox();
            txtVagasMotos = new TextBox();
            grpVagasDisponiveis = new GroupBox();
            lblMotos = new Label();
            lblCarros = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvVeiculosEstacionados = new DataGridView();
            TipoVeiculo = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tbcGerenciador.SuspendLayout();
            tbpGerenciador.SuspendLayout();
            tbpFinanceiro.SuspendLayout();
            grpVagasDisponiveis.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).BeginInit();
            SuspendLayout();
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            lblTipoVeiculo.Location = new Point(29, 97);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(185, 20);
            lblTipoVeiculo.TabIndex = 9;
            lblTipoVeiculo.Text = "Selecione o tipo do veículo:";
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(220, 97);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(141, 28);
            cmbTipoVeiculo.TabIndex = 8;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(20, 27);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(104, 24);
            btnRelatorio.TabIndex = 7;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += button1_Click;
            // 
            // btnSairMenu
            // 
            btnSairMenu.Location = new Point(735, 436);
            btnSairMenu.Name = "btnSairMenu";
            btnSairMenu.Size = new Size(75, 23);
            btnSairMenu.TabIndex = 6;
            btnSairMenu.Text = "Sair";
            btnSairMenu.UseVisualStyleBackColor = true;
            btnSairMenu.Click += btnSairMenu_Click;
            // 
            // btnRemoverVeiculo
            // 
            btnRemoverVeiculo.BackColor = SystemColors.MenuHighlight;
            btnRemoverVeiculo.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            btnRemoverVeiculo.Image = (Image)resources.GetObject("btnRemoverVeiculo.Image");
            btnRemoverVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoverVeiculo.Location = new Point(220, 249);
            btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            btnRemoverVeiculo.Size = new Size(170, 32);
            btnRemoverVeiculo.TabIndex = 3;
            btnRemoverVeiculo.Text = "Remover Veículo";
            btnRemoverVeiculo.UseVisualStyleBackColor = false;
            btnRemoverVeiculo.Click += btnRemoverVeiculo_Click;
            // 
            // btnAdicionarVeiculo
            // 
            btnAdicionarVeiculo.BackColor = SystemColors.MenuHighlight;
            btnAdicionarVeiculo.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarVeiculo.Image = (Image)resources.GetObject("btnAdicionarVeiculo.Image");
            btnAdicionarVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarVeiculo.Location = new Point(29, 249);
            btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            btnAdicionarVeiculo.Size = new Size(176, 32);
            btnAdicionarVeiculo.TabIndex = 2;
            btnAdicionarVeiculo.Text = "Adicionar Veículo";
            btnAdicionarVeiculo.UseVisualStyleBackColor = false;
            btnAdicionarVeiculo.Click += btnAdicionarVeiculo_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(102, 198);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(233, 25);
            txtPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            lblPlaca.Location = new Point(121, 166);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(174, 20);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Digite a placa do veículo :";
            // 
            // tbcGerenciador
            // 
            tbcGerenciador.AccessibleName = "";
            tbcGerenciador.Controls.Add(tbpGerenciador);
            tbcGerenciador.Controls.Add(tbpFinanceiro);
            tbcGerenciador.Location = new Point(12, 22);
            tbcGerenciador.Name = "tbcGerenciador";
            tbcGerenciador.SelectedIndex = 0;
            tbcGerenciador.Size = new Size(429, 408);
            tbcGerenciador.TabIndex = 10;
            // 
            // tbpGerenciador
            // 
            tbpGerenciador.Controls.Add(cmbTipoVeiculo);
            tbpGerenciador.Controls.Add(lblTipoVeiculo);
            tbpGerenciador.Controls.Add(btnAdicionarVeiculo);
            tbpGerenciador.Controls.Add(btnRemoverVeiculo);
            tbpGerenciador.Controls.Add(txtPlaca);
            tbpGerenciador.Controls.Add(lblPlaca);
            tbpGerenciador.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            tbpGerenciador.Location = new Point(4, 24);
            tbpGerenciador.Name = "tbpGerenciador";
            tbpGerenciador.Padding = new Padding(3);
            tbpGerenciador.Size = new Size(421, 380);
            tbpGerenciador.TabIndex = 0;
            tbpGerenciador.Text = "Estacionamento";
            tbpGerenciador.UseVisualStyleBackColor = true;
            // 
            // tbpFinanceiro
            // 
            tbpFinanceiro.Controls.Add(btnRelatorio);
            tbpFinanceiro.ForeColor = SystemColors.ControlText;
            tbpFinanceiro.Location = new Point(4, 24);
            tbpFinanceiro.Name = "tbpFinanceiro";
            tbpFinanceiro.Padding = new Padding(3);
            tbpFinanceiro.Size = new Size(421, 380);
            tbpFinanceiro.TabIndex = 1;
            tbpFinanceiro.Text = "Financeiro";
            tbpFinanceiro.UseVisualStyleBackColor = true;
            // 
            // txtVagasCarros
            // 
            txtVagasCarros.Location = new Point(115, 25);
            txtVagasCarros.Name = "txtVagasCarros";
            txtVagasCarros.ReadOnly = true;
            txtVagasCarros.Size = new Size(78, 23);
            txtVagasCarros.TabIndex = 0;
            // 
            // txtVagasMotos
            // 
            txtVagasMotos.Location = new Point(115, 62);
            txtVagasMotos.Name = "txtVagasMotos";
            txtVagasMotos.ReadOnly = true;
            txtVagasMotos.Size = new Size(78, 23);
            txtVagasMotos.TabIndex = 1;
            // 
            // grpVagasDisponiveis
            // 
            grpVagasDisponiveis.Controls.Add(lblMotos);
            grpVagasDisponiveis.Controls.Add(lblCarros);
            grpVagasDisponiveis.Controls.Add(txtVagasMotos);
            grpVagasDisponiveis.Controls.Add(txtVagasCarros);
            grpVagasDisponiveis.Location = new Point(447, 38);
            grpVagasDisponiveis.Name = "grpVagasDisponiveis";
            grpVagasDisponiveis.Size = new Size(345, 99);
            grpVagasDisponiveis.TabIndex = 12;
            grpVagasDisponiveis.TabStop = false;
            grpVagasDisponiveis.Text = "Vagas Disponíveis";
            // 
            // lblMotos
            // 
            lblMotos.AutoSize = true;
            lblMotos.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            lblMotos.Location = new Point(32, 62);
            lblMotos.Name = "lblMotos";
            lblMotos.Size = new Size(77, 17);
            lblMotos.TabIndex = 3;
            lblMotos.Text = "\U0001f6f5 Motos :";
            // 
            // lblCarros
            // 
            lblCarros.AutoSize = true;
            lblCarros.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarros.Location = new Point(32, 26);
            lblCarros.Name = "lblCarros";
            lblCarros.Size = new Size(77, 17);
            lblCarros.TabIndex = 2;
            lblCarros.Text = "🚗 Carros :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(443, 143);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(367, 287);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvVeiculosEstacionados);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(359, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Veículos Estacionados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVeiculosEstacionados
            // 
            dgvVeiculosEstacionados.AllowUserToDeleteRows = false;
            dgvVeiculosEstacionados.BackgroundColor = SystemColors.ControlLightLight;
            dgvVeiculosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculosEstacionados.Columns.AddRange(new DataGridViewColumn[] { TipoVeiculo, Placa, HoraEntrada });
            dgvVeiculosEstacionados.Location = new Point(0, 6);
            dgvVeiculosEstacionados.Name = "dgvVeiculosEstacionados";
            dgvVeiculosEstacionados.ReadOnly = true;
            dgvVeiculosEstacionados.Size = new Size(353, 237);
            dgvVeiculosEstacionados.TabIndex = 0;
            dgvVeiculosEstacionados.CellDoubleClick += dgvVeiculosEstacionados_CellDoubleClick;
            // 
            // TipoVeiculo
            // 
            TipoVeiculo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoVeiculo.DataPropertyName = "TipoVeiculo";
            TipoVeiculo.HeaderText = "Tipo Veículo";
            TipoVeiculo.Name = "TipoVeiculo";
            TipoVeiculo.ReadOnly = true;
            // 
            // Placa
            // 
            Placa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Placa.DataPropertyName = "Placa";
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            HoraEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoraEntrada.DataPropertyName = "HoraEntrada";
            HoraEntrada.HeaderText = "Hora Entrada";
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(359, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmParkingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(845, 471);
            Controls.Add(tabControl1);
            Controls.Add(grpVagasDisponiveis);
            Controls.Add(tbcGerenciador);
            Controls.Add(btnSairMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmParkingApp";
            Text = "FrmMenu";
            Load += FrmParkingApp_Load;
            tbcGerenciador.ResumeLayout(false);
            tbpGerenciador.ResumeLayout(false);
            tbpGerenciador.PerformLayout();
            tbpFinanceiro.ResumeLayout(false);
            grpVagasDisponiveis.ResumeLayout(false);
            grpVagasDisponiveis.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSairMenu;
        private Button btnRemoverVeiculo;
        private Button btnAdicionarVeiculo;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private Button btnRelatorio;
        private Label lblTipoVeiculo;
        private ComboBox cmbTipoVeiculo;
        private TabControl tbcGerenciador;
        private TabPage tbpGerenciador;
        private TabPage tbpFinanceiro;
        private TextBox txtVagasCarros;
        private TextBox txtVagasMotos;
        private GroupBox grpVagasDisponiveis;
        private Label lblCarros;
        private Label lblMotos;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvVeiculosEstacionados;
        private DataGridViewTextBoxColumn TipoVeiculo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn HoraEntrada;
    }
}