﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Busca

    {
   public class GeradorDeDevedores
    {
        public List<string> GeraList()

        {
            List<string> nomes = new List<string>();

            for(int i = 0; i < 30000; i++ )

            {
                nomes.Add("Devedor" + 1);
            }

            return nomes;
        }
    }
}
