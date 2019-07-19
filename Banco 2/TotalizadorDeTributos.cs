using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        //public void Acumula(Conta c)
        //{
        //    Total += c.CalculaTributo();
        //}

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }

        public void Acumula(ContaInvestimento ci)
        {
            Total += ci.CalculaTributo();
        }

        internal void Acumula(ContaCorrente conta)
        {
            throw new NotImplementedException();
        }
    }
}
