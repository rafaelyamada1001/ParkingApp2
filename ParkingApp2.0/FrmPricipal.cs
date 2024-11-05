using Aplication.Interface;
using Aplication.UseCase;

namespace ParkingApp2._0
{
    public partial class FrmPricipal : Form
    {
        private AdicionarVeiculoUseCase adicionarVeiculo;
        public FrmPricipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("123") & txtSenha.Text.Equals("123"))
            {
                var menu = new FrmMenu();
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
            this.Close();
        }
    }
}
