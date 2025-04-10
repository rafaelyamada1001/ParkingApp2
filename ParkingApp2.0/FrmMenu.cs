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
        private readonly CalcularPagamentoUseCase _calcularPagamentoUseCase;
        private readonly AdicionarVeiculoUseCase _adicionarVeiculoUseCase;
        private readonly RetirarVeiculoUseCase _retirarVeiculoUseCase;
        private readonly SomaValorUseCase _relatorioLucroUseCase;
        private readonly ObterMovimentoPorDataUseCase _movimentoPorDataUseCase;
        private readonly EditarVeiculoUseCase _editarVeiculoUseCase;

        public FrmParkingApp(IVeiculoRepository veiculoRepository,
                       IEstacionamentoRepository estacionamentoRepository,
                       CalcularPagamentoUseCase calcularPagamentoUseCase,
                       AdicionarVeiculoUseCase adicionarVeiculoUseCase,
                       RetirarVeiculoUseCase retirarVeiculoUseCase,
                       SomaValorUseCase relatorioLucroUseCase,
                       ObterMovimentoPorDataUseCase movimentoPorDataUseCase,
                       EditarVeiculoUseCase editarVeiculoUseCase)
        {
            _veiculoRepository = veiculoRepository;
            _estacionamentoRepository = estacionamentoRepository;
            _calcularPagamentoUseCase = calcularPagamentoUseCase;
            _adicionarVeiculoUseCase = adicionarVeiculoUseCase;
            _retirarVeiculoUseCase = retirarVeiculoUseCase;
            _relatorioLucroUseCase = relatorioLucroUseCase;
            _movimentoPorDataUseCase = movimentoPorDataUseCase;
            _editarVeiculoUseCase = editarVeiculoUseCase;
            _adicionarVeiculoUseCase = adicionarVeiculoUseCase;
            _relatorioLucroUseCase = relatorioLucroUseCase;

            InitializeComponent();

            this.Load += new EventHandler(FrmMenu_Load);
        }

        private void FrmMenu_Load(object? sender, EventArgs e)
        {
            cmbTipoVeiculo.DataSource = Enum.GetValues(typeof(EVeiculoType));
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string placaAtual = txtPlaca.Text;
            var response = _veiculoRepository.TipoVeiculo(placaAtual);
            if (!response.Sucesso || string.IsNullOrWhiteSpace(response.Dados))
            {
                MessageBox.Show("Veículo não encontrado verificar Placa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tipoVeiculo = response.Dados;

            var formEditar = new FrmEditarVeiculo(placaAtual, tipoVeiculo, _editarVeiculoUseCase);
            var resultado = formEditar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AtualizarTela();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataInicial = dtpDataInicial.Value.Date;
            var dataFinal = dtpDataFinal.Value.Date.AddDays(1);

            if (dataInicial > dataFinal)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _relatorioLucroUseCase.Execute(dataInicial, dataFinal);
            var movimentacao = _movimentoPorDataUseCase.Execute(dataInicial, dataFinal);

            dgvRelatorio.DataSource = movimentacao.Dados;
            txtValor.Text = result.Dados.ToString();
        }

        private void dgvVeiculosEstacionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvVeiculosEstacionados.Rows[e.RowIndex];

                string placa = selectedRow.Cells["Placa"].Value.ToString();

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
        private void FrmParkingApp_Load(object sender, EventArgs e)
        {

        }
        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
