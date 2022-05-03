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
    public partial class Vizualizar_compormissos : Form
    {
        public List<Compromisso> lista;
        public Vizualizar_compormissos(List<Compromisso> listaCompromisso)
        {
            this.lista = listaCompromisso;
            InitializeComponent();
            vizualizarPassado();
        }
        private void vizualizarPassado()
        {
            List<Compromisso> listaPassado = lista;
            foreach (Compromisso compromisso in listaPassado)
            {
                if (compromisso.dataCompromisso < DateTime.Now)
                {
                  listCompromissosPassados.Items.Add(compromisso);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime primeiraData = dateTimePrimeiraData.Value.Date;
            DateTime segundaData = dateTimeSegundaData.Value.Date;
            if (primeiraData > segundaData)
            {
                MessageBox.Show("Favor colocar uma data válida", "Vizualização de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               DialogResult= DialogResult.None;
            }
            listCompormissosFuturos.Items.Clear();
            foreach (Compromisso item in lista)
            {
                if(item.dataCompromisso >= primeiraData && item.dataCompromisso <= segundaData)
                {      
                    listCompormissosFuturos.Items.Add(item);        
                }          
            }
        }
    }
}
