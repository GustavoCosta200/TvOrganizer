using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVOrganizer.Controle;
using TVOrganizer.Entidade;
using TVOrganizer.Fronteira;

namespace TvOrganizer.Fronteira
{
    public partial class frmAvaliar : Form
    {
        private Programar programa = null;
        public frmAvaliar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_Avaliar_Load(object sender, EventArgs e)
        {

        }

        private void nudNota_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void CarregarAvaliação(Programar programar)
        {
            lblNome.Text = programar.Programa.Nome;
            txtComentário.Text = programar.Comentario;
            try
            {
                nudNota.Value = (decimal)programar.Nota;
            }
            catch (InvalidOperationException)
            {
                nudNota.Value = nudNota.Minimum;
            }
            programa = programar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            C_ProgramaConcluído.AvaliarPrograma(programa, txtComentário.Text, nudNota.Value);
            MessageBox.Show("Programa avaliado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmProgramaConcluido frmProgramaConcluido = new frmProgramaConcluido();
            frmProgramaConcluido.Show();
            this.Hide();
        }
    }
}
