using System;
using System.Collections.Generic;
using System.Text;

namespace appAlcancia.Dominio
{
    public class clsDivisa
    {
        #region Atributos
        #region Propios
        private string atrIDO;
        private string atrNombre;
        #endregion
        #region Asociativos
        private clsAlcancia atrAlcancia;
        private List<clsMoneda> atrMonedas;
        private List<clsBillete> atrBilletes;
        #endregion
        #endregion
        #region Operaciones

        #region Accesores
        public string darIDO()
        {
            throw new NotImplementedException();
        }
        public string darNombre()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Mutador
        public bool ponerNombre()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Destructor
        public bool finalizar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
