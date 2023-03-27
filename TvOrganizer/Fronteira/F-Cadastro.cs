using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvOrganizer.Exception;
using TVOrganizer.Controle;

namespace TVOrganizer.Fronteira
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == null || txtEmail.Text.Trim() == null || txtBoxSenha.Text.Trim() == null || txtConfirmarSenha.Text.Trim() == null)
            {
                MessageBox.Show("Existem Campos de entrada em Branco", "Campos em Branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("Senha com número de cacarcteres menor que o mínimo!", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtBoxSenha.Text.Trim().Equals(txtConfirmarSenha.Text.Trim(), StringComparison.Ordinal))
            {
                MessageBox.Show("Senhas inseridas são diferentes", "Senhas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                C_Cadastro.CriarCadastro(txtNome.Text.Trim(), txtBoxSenha.Text.Trim(), txtEmail.Text.Trim());
                MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FecharCadastro();
            }
            catch (UserAlreadyExists error)
            {
                MessageBox.Show(error.Message, "Usuário já existe!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(InvalidEmailException error)
            {
                MessageBox.Show(error.Message, "Email Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharCadastro();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void FecharCadastro()
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
