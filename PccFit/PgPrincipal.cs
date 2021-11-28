using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PccFit
{
    public partial class PgPrincipal : Form
    {
        public Form OpenForm;

        public PgPrincipal()
        {
            InitializeComponent();
        }

        private void PgPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCad_Cliente_Click(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }

        private void btnCad_Atendente_Click(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgAtendente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }

        private void btnCad_Nutricionista_Click(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgNutricionista
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgAgenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }
    }
}
