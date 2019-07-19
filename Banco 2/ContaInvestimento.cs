using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco_2
{
    public class ContaInvestimento : Conta 
    {
        ContaInvestimento ci = new ContaInvestimento();

        public double CalculaTributo()

        {
            return this.Saldo * 0.03;
        }

    }
}
