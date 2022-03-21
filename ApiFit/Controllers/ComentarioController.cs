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
    public class ComentarioController : ApiController
    {
        private static List<Comentarios> Coments = new List<Comentarios>();
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        public string Post(string nome, string email, string comentario, string assunto)
        {
            if (!string.IsNullOrEmpty(comentario) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(assunto))
            {
                try
                {

                    string query = "INSERT INTO tb_comentarios (nome, email, comentario, assunto) values (@Nome, @Email, @Coment, @Assunto)";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Coment", comentario);
                        command.Parameters.AddWithValue("@Assunto", assunto);

                        conexao.Open();
                        reader = command.ExecuteReader();
                        conexao.Close();

                        return @"{""Status"":""OK""}";
                    }
                }catch
                {
                    return @"{""Status"":""ERRO""}";
                }
            }
            else
            {
                return @"{""Status"":""Campos Vazios""}";
            }
        }

        

        public string Get(string assunto)
        {
            if (!string.IsNullOrEmpty(assunto))
            {
                    try
                    {
                        string query = "SELECT * FROM tb_comentarios WHERE assunto = @Assunto;";
                        using (MySqlConnection conexao = new MySqlConnection(myconn))
                        {
                            MySqlCommand command = new MySqlCommand(query, conexao);
                            command.Parameters.AddWithValue("@Assunto", assunto);

                            conexao.Open();
                            reader = command.ExecuteReader();

                            List<dynamic> list = new List<dynamic>();

                        while (reader.Read())
                            {

                                string Nome = Convert.ToString(reader["nome"]);
                                string Email = Convert.ToString(reader["email"]);
                                string Comentario = Convert.ToString(reader["comentario"]);
                                string Assunto = Convert.ToString(reader["assunto"]);

                                list.Add(new { nome = Nome, email = Email, comentario = Comentario, assunto = Assunto });
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
