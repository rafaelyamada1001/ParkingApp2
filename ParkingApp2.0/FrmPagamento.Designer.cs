namespace ParkingApp2._0
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            txtPlaca = new TextBox();
            txtTipoVeiculo = new TextBox();
            txtHoraEntrada = new TextBox();
            txtHoraSaida = new TextBox();
            txtTempoEstacionado = new TextBox();
            txtValorTotal = new TextBox();
            lblPlaca = new Label();
            lblTipoVeiculo = new Label();
            lblHoraEntrada = new Label();
            lblHoraSaida = new Label();
            lblTempoTotal = new Label();
            lblValorTotal = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnConfirmarPagamento = new Button();
            lblFormaDePagamento = new Label();
            cmbFormaDePagamento = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = SystemColors.ControlLightLight;
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.ForeColor = SystemColors.WindowText;
            txtPlaca.Location = new Point(216, 41);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(137, 18);
            txtPlaca.TabIndex = 0;
            // 
            // txtTipoVeiculo
            // 
            txtTipoVeiculo.BackColor = SystemColors.ControlLightLight;
            txtTipoVeiculo.BorderStyle = BorderStyle.None;
            txtTipoVeiculo.Location = new Point(216, 70);
            txtTipoVeiculo.Name = "txtTipoVeiculo";
            txtTipoVeiculo.ReadOnly = true;
            txtTipoVeiculo.Size = new Size(137, 18);
            txtTipoVeiculo.TabIndex = 1;
            // 
            // txtHoraEntrada
            // 
            txtHoraEntrada.BackColor = SystemColors.ControlLightLight;
            txtHoraEntrada.BorderStyle = BorderStyle.None;
            txtHoraEntrada.Location = new Point(216, 99);
            txtHoraEntrada.Name = "txtHoraEntrada";
            txtHoraEntrada.ReadOnly = true;
            txtHoraEntrada.Size = new Size(137, 18);
            txtHoraEntrada.TabIndex = 2;
            // 
            // txtHoraSaida
            // 
            txtHoraSaida.BackColor = SystemColors.ControlLightLight;
            txtHoraSaida.BorderStyle = BorderStyle.None;
            txtHoraSaida.Location = new Point(216, 128);
            txtHoraSaida.Name = "txtHoraSaida";
            txtHoraSaida.ReadOnly = true;
            txtHoraSaida.Size = new Size(137, 18);
            txtHoraSaida.TabIndex = 3;
            // 
            // txtTempoEstacionado
            // 
            txtTempoEstacionado.BackColor = SystemColors.ControlLightLight;
            txtTempoEstacionado.BorderStyle = BorderStyle.None;
            txtTempoEstacionado.Location = new Point(216, 157);
            txtTempoEstacionado.Name = "txtTempoEstacionado";
            txtTempoEstacionado.ReadOnly = true;
            txtTempoEstacionado.Size = new Size(137, 18);
            txtTempoEstacionado.TabIndex = 4;
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = SystemColors.ControlLightLight;
            txtValorTotal.BorderStyle = BorderStyle.None;
            txtValorTotal.Location = new Point(216, 186);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(137, 18);
            txtValorTotal.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(6, 41);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(48, 20);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa:";
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Location = new Point(6, 70);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(111, 20);
            lblTipoVeiculo.TabIndex = 7;
            lblTipoVeiculo.Text = "Tipo de Veículo:";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Location = new Point(6, 99);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(100, 20);
            lblHoraEntrada.TabIndex = 8;
            lblHoraEntrada.Text = "Hora Entrada:";
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Location = new Point(6, 128);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(83, 20);
            lblHoraSaida.TabIndex = 9;
            lblHoraSaida.Text = "Hora Saída:";
            // 
            // lblTempoTotal
            // 
            lblTempoTotal.AutoSize = true;
            lblTempoTotal.Location = new Point(6, 157);
            lblTempoTotal.Name = "lblTempoTotal";
            lblTempoTotal.Size = new Size(93, 20);
            lblTempoTotal.TabIndex = 10;
            lblTempoTotal.Text = "Tempo Total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(6, 186);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(83, 20);
            lblValorTotal.TabIndex = 11;
            lblValorTotal.Text = "Valor Total:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnConfirmarPagamento);
            groupBox1.Controls.Add(lblFormaDePagamento);
            groupBox1.Controls.Add(cmbFormaDePagamento);
            groupBox1.Controls.Add(lblPlaca);
            groupBox1.Controls.Add(lblValorTotal);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(lblTempoTotal);
            groupBox1.Controls.Add(txtTipoVeiculo);
            groupBox1.Controls.Add(lblHoraSaida);
            groupBox1.Controls.Add(txtHoraEntrada);
            groupBox1.Controls.Add(lblHoraEntrada);
            groupBox1.Controls.Add(txtHoraSaida);
            groupBox1.Controls.Add(lblTipoVeiculo);
            groupBox1.Controls.Add(txtTempoEstacionado);
            groupBox1.Controls.Add(txtValorTotal);
            groupBox1.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 385);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro De Pagamento";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(233, 346);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnConfirmarPagamento
            // 
            btnConfirmarPagamento.BackColor = SystemColors.MenuHighlight;
            btnConfirmarPagamento.Image = (Image)resources.GetObject("btnConfirmarPagamento.Image");
            btnConfirmarPagamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarPagamento.Location = new Point(70, 280);
            btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            btnConfirmarPagamento.Size = new Size(214, 39);
            btnConfirmarPagamento.TabIndex = 14;
            btnConfirmarPagamento.Text = "Confirmar Pagamento";
            btnConfirmarPagamento.UseVisualStyleBackColor = false;
            btnConfirmarPagamento.Click += btnConfirmarPagamento_Click;
            // 
            // lblFormaDePagamento
            // 
            lblFormaDePagamento.AutoSize = true;
            lblFormaDePagamento.Location = new Point(6, 229);
            lblFormaDePagamento.Name = "lblFormaDePagamento";
            lblFormaDePagamento.Size = new Size(155, 20);
            lblFormaDePagamento.TabIndex = 13;
            lblFormaDePagamento.Text = "Forma De Pagamento:";
            // 
            // cmbFormaDePagamento
            // 
            cmbFormaDePagamento.FormattingEnabled = true;
            cmbFormaDePagamento.Location = new Point(179, 226);
            cmbFormaDePagamento.Name = "cmbFormaDePagamento";
            cmbFormaDePagamento.Size = new Size(174, 28);
            cmbFormaDePagamento.TabIndex = 12;
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(383, 409);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPagamento";
            Load += FrmPagamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPlaca;
        private TextBox txtTipoVeiculo;
        private TextBox txtHoraEntrada;
        private TextBox txtHoraSaida;
        private TextBox txtTempoEstacionado;
        private TextBox txtValorTotal;
        private Label lblPlaca;
        private Label lblTipoVeiculo;
        private Label lblHoraEntrada;
        private Label lblHoraSaida;
        private Label lblTempoTotal;
        private Label lblValorTotal;
        private GroupBox groupBox1;
        private Button btnConfirmarPagamento;
        private Label lblFormaDePagamento;
        private ComboBox cmbFormaDePagamento;
        private Button button1;
    }
}