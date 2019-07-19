using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Busca;
using Banco.Contas;

namespace Banco_2
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> deveores;
        private Form1 formPrincipal;
         
        
        public FormCadastroConta(Form1 formPrincipal)

        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();


        }

        public List<string> devedores { get; private set; }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);

            for (int i = 0; i < 30000; i++)
            { ehDevedor = this.devedores.Contains(titular); }

            if (!ehDevedor)
            {
                //	faz	a	lógica	para	criar	a	conta	
            }
            else
            {
                MessageBox.Show("devedor");
            } 
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            //novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);

            MessageBox.Show("Cadastro feito com sucesso!");

           //textoNumero.Text = string.Empty;
            textoTitular.Text = string.Empty;

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
