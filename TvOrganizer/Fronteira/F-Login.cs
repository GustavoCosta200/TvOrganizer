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
                if (C_Login.ConferirUsu�rio(txtUser.Text, txtSenha.Text) == true)
                {
                    this.Hide();
                    frmAssistindo frmassistindo = new frmAssistindo();
                    frmassistindo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usu�rio/Senha Inv�lidos", "Usu�rio/Senha Inv�lidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (UserNotFoundException error)
            {
                MessageBox.Show(error.Message, "Usu�rio/Senha Inv�lidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}