using System;
using System.Collections.Generic;
using System.Text;
using BO;

namespace Dados
{
    internal class DadosComida
    {
        #region FIELDS
        private static List<Comida> listaComida;
        #endregion

        #region PROPERTIES
        public static List<Comida> _listaComida
        {
            get { return listaComida; }
            set { listaComida = value; }
        }
        #endregion

        #region CONSTRUCTORS
        static DadosComida()
        {
            _listaComida = new List<Comida>();
        }
        #endregion

        #region METHODS
        public static List<Comida> RetornaListaComida()
        {
            return _listaComida;
        }
        #endregion
    }

}
