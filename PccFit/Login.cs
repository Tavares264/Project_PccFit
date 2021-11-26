using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PccFit
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn))
            {
                MySqlCommand command = new MySqlCommand(String.Format("select * from cpf = {1};", Cpf), conexao);
                reader = (command.ExecuteReader());
            }
        }
    }
}
