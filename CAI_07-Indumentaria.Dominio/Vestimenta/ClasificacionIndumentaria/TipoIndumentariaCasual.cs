using System;

namespace CAI_07_Indumentaria.Dominio
{
    public class TipoIndumentariaCasual : TipoIndumentaria
    {
        public TipoIndumentariaCasual(TipoIndumentariaCasual indumentariaCasual) : base((TipoIndumentaria)indumentariaCasual)
        {
        }
        public TipoIndumentariaCasual(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
        }
        public override string ToString()
        {
            return "Indumentaria Casual";
        }
    }
}
