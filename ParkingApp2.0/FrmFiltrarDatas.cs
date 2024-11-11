using Aplication.Interface;
using Aplication.UseCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp2._0
{
    public partial class FrmFiltrarDatas : Form
    {
        private IRelatorioRepositoy relatorioRepository;
        public FrmFiltrarDatas()
        {
            InitializeComponent();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var dataInicial = dtpDataInicial.Value;
            var dataFinal = dtpDataFinal.Value;

            try
            {
                var usecase = new RelatorioLucroUseCase(relatorioRepository);
                var valorTotal usecase.Execute(dataInicial, dataFinal);

                MessageBox.Show($"{valorTotal}", $"Periodo {dataInicial} - {dataFinal}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
