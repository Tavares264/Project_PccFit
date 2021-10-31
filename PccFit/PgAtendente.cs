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
    public partial class PgAtendente : Form
    {
        public PgAtendente()
        {
            InitializeComponent();
        }


        string myconn = ConfigurationManager.AppSettings["msconn"];

        MySqlDataReader reader;


        private void btn_A_Pesquisar_Click(object sender, EventArgs e)
        {
            if (msk_A_Cpf.Text != null)
            {
                string cpf = msk_A_Cpf.Text;

                string sqlquery = "SELECT * FROM tb_atendente WHERE cpf = '" + cpf + "';";


                MySqlConnection conexao = new MySqlConnection(myconn);

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();

                if (reader.Read() != null) 
                {
                    txt_A_Nome.Text = Convert.ToString(reader["nome"]);
                }
                while (reader.Read())
                {
                    
                }
                MessageBox.Show("OK");
            }
        }

        private void btn_A_Cadastrar_Click(object sender, EventArgs e)
        {
            string sqlquery = "INSERT INTO tb_atendente (cpf, nome, email, cep, logradouro, numero, bairro, cidade, estado, telefone, dt_inicio, dt_final) VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Dt_inicio, @Dt_final);";

            using (MySqlConnection conexao = new MySqlConnection(myconn))
            {
                MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                command.Parameters.AddWithValue("@Cpf", msk_A_Cpf.Text);
                command.Parameters.AddWithValue("@Nome", txt_A_Nome.Text);
                command.Parameters.AddWithValue("@Email", txt_A_Email.Text);
                command.Parameters.AddWithValue("@Cep", msk_A_Cep.Text);
                command.Parameters.AddWithValue("@Logradouro", txt_A_Logradouro.Text);
                command.Parameters.AddWithValue("@Numero", txt_A_Numero.Text);
                command.Parameters.AddWithValue("@Bairro", txt_A_Bairro.Text);
                command.Parameters.AddWithValue("@Cidade", txt_A_Cidade.Text);
                command.Parameters.AddWithValue("@Estado", cb_A_Estado.Text);
                command.Parameters.AddWithValue("@Telefone", msk_A_Tel.Text);
                command.Parameters.AddWithValue("@Dt_inicio", Convert.ToDateTime(msk_A_DtInicio.Text));
                command.Parameters.AddWithValue("@Dt_final", Convert.ToDateTime(msk_A_DtFinal.Text));

                conexao.Open();   
                command.ExecuteNonQuery();

                conexao.Close();
            }
        }
    }
}
