using mybank2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mybank2
{
    public partial class Cadastra_cliente : Form
    {
        public Cadastra_cliente()
        {
            InitializeComponent();
        }

        private void Criar_Load(object sender, EventArgs e)
        {
            {
                

            }
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            
           Cadastrocliente cad = new Cadastrocliente(textnome.Text, textcpf.Text, textrg.Text, textdt_ns.Text, textescivil.Text, textendereco.Text, textnumero.Text, textcomplemento.Text, textcep.Text,
               textbairro.Text, textcidade.Text, textestado.Text, textemail.Text, texttituloel.Text, textrenda.Text, textcelular.Text, texttelefone.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
