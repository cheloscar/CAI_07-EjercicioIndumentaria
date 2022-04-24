using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Negocio
{
    internal class Cliente
    {
        #region Variables
        private uint _codigo;
        private string _nombre;
        private string _apellido;

        #endregion

        #region Propiedades
        public global::System.UInt32 Codigo { get => _codigo; set => _codigo = value; }
        public global::System.String Nombre { get => _nombre; set => _nombre = value; }
        public global::System.String Apellido { get => _apellido; set => _apellido = value; }

        #endregion

        #region Constructores
        public Cliente(global::System.UInt32 codigo, global::System.String nombre, global::System.String apellido)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apellido = apellido;
        }

        #endregion

        #region Métodos


        #endregion
    }
}
