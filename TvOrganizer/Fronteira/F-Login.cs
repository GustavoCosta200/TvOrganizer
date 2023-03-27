using TvOrganizer.Exception;
using TVOrganizer.Controle;
using TVOrganizer.Fronteira;

namespace TVOrganizer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (C_Login.ConferirUsuário(txtUser.Text, txtSenha.Text) == true)
                {
                    this.Hide();
                    frmAssistindo frmassistindo = new frmAssistindo();
                    frmassistindo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário/Senha Inválidos", "Usuário/Senha Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (UserNotFoundException error)
            {
                MessageBox.Show(error.Message, "Usuário/Senha Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}