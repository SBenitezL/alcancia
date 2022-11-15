using System;

namespace appAlcancia.Dominio
{
    /// <summary>
    /// @brief Clase padre que se encarga de la formar la plantilla de los diferentes tipos de usuarios.
    /// </summary>
    public class clsUsuario
    {
        #region Atributos
        #region Propios
        /// <summary>
        /// @brief Atributo protegido que hace referencia al nombre del usuario.
        /// </summary>
        protected string atrNombreUsuario;
        /// <summary>
        /// @brief Atributo protegido que hace referencia a la contraseña cifrada del usuario.
        /// </summary>
        protected string atrClave;
        #endregion
        #endregion
        #region Operaciones
        #region Accesores
        public string darNombreUsuario()
        {
            throw new NotImplementedException();
        }
        public string darClave()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        public bool ponerClave(string prmValor)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Constructores
        public clsUsuario(string prmNombreUsuario, string prmClave)
        {
            throw new NotImplementedException();
        } 
        #endregion
        #endregion
    }
}
