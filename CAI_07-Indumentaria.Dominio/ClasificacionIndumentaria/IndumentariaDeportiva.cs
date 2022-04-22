using System;
namespace CAI_07Indumentaria.Dominio.ClasificacionIndumentaria
{
	public class IndumentariaDeportiva : TipoIndumentaria
	{
        public IndumentariaDeportiva(IndumentariaDeportiva indumentariaDeportiva) : base((TipoIndumentaria)indumentariaDeportiva)
        {
        }
        public IndumentariaDeportiva(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
		{
		}
		
	}
}
