using Aplication.Interface;
using Aplication.UseCase;
using Infra.DataBase;
using Infra.Repository;
using Domain.Enums;


namespace ParkingApp2._0
{
    public partial class FrmMenu : Form
    {
        private IVeiculoRepository veiculoRepository;
        private IEstacionamentoRepository estacionamentoRepository;

        public FrmMenu()
        {
            var connection = new Connection();

            veiculoRepository = new VeiculoRepository(connection);
            estacionamentoRepository = new EstacionamentoRepository(connection);

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

            EVeiculoType tipoVeiculo = (EVeiculoType)cmbTipoVeiculo.SelectedItem;
            var useCase = new RemoverVeiculoUseCase(veiculoRepository, estacionamentoRepository);
            var message = useCase.Execute(placa, tipoVeiculo);

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

            if (vagasLivres.Dados != 0)
            {
                MessageBox.Show($"Total de vagas desocupadas: {vagasLivres.Dados}");
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
