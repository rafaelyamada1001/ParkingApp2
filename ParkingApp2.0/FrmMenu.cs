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

        public FrmParkingApp(IVeiculoRepository veiculoRepository,
                       IEstacionamentoRepository estacionamentoRepository,
                       FrmFiltrarDatas frmFiltrarDatas)
        {
            _veiculoRepository = veiculoRepository;
            _estacionamentoRepository = estacionamentoRepository;
            _frmFiltrarDatas = frmFiltrarDatas;

            InitializeComponent();

            this.Load += new EventHandler(FrmMenu_Load);
        }

        private void FrmMenu_Load(object? sender, EventArgs e)
        {
            cmbTipoVeiculo.DataSource = Enum.GetValues(typeof(EVeiculoType));
            dgvVeiculosEstacionados.AutoGenerateColumns = false;

            AtualizarTela();
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            EVeiculoType tipoVeiculo = (EVeiculoType)cmbTipoVeiculo.SelectedItem;

            var useCase = new AdicionarVeiculoUseCase(_veiculoRepository, _estacionamentoRepository);
            var message = useCase.Execute(placa, tipoVeiculo);



            MessageBox.Show(message.Mensagem,
                            "Alerta!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            AtualizarTela();
        }

        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            var useCase = new RemoverVeiculoUseCase(_veiculoRepository, _estacionamentoRepository);
            var message = useCase.Execute(placa);

            MessageBox.Show(message.Mensagem,
                  "Alerta!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            AtualizarTela();
        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {
            var useCase = new ListarVeiculosUseCase(_veiculoRepository);
            var resultado = useCase.Execute();

            dgvVeiculosEstacionados.DataSource = resultado.Dados;
            dgvVeiculosEstacionados.Refresh();
        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {
            var useCase = new VagasDesocupadasUseCase(_estacionamentoRepository);
            var vagasLivres = useCase.Execute();

            if (vagasLivres.Sucesso && vagasLivres.Dados != null)
            {
                txtVagasCarros.Text = vagasLivres.Dados.VagasCarros.ToString();
                txtVagasMotos.Text = vagasLivres.Dados.VagasMotos.ToString();
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
            _frmFiltrarDatas.Show();
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvVeiculosEstacionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // garante que não clicou no header
            {
                var selectedRow = dgvVeiculosEstacionados.Rows[e.RowIndex];

                string placa = selectedRow.Cells["Placa"].Value.ToString();
                string tipo = selectedRow.Cells["TipoVeiculo"].Value.ToString();

                var result = MessageBox.Show(
                    $"Deseja remover o veículo?\n\nPlaca: {placa}\nTipo: {tipo}",
                    "Remover Veículo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var useCase = new RemoverVeiculoUseCase(_veiculoRepository, _estacionamentoRepository);
                    var response = useCase.Execute(placa);

                    MessageBox.Show(response.Mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarTela();
                }
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
    }

}
