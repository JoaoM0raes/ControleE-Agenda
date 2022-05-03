using ControleEAgenda.ControleContatos;
using GestãoDeAgendaDominio.GestãoCompromissos;
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

namespace ControleEAgenda.ControleDeCompromissos
{
    public partial class AdicionarNovoCompromisso : Form
    {
        public Compromisso compromisso;
        private ControleDeContatos controleContatos;
        private List<Contato> contatoList;
        public AdicionarNovoCompromisso()
        {
            
            InitializeComponent();
            this.controleContatos = new ControleDeContatos();
            carregarComponentes();
        }
      
        private void carregarComponentes()
        {
           contatoList= controleContatos.PegarContatos();
           listContatos.Items.Clear();
            foreach (Contato contato in contatoList)
            {
                listContatos.Items.Add(contato);
            }
        }
        private bool ValidarCampos()
        {
            Contato ContatoSelecionado = (Contato)listContatos.SelectedItem;
            if (String.IsNullOrEmpty(textAssunto.Text) || String.IsNullOrEmpty(textLocal.Text))
            {
                MessageBox.Show("Favor preencher todos os campos", "Adição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;

            }
            else if (ContatoSelecionado==null){
                MessageBox.Show("Selecione um Contato ", "Adição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (dataCompromisso.Value < DateTime.Now)
            {
                MessageBox.Show("A Data de compromisso deve ser válida", "Adição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Contato ContatoSelecionado = (Contato)listContatos.SelectedItem;
            if (ValidarCampos())
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                int horaInicial=Convert.ToInt32(textHoraIncial.Text);
                int horaFinal = Convert.ToInt32(textHoraFinal.Text);
                this.compromisso = new Compromisso( textAssunto.Text,  textLocal.Text,  dataCompromisso.Value, horaInicial, horaFinal, ContatoSelecionado);
            }
           
        }
    }
}
