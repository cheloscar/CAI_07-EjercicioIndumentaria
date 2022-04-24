using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Dominio
{
    internal class PrecioNegativoException : Exception
    {
        public PrecioNegativoException() : base ("El precio no puede ser negativo.") { }
    }
}
