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
    public class RotinaController : ApiController
    {
        private static List<Rotina> Coments = new List<Rotina>();
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        //nutricionista
        //nut_cpf
        //paciente
        //pac_cpf
        //id
        //id_nutricionista
        //id_paciente
        //item
        //feito
        //public string Post(string ncpf, string email, string comentario, string assunto)
        //{
        //    if (!string.IsNullOrEmpty(comentario) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(assunto))
        //    {
        //        try
        //        {
        //            string querynut = "SELECT id from tb_nutricionista WHERE nut_cpf = @NCPF;";
        //            string querynut = "SELECT id from tb_paciente WHERE nut_cpf = @PCPF;";


        //            string query = "INSERT INTO tb_comentarios (nome, email, comentario, assunto) values (@Nome, @Email, @Coment, @Assunto)";
        //            using (MySqlConnection conexao = new MySqlConnection(myconn))
        //            {
        //                MySqlCommand commandcpf = new MySqlCommand(querycpf, conexao);
        //                commandcpf.Parameters.AddWithValue("@NCPF", ncpf);

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
                    string query = "SELECT * FROM vw_rotina WHERE pac_cpf = @PCpf;";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@PCpf", PCpf);

                        conexao.Open();
                        reader = command.ExecuteReader();

                        List<dynamic> list = new List<dynamic>();

                        while (reader.Read())
                        {
                            string Paciente = Convert.ToString(reader["paciente"]);
                            string Item = Convert.ToString(reader["item"]);
                            string Feito = Convert.ToString(reader["feito"]);

                            list.Add(new { paciente = Paciente, item = Item, feito = Feito });
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
                    string query = "SELECT * FROM vw_rotina WHERE nut_cpf = @NCpf;";
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
                            string Item = Convert.ToString(reader["item"]);
                            string Feito = Convert.ToString(reader["feito"]);

                            list.Add(new { paciente = Paciente, item = Item, feito = Feito });
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
