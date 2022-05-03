using GestãoDeAgendaDominio.GestãoBase;
using GestãoDeAgendaDominio.GestãoDeContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeAgendaDominio.GestãoCompromissos
{
    public class Compromisso:EntidadeBase
    {
        public string local;
        public DateTime dataCompromisso;
        public int horaInicio;
        public int horaTermino ;
        public Contato Contato;

        public Compromisso(string assunto,string local, DateTime dataCompromisso, int horaInicio, int horaTermino,Contato contato)
        {
            this.nome= assunto;
            this.local = local;
            this.dataCompromisso = dataCompromisso;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.Contato = contato;
        }
        public override string ToString()
        {
            if (Contato != null)
            {
                return $"Assunto: {nome}  Local: {local} Data Compromisso: {dataCompromisso} Contato: {Contato.nome}";
            }
            else
            {
                return $"Assunto: {nome}  Local: {local} Data Compromisso: {dataCompromisso}";
            }
            
        }
    }
}
