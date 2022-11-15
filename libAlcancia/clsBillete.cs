using System;

namespace appAlcancia.Dominio
{
    public class clsBillete:clsDinero
    {
        #region Operaciones
        #region Contructores
        public clsBillete(string prmSerial, int prmDenominacion, clsDivisa prmDivisa): base( prmSerial, prmDenominacion, prmDivisa)
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
