using BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados
{
    internal class DadosFuncionarios
    {
        #region FIELDS
        private static List<Funcionario> listaFuncionarios;
        #endregion

        #region PROPERTIES
        public static List<Funcionario> _listaFuncionarios
        {
            get { return listaFuncionarios; }
            set { listaFuncionarios = value; }
        }
        #endregion

        #region CONSTRUCTORS
        static DadosFuncionarios()
        {
            _listaFuncionarios = new List<Funcionario>();
        }
        #endregion

        #region METHODS
        public static List<Funcionario> RetornaListaFuncionarios()
        {
            return _listaFuncionarios;
        }
        #endregion
    }
}
