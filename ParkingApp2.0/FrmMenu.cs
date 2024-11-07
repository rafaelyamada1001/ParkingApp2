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
                var useCase = new AdicionarVeiculoUseCase(veiculoRepository);
                useCase.ExecuteAdicionarVeiculo(placa);
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
                useCase.ExecuteRemoverVeiculo(placa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {
            try
            {
                var useCase = new VagasDesocupadasUseCase(estacionamentoRepository);
                useCase.ExecuteVagasLivres();

                //string message = 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
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
