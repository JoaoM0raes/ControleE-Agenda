using ControleEAgenda.ControleContatos;
using ControleEAgenda.ControleDeCompromissos;
using ControleTarefas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControleEAgenda
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnTelaPrincipal_Click(object sender, EventArgs e)
        {
            ControleDeTarefas  controle =new ControleDeTarefas();
            controle.ShowDialog();
        }

        private void btnTelaCompromisso_Click(object sender, EventArgs e)
        {
           ControleCompromisso controle =new ControleCompromisso();
            controle.ShowDialog();
        }

        private void btnTelaContatos_Click(object sender, EventArgs e)
        {
            ControleDeContatos controle =new ControleDeContatos();
            controle.ShowDialog();
        }
    }
}
