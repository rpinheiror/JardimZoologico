
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

        #region Constructors
        // Fix: Constructor name must match class name
        public DadosAnimais()
        {
            ListaAnimais = new List<Animal>();
        }
        #endregion

        #region Methods
        public List<Animal> RetornaListaAnimais()
        {
            return ListaAnimais;
        }
        #endregion
    }
}
