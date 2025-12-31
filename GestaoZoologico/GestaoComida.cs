using System;
using System.Collections.Generic;
using System.Text;
using System.Security.AccessControl;
using BO;// Usar Business Object para aceder aos dados dos Animais
using Dados;

namespace GestaoZoologico
{
    public class GestaoComida
    {

        #region Methods
        public bool AdicionarComida(List<Comida> _listaComida, Comida c)
        {
            if (c == null) // Verifica se a comida nao é nula
                return false;

            if (_listaComida.Any(comida => comida.IddaComida == c.IddaComida))  // Verifica se a comida já existe na lista
                return false;

            else
                _listaComida.Add(c); // Adiciona a comida à lista
            return true;
        }

        public static bool RemoverComida(List<Comida> _listaComida, int idcomida)
        {
            Comida c = _listaComida.Find(comida => comida.IddaComida == idcomida);

            if (c != null)
            {
                _listaComida.Remove(c);
                return true;
            }
            return false;
        }

        public  Comida ObterComidaPorId(List<Comida> _listaComida, int idcomida)
        {
            return _listaComida.Find(comida => comida.IddaComida == idcomida);
        }

        public int QuantidadeTotalComidaPorTipo(List<Comida> _listaComida, string tipo)
        {
            return _listaComida.Where(comida => comida.TPcomida == tipo)
                              .Sum(comida => (int)comida.QuantidadeComida);
        }
        #endregion
    }
}