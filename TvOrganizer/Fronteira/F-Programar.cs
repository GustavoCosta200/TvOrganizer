using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVOrganizer.Entidade;
using TVOrganizer.Fronteira;
using TVOrganizer.Controle;

namespace TvOrganizer.Fronteira
{
    public partial class frmProgramar : Form
    {
        internal Programar programa = null;
        public frmProgramar()
        {
            InitializeComponent();
        }

        private void frmProgramar_Load(object sender, EventArgs e)
        {
        }

        internal void CarregarCampos(Programar programar)
        {
            programa = programar;
            mtbHora.ValidatingType = typeof(System.DateTime);
            mtbHora.TypeValidationCompleted += new TypeValidationEventHandler(mtbHora_TypeValidationCompleted);
            try
            {
                lblNome.Text = "Programar: " + programa.Programa.Nome;
                dtpData.Value = DateTime.Parse(programa.Data);
                mtbHora.Text = programa.Hora;
            }
            catch
            {
                dtpData.Value = DateTime.Today;
                mtbHora.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void mtbHora_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Hora inválida!", "Hora Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAssistindo frm = new frmAssistindo();
            frm.Show();
            this.Hide();
        }

        private void mtbHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DateTime.Today == dtpData.Value && DateTime.Parse(mtbHora.Text) <= DateTime.Now)
            {
                MessageBox.Show("Insira uma hora maior do que a hora atual!", "Hora Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = dtpData.Value.ToString("dd-MM-yyyy");
                string hora = mtbHora.Text.ToString();
                C_Calendário.AdicionarCalendário(programa, data, hora);
                MessageBox.Show("Calendário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAssistindo frm = new frmAssistindo();
                frm.Show();
                this.Hide();
            }
        }


    }
}
