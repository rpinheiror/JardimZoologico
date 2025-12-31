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
        #region Methods 
        public bool AdicionarJaula(Jaula j, List<Jaula> _listaJaulas)
        {
            if (j == null) return false;

            if (_listaJaulas.Any(jaula => jaula.IddaJaula == j.IddaJaula))  // Verifica se a jaula já existe na lista
                return false;

            _listaJaulas.Add(j);
            return true;
        }

        public bool RemoverJaula(int idJaula, List<Jaula> _listaJaulas)
        {
            Jaula j = _listaJaulas.Find(x => x.IddaJaula == idJaula);

            if (j != null)
            {
                _listaJaulas.Remove(j);
                return true;
            }
            return false;

        }
        #endregion 
    }
}
