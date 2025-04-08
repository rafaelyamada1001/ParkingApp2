using Aplication.Interface;
using Aplication.UseCase;
using Infra.Repository;

namespace ParkingApp2._0
{
    public partial class FrmPricipal : Form
    {

        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;
        private readonly FrmFiltrarDatas _filtrarDatas;
        public FrmPricipal(IVeiculoRepository veiculoRepository, IEstacionamentoRepository estacionamentoRepository, FrmFiltrarDatas filtrarDatas)
        {
            InitializeComponent();
            _veiculoRepository = veiculoRepository;
            _estacionamentoRepository = estacionamentoRepository;
            _filtrarDatas = filtrarDatas;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("123") & txtSenha.Text.Equals("123"))
            {
                var menu = new FrmParkingApp(_veiculoRepository, _estacionamentoRepository, _filtrarDatas);
                menu.Show();

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos",
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtUsuario.Focus();
                txtSenha.Text = string.Empty;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
