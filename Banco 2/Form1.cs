using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco_2
{
    public partial class Form1 : Form
    {
        //variável local é aquela limitada a uma parte do algoritimo.

        //variável global é aquela usada por qualquer parte do algoritimo.

        Conta c = new Conta();
        ContaPoupança cp = new ContaPoupança();
        ContaCorrente cc = new ContaCorrente();
      
        private List <Conta> conta;
        //private int numeroDeContas;

        public Form1()
        {
            InitializeComponent(); //Função para abrir o formulário;

            //cc.Numero = 1;
            //Cliente cliente = new Cliente("Victor");
            //cc.Titular = cliente;
            //cc.Saldo = 88.00;

            //textoNumero.Text = Convert.ToString(cc.Numero);
            textoSaldo.Text = Convert.ToString(cc.Saldo);
            //textoTitular.Text = cliente.Nome;
            textoValor.Text = Convert.ToString(cc.Valor);


            this.conta = new List<Conta>();

            Conta c1 = new Conta();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            //c1.Saldo = 88.00;
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupança();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            c2.Saldo = 800.0;
            //c2.Saca(100.0);
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            //c3.Saldo = 500.00;
            this.AdicionaConta(c3);

            if (c1.Equals(c2))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }



            //foreach (Conta conta in conta)
            //{
            //    comboContas.Items.Add(c.Titular.Nome);
            //}

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

            //textoSaldo.Text = Convert.ToString(c.Saldo); CHAMANDO A FUNÇÃO QUE FOI DECLARADA NO FORM 1
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

            //textoNumero.Text = Convert.ToString(c.Numero);
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            


            //textoTitular.Text = conta.Titular.Nome;
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            //Quando o botão for clicado executará essas funções.

            //primeiro precisamos recuperar	o índice da	conta selecionada.

            //int indice = comboContas.SelectedIndex;

            //e	depois precisamos ler a	posição	correta	do array.	
            //Conta selecionada = this.conta[indice];
            //double valor = comboContas.SelectedIndex;
            //selecionada.Deposita(valor);
            //textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            //string valorDigitado = textoValor.Text;
            //double valorOperacao = comboContas.SelectedIndex;
            //this.cc.Deposita(valorOperacao);
            //cc.Deposita(100.0);
            //textoSaldo.Text = Convert.ToString(this.cc.Saldo);
            //MessageBox.Show("Sucesso");

            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = (Conta)comboContas.SelectedItem;

            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Argumento Inválido");
            }
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;
            //Conta selecionada = this.conta[indice];
            //double valor = comboContas.SelectedIndex;
            //selecionada.Saca(valor);
            //textoSaldo.Text = Convert.ToString(selecionada.Saldo);



            //string valorDigitado = textoValor.Text;
            //double valorOperacao = comboContas.SelectedIndex; 
            //this.cc.Saca(valorOperacao);
            ////cc.Saca(10.0);
            //MessageBox.Show("Sucesso");
            //textoSaldo.Text = Convert.ToString(this.cc.Saldo);

            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = this.conta[indice];

            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException)

            {
                MessageBox.Show("Não é possível sacar valor negativo");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.conta[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int indice = comboContas.SelectedIndex;
            Conta selecionada = conta[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void AdicionaConta (Conta conta)
        {
            this.conta.Add(conta);
            comboContas.Items.Add(conta);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            {

                ContaCorrente conta = new ContaCorrente();
                conta.Deposita(200.0);
                MessageBox.Show("Imposto da Conta Corrente = " + conta.CalculaTributo());

                //ITributavel t = conta;
                //MessageBox.Show("Imposto da Conta pela Interface = " + t.CalculaTributo());

                //SeguroDeVida sv = new SeguroDeVida();
                //MessageBox.Show("Imposto do	Seguro = " + sv.CalculaTributo());

                //t = sv;
                //MessageBox.Show("Imposto do	Seguro pela	Interface " + t.CalculaTributo());

                //SeguroDeVida sv = new SeguroDeVida();
                //TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
                //totalizador.Acumula(conta);
                //MessageBox.Show("Total:	" + totalizador.Total);
                //totalizador.Acumula(sv);

                //MessageBox.Show("Total:	" + totalizador.Total);
            }
        }

        
    }
}
