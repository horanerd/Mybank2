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
    public partial class Cadastro_funcionario : Form
    {
        public Cadastro_funcionario()
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
            
            Cadastrofuncionarios cad = new Cadastrofuncionarios(textnome.Text, textcpf.Text, textrg.Text, textnomemae.Text, textdt_ns.Text, textcnh.Text, textendereco.Text, textnumero.Text, textcomplemento.Text, 
                textcep.Text, textbairro.Text, textcidade.Text, textestado.Text, textemail.Text, texttituloel.Text, textrenda.Text, textcargo.Text, textreservista.Text, textnreservista.Text);
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
