using System;
using System.Collections.Generic;
using System.Text;
using BO;// Usar Business Object para aceder aos dados dos Animais
using Dados;

namespace GestaoZoologico
{
    internal class GestaoClientes
    {
        #region Fields
        private List<Cliente> listacliente;
        #endregion

        #region Constructors
        public GestaoClientes()
        {
            listacliente = new List<Cliente>();
        }
        #endregion

        #region Methods
        public bool AdicionarCliente(Cliente p)
        {
            if (p == null) return false; // Verifica se o cliente é nulo

            if (listacliente.Any(cliente => cliente.NumeroNIF == p.NumeroNIF))  // Verifica se o cliente já existe na lista
                return false;

            listacliente.Add(p); // Adiciona o cliente à lista
            return true;
        }

        public List<Cliente> RetornaListaClientes()
        {
            return listacliente;
        }

        public bool RemoverCliente(string Id_Cliente)
        {
            Cliente p = listacliente.Find(x => x.Id_Cliente == Id_Cliente);

            if (p != null)
            {
                listacliente.Remove(p);
                return true;
            }
            return false;
        }
    }
    #endregion
}

