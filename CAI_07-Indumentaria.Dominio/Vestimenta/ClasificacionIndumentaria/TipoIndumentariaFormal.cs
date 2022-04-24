using System;
namespace CAI_07_Indumentaria.Dominio
{
    public class TipoIndumentariaFormal : TipoIndumentaria
    {
        public TipoIndumentariaFormal(TipoIndumentariaFormal indumentariaFormal) : base((TipoIndumentaria)indumentariaFormal)
        {
        }
        public TipoIndumentariaFormal(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
        }
    }
}
