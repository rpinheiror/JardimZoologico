using System;
using System.Collections.Generic;
using System.Text;
using BO; // Usar Business Object para aceder aos dados dos Funcionarios
using Dados;

namespace GestaoZoologico
{
    public class GestaoFuncionarios
    {
        #region Fields
        private List<Funcionario> listaFuncionarios;
        #endregion

        #region Constructors
        public GestaoFuncionarios()
        {
            listaFuncionarios = new List<Funcionario>();
        }
        #endregion

        #region Methods
        public bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null ) return false; // Verifica se o funcionario é nulo

            if (listaFuncionarios.Any(funcionario => funcionario.IDFuncionario == f.IDFuncionario))  // Verifica se o funcionario já existe na lista
            return false;

            listaFuncionarios.Add(f); // Adiciona o funcionario à lista
            return true;
        }

        public List<Funcionario> RetornaListaFuncionarios()
        {
            return listaFuncionarios;
        }

        public bool RemoverFuncionario(int IDFuncionario)
        {
            
            Funcionario f = listaFuncionarios.Find(x => x.IDFuncionario == IDFuncionario);

            if (f != null)
            {
                listaFuncionarios.Remove(f);
                return true; 
            }
            return false; 
        }
    }
    #endregion
}