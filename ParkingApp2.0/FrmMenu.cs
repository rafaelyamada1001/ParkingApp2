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

            try
            {
                var useCase = new AdicionarVeiculoUseCase(veiculoRepository, estacionamentoRepository);
                string message = useCase.ExecuteAdicionarVeiculo(placa);

                MessageBox.Show(message,
                                "Alerta!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            try
            {
                var useCase = new RemoverVeiculoUseCase(veiculoRepository, estacionamentoRepository);
                var message = useCase.ExecuteRemoverVeiculo(placa);

                MessageBox.Show(message,
                      "Veículo Removido com sucesso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //if (saidaVeiculoDTO != null)
                //{
                //    MessageBox.Show($"Placa: {saidaVeiculoDTO.Placa}\nValor Total R$ {saidaVeiculoDTO.ValorTotal:F2}",
                //        "Veículo Removido com sucesso!",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Teste");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {
            try
            {

            var useCase = new ListarVeiculosUseCase(veiculoRepository);
            var veiculos = useCase.ExecuteListarVeiculos();
            string message = "Veículos estacionados: \n";
            foreach (var veiculo in veiculos)
            {
                message += $" Veículo: {veiculo.Placa} - Hora Entrada: {veiculo.HoraEntrada}\n";
            }

            MessageBox.Show(message,
                "Lista de Veículos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {
            try
            {
                var useCase = new VagasDesocupadasUseCase(estacionamentoRepository);
                var vagasLivres = useCase.ExecuteVagasLivres();

                MessageBox.Show($"Total de vagas desocupadas: {vagasLivres}"); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estacionamentoRepository = new EstacionamentoRepository();
            var vagasDesocupadas = estacionamentoRepository.VagasTotais();

            int vagasTotais = vagasDesocupadas.VagasTotais;
            string message = ($"Vagas desocupadas:{vagasTotais}");

            MessageBox.Show(message);
        }
    }
}
