using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Negocio.Excepciones
{
    internal class PedidoVacioException : Exception
    {
        public PedidoVacioException() : base ("El pedido está vacío.") { }
    }
}
