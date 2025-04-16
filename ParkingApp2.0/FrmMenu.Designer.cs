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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
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
            tpCadastro = new TabPage();
            grpCadastroPlano = new GroupBox();
            gpbCadastrarCliente = new GroupBox();
            mtxtTelefoneCliente = new MaskedTextBox();
            mtxtCpfCliente = new MaskedTextBox();
            btnCadastroCliente = new Button();
            txtSobrenomeCliente = new TextBox();
            lblSobreNomeCliente = new Label();
            txtNomeCliente = new TextBox();
            lblCpfCliente = new Label();
            lblTelefoneCliente = new Label();
            lblNomeCliente = new Label();
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
            txtCliente = new TextBox();
            lblCliente = new Label();
            btnRemoverCliente = new Button();
            btn = new Button();
            dgvClientes = new DataGridView();
            NomeCliente = new DataGridViewTextBoxColumn();
            SobrenomeCliente = new DataGridViewTextBoxColumn();
            CpfCliente = new DataGridViewTextBoxColumn();
            TelefoneCliente = new DataGridViewTextBoxColumn();
            grpGerenciarPlanos = new GroupBox();
            btnRenovar = new Button();
            button1 = new Button();
            tbcGerenciador.SuspendLayout();
            tbpGerenciador.SuspendLayout();
            tpCadastro.SuspendLayout();
            grpCadastroPlano.SuspendLayout();
            gpbCadastrarCliente.SuspendLayout();
            tbpFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            grpExibirValorPorData.SuspendLayout();
            grpVagasDisponiveis.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculosEstacionados).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfigEstacionamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grpGerenciarPlanos.SuspendLayout();
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
            txtPlaca.Location = new Point(103, 312);
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
            tbcGerenciador.Controls.Add(tpCadastro);
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
            // tpCadastro
            // 
            tpCadastro.Controls.Add(grpCadastroPlano);
            tpCadastro.Controls.Add(gpbCadastrarCliente);
            tpCadastro.Location = new Point(4, 27);
            tpCadastro.Name = "tpCadastro";
            tpCadastro.Padding = new Padding(3);
            tpCadastro.Size = new Size(532, 459);
            tpCadastro.TabIndex = 2;
            tpCadastro.Text = "Cadastro";
            tpCadastro.UseVisualStyleBackColor = true;
            // 
            // grpCadastroPlano
            // 
            grpCadastroPlano.Controls.Add(grpGerenciarPlanos);
            grpCadastroPlano.Controls.Add(dgvClientes);
            grpCadastroPlano.Controls.Add(btnRemoverCliente);
            grpCadastroPlano.Controls.Add(lblCliente);
            grpCadastroPlano.Controls.Add(txtCliente);
            grpCadastroPlano.Font = new Font("Noto Sans", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCadastroPlano.Location = new Point(6, 180);
            grpCadastroPlano.Name = "grpCadastroPlano";
            grpCadastroPlano.Size = new Size(520, 271);
            grpCadastroPlano.TabIndex = 1;
            grpCadastroPlano.TabStop = false;
            grpCadastroPlano.Text = "Gerenciar Clientes :";
            // 
            // gpbCadastrarCliente
            // 
            gpbCadastrarCliente.Controls.Add(mtxtTelefoneCliente);
            gpbCadastrarCliente.Controls.Add(mtxtCpfCliente);
            gpbCadastrarCliente.Controls.Add(btnCadastroCliente);
            gpbCadastrarCliente.Controls.Add(txtSobrenomeCliente);
            gpbCadastrarCliente.Controls.Add(lblSobreNomeCliente);
            gpbCadastrarCliente.Controls.Add(txtNomeCliente);
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
            // mtxtTelefoneCliente
            // 
            mtxtTelefoneCliente.Location = new Point(321, 72);
            mtxtTelefoneCliente.Mask = "(00) 00000-0000";
            mtxtTelefoneCliente.Name = "mtxtTelefoneCliente";
            mtxtTelefoneCliente.Size = new Size(151, 24);
            mtxtTelefoneCliente.TabIndex = 8;
            // 
            // mtxtCpfCliente
            // 
            mtxtCpfCliente.Location = new Point(68, 72);
            mtxtCpfCliente.Mask = "000.000.000-00";
            mtxtCpfCliente.Name = "mtxtCpfCliente";
            mtxtCpfCliente.Size = new Size(151, 24);
            mtxtCpfCliente.TabIndex = 7;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = SystemColors.MenuHighlight;
            btnCadastroCliente.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroCliente.Location = new Point(344, 120);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(128, 26);
            btnCadastroCliente.TabIndex = 5;
            btnCadastroCliente.Text = "Cadastrar Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // txtSobrenomeCliente
            // 
            txtSobrenomeCliente.Location = new Point(321, 29);
            txtSobrenomeCliente.Name = "txtSobrenomeCliente";
            txtSobrenomeCliente.Size = new Size(151, 24);
            txtSobrenomeCliente.TabIndex = 2;
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
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(69, 26);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(151, 24);
            txtNomeCliente.TabIndex = 1;
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
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Location = new Point(239, 75);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(65, 18);
            lblTelefoneCliente.TabIndex = 1;
            lblTelefoneCliente.Text = "Telefone :";
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
            dataGridViewCellStyle8.Format = "000-000";
            dataGridViewCellStyle8.NullValue = null;
            PlacaVeiculo.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            HoraEntradaRelatorio.DefaultCellStyle = dataGridViewCellStyle9;
            HoraEntradaRelatorio.HeaderText = "Hora Entrada";
            HoraEntradaRelatorio.Name = "HoraEntradaRelatorio";
            HoraEntradaRelatorio.ReadOnly = true;
            HoraEntradaRelatorio.Width = 5;
            // 
            // HoraSaidaRelatorio
            // 
            HoraSaidaRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            HoraSaidaRelatorio.DataPropertyName = "HoraSaida";
            dataGridViewCellStyle10.Format = "g";
            dataGridViewCellStyle10.NullValue = null;
            HoraSaidaRelatorio.DefaultCellStyle = dataGridViewCellStyle10;
            HoraSaidaRelatorio.HeaderText = "Hora Saida";
            HoraSaidaRelatorio.Name = "HoraSaidaRelatorio";
            HoraSaidaRelatorio.ReadOnly = true;
            HoraSaidaRelatorio.Width = 5;
            // 
            // PermanenciaHora
            // 
            PermanenciaHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PermanenciaHora.DataPropertyName = "PermanenciaHora";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            PermanenciaHora.DefaultCellStyle = dataGridViewCellStyle11;
            PermanenciaHora.HeaderText = "Hora";
            PermanenciaHora.Name = "PermanenciaHora";
            PermanenciaHora.ReadOnly = true;
            PermanenciaHora.Width = 59;
            // 
            // PermanenciaMin
            // 
            PermanenciaMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PermanenciaMin.DataPropertyName = "PermanenciaMin";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            PermanenciaMin.DefaultCellStyle = dataGridViewCellStyle12;
            PermanenciaMin.HeaderText = "Min";
            PermanenciaMin.Name = "PermanenciaMin";
            PermanenciaMin.ReadOnly = true;
            PermanenciaMin.Width = 52;
            // 
            // ValorRelatorio
            // 
            ValorRelatorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ValorRelatorio.DataPropertyName = "Valor";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            ValorRelatorio.DefaultCellStyle = dataGridViewCellStyle13;
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
            dgvVeiculosEstacionados.Location = new Point(-41, 17);
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            ValorHora.DefaultCellStyle = dataGridViewCellStyle14;
            ValorHora.HeaderText = "Valor Hora";
            ValorHora.Name = "ValorHora";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(69, 241);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(295, 22);
            txtCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 244);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 16);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente :";
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.BackColor = SystemColors.MenuHighlight;
            btnRemoverCliente.Location = new Point(393, 240);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(79, 23);
            btnRemoverCliente.TabIndex = 2;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.MenuHighlight;
            btn.Location = new Point(6, 40);
            btn.Name = "btn";
            btn.Size = new Size(89, 25);
            btn.TabIndex = 3;
            btn.Text = "Cadastrar";
            btn.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = SystemColors.ControlLightLight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { NomeCliente, SobrenomeCliente, CpfCliente, TelefoneCliente });
            dgvClientes.Location = new Point(-40, 13);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(447, 222);
            dgvClientes.TabIndex = 4;
            // 
            // NomeCliente
            // 
            NomeCliente.HeaderText = "Nome";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            // 
            // SobrenomeCliente
            // 
            SobrenomeCliente.HeaderText = "Sobrenome";
            SobrenomeCliente.Name = "SobrenomeCliente";
            SobrenomeCliente.ReadOnly = true;
            // 
            // CpfCliente
            // 
            CpfCliente.HeaderText = "CPF";
            CpfCliente.Name = "CpfCliente";
            CpfCliente.ReadOnly = true;
            // 
            // TelefoneCliente
            // 
            TelefoneCliente.HeaderText = "Telefone";
            TelefoneCliente.Name = "TelefoneCliente";
            TelefoneCliente.ReadOnly = true;
            // 
            // grpGerenciarPlanos
            // 
            grpGerenciarPlanos.Controls.Add(button1);
            grpGerenciarPlanos.Controls.Add(btnRenovar);
            grpGerenciarPlanos.Controls.Add(btn);
            grpGerenciarPlanos.Location = new Point(413, 13);
            grpGerenciarPlanos.Name = "grpGerenciarPlanos";
            grpGerenciarPlanos.Size = new Size(101, 174);
            grpGerenciarPlanos.TabIndex = 5;
            grpGerenciarPlanos.TabStop = false;
            grpGerenciarPlanos.Text = "Gerenciar Planos :";
            // 
            // btnRenovar
            // 
            btnRenovar.BackColor = SystemColors.MenuHighlight;
            btnRenovar.Location = new Point(6, 81);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(89, 23);
            btnRenovar.TabIndex = 4;
            btnRenovar.Text = "Renovar";
            btnRenovar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(6, 122);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmParkingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(937, 565);
            Controls.Add(tabControl1);
            Controls.Add(grpVagasDisponiveis);
            Controls.Add(btnSairMenu);
            Controls.Add(tbcGerenciador);
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
            tpCadastro.ResumeLayout(false);
            grpCadastroPlano.ResumeLayout(false);
            grpCadastroPlano.PerformLayout();
            gpbCadastrarCliente.ResumeLayout(false);
            gpbCadastrarCliente.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grpGerenciarPlanos.ResumeLayout(false);
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
        private TabPage tpCadastro;
        private GroupBox gpbCadastrarCliente;
        private TextBox txtNomeCliente;
        private Label lblCpfCliente;
        private Label lblTelefoneCliente;
        private Label lblNomeCliente;
        private Button btnCadastroCliente;
        private TextBox txtSobrenomeCliente;
        private Label lblSobreNomeCliente;
        private GroupBox grpCadastroPlano;
        private MaskedTextBox mtxtCpfCliente;
        private MaskedTextBox mtxtTelefoneCliente;
        private Label lblCliente;
        private TextBox txtCliente;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn SobrenomeCliente;
        private DataGridViewTextBoxColumn CpfCliente;
        private DataGridViewTextBoxColumn TelefoneCliente;
        private Button btnRemoverCliente;
        private Button btn;
        private GroupBox grpGerenciarPlanos;
        private Button button1;
        private Button btnRenovar;
    }
}