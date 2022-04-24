using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Negocio.Excepciones
{
    internal class CantidadCeroException : Exception
    {   
        public CantidadCeroException() : base ("La cantidad no puede ser cero para esta operación.") { }
    }
}
