using GestãoDeAgendaDominio.GestãoTarefas;
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
    public partial class InserirNovaTarefa : Form
    {
        private Tarefa novaTarefa;
        public InserirNovaTarefa()
        {
            InitializeComponent();
        }
        
       
        public Tarefa NovaTarefa
        {
            get { return novaTarefa; }
            set { }
        }
        private prioridade Prioridade(string PegarPrioridade)
        {
            if (PegarPrioridade == "Alta")
            {
                return prioridade.alta;
            }
            else if (PegarPrioridade == "Media")
            {
                return prioridade.media;
            }   
                return prioridade.baixa;      
        }
        private void Gravar_Click(object sender, EventArgs e)
        {
           
           string PegarPrioridade=listPrioridade.SelectedItem.ToString();
            
            string nome = Nome.Text;
            novaTarefa = new Tarefa(nome,DateTime.Now,Prioridade(PegarPrioridade));            
        }

       
    }
}
                                                                              