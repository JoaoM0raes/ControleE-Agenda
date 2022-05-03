using GestãoAgenda.Infra;
using GestãoAgenda.Infra.GestãoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeAgendaDominio.GestãoCompromissos
{
    public class RepositorioComrpomissos : RepositorioBase<Compromisso>
    {
        public RepositorioComrpomissos(SerializadorJson<Compromisso> serializador) : base(serializador)
        {

        }
    }
}
