using System;
using System.Collections.Generic;
using System.Text;

namespace appAlcancia.Dominio
{
    public class clsMoneda: clsDinero
    {
        #region Operaciones
        #region Constructores
        public clsMoneda(string prmIDO, int prmDenominacion, clsDivisa prmDivisa):base(prmIDO, prmDenominacion, prmDivisa)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public bool modificar(int prmDenominacion)
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
