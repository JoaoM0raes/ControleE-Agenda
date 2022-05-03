using GestãoDeAgendaDominio.GestãoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeAgendaDominio.GestãoDeContatos
{
    public class Contato:EntidadeBase 
    {
        private string email;
        private string numero;
        private string empresa;
        private string cargo;

        public Contato(string nome,string email, string numero, string empresa, string cargo)
        {
            this.nome = nome;
            this.email = email;
            this.numero = numero;
            this.empresa = empresa;
            this.cargo = cargo;
        }
        public string Email { get { return email; } }
        public string Numero { get { return numero; } }
        public string Empresa { get { return empresa; } }
        public string Cargo { get { return cargo; } }
        public string Nome { get { return nome; } }

        public override string ToString()
        {
            return $"Nome: {Nome} Email:{Email} Numero:{Numero} Epresa:{Empresa} Cargo:{Cargo} ";
        }
    }
}
