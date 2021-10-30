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
    public partial class PgAtendente : Form
    {
        public PgAtendente()
        {
            InitializeComponent();
        }


        private void btn_A_Pesquisar_Click(object sender, EventArgs e)
        {
            if (msk_A_Cpf != null) 
            {
                Pesquisar(msk_A_Cpf);   
            }
        }
    }
}
