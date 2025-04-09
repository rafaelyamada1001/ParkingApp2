using Aplication.DTO;
using Aplication.Interface;
using Aplication.UseCase;
using Domain.Enums;

namespace ParkingApp2._0
{
    public partial class FrmParkingApp : Form
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;
        private readonly FrmFiltrarDatas _frmFiltrarDatas;
        private readonly CalcularPagamentoUseCase _calcularPagamentoUseCase;
        private readonly AdicionarVeiculoUseCase _adicionarVeiculoUseCase;
        private readonly RetirarVeiculoUseCase _retirarVeiculoUseCase;

        public FrmParkingApp(IVeiculoRepository veiculoRepository,
                       IEstacionamentoRepository estacionamentoRepository,
                       FrmFiltrarDatas frmFiltrarDatas,
                       CalcularPagamentoUseCase calcularPagamentoUseCase,
                       AdicionarVeiculoUseCase adicionarVeiculoUseCase,
                       RetirarVeiculoUseCase retirarVeiculoUseCase)
        {
            _veiculoRepository = veiculoRepository;
            _estacionamentoRepository = estacionamentoRepository;
            _frmFiltrarDatas = frmFiltrarDatas;
            _calcularPagamentoUseCase = calcularPagamentoUseCase;
            _adicionarVeiculoUseCase = adicionarVeiculoUseCase;
            _retirarVeiculoUseCase = retirarVeiculoUseCase;

            InitializeComponent();

            this.Load += new EventHandler(FrmMenu_Load);
            _adicionarVeiculoUseCase = adicionarVeiculoUseCase;
        }

        private void FrmMenu_Load(object? sender, EventArgs e)
        {
            cmbTipoVeiculo.DataSource = Enum.GetValues(typeof(EVeiculoType));
            dgvVeiculosEstacionados.AutoGenerateColumns = false;
            var estacionamento = _estacionamentoRepository.VagasTotais();
            dgvConfigEstacionamento.DataSource = new List<VagasTotaisDTO> { estacionamento.Dados };
            dgvConfigEstacionamento.Refresh();
            AtualizarTela();
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            EVeiculoType tipoVeiculo = (EVeiculoType)cmbTipoVeiculo.SelectedItem;

            var useCase = _adicionarVeiculoUseCase.Execute(placa, tipoVeiculo);

            MessageBox.Show(useCase.Mensagem,
                            "Alerta!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            AtualizarTela();
        }

        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            var result = _calcularPagamentoUseCase.Execute(placa);

            if (!result.Sucesso)
            {
                MessageBox.Show(result.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var formaPagamento = new FrmPagamento(result.Dados);
            var confirmacao = formaPagamento.ShowDialog();

            if (confirmacao == DialogResult.OK)
            {
                var dados = result.Dados;

                var retirarVeiculo = _retirarVeiculoUseCase.Execute
                    (dados.Placa, dados.HoraSaida, dados.HorasCobradas, dados.TempoEstacionado.Minutes, dados.ValorTotal);

                MessageBox.Show(retirarVeiculo.Mensagem,
                "Alerta!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                if (retirarVeiculo.Sucesso) AtualizarTela();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmFiltrarDatas.Show();
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvVeiculosEstacionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvVeiculosEstacionados.Rows[e.RowIndex];

                string placa = selectedRow.Cells["Placa"].Value.ToString();
                string tipo = selectedRow.Cells["TipoVeiculo"].Value.ToString();


                var response = _calcularPagamentoUseCase.Execute(placa);

                if (!response.Sucesso)
                {
                    MessageBox.Show(response.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var formaPagamento = new FrmPagamento(response.Dados);
                var confirmacao = formaPagamento.ShowDialog();

                if (confirmacao == DialogResult.OK)
                {
                    var dados = response.Dados;
                    var retirarVeiculo = _retirarVeiculoUseCase.Execute
                        (dados.Placa, dados.HoraSaida, dados.HorasCobradas, dados.TempoEstacionado.Minutes, dados.ValorTotal);

                    MessageBox.Show(retirarVeiculo.Mensagem, "Sucesso", MessageBoxButtons.OK);
                }

                AtualizarTela();

            }
        }
        private void AtualizarTela()
        {
            // Atualiza DataGrid
            var listarUseCase = new ListarVeiculosUseCase(_veiculoRepository);
            var resultado = listarUseCase.Execute();
            dgvVeiculosEstacionados.DataSource = resultado.Dados;

            // Atualiza TextBoxes de vagas
            var vagasUseCase = new VagasDesocupadasUseCase(_estacionamentoRepository);
            var vagasLivres = vagasUseCase.Execute();

            if (vagasLivres.Sucesso && vagasLivres.Dados != null)
            {
                txtVagasCarros.Text = vagasLivres.Dados.VagasCarros.ToString();
                txtVagasMotos.Text = vagasLivres.Dados.VagasMotos.ToString();

                txtVagasCarros.BackColor = vagasLivres.Dados.VagasCarros > 0 ? Color.LightGreen : Color.LightCoral;
                txtVagasMotos.BackColor = vagasLivres.Dados.VagasMotos > 0 ? Color.LightGreen : Color.LightCoral;
            }
        }

        private void FrmParkingApp_Load(object sender, EventArgs e)
        {

        }
        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvConfigEstacionamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dto = dgvConfigEstacionamento.Rows[e.RowIndex].DataBoundItem as VagasTotaisDTO;

                if (dto != null)
                {
                    var response = _estacionamentoRepository.AtualizarDadosEstacionamento(dto);
                    if (!response.Sucesso)
                    {
                        MessageBox.Show("Erro ao atualizar: " + response.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            AtualizarTela();
        }

        private void tbpGerenciador_Click(object sender, EventArgs e)
        {

        }

    }

}
