using System;
using CAI_07Indumentaria.Dominio.ClasificacionIndumentaria;

namespace CAI_07Indumentaria.Dominio
{
    public abstract class Indumentaria
    {
        #region Variables
        internal int _codigo;
        internal int _stock;
        internal string _talle;
        internal double _precio;
        internal TipoIndumentaria _tipoIndumentaria;

        #endregion

        #region Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }

        #endregion

        #region Constructores
        public Indumentaria(int codigo, int stock, string talle, double precio, TipoIndumentaria tipoIndumentaria)
        {
            _codigo = codigo;
            _stock = stock;
            _talle = talle;
            _precio = precio;
            _tipoIndumentaria = tipoIndumentaria;
        }
        public Indumentaria(Indumentaria indumentaria)
        {
            _codigo = indumentaria._codigo;
            _stock = indumentaria._stock;
            _talle = indumentaria._talle;
            _precio = indumentaria._precio;
            _tipoIndumentaria = indumentaria._tipoIndumentaria;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return ("Soy Indumentaria del tipo: " + _tipoIndumentaria + ", con el código: " + _codigo) ;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
