using GestãoAgenda.Infra;
using GestãoAgenda.Infra.GestãoBase;
using GestãoDeAgendaDominio.GestãoCompromissos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEAgenda.ControleDeCompromissos
{
    public partial class ControleCompromisso : Form
    {
        private RepositorioBase<Compromisso> repositorio; 
        private SerializadorJson<Compromisso> serializador=new SerializadorJson<Compromisso>("Compromisso");
        public ControleCompromisso()
        {
            this.repositorio = new RepositorioBase<Compromisso>(serializador);
            InitializeComponent();
            CarregarComponentes();
        }
        public void CarregarComponentes()
        {
            List<Compromisso> Compromissos = repositorio.CarregarTodos();
            listCompromissos.Items.Clear();
            foreach (Compromisso t in Compromissos)
            {
                listCompromissos.Items.Add(t);
            }

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarNovoCompromisso novoCompromisso = new AdicionarNovoCompromisso();
            if (novoCompromisso.ShowDialog() == DialogResult.OK)
            {
                repositorio.Inserir(novoCompromisso.compromisso);
                CarregarComponentes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso CompromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;
            if (CompromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um  Compromisso Primeiro", "Edição de  Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AdicionarNovoCompromisso novoCompromisso=new AdicionarNovoCompromisso();
            novoCompromisso.compromisso = CompromissoSelecionado;
            int numeroSelecionado = CompromissoSelecionado.id;
            DialogResult dialago = novoCompromisso.ShowDialog();
            if (dialago == DialogResult.OK)
            {
                repositorio.Editar(novoCompromisso.compromisso, numeroSelecionado);
            }
            CarregarComponentes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso CompromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;
            if (CompromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um Compromisso Primeiro", "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            repositorio.Excluir(CompromissoSelecionado);
            CarregarComponentes();
        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissoList = repositorio.CarregarTodos();
            Vizualizar_compormissos compormissos=new Vizualizar_compormissos(compromissoList);
            compormissos.ShowDialog();  

        }
    }
}
