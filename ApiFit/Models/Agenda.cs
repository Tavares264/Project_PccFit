using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PccAPI.Models
{
    public class Agenda
    {
        public string Nutricionista { get; set; }
        public string Paciente { get; set; }
        public int Id { get; set; }
        public int Id_nutricionista { get; set; }
        public int Id_paciente { get; set; }
        public DateTime Dt_agenda { get; set; }   
        public string Horario { get; set; }
        public string Descricao { get; set; }

    public Agenda(string r1, string r2, int r3, int r4, int r5, DateTime r6, string r7, string r8)
        {
            this.Nutricionista = r1;
            this.Paciente = r2;
            this.Id = r3;
            this.Id_nutricionista = r4;
            this.Id_paciente = r5;
            this.Dt_agenda = r6;
            this.Horario = r7;
            this.Descricao = r8;
        }
    }
}