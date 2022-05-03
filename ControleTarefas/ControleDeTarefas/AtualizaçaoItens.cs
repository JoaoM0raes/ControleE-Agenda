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
    public partial class AtualizaçaoItens : Form
    {
       public Tarefa tarefa;
        public AtualizaçaoItens(Tarefa tarefa)
        {
            this.tarefa = tarefa;
            InitializeComponent();
            labelTitulo.Text = tarefa.name;
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                listaCheckItems.Items.Add(item);
                if(item.concluido)
                 listaCheckItems.SetItemChecked(i, true);
                i++;
            }
           
        }
        public List<ItemTarefa> ItemConcluidos
        {
            get { return listaCheckItems.CheckedItems.Cast<ItemTarefa>().ToList();}
        }
        public List<ItemTarefa> ItemPendentes {
            get
            {
                return listaCheckItems.CheckedItems.Cast<ItemTarefa>()
                      .Except(ItemConcluidos).ToList();
            }
        }
        

     
    }
}
