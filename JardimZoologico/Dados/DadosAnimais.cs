
using System;
using System.Collections.Generic;
using System.Text;
using BO;

namespace Dados
{
    public class DadosAnimais
    {
        #region Fields
        private static List<Animal> ListaAnimais;
        #endregion

        #region Properties
        public static List<Animal> _ListaAnimais
        {
            get { return ListaAnimais; }
            set { ListaAnimais = value; }
        }
        #endregion

        #region Constructors
        static DadosAnimais()
        {
            _ListaAnimais = new List<Animal>();
        }
        #endregion

        #region Methods
        public static List<Animal> RetornaListaAnimais()
        {
            return _ListaAnimais;
        }
        #endregion
    }
}
