using System;
namespace CAI_07_Indumentaria.Dominio
{
	public class TipoIndumentariaDeportiva : TipoIndumentaria
	{
        public TipoIndumentariaDeportiva(TipoIndumentariaDeportiva indumentariaDeportiva) : base((TipoIndumentaria)indumentariaDeportiva)
        {
        }
        public TipoIndumentariaDeportiva(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
		{
		}
		
	}
}
