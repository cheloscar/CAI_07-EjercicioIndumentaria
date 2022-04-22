using System;
namespace CAI_07Indumentaria.Dominio.ClasificacionIndumentaria
{
    public class IndumentariaCasual : TipoIndumentaria
    {
        public IndumentariaCasual(IndumentariaCasual indumentariaCasual) : base((TipoIndumentaria)indumentariaCasual)
        {
        }
        public IndumentariaCasual(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
        }
    }
}
