using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PccAPI.Models
{
    public class Rotina
    {
        public string Nutricionista { get; set; }
        public string Nut_cpf { get; set; }
        public string Paciente { get; set; }
        public string Pac_cpf { get; set; }
        public int Id { get; set; }
        public int Id_nutricionista { get; set; }
        public int Id_paciente { get; set; }
        public string Item { get; set; }
        public bool Feito { get; set; }

        public Rotina(string r1, string r2, string r3, string r4, int r5, int r6, int r7, string r8, bool r9)
        {
            this.Nutricionista = r1;
            this.Nut_cpf = r2;
            this.Paciente = r3;
            this.Pac_cpf = r4;
            this.Id = r5;
            this.Id_nutricionista = r6;
            this.Id_paciente = r7;
            this.Item = r8;
            this.Feito = r9;
        }
    }
}