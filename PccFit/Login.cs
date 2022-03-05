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
using System.Configuration;

namespace PccFit
{
    public partial class Login : Form
    {
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acesso = "";
            if (msk_CPF.Text != "   .   .   -" && txt_Senha.Text != "")
            {
                string query = "SELECT * FROM tb_login WHERE cpf = '" + msk_CPF.Text + "' AND senha = '" + txt_Senha.Text + "';";
                using (MySqlConnection conexao = new MySqlConnection(myconn))
                {
                    MySqlCommand command = new MySqlCommand(query, conexao);

                    conexao.Open();

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            acesso = Convert.ToString(reader["acesso"]);
                        }
                        if(acesso == "nutricionista")
                        {
                            PgAgenda pa = new PgAgenda();
                            pa.Show();
                            this.Hide();
                        }
                        else if (acesso == "atendente")
                        {
                            PgPrincipal pd = new PgPrincipal();
                            pd.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("VOCÊ NÂO TEM ACESSO AO SISTEMA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF OU SENHA INVALIDO");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite o CPF e Senha");
            }
        }
    }
}
