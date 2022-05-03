using GestãoAgenda.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas
{
    public class RepositorioTarefa
    {
       public int numero;
       
       public SerializadorJson<Tarefa> serializador;
        public List<Tarefa> tarefas;
       public RepositorioTarefa(SerializadorJson<Tarefa>serializador)
        {
          this.serializador = serializador;
          tarefas = serializador.carregarArquivo();

          if (tarefas.Count > 0)
                numero = tarefas.Max(x => x.id);
        }

      public List<Tarefa> CarregarTodos()
      {
            return tarefas;
      }
      public void InserirTarefa(Tarefa tarefa)
      {
          tarefa.id = ++numero;
          tarefas.Add(tarefa);
          serializador.pegarArquivo(tarefas);
        }
      public void EditarTarefa(Tarefa tarefa, int numeroParaEdição)
       {
            foreach (Tarefa item in tarefas)
            {
                if (item.id == numeroParaEdição)
                {
                    item.name = tarefa.name;
                    break;
                }
            }
            serializador.pegarArquivo(tarefas);
        }
        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
            serializador.pegarArquivo(tarefas);
        }
        public void AdicionarItems(Tarefa tarefa ,List<ItemTarefa> items)
        {
            foreach(var item in items)
            {
                tarefa.AdicionarItem(item);
            }
            serializador.pegarArquivo(tarefas);
        }

        public void AtualizarItems(Tarefa tarefaSelecionada, List<ItemTarefa> listaConcluida,List<ItemTarefa> listaPendente)
        {
            foreach (var item in listaConcluida)
            {
                tarefaSelecionada.ConcluirItem(item);
            }
            foreach (var item in listaPendente)
            {
                tarefaSelecionada.marcarPendente(item);
            
            }
           serializador.pegarArquivo(tarefas);
        }
        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.pegarPorcentagem() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.pegarPorcentagem() < 100).ToList();
        }
    }
}
