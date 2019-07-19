using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco_2
{
    public class ContaCorrente : Conta
    {
       
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.05);
            //return true;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += (valor - 0.10);
        }

        public double CalculaTributo()

        {
            return this.Saldo * 5 / 100;
        }

        

        
    }
}
