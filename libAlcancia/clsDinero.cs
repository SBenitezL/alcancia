using System;
using System.Collections.Generic;
using System.Text;

namespace appAlcancia.Dominio
{
    public class clsDinero
    {
        #region Atributos
        /// <summary>
        /// Atributo que representa el identificador unico de objeto, con el fin de llegar a la persistencia con una base de datos
        /// </summary>
        protected string atrIDO;
        /// <summary>
        /// Atibuto que representa la denominación  valor del dinero
        /// </summary>
        protected int atrDenominacion;
        #region Asociativos
        /// <summary>
        /// Atributo que representa el propietario del dinero
        /// </summary>
        protected clsAhorrador atrAhorrador;
        /// <summary>
        /// Atributo que representa si el dinero se está almacenando y el contenedor
        /// </summary>
        protected clsAlcancia atrAlcancia;
        /// <summary>
        /// Atributo que representa la divisa del dinero
        /// </summary>
        protected clsDivisa atrDivisa; 
        #endregion
        #endregion
        #region Operaciones
        #region Accesores
        public string darIDO()
        {
            throw new NotImplementedException();
        }
        public int darDenominacion()
        {
            throw new NotImplementedException();
        }

        public clsAlcancia darAlcancia()
        {
            throw new NotImplementedException();
        }

        public clsAhorrador darAhorrador()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        public bool ponerDenominacion(int prmValor)
        {
            throw new NotImplementedException();
        }
        public bool ponerAlcancia(clsAlcancia prmObjeto)
        {
            throw new NotImplementedException();
        }
        public bool ponerAhorrador(clsAhorrador prmObjeto)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Constructor
        public clsDinero(string prmIDO, int prmDenominacion, clsDivisa prmDivisa)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
