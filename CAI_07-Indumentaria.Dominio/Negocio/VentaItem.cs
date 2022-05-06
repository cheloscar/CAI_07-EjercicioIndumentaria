using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAI_07_Indumentaria.Dominio
{
    public class VentaItem
    { 
        Indumentaria _prenda;
        uint _cantidad;
        double _precio;

        public VentaItem(Indumentaria prenda, double precio, uint cantidad)
        {
            _prenda = (Indumentaria)prenda;
            _precio = precio;
            _cantidad = cantidad;
        }

        public Indumentaria Prenda { get => _prenda; set => _prenda = value; }

        public double Precio() { return _precio; }
        /// <summary>
        /// Método para asignar el precio del ítem comprado.
        /// </summary>
        /// <param name="precio">No puede ser negativo</param>
        /// <exception cref="PrecioNegativoException"></exception>
        public void Precio(double precio) 
        {
            if (precio < 0)
                throw new PrecioNegativoException();
            _precio = precio;
        }
        public uint Cantidad() { return _cantidad; }
        /// <summary>
        /// Método para agregar la cantidad comprada del item. 
        /// </summary>
        /// <param name="cantidad">No puede ser cero</param>
        /// <exception cref="CantidadCeroException"></exception>
        public void Cantidad(uint cantidad)
        {
            if (cantidad == 0)
                throw new CantidadCeroException();
            _cantidad = cantidad;
        }
        public double GetTotal()
        {
            return _precio * _cantidad;
        }
    }
}
