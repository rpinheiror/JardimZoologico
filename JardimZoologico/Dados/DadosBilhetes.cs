using System;
using System.Collections.Generic;
using System.Text;
using BO;

namespace Dados
{
    public class DadosBilhetes
    {
        #region Fields
        private static List<Bilhete> listaBilhetes;
        #endregion

        #region Properties
        public static List<Bilhete> _listaBilhetes
        {
            get { return listaBilhetes; }
            set { listaBilhetes = value; }
        }
        #endregion

        #region Constructors
        static DadosBilhetes()
        {
            _listaBilhetes = new List<Bilhete>();
        }
        #endregion

        #region Methods
        public static List<Bilhete> RetornaListaBilhetes()
        {
            return _listaBilhetes;
        }
        #endregion
    }
}
