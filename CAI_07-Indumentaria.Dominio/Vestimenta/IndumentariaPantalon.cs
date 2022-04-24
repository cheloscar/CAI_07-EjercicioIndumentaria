using System;

namespace CAI_07_Indumentaria.Dominio
{
    public class IndumentariaPantalon : Indumentaria
    {
        #region Variables
        private bool _tieneBolsillos;
        private string _material;

        #endregion

        #region Propiedades
        public bool TieneBolsillos { get => _tieneBolsillos; set => _tieneBolsillos = value; }
        public string Material { get => _material; set => _material = value; }

        #endregion

        #region Constructores
        public IndumentariaPantalon(int codigo, int stock, string talle, double precio, TipoIndumentaria tipoIndumentaria, bool tieneBolsillos, string material)
            : base (codigo, stock, talle, precio, tipoIndumentaria)
        {
            _tieneBolsillos = tieneBolsillos;
            _material = material;
        }

        #endregion

        #region Métodos
        public override string GetDetalle()
        {
            return "Detalles de la prenda: ";
        }

        #endregion
    }
}
