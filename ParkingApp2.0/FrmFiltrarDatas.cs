using Aplication.Interface;
using Aplication.UseCase;

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
                string message = usecase.Execute(dataInicial, dataFinal);

                MessageBox.Show($"{message}","sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
