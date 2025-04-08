using Aplication.Interface;
using Aplication.UseCase;

namespace ParkingApp2._0
{
    public partial class FrmFiltrarDatas : Form
    {
        private readonly IRelatorioRepositoy _relatorioRepository;

        public FrmFiltrarDatas(IRelatorioRepositoy relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var dataInicial = dtpDataInicial.Value.Date;
            var dataFinal = dtpDataFinal.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            try
            {
                var usecase = new RelatorioLucroUseCase(_relatorioRepository);
                var message = usecase.Execute(dataInicial, dataFinal);

                MessageBox.Show($"{message.Mensagem}","sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
