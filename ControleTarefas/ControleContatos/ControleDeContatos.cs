using GestãoAgenda.Infra;
using GestãoDeAgendaDominio.GestãoDeContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEAgenda.ControleContatos
{
    public partial class ControleDeContatos : Form
    {
        private RepositórioContato repositorio;
        private SerializadorJson<Contato> serializador = new SerializadorJson<Contato>("Contato");
        public ControleDeContatos()
        {
            this.repositorio = new RepositórioContato(serializador);
            InitializeComponent();
            CarregarComponentes();
        }
        public void CarregarComponentes()
        {
            List<Contato> Contatos = repositorio.CarregarTodos();
            listaContatos.Items.Clear();

            foreach (Contato t in Contatos)
            {
                listaContatos.Items.Add(t);

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarContato novoContato= new AdicionarContato();
           
            if (novoContato.ShowDialog()== DialogResult.OK)
            {
                if (AcharIgual(novoContato.contato))
                {
                    MessageBox.Show("Você de utilizar Nome,Email e Numero Diferentes", "Adição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                repositorio.Inserir(novoContato.Contato);
                CarregarComponentes();
            }
             
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato ContatoSelecionado = (Contato)listaContatos.SelectedItem;
            if (ContatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro", "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AdicionarContato ContatoEditado= new AdicionarContato();
            ContatoEditado.contato = ContatoSelecionado;
            int numeroSelecionado = ContatoSelecionado.id;
            DialogResult dialago = ContatoEditado.ShowDialog();
            if (dialago == DialogResult.OK)
            {
                repositorio.Editar(ContatoEditado.contato, numeroSelecionado);
            }
            CarregarComponentes();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato ContatoSelecionado = (Contato)listaContatos.SelectedItem;
            if (ContatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro", "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            repositorio.Excluir(ContatoSelecionado);
            CarregarComponentes();
        }
        private bool AcharIgual(Contato contato)
        {
            List<Contato> lista = repositorio.CarregarTodos();
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].nome == contato.nome || lista[i].Email == contato.Email || lista[i].Numero == contato.Numero)
                {
                    return true;
                 
                }
            }
            return false;
        }
        public List<Contato> PegarContatos()
        {
            List<Contato> Contatos = repositorio.CarregarTodos();
            return Contatos;
        }

       
    }
}
