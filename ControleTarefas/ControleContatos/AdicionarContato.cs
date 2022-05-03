using GestãoDeAgendaDominio.GestãoDeContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEAgenda.ControleContatos
{
    public partial class AdicionarContato : Form
    {
        public  Contato contato; 
        public AdicionarContato()
        {
            InitializeComponent();
        }
        public Contato Contato{ get { return contato; } }
        private bool ValidarEmail()
        {
            try
            {
                MailAddress NovoEmail = new MailAddress(textEmail.Text);
                return false;
            }
            catch (FormatException)
            {
                return true;
            }
        }
        private bool ValidarCampos()
        {

            if (String.IsNullOrEmpty(textName.Text) || String.IsNullOrEmpty(textEmail.Text) || String.IsNullOrEmpty(textNumero.Text))
            {

                MessageBox.Show("Favor preencher todos os campos", "Adição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;

            }else if (ValidarEmail())
            {
                MessageBox.Show("Favor preencher com um Email Válido", "Adição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }else if(textNumero.Text.Length<9 && textNumero.Text.Length > 9)
            {
                MessageBox.Show("Favor preencher com um Numero Válido", "Adição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return false;            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {       
              DialogResult=DialogResult.None;
            }
            else
            {
                string nome = textName.Text;

                string empresa = textEmpresa.Text;

                string numero = textNumero.Text;

                string cargo = textCargo.Text;

                string email = textEmail.Text;

                contato = new Contato(nome, email, numero, empresa, cargo);
            }
            
              
        }

       
    }
}
