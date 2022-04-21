using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static PccFit.Atendente;

namespace PccFit
{
    public partial class PgPrincipalNut : Form
    {
        public Form OpenForm;

        public PgPrincipalNut()
        {
            InitializeComponent();
        }

        private void btnNRotina_Click(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgAgenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelNPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }

        private void btnNAgenda_Click_1(object sender, EventArgs e)
        {
            OpenForm?.Close();

            OpenForm = new PgRotina
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelNPrincipal.Controls.Add(OpenForm);
            OpenForm.Show();
        }
    }
}
