using BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados
{
    internal class DadosJaulas
    {
        #region FIELDS
        private static List<Jaula> listaJaulas;
        #endregion

        #region PROPERTIES
        public static List<Jaula> _listaJaulas
        {
            get { return listaJaulas; }
            set { listaJaulas = value; }
        }
        #endregion

        #region CONSTRUCTORS
        static DadosJaulas()
        {
            _listaJaulas = new List<Jaula>();
        }
        #endregion

        #region METHODS
        public static List<Jaula> RetornaListaJaulas()
        {
            return _listaJaulas;
        }
        #endregion
    }
}
