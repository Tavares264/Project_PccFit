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
    public partial class PgAgenda : Form
    {
        public PgAgenda()
        {
            InitializeComponent();
        }

        Conexao myconn = new Conexao();
        MySqlDataReader reader;

        private void btn_AG_Visualizar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tb_agenda where ";


        }

        private void btn_AG_Agendar_Click(object sender, EventArgs e)
        {
            string sqlquery = "INSERT INTO tb_nutricionista (cpf, nome, email, cep, logradouro, numero, bairro, cidade, estado, telefone, dt_inicio) VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Dt_inicio);";
            string query = "INSERT INTO tb_login (cpf, senha, acesso) VALUE (@cpf, @senha, 'nutricionista')";

            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {

                string camposvazio = "";


                if (txt_N_Nome.Text == "")
                {
                    camposvazio = camposvazio + "Campo Nome é obrigatorio \n";
                }

                if (msk_N_Cpf.Text == "   .   .   -")
                {
                    camposvazio = camposvazio + "Campo CPF é obrigatorio \n";
                }

                if (txt_N_Email.Text == "")
                {
                    camposvazio = camposvazio + "Campo Email é obrigatorio \n";
                }

                if (msk_N_Tel.Text == "(  )     -")
                {
                    camposvazio = camposvazio + "Campo Telefone é obrigatorio \n";
                }

                if (txt_N_Logradouro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Logradouro é obrigatorio \n";
                }

                if (cb_N_Estado.Text == "")
                {
                    camposvazio = camposvazio + "Campo Estado é obrigatorio \n";
                }

                if (txt_N_Cidade.Text == "")
                {
                    camposvazio = camposvazio + "Campo Cidade é obrigatorio \n";
                }

                if (txt_N_Bairro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Bairro é obrigatorio \n";
                }

                if (msk_N_Cep.Text == "     -")
                {
                    camposvazio = camposvazio + "Campo CEP é obrigatorio \n";
                }

                if (msk_N_DtInicio.Text == "  /  /")
                {
                    camposvazio = camposvazio + "Campo Data de inicio é obrigatorio \n";
                }

                if (txt_N_Numero.Text == "")
                {
                    sqlquery = "INSERT INTO tb_nutricionista (cpf, nome, email, cep, logradouro, bairro, cidade, estado, telefone, dt_inicio) VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Bairro, @Cidade, @Estado, @Telefone, @Dt_inicio);";
                }


                if (camposvazio == "")
                {
                    string senha = msk_N_Cpf.Text.Substring(9).Replace("-", "");

                    try
                    {
                        MySqlCommand command2 = new MySqlCommand(query, conexao);
                        command2.Parameters.AddWithValue("@cpf", msk_N_Cpf.Text);
                        command2.Parameters.AddWithValue("@senha", senha);

                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Cpf", msk_N_Cpf.Text);
                        command.Parameters.AddWithValue("@Nome", txt_N_Nome.Text);
                        command.Parameters.AddWithValue("@Email", txt_N_Email.Text);
                        command.Parameters.AddWithValue("@Cep", msk_N_Cep.Text);
                        command.Parameters.AddWithValue("@Logradouro", txt_N_Logradouro.Text);
                        command.Parameters.AddWithValue("@Numero", txt_N_Numero.Text);
                        command.Parameters.AddWithValue("@Bairro", txt_N_Bairro.Text);
                        command.Parameters.AddWithValue("@Cidade", txt_N_Cidade.Text);
                        command.Parameters.AddWithValue("@Estado", cb_N_Estado.Text);
                        command.Parameters.AddWithValue("@Telefone", msk_N_Tel.Text);
                        command.Parameters.AddWithValue("@Dt_inicio", Convert.ToDateTime(msk_N_DtInicio.Text));

                        conexao.Open();
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        conexao.Close();

                        msk_N_Cpf.Text = null;
                        txt_N_Nome.Text = null;
                        txt_N_Email.Text = null;
                        msk_N_Cep.Text = null;
                        txt_N_Logradouro.Text = null;
                        txt_N_Numero.Text = null;
                        txt_N_Bairro.Text = null;
                        txt_N_Cidade.Text = null;
                        cb_N_Estado.Text = null;
                        msk_N_Tel.Text = null;
                        msk_N_DtInicio.Text = null;
                        msk_N_DtFinal.Text = null;
                        MessageBox.Show("O NUTRICIONISTA FOI CADASTRADO");
                    }
                    catch
                    {
                        MessageBox.Show("ERRO NO CADASTRO");
                    }
                }
                else
                {
                    MessageBox.Show(camposvazio);
                }
            }
        }

        private void btn_AG_NPesquisar_Click(object sender, EventArgs e)
        {
            if (txt_AG_IDNutricionista.Text != "")
            {
                string id = txt_AG_IDNutricionista.Text;

                string sqlquery = "SELECT id, nome FROM tb_nutricionista WHERE id = " + id + ";";


                MySqlConnection conexao = new MySqlConnection(myconn.conectar());

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_D_Id.Text = Convert.ToString(reader["id"]);
                    txt_D_Nome.Text = Convert.ToString(reader["nome"]);
                }
            }
            else if (txt_D_Nome.Text != "")
            {
                string nome = txt_D_Nome.Text;

                string sqlquery = "SELECT id, nome FROM tb_nutricionista WHERE nome = '" + nome + "';";


                MySqlConnection conexao = new MySqlConnection(myconn.conectar());

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_D_Id.Text = Convert.ToString(reader["id"]);
                    txt_D_Nome.Text = Convert.ToString(reader["nome"]);
                }
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Digite o Id ou Nome para pesquisar");
            }
        }

        private void btn_AG_PPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
