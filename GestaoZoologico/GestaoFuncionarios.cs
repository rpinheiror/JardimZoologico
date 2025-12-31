using System;
using System.Collections.Generic;
using System.Text;
using BO; // Usar Business Object para aceder aos dados dos Funcionarios
using Dados;

namespace GestaoZoologico
{
    public class GestaoFuncionarios
    {
       
        #region Methods
        public bool AdicionarFuncionario(Funcionario f, List<Funcionario> _listaFuncionarios)
        {
            if (f == null ) return false; // Verifica se o funcionario é nulo

            if (_listaFuncionarios.Any(funcionario => funcionario.IDFuncionario == f.IDFuncionario))  // Verifica se o funcionario já existe na lista
            return false;

            _listaFuncionarios.Add(f); // Adiciona o funcionario à lista
            return true;
        }

        public bool RemoverFuncionario(int IDFuncionario, List<Funcionario> _listaFuncionarios)
        {
            
            Funcionario f = _listaFuncionarios.Find(x => x.IDFuncionario == IDFuncionario);

            if (f != null)
            {
                _listaFuncionarios.Remove(f);
                return true; 
            }
            return false; 
        }
    }
    #endregion
}