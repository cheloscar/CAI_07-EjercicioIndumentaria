using System.Collections.Generic;
using CAI_07_Indumentaria.Dominio.Excepciones;


namespace CAI_07_Indumentaria.Dominio
{
    public class TiendaRopa
    {
        List<Indumentaria> _inventario = new List<Indumentaria>();
        List<Venta> _ventas = new List<Venta>();
        int _ultimoCodigo;

        
        public int GetProximoCodigo() { return _ultimoCodigo + 1; }
        public void Agregar(Indumentaria indumentaria)
        {
            if (indumentaria == null)
                throw new TipoVacioException();

            _inventario.Add(indumentaria);
            return;
        }
        public void Modificar(Indumentaria indumentaria)
        {
            if (indumentaria == null || _inventario.Count == 0)
                throw new TipoVacioException();

            foreach (Indumentaria ind in _inventario)
            {
                if (indumentaria.Codigo == ind.Codigo) { _inventario[_inventario.IndexOf(ind)] = indumentaria; break; }
            }
            return;
        }
        public void Quitar(Indumentaria indumentaria)
        {
            if (indumentaria == null || _inventario.Count == 0)
                throw new TipoVacioException();

            foreach (Indumentaria ind in _inventario)
            {
                if (indumentaria.Codigo == ind.Codigo) { _inventario.Remove(indumentaria); break; }
            }
            return;
        }
        public List<Indumentaria> Listar() { return _inventario; }
        public Venta ListarOrden(int codigo)
        {
            if (codigo == 0)
                throw new TipoVacioException();

            foreach (Venta venta in _ventas)
            {
                if (venta.Codigo == codigo) { return venta; }
            }
            Venta venta1 = new Venta(null, null, 0, 0);
            return venta1;
        }
        public void DevolverVenta(Venta venta)
        {
            if (venta == null)
                throw new TipoVacioException();

            foreach (Venta venta2 in _ventas)
            {
                if (venta.Codigo == venta2.Codigo) { venta2.Estado =  (int)EstadoVenta.DEVUELTO; break; }
            }
            return;
        }
    }
}