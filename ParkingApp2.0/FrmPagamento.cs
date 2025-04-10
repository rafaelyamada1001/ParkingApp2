using Aplication.DTO;

namespace ParkingApp2._0
{
    public partial class FrmPagamento : Form
    {
        public bool PagamentoConfirmado { get; private set; }
        public FrmPagamento(PagamentoDTO dados)
        {
            InitializeComponent();

            txtPlaca.Text = dados.Placa;
            txtTipoVeiculo.Text = dados.TipoVeiculo;
            txtHoraEntrada.Text = dados.HoraEntrada.ToString("g");
            txtHoraSaida.Text = dados.HoraSaida.ToString("g");
            txtTempoEstacionado.Text = $"{dados.TempoEstacionado.Hours}h {dados.TempoEstacionado.Minutes}min";
            txtValorTotal.Text = $"R$ {dados.ValorTotal:F2}";

        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
