using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoStatic
{
    public class CalculadoraAumentoS
    {
        public static decimal CalcularAumento(decimal salarioS, decimal taxaS)
        {
            return salarioS * (1 + taxaS / 100);
        }
    }
}
