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
    public partial class PgRotina : Form
    {

        string sqlquery;
        string query;
        MySqlDataReader reader;
        Conexao myconn = new Conexao();

        public PgRotina()
        {
            InitializeComponent();
        }

        private void btn_R_NPesquisar_Click(object sender, EventArgs e)
        {
            if (txt_R_IDNutricionista.Text == "")
            {
                MessageBox.Show("Digite o Id ou Nome para pesquisar");
            }
            else
            {
                using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                {
                    query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, item, feito FROM vw_rotina where id_nutricionista = @IDN;";

                    MySqlCommand command = new MySqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@IDN", txt_R_IDNutricionista.Text);

                    conexao.Open();
                    MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                    DataTable dtgrid = new DataTable();

                    returnVal.Fill(dtgrid);
                    dtGridRotina.DataSource = dtgrid;

                    conexao.Close();
                }
            }
        }

        private void btn_R_PPesquisar_Click(object sender, EventArgs e)
        {
            if (txt_R_IDPaciente.Text == "")
            {
                MessageBox.Show("Digite o Id ou Nome para pesquisar");
            }
            else
            {
                using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                {
                    query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, item, feito FROM vw_rotina where id_paciente = @IDP;";

                    MySqlCommand command = new MySqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@IDP", txt_R_IDPaciente.Text);

                    conexao.Open();
                    MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                    DataTable dtgrid = new DataTable();

                    returnVal.Fill(dtgrid);
                    dtGridRotina.DataSource = dtgrid;

                    conexao.Close();
                }
            }
        }

        private void btn_R_Cadastrar_Click(object sender, EventArgs e)
        {
            sqlquery = "INSERT INTO tb_rotina (id_nutricionista, id_paciente, item, feito) VALUES (@Id_nutricionista, @Id_paciente, @Item, @Feito);";
            string camposvazio = "";
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                if (txt_R_IDNutricionista.Text == "")
                {
                    camposvazio = camposvazio + "Campo Id Nutricionista é obrigatorio \n";
                }

                if (txt_R_IDPaciente.Text == "")
                {
                    camposvazio = camposvazio + "Campo Id Paciente é obrigatorio \n";
                }

                if (txt_R_Itens.Text == "")
                {
                    camposvazio = camposvazio + "Campo Itens é obrigatorio \n";
                }


                if (camposvazio == "")
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Id_nutricionista", txt_R_IDNutricionista.Text);
                        command.Parameters.AddWithValue("@Id_paciente", txt_R_IDPaciente.Text);
                        command.Parameters.AddWithValue("@Item", txt_R_Itens.Text);
                        command.Parameters.AddWithValue("@Feito", false);

                        conexao.Open();
                        command.ExecuteNonQuery();
                        conexao.Close();


                        txt_R_IDNutricionista.Text = null;
                        cb_R_Nutricionista.Text = null;
                        txt_R_IDPaciente.Text = null;
                        cb_R_Paciente.Text = null;
                        txt_R_Itens.Text = null;

                        MessageBox.Show("Item da rotina adicionado");
                    }
                    catch
                    {
                        MessageBox.Show("ERRO AO CADASTRAR ITEM");
                    }
                }
                else
                {
                    MessageBox.Show(camposvazio);
                }
            }
        }

        private void btn_R_Excluir_Click(object sender, EventArgs e)
        {
            string camposvazio = "";
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                try
                {
                    if (txt_R_IDPaciente.Text == "")
                    {
                        camposvazio = camposvazio + "Campo Id Paciente é obrigatorio \n";
                    }

                    if (txt_R_Itens.Text == "")
                    {
                        camposvazio = camposvazio + "Campo Item é obrigatorio \n";
                    }

                    if (camposvazio != "")
                    {
                        MessageBox.Show(camposvazio);
                    }
                    else
                    {
                        MessageBox.Show(camposvazio);
                        sqlquery = "DELETE FROM tb_rotina WHERE id_paciente = @IDP and item = @IT;";

                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);


                        command.Parameters.AddWithValue("@IDP", txt_R_IDPaciente.Text);
                        command.Parameters.AddWithValue("@IT", txt_R_Itens.Text);


                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        txt_R_IDNutricionista.Text = null;
                        cb_R_Nutricionista.Text = null;
                        txt_R_IDPaciente.Text = null;
                        cb_R_Paciente.Text = null;
                        txt_R_Itens.Text = null;

                        MessageBox.Show("Item Excluido");
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO AO EXCLUIR ITEM");
                }
            }
        }

        private void PgRotina_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                conexao.Open();

                query = "SELECT id, nome FROM tb_nutricionista;";

                MySqlCommand command = new MySqlCommand(query, conexao);


                MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                DataTable dtgrid = new DataTable();

                returnVal.Fill(dtgrid);

                cb_R_Nutricionista.DataSource = dtgrid;
                cb_R_Nutricionista.ValueMember = "nome";
                cb_R_Nutricionista.DisplayMember = "descricao";
                cb_R_Nutricionista.SelectedItem = "";
                cb_R_Nutricionista.Refresh();


                string query2 = "SELECT id, nome FROM tb_paciente;";

                MySqlCommand command2 = new MySqlCommand(query2, conexao);


                MySqlDataAdapter returnVal2 = new MySqlDataAdapter(command2);
                DataTable dtgrid2 = new DataTable();

                returnVal2.Fill(dtgrid2);

                cb_R_Paciente.DataSource = dtgrid2;
                cb_R_Paciente.ValueMember = "nome";
                cb_R_Paciente.DisplayMember = "descricao";
                cb_R_Paciente.SelectedItem = "";
                cb_R_Paciente.Refresh();


                conexao.Close();
            }
        }
        

        private void cb_R_Nutricionista_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                query = "SELECT id FROM tb_nutricionista where nome = @Nome;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Nome", cb_R_Nutricionista.Text);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_R_IDNutricionista.Text = Convert.ToString(reader["id"]);
                }

                conexao.Close();
            }
        }

        private void cb_R_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                query = "SELECT id FROM tb_paciente where nome = @Nome;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Nome", cb_R_Paciente.Text);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_R_IDPaciente.Text = Convert.ToString(reader["id"]);
                }

                conexao.Close();
            }
        }
    }
}
