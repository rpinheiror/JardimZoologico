using System;
using System.Collections.Generic;
using System.Text;
using BO;// Usar Business Object para aceder aos dados dos Animais
using Dados;

namespace GestaoZoologico
{
    internal class GestaoClientes
    {
       
        #region Methods
        public bool AdicionarCliente(Cliente p, List<Cliente> _listaClientes)
        {
            if (p == null) return false; // Verifica se o cliente é nulo

            if (_listaClientes.Any(cliente => cliente.NumeroNIF == p.NumeroNIF))  // Verifica se o cliente já existe na lista
                return false;

            _listaClientes.Add(p); // Adiciona o cliente à lista
            return true;
        }
        public bool RemoverCliente(string Id_Cliente, List<Cliente> _listaClientes)
        {
            Cliente p = _listaClientes.Find(x => x.Id_Cliente == Id_Cliente);

            if (p != null)
            {
                _listaClientes.Remove(p);
                return true;
            }
            return false;
        }
    }
    #endregion
}

