using PccAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Web.Script.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace PccAPI.Controllers
{
    public class AgendaController : ApiController
    {
        private static List<Agenda> Coments = new List<Agenda>();
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        //Nutricionista
        //Paciente
        //Id
        //Id_nutricionista
        //Id_paciente
        //Dt_agenda
        //Horario
        //Descricao

        //public string Post(string nome, string email, string comentario, string assunto)
        //{
        //    if (!string.IsNullOrEmpty(comentario) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(assunto))
        //    {
        //        try
        //        {
        //            string query = "INSERT INTO tb_comentarios (nome, email, comentario, assunto) values (@Nome, @Email, @Coment, @Assunto)";
        //            using (MySqlConnection conexao = new MySqlConnection(myconn))
        //            {
        //                MySqlCommand command = new MySqlCommand(query, conexao);
        //                command.Parameters.AddWithValue("@Nome", nome);
        //                command.Parameters.AddWithValue("@Email", email);
        //                command.Parameters.AddWithValue("@Coment", comentario);
        //                command.Parameters.AddWithValue("@Assunto", assunto);

        //                conexao.Open();
        //                reader = command.ExecuteReader();
        //                conexao.Close();

        //                return @"{""Status"":""OK""}";
        //            }
        //        }
        //        catch
        //        {
        //            return @"{""Status"":""ERRO""}";
        //        }
        //    }
        //    else
        //    {
        //        return @"{""Status"":""Campos Vazios""}";
        //    }
        //}



        public string Get(string PCpf)
        {
            if (!string.IsNullOrEmpty(PCpf))
            {
                try
                {
                    string query = "SELECT * FROM vw_agenda WHERE pac_cpf = @PCpf;";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@PCpf", PCpf);

                        conexao.Open();
                        reader = command.ExecuteReader();

                        List<dynamic> list = new List<dynamic>();

                        while (reader.Read())
                        {
                            string Nutricionista = Convert.ToString(reader["nutricionista"]);
                            string Dt_agenda = Convert.ToString(reader["dt_agenda"]);
                            string Horario = Convert.ToString(reader["horario"]);

                            list.Add(new { nutricionista = Nutricionista, dt_agenda = Dt_agenda, horario = Horario });
                        }
                        conexao.Close();
                        return JsonConvert.SerializeObject(list);

                    }
                }
                catch
                {

                    return @"{""Status"":""ERRO""}";
                }
            }
            else
            {
                return @"{""Status"":""Campos Vazios""}";
            }
        }

        public string GET(string NCpf)
        {
            if (!string.IsNullOrEmpty(NCpf))
            {
                try
                {
                    string query = "SELECT * FROM vw_agenda WHERE nut_cpf = @NCpf;";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@NCpf", NCpf);

                        conexao.Open();
                        reader = command.ExecuteReader();

                        List<dynamic> list = new List<dynamic>();

                        while (reader.Read())
                        {
                            string Paciente = Convert.ToString(reader["paciente"]);
                            string Dt_agenda = Convert.ToString(reader["dt_agenda"]);
                            string Horario = Convert.ToString(reader["horario"]);

                            list.Add(new { paciente = Paciente, dt_agenda = Dt_agenda, horario = Horario });
                        }
                        conexao.Close();
                        return JsonConvert.SerializeObject(list);

                    }
                }
                catch
                {

                    return @"{""Status"":""ERRO""}";
                }
            }
            else
            {
                return @"{""Status"":""Campos Vazios""}";
            }
        }
    }
}
