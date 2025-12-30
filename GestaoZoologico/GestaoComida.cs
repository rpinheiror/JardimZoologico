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
        public bool AdicionarComida(List<Comida> ListaComida, Comida c)
        {
            if (c == null) // Verifica se a comida nao é nula
                return false;

            if (ListaComida.Any(comida => comida.IddaComida == c.IddaComida))  // Verifica se a comida já existe na lista
                return false;

            else
                ListaComida.Add(c); // Adiciona a comida à lista
            return true;
        }

        public static bool RemoverComida(List<Comida> listaComida, int idcomida)
        {
            Comida c = listaComida.Find(comida => comida.IddaComida == idcomida);

            if (c != null)
            {
                listaComida.Remove(c);
                return true;
            }
            return false;
        }

        public  Comida ObterComidaPorId(List<Comida> ListaComida,int idcomida)
        {
            return ListaComida.Find(comida => comida.IddaComida == idcomida);
        }

        public int QuantidadeTotalComidaPorTipo(List<Comida> ListaComida, string tipo)
        {
            return ListaComida.Where(comida => comida.TPcomida == tipo)
                              .Sum(comida => (int)comida.QuantidadeComida);
        }
        #endregion
    }
}