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
    public partial class PgAtendente : Form
    {
        Conexao myconn = new Conexao();
        MySqlDataReader reader;

        public PgAtendente()
        {
            InitializeComponent();
        }

        private void btn_A_Pesquisar_Click(object sender, EventArgs e)
        {
            if (msk_A_Cpf.Text != "   .   .   -")
            {
                string cpf = msk_A_Cpf.Text;

                string sqlquery = "SELECT * FROM tb_atendente WHERE cpf = '" + cpf + "';";


                MySqlConnection conexao = new MySqlConnection(myconn.conectar());

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_A_Nome.Text = Convert.ToString(reader["nome"]);
                    txt_A_Email.Text = Convert.ToString(reader["email"]);
                    msk_A_Tel.Text = Convert.ToString(reader["telefone"]);
                    txt_A_Logradouro.Text = Convert.ToString(reader["logradouro"]);
                    txt_A_Numero.Text = Convert.ToString(reader["numero"]);
                    cb_A_Estado.Text = Convert.ToString(reader["estado"]);
                    txt_A_Cidade.Text = Convert.ToString(reader["cidade"]);
                    txt_A_Bairro.Text = Convert.ToString(reader["bairro"]);
                    msk_A_Cep.Text = Convert.ToString(reader["cep"]);
                    msk_A_DtInicio.Text = Convert.ToString(reader["dt_inicio"]);
                    msk_A_DtFinal.Text = Convert.ToString(reader["dt_final"]);
                }
            }
            else
            {
                MessageBox.Show("Digite o CPF para pesquisar");
            }
        }

        private void btn_A_Cadastrar_Click(object sender, EventArgs e)
        {
            string sqlquery = "INSERT INTO tb_atendente (cpf, nome, email, cep, logradouro, numero, bairro, cidade, estado, telefone, dt_inicio) VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Dt_inicio);";
            string query = "INSERT INTO tb_login (cpf, senha, acesso) VALUE (@cpf, @senha, 'atendente')";

            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {

                string camposvazio = "";


                if (txt_A_Nome.Text == "")
                {
                    camposvazio = camposvazio + "Campo Nome é obrigatorio \n";
                }

                if (msk_A_Cpf.Text == "   .   .   -")
                {
                    camposvazio = camposvazio + "Campo CPF é obrigatorio \n";
                }

                if (txt_A_Email.Text == "")
                {
                    camposvazio = camposvazio + "Campo Email é obrigatorio \n";
                }

                if (msk_A_Tel.Text == "(  )     -")
                {
                    camposvazio = camposvazio + "Campo Telefone é obrigatorio \n";
                }

                if (txt_A_Logradouro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Logradouro é obrigatorio \n";
                }

                if (cb_A_Estado.Text == "")
                {
                    camposvazio = camposvazio + "Campo Estado é obrigatorio \n";
                }

                if (txt_A_Cidade.Text == "")
                {
                    camposvazio = camposvazio + "Campo Cidade é obrigatorio \n";
                }

                if (txt_A_Bairro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Bairro é obrigatorio \n";
                }

                if (msk_A_Cep.Text == "     -")
                {
                    camposvazio = camposvazio + "Campo CEP é obrigatorio \n";
                }

                if (msk_A_DtInicio.Text == "  /  /")
                {
                    camposvazio = camposvazio + "Campo Data de inicio é obrigatorio \n";
                }

                if (txt_A_Numero.Text == "")
                {
                    sqlquery = "INSERT INTO tb_atendente (cpf, nome, email, cep, logradouro, bairro, cidade, estado, telefone, dt_inicio) VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Bairro, @Cidade, @Estado, @Telefone, @Dt_inicio);";
                }

                if (camposvazio == "")
                {
                    try
                    {
                        string senha = msk_A_Cpf.Text.Substring(9).Replace("-", "");
                        MySqlCommand command2 = new MySqlCommand(query, conexao);
                        command2.Parameters.AddWithValue("@cpf", msk_A_Cpf.Text);
                        command2.Parameters.AddWithValue("@senha", senha);

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

                        conexao.Open();
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        conexao.Close();

                        msk_A_Cpf.Text = null;
                        txt_A_Nome.Text = null;
                        txt_A_Email.Text = null;
                        msk_A_Cep.Text = null;
                        txt_A_Logradouro.Text = null;
                        txt_A_Numero.Text = null;
                        txt_A_Bairro.Text = null;
                        txt_A_Cidade.Text = null;
                        cb_A_Estado.Text = null;
                        msk_A_Tel.Text = null;
                        msk_A_DtInicio.Text = null;
                        msk_A_DtFinal.Text = null;
                        MessageBox.Show("O ATENDENTE FOI CADASTRADO");
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

        private void btn_A_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (msk_A_Cpf.Text == "   .   .   -")
                {
                    MessageBox.Show("Digite o CPF do Atendente");
                }
                else
                {
                    string sqlquery = "DELETE FROM tb_atendente WHERE cpf = @Cpf;";

                    using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Cpf", msk_A_Cpf.Text);

                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        msk_A_Cpf.Text = null;
                        txt_A_Nome.Text = null;
                        txt_A_Email.Text = null;
                        msk_A_Cep.Text = null;
                        txt_A_Logradouro.Text = null;
                        txt_A_Numero.Text = null;
                        txt_A_Bairro.Text = null;
                        txt_A_Cidade.Text = null;
                        cb_A_Estado.Text = null;
                        msk_A_Tel.Text = null;
                        msk_A_DtInicio.Text = null;
                        msk_A_DtFinal.Text = null;
                        MessageBox.Show("ATENDENTE EXCLUIDO");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO AO EXCLUIR ATENDENTE");
            }
        }

        private void btn_A_Atualizar_Click(object sender, EventArgs e)
        {
            string concat = "";
            string sqlquery = "UPDATE tb_atendente SET ";

            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                try
                {

                    if (msk_A_Cpf.Text == "   .   .   -")
                    {
                        MessageBox.Show("Campo CPF é obrigatorio");
                    }
                    else
                    {
                        if (txt_A_Nome.Text != "")
                        {
                            sqlquery += "nome = '" + txt_A_Nome.Text + "'";
                            concat = ", ";
                        }

                        if (txt_A_Email.Text != "")
                        {
                            sqlquery += concat + " email = '" + txt_A_Email.Text + "'";
                            concat = ", ";
                        }

                        if (msk_A_Tel.Text != "(  )     -")
                        {
                            sqlquery += concat + " telefone = '" + msk_A_Tel.Text + "'";
                            concat = ", ";
                        }

                        if (txt_A_Logradouro.Text != "")
                        {
                            sqlquery += concat + " logradouro = '" + txt_A_Logradouro.Text + "'";
                            concat = ", ";
                        }

                        if (cb_A_Estado.Text != "")
                        {
                            sqlquery += concat + " estado = '" + cb_A_Estado.Text + "'";
                            concat = ", ";
                        }

                        if (txt_A_Cidade.Text != "")
                        {
                            sqlquery += concat + " cidade = '" + txt_A_Cidade.Text + "'";
                            concat = ", ";
                        }

                        if (txt_A_Bairro.Text != "")
                        {
                            sqlquery += concat + " bairro = '" + txt_A_Bairro.Text + "'";
                            concat = ", ";
                        }

                        if (msk_A_Cep.Text != "     -")
                        {
                            sqlquery += concat + " cep = '" + msk_A_Cep.Text + "'";
                            concat = ", ";
                        }


                        if (txt_A_Numero.Text != "")
                        {
                            sqlquery += concat + " numero = '" + txt_A_Numero.Text + "'";
                            concat = ", ";
                        }

                        if (msk_A_DtInicio.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_inicio = @Dt_inicio";
                            concat = ", ";
                        }

                        if (msk_A_DtFinal.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_final = @Dt_final";
                        }

                        sqlquery += " WHERE cpf = '" + msk_A_Cpf.Text + "';";


                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                        if (msk_A_DtInicio.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_inicio", Convert.ToDateTime(msk_A_DtInicio.Text));
                        }

                        if (msk_A_DtFinal.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_final", Convert.ToDateTime(msk_A_DtFinal.Text));
                        }

                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        msk_A_Cpf.Text = null;
                        txt_A_Nome.Text = null;
                        txt_A_Email.Text = null;
                        msk_A_Cep.Text = null;
                        txt_A_Logradouro.Text = null;
                        txt_A_Numero.Text = null;
                        txt_A_Bairro.Text = null;
                        txt_A_Cidade.Text = null;
                        cb_A_Estado.Text = null;
                        msk_A_Tel.Text = null;
                        msk_A_DtInicio.Text = null;
                        msk_A_DtFinal.Text = null;

                        MessageBox.Show("O ATENDENTE FOI ATUALIZADO");
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO AO ATUALIZAR INFORMAÇÕES");
                }
            }
        }
    }
}
