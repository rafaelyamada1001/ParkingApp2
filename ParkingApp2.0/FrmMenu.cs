using Aplication.Interface;
using Aplication.UseCase;
using Infra.Repository;
using Domain.Enums;
using Infra.Connection;
using Infra.DataBase;


namespace ParkingApp2._0
{
    public partial class FrmMenu : Form
    {
        private IVeiculoRepository veiculoRepository;
        private IEstacionamentoRepository estacionamentoRepository;

        public FrmMenu()
        {
            var connection2 = new Connection();
            var connection = new DatabaseConnection();

            veiculoRepository = new VeiculoRepository(connection);
            estacionamentoRepository = new EstacionamentoRepository(connection2, connection);

            InitializeComponent();

            this.Load += new EventHandler(FrmMenu_Load);
        }

        private void FrmMenu_Load(object? sender, EventArgs e)
        {
            cmbTipoVeiculo.DataSource = Enum.GetValues(typeof(EVeiculoType));
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            EVeiculoType tipoVeiculo = (EVeiculoType)cmbTipoVeiculo.SelectedItem;

            var useCase = new AdicionarVeiculoUseCase(veiculoRepository, estacionamentoRepository);
            var message = useCase.Execute(placa, tipoVeiculo);


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

            if (vagasLivres.Sucesso && vagasLivres.Dados != null)
            {
                MessageBox.Show($"Total de vagas desocupadas:\n" +
                    $"Carros:{vagasLivres.Dados.VagasCarros}\n" +
                    $"Motos:{vagasLivres.Dados.VagasMotos}",
                    "Vagas Disponíveis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{vagasLivres.Mensagem}");
            }
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

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
