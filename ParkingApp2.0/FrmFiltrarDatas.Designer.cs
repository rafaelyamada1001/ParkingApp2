namespace ParkingApp2._0
{
    partial class FrmFiltrarDatas
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
            lblDataInicial = new Label();
            lblDataFinal = new Label();
            grpInserirPeriodo = new GroupBox();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            btnVoltarMenu = new Button();
            btnFiltrar = new Button();
            grpInserirPeriodo.SuspendLayout();
            SuspendLayout();
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(20, 19);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(68, 15);
            lblDataInicial.TabIndex = 0;
            lblDataInicial.Text = "Data inicial:";
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(20, 63);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(60, 15);
            lblDataFinal.TabIndex = 1;
            lblDataFinal.Text = "Data final:";
            // 
            // grpInserirPeriodo
            // 
            grpInserirPeriodo.Controls.Add(dtpDataFinal);
            grpInserirPeriodo.Controls.Add(dtpDataInicial);
            grpInserirPeriodo.Controls.Add(btnVoltarMenu);
            grpInserirPeriodo.Controls.Add(btnFiltrar);
            grpInserirPeriodo.Controls.Add(lblDataInicial);
            grpInserirPeriodo.Controls.Add(lblDataFinal);
            grpInserirPeriodo.Location = new Point(12, 12);
            grpInserirPeriodo.Name = "grpInserirPeriodo";
            grpInserirPeriodo.Size = new Size(226, 163);
            grpInserirPeriodo.TabIndex = 3;
            grpInserirPeriodo.TabStop = false;
            grpInserirPeriodo.Text = "Insira o periodo";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(6, 81);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(200, 23);
            dtpDataFinal.TabIndex = 7;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(6, 37);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(200, 23);
            dtpDataInicial.TabIndex = 6;
            dtpDataInicial.Value = new DateTime(2024, 11, 12, 15, 15, 24, 0);
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Location = new Point(143, 136);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(75, 23);
            btnVoltarMenu.TabIndex = 5;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = true;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(62, 136);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FrmFiltrarDatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 185);
            Controls.Add(grpInserirPeriodo);
            Name = "FrmFiltrarDatas";
            Text = "FrmFiltrarDatas";
            grpInserirPeriodo.ResumeLayout(false);
            grpInserirPeriodo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDataInicial;
        private Label lblDataFinal;
        private GroupBox grpInserirPeriodo;
        private Button btnVoltarMenu;
        private Button btnFiltrar;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
    }
}