using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PccFit
{
    class Pessoa
    {
        int id;
        String cpf;
        String nome;
        String email;
        String cep;
        String logradouro;
        String numero;
        String bairro;
        String cidade;
        String estado;
        String telefone;
        String dt_inicio;
        String dt_final;

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Dt_inicio { get => dt_inicio; set => dt_inicio = value; }
        public string Dt_final { get => dt_final; set => dt_final = value; }


        public void Cadastro(string n1, string n2, string n3, string n4, string n5, string n6, string n7, string n8, string n9, string n10, string n11, string n12)
        {
            Cpf = n1;
            Nome = n2;
            Email = n3;
            Cep = n4;
            Logradouro = n5;
            Numero = n6;
            Bairro = n7;
            Cidade = n8;
            Estado = n9;
            Telefone = n10;
            Dt_final = n11;
            Dt_inicio = n12;
        }

        public void Pesquisar(string n1)
        {

        }

    }
}
