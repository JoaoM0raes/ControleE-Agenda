using GestãoAgenda.Infra;
using GestãoAgenda.Infra.GestãoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeAgendaDominio.GestãoDeContatos
{
    public class RepositórioContato : RepositorioBase<Contato>
    {
        public RepositórioContato(SerializadorJson<Contato> serializador) : base(serializador)
        {

        }
    }
}
