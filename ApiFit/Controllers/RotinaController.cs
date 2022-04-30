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


        public string Post(string pcpf, string item)
        {
            if (!string.IsNullOrEmpty(pcpf) && !string.IsNullOrEmpty(item))
            {
                try
                {
                    string querypac = "SELECT id_paciente from vw_rotina WHERE pac_cpf = @PCPF;";
                    string update = "UPDATE tb_rotina SET feito = 1 WHERE item = @ITEM AND id_paciente = @IDP;";

                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(querypac, conexao);
                        command.Parameters.AddWithValue("@PCPF", pcpf);

                        conexao.Open();
                        reader = command.ExecuteReader();

                        reader.Read();
                        string Id_Paciente = Convert.ToString(reader["id_paciente"]);
                        conexao.Close();

                        MySqlCommand commandup = new MySqlCommand(update, conexao);
                        commandup.Parameters.AddWithValue("@IDP", Id_Paciente);
                        commandup.Parameters.AddWithValue("@ITEM", item);

                        conexao.Open();
                        reader = commandup.ExecuteReader();
                        conexao.Close();


                        return @"{""Status"":""OK""}";
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
