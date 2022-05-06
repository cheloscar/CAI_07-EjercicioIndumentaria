using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Dominio.Excepciones
{
    internal class TipoVacioException : Exception
    {
        public TipoVacioException() : base ("Ha ingresado un elemento vacío.") { }
    }
}
