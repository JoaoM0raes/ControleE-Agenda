using GestãoAgenda.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTarefas
{
    public partial class ControleDeTarefas: Form
    {
        private RepositorioTarefa repositorio;
        private SerializadorJson<Tarefa> serializador = new SerializadorJson<Tarefa>("Tarefa"); 
        public ControleDeTarefas()
        {
            repositorio = new RepositorioTarefa(serializador);
            InitializeComponent();                                                               
            CarregarComponentes();                                                                         
        }                                   
                                                               
        public void CarregarComponentes()                                                                                                                                                                                                                                                                                                                  
        {
            List<Tarefa> tarefasPendentes = repositorio.SelecionarTarefasPendentes();

            List<Tarefa> novastarefas=  tarefasPendentes.OrderByDescending(x => x.prioridade).ToList();
            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in novastarefas)
            {
                listTarefasPendentes.Items.Add(t);
               
            }
            List<Tarefa>tarefasConcluidas =repositorio.SelecionarTarefasConcluidas();
            List<Tarefa> novasTarefasConcluidas  = tarefasConcluidas.OrderByDescending(x => x.prioridade).ToList();
            listTarefasConcluidas.Items.Clear();
            foreach (Tarefa t in novasTarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirNovaTarefa inserirNovaTarefa = new InserirNovaTarefa();
            DialogResult dialago = inserirNovaTarefa.ShowDialog();
            if (dialago == DialogResult.OK)
                repositorio.InserirTarefa(inserirNovaTarefa.NovaTarefa);
            CarregarComponentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro","Edição de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            InserirNovaTarefa tarefa = new InserirNovaTarefa();
            tarefa.NovaTarefa = tarefaSelecionada;
            int numeroSelecionado = tarefaSelecionada.id; 
            DialogResult dialago = tarefa.ShowDialog();
            if (dialago == DialogResult.OK)
            {
                repositorio.EditarTarefa(tarefa.NovaTarefa,numeroSelecionado);
            }
                
            CarregarComponentes();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            repositorio.Excluir(tarefaSelecionada);
            CarregarComponentes();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            items novoItem= new items(tarefaSelecionada);
            if (novoItem.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> items = novoItem.ItemAdicionados;
                repositorio.AdicionarItems(tarefaSelecionada, items);
                CarregarComponentes();
            }
        }

        private void BtnAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AtualizaçaoItens tela = new AtualizaçaoItens(tarefaSelecionada);
            if (tela.ShowDialog() == DialogResult.OK)
            {

                List<ItemTarefa> listaConcluida = tela.ItemConcluidos;
                List<ItemTarefa> listaPendende = tela.ItemPendentes;
                repositorio.AtualizarItems(tarefaSelecionada,listaConcluida,listaPendende);
                CarregarComponentes();
            }
        }
        
    }
}
