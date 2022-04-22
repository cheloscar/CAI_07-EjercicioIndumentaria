using System;
namespace CAI_07Indumentaria.Dominio.ClasificacionIndumentaria
{
    public abstract class TipoIndumentaria
    {
        #region Variables
        string _origen;
        double _porcentajeAlgodon;

        #endregion

        #region Propiedades
        public string Origen { get => _origen; set => _origen = value; }
        public double PorcentajeAlgodon { get => _porcentajeAlgodon; set => _porcentajeAlgodon = value; }

        #endregion

        #region Constructores
        public TipoIndumentaria(string origen, double porcentajeAlgodon)
        {
            _origen = origen;
            _porcentajeAlgodon = porcentajeAlgodon;
        }
        public TipoIndumentaria(TipoIndumentaria tipoIndumentaria)
        {
            _origen = tipoIndumentaria.Origen;
            _porcentajeAlgodon = tipoIndumentaria.PorcentajeAlgodon;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return "Soy la clase abstracta TipoIndumentaria";
        }
        public string GetDetalle()
        {
            return "< abs >";
        }
        #endregion
    }
}
