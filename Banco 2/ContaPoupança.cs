using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco_2
{
    public class ContaPoupança : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (valor + 0.10 <= this.Saldo)
            {
                this.Saldo -= valor + 0.10;
                //return true;
                //base.Saca(valor + 0.10);
            }

            if (valor < 0.0)

            {
                throw new Exception("Não é permitido a entrada de valores negatisvos");
            }

            if (valor + 0.10 > this.Saldo)

            {
                throw new SaldoInsuficienteException();
            }
            else

            {
                this.Saldo -= valor + 0.10;
                //return false;
                //throw new Exception("Valor do saque maior que o saldo");
            }
        }
            public override void Deposita(double valor)

            {
             
                if (valor < 0.0)

                 {
                    throw new Exception("Argumento Inválido");
                 }

    }

    public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}


