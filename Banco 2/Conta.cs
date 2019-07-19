using System;

namespace Banco.Contas
{
    public /*abstract*/ class Conta
    //abstract
    //Toda vez que marcamos	um método com 
    //o	modificador	abstract, ele obrigatoriamente não pode	ter	uma	implementação padrão.

    {
        public int Numero { get; set; }
        public double Saldo { get; set; } //O projeto pediu protected
        public Cliente Titular { get; internal set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }
        private static int numeroDeContas;


        public Conta()

        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)

        {

            if (this.Tipo == 1)
            {

                this.Saldo -= (valor + 0.10);
                //return true;
            }

            else
            {
                this.Saldo -= valor;
                //return false;
            }


        }

        public override bool Equals(object outro)
        {

            if (!(outro is Conta))

            {
                return false;
            }
            Conta outraConta = (Conta) outro;
            return this.Numero == outraConta.Numero;

        }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }
    }
}
