using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco_2
{

    public class SeguroDeVida : Conta
    {

        public double CalculaTributo()
        {
            return this.Saldo;

            
        }
    }
}
