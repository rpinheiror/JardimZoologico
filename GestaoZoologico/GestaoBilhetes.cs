using System;
using System.Collections.Generic;
using System.Text;
using BO;// Usar Business Object para aceder aos dados dos Animais
using Dados;

namespace GestaoZoologico
{
    internal class GestaoBilhetes
    {
       

        #region Methods 
        public bool AdicionarBilhete(Bilhete b, List<Bilhete> _listaBilhetes)
        {
            if (b == null) return false;

            if (_listaBilhetes.Any(bilhete => bilhete.Id_Bilhete == b.Id_Bilhete))  // Verifica se o bilhete já existe na lista
                return false;

            _listaBilhetes.Add(b);
            return true;
        }

        public bool RemoverBilhete(int Id_Bilhete, List<Bilhete> _listaBilhetes) {
            Bilhete b = _listaBilhetes.Find(x => x.Id_Bilhete == Id_Bilhete);

            if (b != null)
            {
                _listaBilhetes.Remove(b);
                return true;
            }
            return false;

        }
        #endregion 
    }
}
