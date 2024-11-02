using Aplication.Interface;


namespace ParkingApp2._0
{
    public partial class FrmMenu : Form
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public FrmMenu(IVeiculoRepository veiculoRepository)
        {
            InitializeComponent();
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            try
            {
                _veiculoRepository.AdicionarVeiculo(placa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {
            try
            {
                _veiculoRepository.VagasDesocupadas();
            }
            catch
            {
                MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
