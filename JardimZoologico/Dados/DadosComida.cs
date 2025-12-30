using System;
using System.Collections.Generic;
using System.Text;
using BO;

namespace Dados
{
    internal class DadosComida
    {
        #region FIELDS
        private  List<Comida> ListaComida;
        #endregion

        #region CONSTRUCTORS
        public DadosComida()
        {
            ListaComida = new List<Comida>();
        }
        #endregion
    }

}
