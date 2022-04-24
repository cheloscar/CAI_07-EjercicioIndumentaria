using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_07_Indumentaria.Dominio
{
    internal class Venta
    {
        #region Variables
        List<VentaItem> _items;
        Cliente _cliente;
        int _estado;
        int _codigo;

        #endregion

        #region Propiedades
        public global::System.Int32 Estado { get => _estado; set => _estado = value; }
        public global::System.Int32 Codigo { get => _codigo; set => _codigo = value; }
        internal Cliente Cliente { get => _cliente; set => _cliente = value; }
        internal List<VentaItem> Items1 { get => _items; set => _items = value; }

        #endregion

        #region Constructores
        public Venta(List<VentaItem> items, Cliente cliente, global::System.Int32 estado, global::System.Int32 codigo)
        {
            Items1 = items;
            this._cliente = cliente;
            _estado = estado;
            _codigo = codigo;
        }

        #endregion

        #region Métodos
        public double GetTotalPedido()
        {
            if (_items == null || _items.Count() == 0)
                throw new PedidoVacioException();

            double total = 0;
            foreach (VentaItem item in _items)
            {
                total += item.GetTotal();
            }
            return total;
        }

        #endregion
    }
}
