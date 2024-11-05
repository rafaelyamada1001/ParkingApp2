using Aplication.Interface;
using Aplication.UseCase;
using Infra.Repository;
using System.Numerics;


namespace ParkingApp2._0
{
    public partial class FrmMenu : Form
    {
        private IVeiculoRepository veiculoRepository;
        public FrmMenu()
        {
            InitializeComponent();
            veiculoRepository = new VeiculoRepository();
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            try
            {
                var useCase = new AdicionarVeiculoUseCase(veiculoRepository);
                useCase.Execute(placa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            //var useCase = new RemoverVeiculoUseCase(veiculoRepository);
            //useCase.Execute(placa);
        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void btnVagasLivres_Click(object sender, EventArgs e)
        {

        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
