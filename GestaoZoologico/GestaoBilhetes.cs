using System;
using System.Collections.Generic;
using System.Text;
using BO;// Usar Business Object para aceder aos dados dos Animais
using Dados;

namespace GestaoZoologico
{
    internal class GestaoBilhetes
    {
        #region Fields
        private List<Bilhete> listabilhetes;
        #endregion

        #region Constructors
        public GestaoBilhetes()
        {
            listabilhetes = new List<Bilhete>();
        }
        #endregion

        #region Methods 
        public bool AdicionarBilhete(Bilhete b)
        {
            if (b == null) return false;

            if (listabilhetes.Any(bilhete => bilhete.Id_Bilhete == b.Id_Bilhete))  // Verifica se o bilhete já existe na lista
                return false;

            listabilhetes.Add(b);
            return true;
        }

        public List<Bilhete> RetornaListaBilhetes()
        {
            return listabilhetes;
        }

        public bool RemoverBilhete(int Id_Bilhete) {
            Bilhete b = listabilhetes.Find(x => x.Id_Bilhete == Id_Bilhete);

            if (b != null)
            {
                listabilhetes.Remove(b);
                return true;
            }
            return false;

        }
        #endregion 
    }
}
