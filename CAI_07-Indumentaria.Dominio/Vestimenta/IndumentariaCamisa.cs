using System;

namespace CAI_07_Indumentaria.Dominio
{
    public class IndumentariaCamisa : Indumentaria
    {
        #region Variables
        private bool _tieneEstampado;
        private string _tipoManga;

        #endregion

        #region Propiedades
        public bool TieneEstampado { get => _tieneEstampado; set => _tieneEstampado = value; }
        public string TipoManga { get => _tipoManga; set => _tipoManga = value; }

        #endregion

        #region Constructores
        public IndumentariaCamisa(int codigo, int stock, string talle, double precio, TipoIndumentaria tipoIndumentaria, bool tieneEstampado, string tipoManga)
            : base (codigo, stock, talle, precio, tipoIndumentaria)
        {
            _tieneEstampado = tieneEstampado;
            _tipoManga = tipoManga;
        }

        #endregion

        #region Métodos
        public override string GetDetalle()
        {
            return "Detalles de la prenda: ";
        }
        /// <summary>
        /// Sobreescritura del método para devolver información precisa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Soy Indumentaria Camisa con el tipo: " + _tipoIndumentaria + ", con el código: " + _codigo);
        }
        #endregion
    }
}
