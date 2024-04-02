using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoRetorno
{
    public class CalculadoraAumento
    {
        public decimal CalcularAumento(decimal salarioR, decimal taxaR)
        {
            return  salarioR * (1 + taxaR / 100);
        }
    }
}
