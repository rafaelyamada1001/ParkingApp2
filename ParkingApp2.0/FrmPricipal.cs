using Aplication.Interface;

namespace ParkingApp2._0
{
    public partial class FrmPricipal : Form
    {
        private IVeiculoRepository veiculoRepository;
        public FrmPricipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("123") & txtSenha.Text.Equals("123"))
            {
                var menu = new FrmMenu(veiculoRepository);
                menu.Show();

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha incorretos",
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