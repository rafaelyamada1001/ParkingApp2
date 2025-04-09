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
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            dgvConfigEstacionamento = new DataGridView();
            VagasCarros = new DataGridViewTextBoxColumn();
            VagasMotos = new DataGridViewTextBoxColumn();
            ValorHora = new DataGridViewTextBoxColumn();
            tbcGerenciador.SuspendLayout();
            tbpGerenciador.SuspendLayout();
            tbpFinanceiro.SuspendLayout();
            grpVagasDisponiveis.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfigEstacionamento).BeginInit();
            SuspendLayout();
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            lblTipoVeiculo.Location = new Point(35, 201);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(185, 20);
            lblTipoVeiculo.TabIndex = 9;
            lblTipoVeiculo.Text = "Selecione o tipo do veículo:";
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(253, 201);
            cmbTipoVeiculo.Margin = new Padding(3, 4, 3, 4);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(161, 28);
            cmbTipoVeiculo.TabIndex = 8;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.Transparent;
            btnRelatorio.Location = new Point(23, 32);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(119, 29);
            btnRelatorio.TabIndex = 7;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += button1_Click;
            // 
            // btnSairMenu
            // 
            btnSairMenu.BackColor = SystemColors.MenuHighlight;
            btnSairMenu.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            btnSairMenu.ForeColor = SystemColors.ControlText;
            btnSairMenu.Location = new Point(840, 523);
            btnSairMenu.Margin = new Padding(3, 4, 3, 4);
            btnSairMenu.Name = "btnSairMenu";
            btnSairMenu.Size = new Size(86, 37);
            btnSairMenu.TabIndex = 6;
            btnSairMenu.Text = "Sair";
            btnSairMenu.UseVisualStyleBackColor = false;
            btnSairMenu.Click += btnSairMenu_Click;
            // 
            // btnRemoverVeiculo
            // 
            btnRemoverVeiculo.BackColor = SystemColors.MenuHighlight;
            btnRemoverVeiculo.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            btnRemoverVeiculo.Image = (Image)resources.GetObject("btnRemoverVeiculo.Image");
            btnRemoverVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoverVeiculo.Location = new Point(253, 370);
            btnRemoverVeiculo.Margin = new Padding(3, 4, 3, 4);
            btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            btnRemoverVeiculo.Size = new Size(197, 39);
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
            btnAdicionarVeiculo.Location = new Point(35, 370);
            btnAdicionarVeiculo.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            btnAdicionarVeiculo.Size = new Size(201, 39);
            btnAdicionarVeiculo.TabIndex = 2;
            btnAdicionarVeiculo.Text = "Adicionar Veículo";
            btnAdicionarVeiculo.UseVisualStyleBackColor = false;
            btnAdicionarVeiculo.Click += btnAdicionarVeiculo_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(101, 309);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(276, 25);
            txtPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            lblPlaca.Location = new Point(150, 274);
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
            tbcGerenciador.Location = new Point(14, 26);
            tbcGerenciador.Margin = new Padding(3, 4, 3, 4);
            tbcGerenciador.Name = "tbcGerenciador";
            tbcGerenciador.SelectedIndex = 0;
            tbcGerenciador.Size = new Size(490, 490);
            tbcGerenciador.TabIndex = 10;
            // 
            // tbpGerenciador
            // 
            tbpGerenciador.BackgroundImageLayout = ImageLayout.Stretch;
            tbpGerenciador.Controls.Add(flowLayoutPanel1);
            tbpGerenciador.Controls.Add(cmbTipoVeiculo);
            tbpGerenciador.Controls.Add(lblTipoVeiculo);
            tbpGerenciador.Controls.Add(btnAdicionarVeiculo);
            tbpGerenciador.Controls.Add(btnRemoverVeiculo);
            tbpGerenciador.Controls.Add(txtPlaca);
            tbpGerenciador.Controls.Add(lblPlaca);
            tbpGerenciador.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            tbpGerenciador.Location = new Point(4, 27);
            tbpGerenciador.Margin = new Padding(3, 4, 3, 4);
            tbpGerenciador.Name = "tbpGerenciador";
            tbpGerenciador.Padding = new Padding(3, 4, 3, 4);
            tbpGerenciador.Size = new Size(482, 459);
            tbpGerenciador.TabIndex = 0;
            tbpGerenciador.Text = "Estacionamento";
            tbpGerenciador.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel1.Location = new Point(119, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(248, 159);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // tbpFinanceiro
            // 
            tbpFinanceiro.Controls.Add(btnRelatorio);
            tbpFinanceiro.ForeColor = SystemColors.ControlText;
            tbpFinanceiro.Location = new Point(4, 27);
            tbpFinanceiro.Margin = new Padding(3, 4, 3, 4);
            tbpFinanceiro.Name = "tbpFinanceiro";
            tbpFinanceiro.Padding = new Padding(3, 4, 3, 4);
            tbpFinanceiro.Size = new Size(482, 459);
            tbpFinanceiro.TabIndex = 1;
            tbpFinanceiro.Text = "Financeiro";
            tbpFinanceiro.UseVisualStyleBackColor = true;
            // 
            // txtVagasCarros
            // 
            txtVagasCarros.Location = new Point(131, 30);
            txtVagasCarros.Margin = new Padding(3, 4, 3, 4);
            txtVagasCarros.Name = "txtVagasCarros";
            txtVagasCarros.ReadOnly = true;
            txtVagasCarros.Size = new Size(89, 24);
            txtVagasCarros.TabIndex = 0;
            // 
            // txtVagasMotos
            // 
            txtVagasMotos.Location = new Point(131, 75);
            txtVagasMotos.Margin = new Padding(3, 4, 3, 4);
            txtVagasMotos.Name = "txtVagasMotos";
            txtVagasMotos.ReadOnly = true;
            txtVagasMotos.Size = new Size(89, 24);
            txtVagasMotos.TabIndex = 1;
            // 
            // grpVagasDisponiveis
            // 
            grpVagasDisponiveis.Controls.Add(lblMotos);
            grpVagasDisponiveis.Controls.Add(lblCarros);
            grpVagasDisponiveis.Controls.Add(txtVagasMotos);
            grpVagasDisponiveis.Controls.Add(txtVagasCarros);
            grpVagasDisponiveis.Location = new Point(511, 46);
            grpVagasDisponiveis.Margin = new Padding(3, 4, 3, 4);
            grpVagasDisponiveis.Name = "grpVagasDisponiveis";
            grpVagasDisponiveis.Padding = new Padding(3, 4, 3, 4);
            grpVagasDisponiveis.Size = new Size(394, 119);
            grpVagasDisponiveis.TabIndex = 12;
            grpVagasDisponiveis.TabStop = false;
            grpVagasDisponiveis.Text = "Vagas Disponíveis";
            // 
            // lblMotos
            // 
            lblMotos.AutoSize = true;
            lblMotos.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            lblMotos.Location = new Point(37, 75);
            lblMotos.Name = "lblMotos";
            lblMotos.Size = new Size(77, 17);
            lblMotos.TabIndex = 3;
            lblMotos.Text = "\U0001f6f5 Motos :";
            // 
            // lblCarros
            // 
            lblCarros.AutoSize = true;
            lblCarros.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarros.Location = new Point(37, 32);
            lblCarros.Name = "lblCarros";
            lblCarros.Size = new Size(77, 17);
            lblCarros.TabIndex = 2;
            lblCarros.Text = "🚗 Carros :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(506, 172);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(419, 345);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvVeiculosEstacionados);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(411, 314);
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
            dgvVeiculosEstacionados.Location = new Point(0, 4);
            dgvVeiculosEstacionados.Margin = new Padding(3, 4, 3, 4);
            dgvVeiculosEstacionados.Name = "dgvVeiculosEstacionados";
            dgvVeiculosEstacionados.ReadOnly = true;
            dgvVeiculosEstacionados.Size = new Size(411, 287);
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
            tabPage2.Controls.Add(dgvConfigEstacionamento);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(411, 314);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConfigEstacionamento
            // 
            dgvConfigEstacionamento.AllowUserToAddRows = false;
            dgvConfigEstacionamento.AllowUserToDeleteRows = false;
            dgvConfigEstacionamento.BackgroundColor = SystemColors.ControlLightLight;
            dgvConfigEstacionamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfigEstacionamento.Columns.AddRange(new DataGridViewColumn[] { VagasCarros, VagasMotos, ValorHora });
            dgvConfigEstacionamento.Location = new Point(0, 0);
            dgvConfigEstacionamento.Margin = new Padding(3, 4, 3, 4);
            dgvConfigEstacionamento.Name = "dgvConfigEstacionamento";
            dgvConfigEstacionamento.Size = new Size(411, 285);
            dgvConfigEstacionamento.TabIndex = 0;
            dgvConfigEstacionamento.CellEndEdit += dgvConfigEstacionamento_CellEndEdit;
            // 
            // VagasCarros
            // 
            VagasCarros.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VagasCarros.DataPropertyName = "TotalVagasCarros";
            VagasCarros.HeaderText = "Vagas Carros";
            VagasCarros.Name = "VagasCarros";
            // 
            // VagasMotos
            // 
            VagasMotos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VagasMotos.DataPropertyName = "TotalVagasMotos";
            VagasMotos.HeaderText = "Vagas Motos";
            VagasMotos.Name = "VagasMotos";
            // 
            // ValorHora
            // 
            ValorHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ValorHora.DataPropertyName = "ValorHora";
            ValorHora.HeaderText = "Valor Hora";
            ValorHora.Name = "ValorHora";
            // 
            // FrmParkingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(966, 565);
            Controls.Add(tabControl1);
            Controls.Add(grpVagasDisponiveis);
            Controls.Add(tbcGerenciador);
            Controls.Add(btnSairMenu);
            Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmParkingApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking App";
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
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConfigEstacionamento).EndInit();
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
        private DataGridView dgvConfigEstacionamento;
        private DataGridViewTextBoxColumn TipoVeiculo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn VagasCarros;
        private DataGridViewTextBoxColumn VagasMotos;
        private DataGridViewTextBoxColumn ValorHora;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}