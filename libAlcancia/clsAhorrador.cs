using System;
using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsAhorrador:clsUsuario
    {
        #region Propios
        #region PatronIDO
        private string atrPID; 
        #endregion
        private string atrNombreCompleto;

        #endregion
        #region Asociativos
        private List<clsMoneda> atrMonedas;
        private List<clsBillete> atrBilletes;

        #endregion
        #region Derivables
        private int atrSaldoTotal;
        private int atrSaldoMonedas;
        private int atrSaldoBilletes;
        #endregion
        #region Operaciones
        /// <summary>
        /// Constructor del objeto ahorrador 
        /// </summary>
        /// <param name="prmPID">Numero de identificación del ahorrador</param>
        /// <param name="prmNombreUsuario"></param>
        /// <param name="prmClave"></param>
        public clsAhorrador(string prmPID, string prmNombreUsuario, string prmNombreCompleto,string prmClave) : base(prmNombreUsuario, prmClave)
        {
            throw new NotImplementedException();
        }
        #region Accesores
       /// <summary>
       /// Método accesor que retorna el PID del ahorrador
       /// </summary>
       /// <returns>atrPID</returns>
        public string darPID()
        {
            throw new NotFiniteNumberException();
        }
        /// <summary>
        /// Método accesor que retorna el saldo total del ahorrador
        /// </summary>
        /// <returns>atrSaldoTotal</returns>
        public int darSaldoTotal()
        {
            throw new NotFiniteNumberException();
        }
        /// <summary>
        /// Método accesor que retorna la suma de  
        /// </summary>
        /// <returns></returns>
        public int darSaldoTotalMonedas()
        {
            throw new NotFiniteNumberException();
        }
        public int darSaldoTotalBilletes()
        {
            throw new NotFiniteNumberException();
        }
        public List<clsMoneda> darModenas()
        {
            throw new NotImplementedException();
        }

        public List<clsBillete> darBilletes()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        public bool ponerMonedas(List<clsMoneda> prmColeccion)
        {
            throw new NotImplementedException();
        }
        public bool ponerBilletes(List<clsBillete> prmColeccion)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public bool modificar(string prmNombreCompleto, string prmClave)
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
    }

    #endregion
}
