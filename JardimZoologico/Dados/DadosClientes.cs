using BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados
{
    internal class DadosClientes
    {
        #region Fields
        private static List<Cliente> listaClientes;
        #endregion

        #region Properties
        public static List<Cliente> _listaClientes   
        {
            get { return listaClientes; }
            set { listaClientes = value; }
        }
        #endregion

        #region Constructors
        static DadosClientes()
        {
            _listaClientes = new List<Cliente>();
        }
        #endregion

        #region Methods
        public static List<Cliente> RetornaListaCliente()
        {
            return _listaClientes;
        }
        #endregion
    }
}
