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
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            lblTipoVeiculo = new Label();
            cmbTipoVeiculo = new ComboBox();
            btnFiltrar = new Button();
            btnSairMenu = new Button();
            btnRemoverVeiculo = new Button();
            btnAdicionarVeiculo = new Button();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            tbcGerenciador = new TabControl();
            tbpGerenciador = new TabPage();
            btnEditar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbpFinanceiro = new TabPage();
            dgvRelatorio = new DataGridView();
            PlacaVeiculo = new DataGridViewTextBoxColumn();
            TipoVeiculoRelatorio = new DataGridViewTextBoxColumn();
            HoraEntradaRelatorio = new DataGridViewTextBoxColumn();
            HoraSaidaRelatorio = new DataGridViewTextBoxColumn();
            PermanenciaHora = new DataGridViewTextBoxColumn();
            PermanenciaMin = new DataGridViewTextBoxColumn();
            ValorRelatorio = new DataGridViewTextBoxColumn();
            grpExibirValorPorData = new GroupBox();
            lblReal = new Label();
            lblDataInicial = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            dtpDataInicial = new DateTimePicker();
            lblDataFinal = new Label();
            dtpDataFinal = new DateTimePicker();
            txtVagasCarros = new TextBox();
            txtVagasMotos = new TextBox();
            grpVagasDisponiveis = new GroupBox();
            lblMotos = new Label();
            lblCarros = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvVeiculosEstacionados = new DataGridView();
            Placa = new DataGridViewTextBoxColumn();
            TipoVeiculo = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dgvConfigEstacionamento = new DataGridView();
            VagasCarros = new DataGridViewTextBoxColumn();
            VagasMotos = new DataGridViewTextBoxColumn();
            ValorHora = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            gpbCadastrarCliente = new GroupBox();
            lblNomeCliente = new Label();
            lblTelefoneCliente = new Label();
            lblCpfCliente = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblSobreNomeCliente = new Label();
            textBox4 = new TextBox();
            btnCadastroCliente = new Button();
            grpCadastroPlano = new GroupBox();
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            lblPlano = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dtpInicioPlano = new DateTimePicker();
            btnCadastrarPlano = new Button();
            tbcGerenciador.SuspendLayout();
            tbpGerenciador.SuspendLayout();
            tbpFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            grpExibirValorPorData.SuspendLayout();
            grpVagasDisponiveis.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfigEstacionamento).BeginInit();
            tabPage3.SuspendLayout();
            gpbCadastrarCliente.SuspendLayout();
            grpCadastroPlano.SuspendLayout();
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
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.MenuHighlight;
            btnFiltrar.Location = new Point(419, 68);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(85, 26);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += button1_Click;
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
            btnRemoverVeiculo.Location = new Point(181, 370);
            btnRemoverVeiculo.Margin = new Padding(3, 4, 3, 4);
            btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            btnRemoverVeiculo.Size = new Size(169, 39);
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
            btnAdicionarVeiculo.Location = new Point(6, 370);
            btnAdicionarVeiculo.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            btnAdicionarVeiculo.Size = new Size(169, 39);
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
            tbcGerenciador.Controls.Add(tabPage3);
            tbcGerenciador.Controls.Add(tbpGerenciador);
            tbcGerenciador.Controls.Add(tbpFinanceiro);
            tbcGerenciador.Location = new Point(14, 26);
            tbcGerenciador.Margin = new Padding(3, 4, 3, 4);
            tbcGerenciador.Name = "tbcGerenciador";
            tbcGerenciador.SelectedIndex = 0;
            tbcGerenciador.Size = new Size(540, 490);
            tbcGerenciador.TabIndex = 10;
            // 
            // tbpGerenciador
            // 
            tbpGerenciador.BackgroundImageLayout = ImageLayout.Stretch;
            tbpGerenciador.Controls.Add(btnEditar);
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
            tbpGerenciador.Size = new Size(532, 459);
            tbpGerenciador.TabIndex = 0;
            tbpGerenciador.Text = "Estacionamento";
            tbpGerenciador.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.MenuHighlight;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(357, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(169, 39);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar Veículo";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            tbpFinanceiro.Controls.Add(dgvRelatorio);
            tbpFinanceiro.Controls.Add(grpExibirValorPorData);
            tbpFinanceiro.Font = new Font("Noto Sans", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbpFinanceiro.ForeColor = SystemColors.ControlText;
            tbpFinanceiro.Location = new Point(4, 27);
            tbpFinanceiro.Margin = new Padding(3, 4, 3, 4);
            tbpFinanceiro.Name = "tbpFinanceiro";
            tbpFinanceiro.Padding = new Padding(3, 4, 3, 4);
            tbpFinanceiro.Size = new Size(532, 459);
            tbpFinanceiro.TabIndex = 1;
            tbpFinanceiro.Text = "Relatório";
            tbpFinanceiro.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToDeleteRows = false;
            dgvRelatorio.BackgroundColor = SystemColors.ControlLightLight;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { PlacaVeiculo, TipoVeiculoRelatorio, HoraEntradaRelatorio, HoraSaidaRelatorio, PermanenciaHora, PermanenciaMin, ValorRelatorio });
            dgvRelatorio.Location = new Point(-41, 109);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.Size = new Size(570, 343);
            dgvRelatorio.TabIndex = 15;
            // 
            // PlacaVeiculo
            // 
            PlacaVeiculo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            PlacaVeiculo.DataPropertyName = "Placa";
            dataGridViewCellStyle22.Format = "000-000";
            dataGridViewCellStyle22.NullValue = null;
            PlacaVeiculo.DefaultCellStyle = dataGridViewCellStyle22;
            PlacaVeiculo.HeaderText = "Placa";
            PlacaVeiculo.Name = "PlacaVeiculo";
            PlacaVeiculo.ReadOnly = true;
            PlacaVeiculo.Width = 5;
            // 
            // TipoVeiculoRelatorio
            // 
            TipoVeiculoRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TipoVeiculoRelatorio.DataPropertyName = "TipoVeiculo";
            TipoVeiculoRelatorio.HeaderText = "Veiculo";
            TipoVeiculoRelatorio.Name = "TipoVeiculoRelatorio";
            TipoVeiculoRelatorio.ReadOnly = true;
            TipoVeiculoRelatorio.Width = 72;
            // 
            // HoraEntradaRelatorio
            // 
            HoraEntradaRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            HoraEntradaRelatorio.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle23.Format = "g";
            dataGridViewCellStyle23.NullValue = null;
            HoraEntradaRelatorio.DefaultCellStyle = dataGridViewCellStyle23;
            HoraEntradaRelatorio.HeaderText = "Hora Entrada";
            HoraEntradaRelatorio.Name = "HoraEntradaRelatorio";
            HoraEntradaRelatorio.ReadOnly = true;
            HoraEntradaRelatorio.Width = 5;
            // 
            // HoraSaidaRelatorio
            // 
            HoraSaidaRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            HoraSaidaRelatorio.DataPropertyName = "HoraSaida";
            dataGridViewCellStyle24.Format = "g";
            dataGridViewCellStyle24.NullValue = null;
            HoraSaidaRelatorio.DefaultCellStyle = dataGridViewCellStyle24;
            HoraSaidaRelatorio.HeaderText = "Hora Saida";
            HoraSaidaRelatorio.Name = "HoraSaidaRelatorio";
            HoraSaidaRelatorio.ReadOnly = true;
            HoraSaidaRelatorio.Width = 5;
            // 
            // PermanenciaHora
            // 
            PermanenciaHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PermanenciaHora.DataPropertyName = "PermanenciaHora";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            PermanenciaHora.DefaultCellStyle = dataGridViewCellStyle25;
            PermanenciaHora.HeaderText = "Hora";
            PermanenciaHora.Name = "PermanenciaHora";
            PermanenciaHora.ReadOnly = true;
            PermanenciaHora.Width = 59;
            // 
            // PermanenciaMin
            // 
            PermanenciaMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PermanenciaMin.DataPropertyName = "PermanenciaMin";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            PermanenciaMin.DefaultCellStyle = dataGridViewCellStyle26;
            PermanenciaMin.HeaderText = "Min";
            PermanenciaMin.Name = "PermanenciaMin";
            PermanenciaMin.ReadOnly = true;
            PermanenciaMin.Width = 52;
            // 
            // ValorRelatorio
            // 
            ValorRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ValorRelatorio.DataPropertyName = "Valor";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            ValorRelatorio.DefaultCellStyle = dataGridViewCellStyle27;
            ValorRelatorio.HeaderText = "Valor";
            ValorRelatorio.Name = "ValorRelatorio";
            ValorRelatorio.ReadOnly = true;
            ValorRelatorio.Width = 61;
            // 
            // grpExibirValorPorData
            // 
            grpExibirValorPorData.Controls.Add(lblReal);
            grpExibirValorPorData.Controls.Add(lblDataInicial);
            grpExibirValorPorData.Controls.Add(txtValor);
            grpExibirValorPorData.Controls.Add(btnFiltrar);
            grpExibirValorPorData.Controls.Add(lblValor);
            grpExibirValorPorData.Controls.Add(dtpDataInicial);
            grpExibirValorPorData.Controls.Add(lblDataFinal);
            grpExibirValorPorData.Controls.Add(dtpDataFinal);
            grpExibirValorPorData.Location = new Point(3, 3);
            grpExibirValorPorData.Name = "grpExibirValorPorData";
            grpExibirValorPorData.Size = new Size(523, 100);
            grpExibirValorPorData.TabIndex = 14;
            grpExibirValorPorData.TabStop = false;
            grpExibirValorPorData.Text = "Filtrar Valor Por Data:";
            // 
            // lblReal
            // 
            lblReal.AutoSize = true;
            lblReal.Location = new Point(419, 25);
            lblReal.Name = "lblReal";
            lblReal.Size = new Size(20, 16);
            lblReal.TabIndex = 14;
            lblReal.Text = "R$";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(6, 27);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(73, 16);
            lblDataInicial.TabIndex = 10;
            lblDataInicial.Text = "Data Inicial:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(448, 22);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(58, 22);
            txtValor.TabIndex = 13;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(374, 25);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(39, 16);
            lblValor.TabIndex = 12;
            lblValor.Text = "Valor:";
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(92, 22);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(200, 22);
            dtpDataInicial.TabIndex = 8;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(6, 70);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(66, 16);
            lblDataFinal.TabIndex = 11;
            lblDataFinal.Text = "Data Final:";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(92, 64);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(200, 22);
            dtpDataFinal.TabIndex = 9;
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
            grpVagasDisponiveis.Location = new Point(556, 46);
            grpVagasDisponiveis.Margin = new Padding(3, 4, 3, 4);
            grpVagasDisponiveis.Name = "grpVagasDisponiveis";
            grpVagasDisponiveis.Padding = new Padding(3, 4, 3, 4);
            grpVagasDisponiveis.Size = new Size(349, 119);
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
            tabControl1.Location = new Point(556, 172);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(369, 345);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvVeiculosEstacionados);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(361, 314);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Veículos Estacionados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVeiculosEstacionados
            // 
            dgvVeiculosEstacionados.AllowUserToDeleteRows = false;
            dgvVeiculosEstacionados.BackgroundColor = SystemColors.ControlLightLight;
            dgvVeiculosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculosEstacionados.Columns.AddRange(new DataGridViewColumn[] { Placa, TipoVeiculo, HoraEntrada });
            dgvVeiculosEstacionados.Location = new Point(-41, 4);
            dgvVeiculosEstacionados.Margin = new Padding(3, 4, 3, 4);
            dgvVeiculosEstacionados.Name = "dgvVeiculosEstacionados";
            dgvVeiculosEstacionados.ReadOnly = true;
            dgvVeiculosEstacionados.Size = new Size(402, 301);
            dgvVeiculosEstacionados.TabIndex = 0;
            dgvVeiculosEstacionados.CellDoubleClick += dgvVeiculosEstacionados_CellDoubleClick;
            // 
            // Placa
            // 
            Placa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Placa.DataPropertyName = "Placa";
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            // 
            // TipoVeiculo
            // 
            TipoVeiculo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoVeiculo.DataPropertyName = "TipoVeiculo";
            TipoVeiculo.HeaderText = "Tipo Veículo";
            TipoVeiculo.Name = "TipoVeiculo";
            TipoVeiculo.ReadOnly = true;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(361, 317);
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
            dgvConfigEstacionamento.Location = new Point(-40, 0);
            dgvConfigEstacionamento.Margin = new Padding(3, 4, 3, 4);
            dgvConfigEstacionamento.Name = "dgvConfigEstacionamento";
            dgvConfigEstacionamento.Size = new Size(401, 285);
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
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = null;
            ValorHora.DefaultCellStyle = dataGridViewCellStyle28;
            ValorHora.HeaderText = "Valor Hora";
            ValorHora.Name = "ValorHora";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(grpCadastroPlano);
            tabPage3.Controls.Add(gpbCadastrarCliente);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(532, 459);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cadastro";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // gpbCadastrarCliente
            // 
            gpbCadastrarCliente.Controls.Add(btnCadastroCliente);
            gpbCadastrarCliente.Controls.Add(textBox4);
            gpbCadastrarCliente.Controls.Add(lblSobreNomeCliente);
            gpbCadastrarCliente.Controls.Add(textBox3);
            gpbCadastrarCliente.Controls.Add(textBox2);
            gpbCadastrarCliente.Controls.Add(textBox1);
            gpbCadastrarCliente.Controls.Add(lblCpfCliente);
            gpbCadastrarCliente.Controls.Add(lblTelefoneCliente);
            gpbCadastrarCliente.Controls.Add(lblNomeCliente);
            gpbCadastrarCliente.Location = new Point(6, 10);
            gpbCadastrarCliente.Name = "gpbCadastrarCliente";
            gpbCadastrarCliente.Size = new Size(520, 164);
            gpbCadastrarCliente.TabIndex = 0;
            gpbCadastrarCliente.TabStop = false;
            gpbCadastrarCliente.Text = "Cadastrar Cliente :";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(0, 29);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(50, 18);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Nome :";
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Location = new Point(239, 75);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(65, 18);
            lblTelefoneCliente.TabIndex = 1;
            lblTelefoneCliente.Text = "Telefone :";
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.Location = new Point(0, 72);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(35, 18);
            lblCpfCliente.TabIndex = 2;
            lblCpfCliente.Text = "Cpf :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 24);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 24);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 24);
            textBox3.TabIndex = 5;
            // 
            // lblSobreNomeCliente
            // 
            lblSobreNomeCliente.AutoSize = true;
            lblSobreNomeCliente.Location = new Point(236, 29);
            lblSobreNomeCliente.Name = "lblSobreNomeCliente";
            lblSobreNomeCliente.Size = new Size(79, 18);
            lblSobreNomeCliente.TabIndex = 6;
            lblSobreNomeCliente.Text = "Sobrenome:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(321, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 24);
            textBox4.TabIndex = 7;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = SystemColors.MenuHighlight;
            btnCadastroCliente.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroCliente.Location = new Point(344, 120);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(128, 26);
            btnCadastroCliente.TabIndex = 8;
            btnCadastroCliente.Text = "Cadastrar Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // grpCadastroPlano
            // 
            grpCadastroPlano.Controls.Add(btnCadastrarPlano);
            grpCadastroPlano.Controls.Add(dtpInicioPlano);
            grpCadastroPlano.Controls.Add(label1);
            grpCadastroPlano.Controls.Add(comboBox1);
            grpCadastroPlano.Controls.Add(lblPlano);
            grpCadastroPlano.Controls.Add(lblCliente);
            grpCadastroPlano.Controls.Add(cmbCliente);
            grpCadastroPlano.Location = new Point(6, 180);
            grpCadastroPlano.Name = "grpCadastroPlano";
            grpCadastroPlano.Size = new Size(520, 271);
            grpCadastroPlano.TabIndex = 1;
            grpCadastroPlano.TabStop = false;
            grpCadastroPlano.Text = "Cadastro Plano :";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(19, 68);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 26);
            cmbCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(19, 47);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(57, 18);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente :";
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.Location = new Point(239, 47);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(113, 18);
            lblPlano.TabIndex = 2;
            lblPlano.Text = "Selecionar Plano :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 26);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 121);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 4;
            label1.Text = "Data Início Plano :";
            // 
            // dtpInicioPlano
            // 
            dtpInicioPlano.Location = new Point(19, 142);
            dtpInicioPlano.Name = "dtpInicioPlano";
            dtpInicioPlano.Size = new Size(200, 24);
            dtpInicioPlano.TabIndex = 5;
            // 
            // btnCadastrarPlano
            // 
            btnCadastrarPlano.BackColor = SystemColors.MenuHighlight;
            btnCadastrarPlano.Location = new Point(271, 142);
            btnCadastrarPlano.Name = "btnCadastrarPlano";
            btnCadastrarPlano.Size = new Size(116, 24);
            btnCadastrarPlano.TabIndex = 6;
            btnCadastrarPlano.Text = "Cadastrar-Plano";
            btnCadastrarPlano.UseVisualStyleBackColor = false;
            // 
            // FrmParkingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(937, 565);
            Controls.Add(tbcGerenciador);
            Controls.Add(tabControl1);
            Controls.Add(grpVagasDisponiveis);
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
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            grpExibirValorPorData.ResumeLayout(false);
            grpExibirValorPorData.PerformLayout();
            grpVagasDisponiveis.ResumeLayout(false);
            grpVagasDisponiveis.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConfigEstacionamento).EndInit();
            tabPage3.ResumeLayout(false);
            gpbCadastrarCliente.ResumeLayout(false);
            gpbCadastrarCliente.PerformLayout();
            grpCadastroPlano.ResumeLayout(false);
            grpCadastroPlano.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSairMenu;
        private Button btnRemoverVeiculo;
        private Button btnAdicionarVeiculo;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private Button btnFiltrar;
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
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFinal;
        private Label lblValor;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private TextBox txtValor;
        private GroupBox grpExibirValorPorData;
        private Label lblReal;
        private DataGridView dgvRelatorio;
        private Button btnEditar;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn TipoVeiculo;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn VagasCarros;
        private DataGridViewTextBoxColumn VagasMotos;
        private DataGridViewTextBoxColumn ValorHora;
        private DataGridViewTextBoxColumn PlacaVeiculo;
        private DataGridViewTextBoxColumn TipoVeiculoRelatorio;
        private DataGridViewTextBoxColumn HoraEntradaRelatorio;
        private DataGridViewTextBoxColumn HoraSaidaRelatorio;
        private DataGridViewTextBoxColumn PermanenciaHora;
        private DataGridViewTextBoxColumn PermanenciaMin;
        private DataGridViewTextBoxColumn ValorRelatorio;
        private TabPage tabPage3;
        private GroupBox gpbCadastrarCliente;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblCpfCliente;
        private Label lblTelefoneCliente;
        private Label lblNomeCliente;
        private Button btnCadastroCliente;
        private TextBox textBox4;
        private Label lblSobreNomeCliente;
        private TextBox textBox3;
        private GroupBox grpCadastroPlano;
        private ComboBox comboBox1;
        private Label lblPlano;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Button btnCadastrarPlano;
        private DateTimePicker dtpInicioPlano;
        private Label label1;
    }
}