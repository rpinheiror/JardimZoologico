using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BO;
using Dados;

namespace GestaoZoologico
{
    internal class GestaoJaulas
    {
        #region Fields
        private List<Jaula> listaJaulas;
        #endregion

        #region Constructors
        public GestaoJaulas()
        {
            listaJaulas = new List<Jaula>();
        }
        #endregion

        #region Methods 
        public bool AdicionarJaula(Jaula j)
        {
            if (j == null) return false;

            if (listaJaulas.Any(jaula => jaula.IddaJaula == j.IddaJaula))  // Verifica se a jaula já existe na lista
                return false;

            listaJaulas.Add(j);
            return true;
        }

        public List<Jaula> RetornaListaJaulas()
        {
            return listaJaulas;
        }

        public bool RemoverJaula(int idJaula)
        {
            Jaula j = listaJaulas.Find(x => x.IddaJaula == idJaula);

            if (j != null)
            {
                listaJaulas.Remove(j);
                return true;
            }
            return false;

        }
        #endregion 
    }
}
