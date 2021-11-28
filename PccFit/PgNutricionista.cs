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
    public partial class PgNutricionista : Form
    {
        Conexao myconn = new Conexao();
        MySqlDataReader reader;

        public PgNutricionista()
        {
            InitializeComponent();
        }

        private void btn_N_Salvar_Click(object sender, EventArgs e)
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
                    string senha = msk_N_Cpf.Text.Substring(9).Replace("-","");
                    
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

        private void btn_N_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (msk_N_Cpf.Text == "   .   .   -")
                {
                    MessageBox.Show("Digite o CPF do Nutricionista");
                }
                else
                {
                    string sqlquery = "DELETE FROM tb_nutricionista WHERE cpf = @Cpf;DELETE FROM tb_login WHERE cpf = @Cpf;";

                    using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Cpf", msk_N_Cpf.Text);

                        conexao.Open();
                        command.ExecuteNonQuery();

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
                        MessageBox.Show("NUTRICIONISTA EXCLUIDO");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO AO EXCLUIR");
            }
        }

        private void btn_N_Atualizar_Click(object sender, EventArgs e)
        {
            string concat = "";
            string sqlquery = "UPDATE tb_nutricionista SET ";

            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                try
                {

                    if (msk_N_Cpf.Text == "   .   .   -")
                    {
                        MessageBox.Show("Campo CPF é obrigatorio");
                    }
                    else
                    {
                        if (txt_N_Nome.Text != "")
                        {
                            sqlquery += "nome = '" + txt_N_Nome.Text + "'";
                            concat = ", ";
                        }

                        if (txt_N_Email.Text != "")
                        {
                            sqlquery += concat + " email = '" + txt_N_Email.Text + "'";
                            concat = ", ";
                        }

                        if (msk_N_Tel.Text != "(  )     -")
                        {
                            sqlquery += concat + " telefone = '" + msk_N_Tel.Text + "'";
                            concat = ", ";
                        }

                        if (txt_N_Logradouro.Text != "")
                        {
                            sqlquery += concat + " logradouro = '" + txt_N_Logradouro.Text + "'";
                            concat = ", ";
                        }

                        if (cb_N_Estado.Text != "")
                        {
                            sqlquery += concat + " estado = '" + cb_N_Estado.Text + "'";
                            concat = ", ";
                        }

                        if (txt_N_Cidade.Text != "")
                        {
                            sqlquery += concat + " cidade = '" + txt_N_Cidade.Text + "'";
                            concat = ", ";
                        }

                        if (txt_N_Bairro.Text != "")
                        {
                            sqlquery += concat + " bairro = '" + txt_N_Bairro.Text + "'";
                            concat = ", ";
                        }

                        if (msk_N_Cep.Text != "     -")
                        {
                            sqlquery += concat + " cep = '" + msk_N_Cep.Text + "'";
                            concat = ", ";
                        }


                        if (txt_N_Numero.Text != "")
                        {
                            sqlquery += concat + " numero = '" + txt_N_Numero.Text + "'";
                            concat = ", ";
                        }

                        if (msk_N_DtInicio.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_inicio = @Dt_inicio";
                            concat = ", ";
                        }

                        if (msk_N_DtFinal.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_final = @Dt_final";
                        }

                        sqlquery += " WHERE cpf = '" + msk_N_Cpf.Text + "';";


                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                        if (msk_N_DtInicio.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_inicio", Convert.ToDateTime(msk_N_DtInicio.Text));
                        }

                        if (msk_N_DtFinal.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_final", Convert.ToDateTime(msk_N_DtFinal.Text));
                        }

                        conexao.Open();
                        command.ExecuteNonQuery();

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

                        MessageBox.Show("O NUTRICIONISTA FOI ATUALIZADO");
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO AO ATUALIZAR INFORMAÇÕES");
                }
            }
        }

        private void btn_N_Pesquisar_Click(object sender, EventArgs e)
        {
            if (msk_N_Cpf.Text != "   .   .   -")
            {
                string cpf = msk_N_Cpf.Text;

                string sqlquery = "SELECT * FROM tb_nutricionista WHERE cpf = '" + cpf + "';";


                MySqlConnection conexao = new MySqlConnection(myconn.conectar());

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    txt_N_Nome.Text = Convert.ToString(reader["nome"]);
                    txt_N_Email.Text = Convert.ToString(reader["email"]);
                    msk_N_Tel.Text = Convert.ToString(reader["telefone"]);
                    txt_N_Logradouro.Text = Convert.ToString(reader["logradouro"]);
                    txt_N_Numero.Text = Convert.ToString(reader["numero"]);
                    cb_N_Estado.Text = Convert.ToString(reader["estado"]);
                    txt_N_Cidade.Text = Convert.ToString(reader["cidade"]);
                    txt_N_Bairro.Text = Convert.ToString(reader["bairro"]);
                    msk_N_Cep.Text = Convert.ToString(reader["cep"]);
                    msk_N_DtInicio.Text = Convert.ToString(reader["dt_inicio"]);
                    msk_N_DtFinal.Text = Convert.ToString(reader["dt_final"]);
                }
            }
            else
            {
                MessageBox.Show("Digite o CPF para pesquisar");
            }
        }
    }
}
