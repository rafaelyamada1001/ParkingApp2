namespace ParkingApp2._0
{
    partial class FrmEditarVeiculo
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbNovoTipo = new ComboBox();
            txtNovaPlaca = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbNovoTipo);
            groupBox1.Controls.Add(txtNovaPlaca);
            groupBox1.Font = new Font("Noto Sans", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Veiculo Estacionado:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.MenuHighlight;
            btnCancelar.Location = new Point(203, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.MenuHighlight;
            btnSalvar.Location = new Point(284, 110);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(74, 24);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 35);
            label2.Name = "label2";
            label2.Size = new Size(155, 16);
            label2.TabIndex = 3;
            label2.Text = "Insira novo tipo de veículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 2;
            label1.Text = "Insira nova placa:";
            // 
            // cmbNovoTipo
            // 
            cmbNovoTipo.FormattingEnabled = true;
            cmbNovoTipo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbNovoTipo.Location = new Point(183, 58);
            cmbNovoTipo.Name = "cmbNovoTipo";
            cmbNovoTipo.Size = new Size(121, 24);
            cmbNovoTipo.TabIndex = 1;
            // 
            // txtNovaPlaca
            // 
            txtNovaPlaca.Location = new Point(22, 58);
            txtNovaPlaca.Name = "txtNovaPlaca";
            txtNovaPlaca.Size = new Size(116, 22);
            txtNovaPlaca.TabIndex = 0;
            // 
            // FrmEditarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(397, 164);
            Controls.Add(groupBox1);
            Name = "FrmEditarVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarVeiculo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbNovoTipo;
        private TextBox txtNovaPlaca;
        private Button btnSalvar;
        private Label label2;
        private Button btnCancelar;
    }
}