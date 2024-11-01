using ParkingContext.Aplication.Interface;
using ParkingContext.Infra.Repository;
using System.Windows.Forms;

namespace ParkingApp2
{
    public partial class FrmPrincipal : Form
    {
        private IVeiculoRepository veiculoRepository;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            if(txtUsuario.Text.Equals("123") & txtSenha.Text.Equals("123"))
            {
                var menu = new FrmMenu(veiculoRepository);
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

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
