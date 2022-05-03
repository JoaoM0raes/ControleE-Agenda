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
    public partial class items : Form
    {
       
        
        public items(Tarefa tarefa)
        {
            InitializeComponent();
            labelTituloTarefa.Text = tarefa.name;
            foreach (var item in tarefa.Itens)
            {
                listItemsDaTarefa.Items.Add(item);
            }
        }

        public List<ItemTarefa> ItemAdicionados { get { return listItemsDaTarefa.Items.Cast<ItemTarefa>().ToList(); } }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItemAdicionados.Select(x => x.Titulo).ToList();
            if (titulos.Count == 0 || titulos.Contains(Labeltitulo.Text))
            {  

            }
            ItemTarefa itemTarefa = new ItemTarefa();
            itemTarefa.Titulo = Labeltitulo.Text;
            listItemsDaTarefa.Items.Add(itemTarefa);

        }

        
    }
}
