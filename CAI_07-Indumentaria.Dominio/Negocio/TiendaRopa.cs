using System.Collections.Generic;

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
            
            /*
            if (indumentaria.GetType())
            try
            {
                (IndumentariaCamisa)indumentaria;
            }
            catch (Exception ex)
            {

            }*/
        }

    }
}