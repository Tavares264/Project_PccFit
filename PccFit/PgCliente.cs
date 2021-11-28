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
    public partial class PgCliente : Form
    {
        Conexao myconn = new Conexao();
        MySqlDataReader reader;
        MySqlDataReader reader2;

        public PgCliente()
        {
            InitializeComponent();
        }


        private void btn_C_Pesquisar_Click_1(object sender, EventArgs e)
        {
            if (msk_C_Cpf.Text != "   .   .   -")
            {
                string cpf = msk_C_Cpf.Text;
                string idnutri = "";

                string sqlquery = "SELECT * FROM tb_paciente WHERE cpf = '" + cpf + "';";
                string sqlquery2 = "";

                MySqlConnection conexao = new MySqlConnection(myconn.conectar());

                MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                conexao.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    txt_C_Nome.Text = Convert.ToString(reader["nome"]);
                    txt_C_Email.Text = Convert.ToString(reader["email"]);
                    msk_C_Tel.Text = Convert.ToString(reader["telefone"]);
                    txt_C_Logradouro.Text = Convert.ToString(reader["logradouro"]);
                    txt_C_Numero.Text = Convert.ToString(reader["numero"]);
                    cbc_C_Estado.Text = Convert.ToString(reader["estado"]);
                    txt_C_Cidade.Text = Convert.ToString(reader["cidade"]);
                    txt_C_Bairro.Text = Convert.ToString(reader["bairro"]);
                    msk_C_Cep.Text = Convert.ToString(reader["cep"]);
                    msk_C_DtInicio.Text = Convert.ToString(reader["dt_inicio"]);
                    msk_C_DtFinal.Text = Convert.ToString(reader["dt_final"]);
                    msk_C_DtNascimento.Text = Convert.ToString(reader["dt_nascimento"]);
                    txt_C_Altura.Text = Convert.ToString(reader["altura"]);
                    txt_C_Peso.Text = Convert.ToString(reader["peso"]);
                    txt_D_Valor.Text = Convert.ToString(reader["valor"]);
                    txt_D_Quantidade.Text = Convert.ToString(reader["quantidade"]);
                    txt_D_Objetivo.Text = Convert.ToString(reader["objetivo"]);

                    idnutri = Convert.ToString(reader["id_nutricionista"]);

                }


                reader.Close();


                if (idnutri != "")
                {
                    sqlquery2 = "SELECT id, nome FROM tb_nutricionista WHERE id = " + idnutri + ";";
                    command = new MySqlCommand(sqlquery2, conexao);
                    reader2 = command.ExecuteReader();

                    while (reader2.Read())
                    {
                        txt_D_Id.Text = Convert.ToString(reader2["id"]);
                        txt_D_Nome.Text = Convert.ToString(reader2["nome"]);
                    }
                }

                conexao.Close();

            }
            else
            {
                MessageBox.Show("Digite o CPF para pesquisar");
            }
        }

        private void btn_C_Cadastrar_Click_1(object sender, EventArgs e)
        {
            string sqlcampos = "INSERT INTO tb_paciente (cpf, nome, email, cep, logradouro, bairro, cidade, estado, telefone, altura, peso, dt_nascimento";

            string sqlvalues = "VALUES (@Cpf, @Nome, @Email, @Cep, @Logradouro, @Bairro, @Cidade, @Estado, @Telefone, @Altura, @Peso, @DtNascimento";


            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {

                string camposvazio = "";


                if (txt_C_Nome.Text == "")
                {
                    camposvazio = camposvazio + "Campo Nome é obrigatorio \n";
                }

                if (msk_C_Cpf.Text == "   .   .   -")
                {
                    camposvazio = camposvazio + "Campo CPF é obrigatorio \n";
                }

                if (txt_C_Email.Text == "")
                {
                    camposvazio = camposvazio + "Campo Email é obrigatorio \n";
                }

                if (msk_C_Tel.Text == "(  )     -")
                {
                    camposvazio = camposvazio + "Campo Telefone é obrigatorio \n";
                }

                if (txt_C_Logradouro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Logradouro é obrigatorio \n";
                }

                if (cb_C_Estado.Text == "")
                {
                    camposvazio = camposvazio + "Campo Estado é obrigatorio \n";
                }

                if (txt_C_Cidade.Text == "")
                {
                    camposvazio = camposvazio + "Campo Cidade é obrigatorio \n";
                }

                if (txt_C_Bairro.Text == "")
                {
                    camposvazio = camposvazio + "Campo Bairro é obrigatorio \n";
                }

                if (msk_C_Cep.Text == "     -")
                {
                    camposvazio = camposvazio + "Campo CEP é obrigatorio \n";
                }

                if (txt_C_Altura.Text == "")
                {
                    camposvazio = camposvazio + "Campo Altura é obrigatorio \n";
                }

                if (txt_C_Peso.Text == "")
                {
                    camposvazio = camposvazio + "Campo Peso é obrigatorio \n";
                }

                if (msk_C_DtNascimento.Text == "  /  /")
                {
                    camposvazio = camposvazio + "Campo Data de Nascimento é obrigatorio \n";
                }

                if (txt_C_Numero.Text != "")
                {
                    sqlcampos += ", numero";
                    sqlvalues += ", " + txt_C_Numero.Text;
                }

                if (msk_C_DtInicio.Text != "  /  /")
                {
                    sqlcampos += ", dt_inicio";
                    sqlvalues += ", @dt_inicio";
                }

                if (msk_C_DtFinal.Text != "  /  /")
                {
                    sqlcampos += ", dt_final";
                    sqlvalues += ", dt_final";
                }

                if (txt_D_Id.Text != "")
                {
                    sqlcampos += ", id_nutricionista";
                    sqlvalues += ", " + Convert.ToInt32(txt_D_Id.Text);
                }

                if (txt_D_Valor.Text != "")
                {
                    sqlcampos += ", valor";
                    sqlvalues += ", " + Convert.ToDouble(txt_D_Valor.Text);
                }

                if (txt_D_Quantidade.Text != "")
                {
                    sqlcampos += ", quantidade";
                    sqlvalues += ", " + Convert.ToInt32(txt_D_Quantidade.Text);
                }

                if (txt_D_Objetivo.Text != "")
                {
                    sqlcampos += ", objetivo";
                    sqlvalues += ", '" + txt_D_Objetivo.Text + "'";
                }

                sqlcampos = sqlcampos + ") ";
                sqlvalues = sqlvalues + ");";
                string sqlquery = sqlcampos + sqlvalues;

                if (camposvazio == "")
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Cpf", msk_C_Cpf.Text);
                        command.Parameters.AddWithValue("@Nome", txt_C_Nome.Text);
                        command.Parameters.AddWithValue("@Email", txt_C_Email.Text);
                        command.Parameters.AddWithValue("@Cep", msk_C_Cep.Text);
                        command.Parameters.AddWithValue("@Logradouro", txt_C_Logradouro.Text);
                        command.Parameters.AddWithValue("@Bairro", txt_C_Bairro.Text);
                        command.Parameters.AddWithValue("@Cidade", txt_C_Cidade.Text);
                        command.Parameters.AddWithValue("@Estado", cbc_C_Estado.Text);
                        command.Parameters.AddWithValue("@Telefone", msk_C_Tel.Text);
                        command.Parameters.AddWithValue("@Altura", txt_C_Altura.Text);
                        command.Parameters.AddWithValue("@Peso", txt_C_Peso.Text);
                        command.Parameters.AddWithValue("@DtNascimento", Convert.ToDateTime(msk_C_DtNascimento.Text));

                        if (msk_C_DtInicio.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@dt_inicio", Convert.ToDateTime(msk_C_DtInicio.Text));
                        }

                        if (msk_C_DtFinal.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@dt_final", Convert.ToDateTime(msk_C_DtFinal.Text));
                        }

                        MessageBox.Show(command.CommandText);
                        conexao.Open();
                        command.ExecuteNonQuery();
                        conexao.Close();


                        msk_C_Cpf.Text = null;
                        txt_C_Nome.Text = null;
                        txt_C_Email.Text = null;
                        msk_C_Cep.Text = null;
                        txt_C_Logradouro.Text = null;
                        txt_C_Numero.Text = null;
                        txt_C_Bairro.Text = null;
                        txt_C_Cidade.Text = null;
                        cbc_C_Estado.Text = null;
                        msk_C_Tel.Text = null;
                        msk_C_DtInicio.Text = null;
                        msk_C_DtFinal.Text = null;
                        txt_D_Id.Text = null;
                        txt_D_Nome.Text = null;
                        txt_D_Valor.Text = null;
                        txt_D_Quantidade.Text = null;
                        txt_D_Objetivo.Text = null;
                        txt_C_Altura.Text = null;
                        txt_C_Peso.Text = null;
                        msk_C_DtNascimento = null;

                        MessageBox.Show("O PACIENTE FOI CADASTRADO");
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

        private void btn_NP_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_D_Id.Text != "")
            {
                string id = txt_D_Id.Text;

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

        private void btn_C_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (msk_C_Cpf.Text == "   .   .   -")
                {
                    MessageBox.Show("Digite o CPF do Paciente");
                }
                else
                {
                    string sqlquery = "DELETE FROM tb_paciente WHERE cpf = @Cpf;";

                    using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Cpf", msk_C_Cpf.Text);

                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        msk_C_Cpf.Text = null;
                        txt_C_Nome.Text = null;
                        txt_C_Email.Text = null;
                        msk_C_Cep.Text = null;
                        txt_C_Logradouro.Text = null;
                        txt_C_Numero.Text = null;
                        txt_C_Bairro.Text = null;
                        txt_C_Cidade.Text = null;
                        cbc_C_Estado.Text = null;
                        msk_C_Tel.Text = null;
                        msk_C_DtInicio.Text = null;
                        msk_C_DtFinal.Text = null;
                        txt_D_Id.Text = null;
                        txt_D_Nome.Text = null;
                        txt_D_Valor.Text = null;
                        txt_D_Quantidade.Text = null;
                        txt_D_Objetivo.Text = null;
                        txt_C_Altura.Text = null;
                        txt_C_Peso.Text = null;
                        msk_C_DtNascimento = null;
                        MessageBox.Show("PACIENTE EXCLUIDO");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO AO EXCLUIR PACIENTE");
            }
        }

        private void btn_C_Atualizar_Click(object sender, EventArgs e)
        {
            string concat = "";
            string sqlquery = "UPDATE tb_paciente SET ";

            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                try
                {

                    if (msk_C_Cpf.Text == "   .   .   -")
                    {
                        MessageBox.Show("Campo CPF é obrigatorio");
                    }
                    else
                    {
                        if (txt_C_Nome.Text != "")
                        {
                            sqlquery += "nome = '" + txt_C_Nome.Text + "'";
                            concat = ", ";
                        }

                        if (txt_C_Email.Text != "")
                        {
                            sqlquery += concat + " email = '" + txt_C_Email.Text + "'";
                            concat = ", ";
                        }

                        if (msk_C_Tel.Text != "(  )     -")
                        {
                            sqlquery += concat + " telefone = '" + msk_C_Tel.Text + "'";
                            concat = ", ";
                        }

                        if (txt_C_Logradouro.Text != "")
                        {
                            sqlquery += concat + " logradouro = '" + txt_C_Logradouro.Text + "'";
                            concat = ", ";
                        }

                        if (cbc_C_Estado.Text != "")
                        {
                            sqlquery += concat + " estado = '" + cbc_C_Estado.Text + "'";
                            concat = ", ";
                        }

                        if (txt_C_Cidade.Text != "")
                        {
                            sqlquery += concat + " cidade = '" + txt_C_Cidade.Text + "'";
                            concat = ", ";
                        }

                        if (txt_C_Bairro.Text != "")
                        {
                            sqlquery += concat + " bairro = '" + txt_C_Bairro.Text + "'";
                            concat = ", ";
                        }

                        if (msk_C_Cep.Text != "     -")
                        {
                            sqlquery += concat + " cep = '" + msk_C_Cep.Text + "'";
                            concat = ", ";
                        }


                        if (txt_C_Numero.Text != "")
                        {
                            sqlquery += concat + " numero = '" + txt_C_Numero.Text + "'";
                            concat = ", ";
                        }


                        if (txt_D_Id.Text != "")
                        {
                            sqlquery += concat + " id_nutricionista = " + Convert.ToInt32(txt_D_Id.Text);
                            concat = ", ";
                        }

                        if (txt_D_Valor.Text != "")
                        {
                            sqlquery += concat + " valor = " + Convert.ToDouble(txt_D_Valor.Text);
                            concat = ", ";
                        }

                        if (txt_D_Quantidade.Text != "")
                        {
                            sqlquery += concat + " quantidade = " + Convert.ToInt32(txt_D_Quantidade.Text);
                            concat = ", ";
                        }

                        if (txt_D_Objetivo.Text != "")
                        {
                            sqlquery += concat + " objetivo = '" + txt_D_Objetivo.Text + "'";
                            concat = ", ";
                        }

                        if (txt_C_Altura.Text != "")
                        {
                            sqlquery += concat + " altura = " + txt_C_Altura.Text;
                            concat = ", ";
                        }

                        if (txt_C_Peso.Text != "")
                        {
                            sqlquery += concat + " peso = " + txt_C_Peso.Text;
                            concat = ", ";
                        }

                        if (msk_C_DtNascimento.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_nascimento = @Dt_nascimento";
                            concat = ", ";
                        }

                        if (msk_C_DtInicio.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_inicio = @Dt_inicio";
                            concat = ", ";
                        }

                        if (msk_C_DtFinal.Text != "  /  /")
                        {
                            sqlquery += concat + " dt_final = @Dt_final";
                        }

                        sqlquery += " WHERE cpf = '" + msk_C_Cpf.Text + "';";


                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);

                        if (msk_C_DtInicio.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_inicio", Convert.ToDateTime(msk_C_DtInicio.Text));
                        }

                        if (msk_C_DtFinal.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_final", Convert.ToDateTime(msk_C_DtFinal.Text));
                        }

                        if (msk_C_DtNascimento.Text != "  /  /")
                        {
                            command.Parameters.AddWithValue("@Dt_nascimento", Convert.ToDateTime(msk_C_DtNascimento.Text));
                        }
                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        msk_C_Cpf.Text = null;
                        txt_C_Nome.Text = null;
                        txt_C_Email.Text = null;
                        msk_C_Cep.Text = null;
                        txt_C_Logradouro.Text = null;
                        txt_C_Numero.Text = null;
                        txt_C_Bairro.Text = null;
                        txt_C_Cidade.Text = null;
                        cbc_C_Estado.Text = null;
                        msk_C_Tel.Text = null;
                        msk_C_DtInicio.Text = null;
                        msk_C_DtFinal.Text = null;
                        txt_D_Id.Text = null;
                        txt_D_Nome.Text = null;
                        txt_D_Valor.Text = null;
                        txt_D_Quantidade.Text = null;
                        txt_D_Objetivo.Text = null;
                        txt_C_Altura.Text = null;
                        txt_C_Peso.Text = null;
                        msk_C_DtNascimento = null;

                        MessageBox.Show("O PACIENTE FOI ATUALIZADO");
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
