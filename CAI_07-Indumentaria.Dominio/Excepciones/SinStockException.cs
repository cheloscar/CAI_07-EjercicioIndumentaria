using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Dominio
{
    internal class SinStockException : Exception
    {
        public SinStockException () : base ("El prosucto no tiene stock para la operación solicitada.")
        {

        }
    }
}
