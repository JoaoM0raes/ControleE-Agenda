using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas
{
    public class ItemTarefa
    {
        private string titulo;
        public bool concluido;

        public ItemTarefa()
        {
           
        }
        public string Titulo { get; set; }

        public override string ToString()
        {
            return $"{Titulo}";
        }

        internal void Concluir()
        {
            concluido = true;
        }

        internal void MarcarPendente()
        {
            concluido = false;
        }
    }
}
