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
        string sqlquery;
        string query;
        MySqlDataReader reader;

        public PgAgenda()
        {
            InitializeComponent();
        }

        Conexao myconn = new Conexao();

        private void btn_AG_DtPesquisar_Click(object sender, EventArgs e)
        {
            if (msk_AG_Data.Text.Replace("/", "").Replace(" ", "") != "")
            {
                using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                {
                    if (msk_AG_Horario.Text.Replace(":", "").Replace(" ", "") != "")
                    {
                        query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where dt_agenda = @Agenda and horario = @Horario;";
                        
                        MySqlCommand command = new MySqlCommand(query, conexao);

                        command.Parameters.AddWithValue("@Agenda", Convert.ToDateTime(msk_AG_Data.Text));
                        command.Parameters.AddWithValue("@Horario", Convert.ToDateTime(msk_AG_Horario.Text));

                        conexao.Open();
                        MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                        DataTable dtgrid = new DataTable();

                        returnVal.Fill(dtgrid);
                        dtGridAgenda.DataSource = dtgrid;
                        
                        conexao.Close();
                    }
                    else
                    {
                        query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where dt_agenda = @Agenda;";
                        
                        
                        MySqlCommand command = new MySqlCommand(query, conexao);

                        command.Parameters.AddWithValue("@Agenda", Convert.ToDateTime(msk_AG_Data.Text));

                        conexao.Open();
                        MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                        DataTable dtgrid = new DataTable();

                        returnVal.Fill(dtgrid);
                        dtGridAgenda.DataSource = dtgrid;

                        conexao.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite a Data");
            }
        }

        private void btn_AG_Agendar_Click(object sender, EventArgs e)
        {
            sqlquery = "INSERT INTO tb_agenda (id_nutricionista, id_paciente, dt_agenda, horario, descricao) VALUES (@Id_nutricionista, @Id_paciente, @Dt_agenda, @Horario, @Descricao);";
            string camposvazio = "";
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                if (txt_AG_IDNutricionista.Text == "")
                {
                    camposvazio = camposvazio + "Campo Id Nutricionista é obrigatorio \n";
                }

                if (txt_AG_IDPaciente.Text == "")
                {
                    camposvazio = camposvazio + "Campo Id Paciente é obrigatorio \n";
                }

                if (txt_AG_Descrição.Text == "")
                {
                    camposvazio = camposvazio + "Campo Logradouro é obrigatorio \n";
                }

                if (msk_AG_Data.Text.Replace("/", "").Replace(" ", "") == "")
                {
                    camposvazio = camposvazio + "Campo Data é obrigatorio \n";
                }

                if (msk_AG_Horario.Text.Replace(":", "").Replace(" ", "") == "")
                {
                    camposvazio = camposvazio + "Campo Horario é obrigatorio \n";
                }


                if (camposvazio == "")
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                        command.Parameters.AddWithValue("@Id_nutricionista", txt_AG_IDNutricionista.Text);
                        command.Parameters.AddWithValue("@Id_paciente", txt_AG_IDPaciente.Text);
                        command.Parameters.AddWithValue("@Dt_agenda", Convert.ToDateTime(msk_AG_Data.Text));
                        command.Parameters.AddWithValue("@Horario", Convert.ToDateTime(msk_AG_Horario.Text));
                        command.Parameters.AddWithValue("@Descricao", txt_AG_Descrição.Text);

                        conexao.Open();
                        command.ExecuteNonQuery();
                        conexao.Close();

                        
                        txt_AG_IDNutricionista.Text = null;
                        cb_AG_Nutricionista.Text = null;
                        txt_AG_IDPaciente.Text = null;
                        cb_AG_Paciente.Text = null;
                        msk_AG_Data.Text = null;
                        msk_AG_Horario.Text = null;
                        txt_AG_Descrição.Text = null;
                        
                        MessageBox.Show("Consulta Agendada");
                    }
                    catch
                    {
                        MessageBox.Show("ERRO AO AGENDAR");
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
            if (txt_AG_IDNutricionista.Text == "")
            {
                MessageBox.Show("Digite o Id ou Nome para pesquisar");
            }
            else
            {
                using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                {
                    query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where id_nutricionista = @IDN;";

                    MySqlCommand command = new MySqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@IDN", txt_AG_IDNutricionista.Text);

                    conexao.Open();
                    MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                    DataTable dtgrid = new DataTable();

                    returnVal.Fill(dtgrid);
                    dtGridAgenda.DataSource = dtgrid;

                    conexao.Close();
                }
            }
        }

        private void btn_AG_PPesquisar_Click(object sender, EventArgs e)
        {
            if (txt_AG_IDPaciente.Text == "")
            {
                MessageBox.Show("Digite o Id ou Nome para pesquisar");
            }
            else
            {
                using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
                {
                    query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where id_paciente = @IDP;";

                    MySqlCommand command = new MySqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@IDP", txt_AG_IDPaciente.Text);

                    conexao.Open();
                    MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                    DataTable dtgrid = new DataTable();

                    returnVal.Fill(dtgrid);
                    dtGridAgenda.DataSource = dtgrid;

                    conexao.Close();
                }
            }
        }

        private void Btn_AG_Hoje_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                query = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where dt_agenda = @Agenda;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Agenda", DateTime.Today);

                conexao.Open();
                MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                DataTable dtgrid = new DataTable();

                returnVal.Fill(dtgrid);
                dtGridAgenda.DataSource = dtgrid;

                conexao.Close();
            }
        }

        private void btn_AG_Excluir_Click(object sender, EventArgs e)
        {
            string camposvazio = "";
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                try
                {
                    if (txt_AG_IDPaciente.Text == "")
                    {
                        camposvazio = camposvazio + "Campo Id Paciente é obrigatorio \n";
                    }
                
                    if (msk_AG_Data.Text.Replace("/", "").Replace(" ", "") == "")
                    {
                        camposvazio = camposvazio + "Campo Data é obrigatorio \n";
                    }

                    if (msk_AG_Horario.Text.Replace(":", "").Replace(" ", "") == "")
                    {
                        camposvazio = camposvazio + "Campo Horario é obrigatorio \n";
                    }

                    if (camposvazio != "")
                    {
                        MessageBox.Show(camposvazio);
                    }
                    else
                    {
                        MessageBox.Show(camposvazio);
                        sqlquery = "DELETE FROM tb_agenda WHERE id_paciente = @IDP and dt_agenda = @DT and horario = @Horario;";
                    
                        MySqlCommand command = new MySqlCommand(sqlquery, conexao);


                        command.Parameters.AddWithValue("@IDP", txt_AG_IDPaciente.Text);
                        command.Parameters.AddWithValue("@DT", Convert.ToDateTime(msk_AG_Data.Text));
                        command.Parameters.AddWithValue("@Horario", Convert.ToDateTime(msk_AG_Horario.Text));


                        conexao.Open();
                        command.ExecuteNonQuery();

                        conexao.Close();

                        txt_AG_IDNutricionista.Text = null;
                        cb_AG_Nutricionista.Text = null;
                        txt_AG_IDPaciente.Text = null;
                        cb_AG_Paciente.Text = null;
                        msk_AG_Data.Text = null;
                        msk_AG_Horario.Text = null;
                        txt_AG_Descrição.Text = null;

                        MessageBox.Show("Agendamento Excluido");
                    }
                }
                    catch
                {
                    MessageBox.Show("ERRO AO EXCLUIR AGENDAMENTO");
                }
            }
        }

        private void dtGridAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_AG_IDNutricionista.Text = dtGridAgenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            cb_AG_Nutricionista.Text = dtGridAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_AG_IDPaciente.Text = dtGridAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_AG_Paciente.Text = dtGridAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            msk_AG_Horario.Text = dtGridAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            msk_AG_Data.Text = dtGridAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_AG_Descrição.Text = dtGridAgenda.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void PgAgenda_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                conexao.Open();

                query = "SELECT id, nome FROM tb_nutricionista;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                
                MySqlDataAdapter returnVal = new MySqlDataAdapter(command);
                DataTable dtgrid = new DataTable();

                returnVal.Fill(dtgrid);

                cb_AG_Nutricionista.DataSource = dtgrid;
                cb_AG_Nutricionista.ValueMember = "nome";
                cb_AG_Nutricionista.DisplayMember = "descricao";
                cb_AG_Nutricionista.SelectedItem = "";
                cb_AG_Nutricionista.Refresh();


                string query2 = "SELECT id, nome FROM tb_paciente;";

                MySqlCommand command2 = new MySqlCommand(query2, conexao);


                MySqlDataAdapter returnVal2 = new MySqlDataAdapter(command2);
                DataTable dtgrid2 = new DataTable();

                returnVal2.Fill(dtgrid2);

                cb_AG_Paciente.DataSource = dtgrid2;
                cb_AG_Paciente.ValueMember = "nome";
                cb_AG_Paciente.DisplayMember = "descricao";
                cb_AG_Paciente.SelectedItem = "";
                cb_AG_Paciente.Refresh();


                string query3 = "SELECT id_nutricionista, nutricionista, id_paciente, paciente, horario, dt_agenda, descricao FROM vw_agenda where dt_agenda = @Agenda;";

                MySqlCommand command3 = new MySqlCommand(query3, conexao);

                command3.Parameters.AddWithValue("@Agenda", DateTime.Today);

                
                MySqlDataAdapter returnVal3 = new MySqlDataAdapter(command3);
                DataTable dtgrid3 = new DataTable();

                returnVal3.Fill(dtgrid3);
                dtGridAgenda.DataSource = dtgrid3;


                conexao.Close();
            }
        }

        private void cb_AG_Nutricionista_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                query = "SELECT id FROM tb_nutricionista where nome = @Nome;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Nome", cb_AG_Nutricionista.Text);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_AG_IDNutricionista.Text = Convert.ToString(reader["id"]);
                }

                conexao.Close();
            }
        }

        private void cb_AG_Paciente_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void cb_AG_Nutricionista_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void cb_AG_Paciente_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(myconn.conectar()))
            {
                query = "SELECT id FROM tb_paciente where nome = @Nome;";

                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Nome", cb_AG_Paciente.Text);

                conexao.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_AG_IDPaciente.Text = Convert.ToString(reader["id"]);
                }

                conexao.Close();
            }
        }
    }
}
