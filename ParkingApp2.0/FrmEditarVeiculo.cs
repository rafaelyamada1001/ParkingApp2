using Aplication.UseCase;

namespace ParkingApp2._0
{
    public partial class FrmEditarVeiculo : Form
    {
        private readonly string _placaAtual;
        private readonly EditarVeiculoUseCase _editarVeiculoUseCase;

        public FrmEditarVeiculo(string placaAtual, string tipoAtual, EditarVeiculoUseCase editarVeiculoUseCase)
        {
            InitializeComponent();

            _placaAtual = placaAtual;
            _editarVeiculoUseCase = editarVeiculoUseCase;

            txtNovaPlaca.Text = placaAtual;
            cmbNovoTipo.SelectedItem = tipoAtual;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string placaNova = txtNovaPlaca.Text;
            string tipoNovo = cmbNovoTipo.SelectedItem?.ToString();

            var response = _editarVeiculoUseCase.Execute(_placaAtual, placaNova, tipoNovo);

            if (response.Sucesso)
            {
                MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Erro ao Atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
