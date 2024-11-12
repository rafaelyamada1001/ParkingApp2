using Aplication.Interface;
using Aplication.UseCase;
using Infra.Repository;



namespace ParkingApp2._0
{
    public partial class FrmMenu : Form
    {
        private IVeiculoRepository veiculoRepository;
        private IEstacionamentoRepository estacionamentoRepository;

        public FrmMenu()
        {
            InitializeComponent();

            veiculoRepository = new VeiculoRepository();
            estacionamentoRepository = new EstacionamentoRepository();
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            var useCase = new AdicionarVeiculoUseCase(veiculoRepository, estacionamentoRepository);
            var message = useCase.Execute(placa);


            MessageBox.Show(message.Mensagem,
                            "Alerta!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

        }
        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            var useCase = new RemoverVeiculoUseCase(veiculoRepository, estacionamentoRepository);
            var message = useCase.Execute(placa);

            MessageBox.Show(message.Mensagem,
                  "Alerta!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {

                var useCase = new ListarVeiculosUseCase(veiculoRepository);
                var message = useCase.Execute();
                
                MessageBox.Show(message.Mensagem,
                    "Lista de Veículos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {
                var useCase = new VagasDesocupadasUseCase(estacionamentoRepository);
                var vagasLivres = useCase.Execute();

                MessageBox.Show($"Total de vagas desocupadas: {vagasLivres.Dados}");

        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var relatorio = new FrmFiltrarDatas();
            relatorio.Show();
        }
    }
}
