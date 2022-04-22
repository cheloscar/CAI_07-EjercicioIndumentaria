using System;
namespace CAI_07Indumentaria.Dominio.ClasificacionIndumentaria
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal(IndumentariaFormal indumentariaFormal) : base((TipoIndumentaria)indumentariaFormal)
        {
        }
        public IndumentariaFormal(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
        }
    }
}
