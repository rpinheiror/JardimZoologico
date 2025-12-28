using JardimZoologico;
using System;
using System.Collections.Generic;
using System.Text;
using BO; // Usar Business Object para aceder aos dados dos Funcionarios

namespace GestaoZoologico
{
    public class GestaoFuncionarios
    {
        // Lista genérica que aceita qualquer tipo de funcionário (Polimorfismo)
        private List<Funcionario> listaFuncionarios;

        public GestaoFuncionarios()
        {
            listaFuncionarios = new List<Funcionario>();
        }

        public bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null ) return false;
            listaFuncionarios.Add(f);
            return true;
        }

        public List<Funcionario> RetornaListaFuncionarios()
        {
            return listaFuncionarios;
        }

        public bool RemoverFuncionario(int idfuncionario)
        {
            
            Funcionario f = listaFuncionarios.Find(x => x.IDFuncionario == idfuncionario);

            if (f != null)
            {
                listaFuncionarios.Remove(f);
                return true; 
            }
            return false; 
        }
    }
}