using GestãoDeAgendaDominio.GestãoBase;
using GestãoDeAgendaDominio.GestãoTarefas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas
{
    public class Tarefa:EntidadeBase
    {
        public int id;
        public string name;
        public List<ItemTarefa> itens=new List<ItemTarefa>();
        public DateTime HorarioInicial;
        public DateTime HorarioFinal;
        public prioridade prioridade;
        public bool status; 
        public Tarefa(string name,DateTime dataInicial, prioridade prioridade)
        {
            this.name = name;
            this.prioridade = prioridade;
            this.HorarioInicial = dataInicial;
        }
        public List<ItemTarefa> Itens { get { return itens; } }
        public override string ToString()
        {
            var porcentual = pegarPorcentagem();
            if (porcentual == 100)
            {
                status = true; 
            }
            if (status == true)
            {
                return $"nome: {name} -------- id: {id} -------- porecentagem: {porcentual}  -------- Data de Fechamento: {HorarioFinal} -------- Prioridade {prioridade}";
            }
            return $"nome: {name} -------- id: {id} -------- porecentagem: {porcentual}  -------- Data de Abertura: {HorarioInicial} -------- Prioridade {prioridade}";  
        }

        public decimal pegarPorcentagem()
        {
            if(Itens.Count == 0) {
                 return 0;
            }
            int qtdConcluidas = itens.Count(x => x.concluido);
             var quantidade = (qtdConcluidas / (decimal)itens.Count()) * 100;
            return ((int)quantidade);
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            if (item != null)
            {
                ItemTarefa itemTarefa = Itens.Find(x => x.Equals(item));
                itemTarefa.Concluir();
            }
            
        }

        public void marcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = Itens.Find(x => x.Equals(item));
            itemTarefa?.MarcarPendente();
        }
    }
}
