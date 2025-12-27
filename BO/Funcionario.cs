// -----------------------------------------------------------------
// Autor: Rodrigo Henrique Silva Pinheiro
// Número: 31502
// Data: 16/11/2025
// Projeto: Gestão de Jardim Zoológico
// Unidade Curricular: Programação Orientada a Objetos
// Curso: LESI
// Instituição: Instituto Politécnico do Cávado e do Ave (IPCA)
// Versão: Fase 1
// -----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardimZoologico
{
    public abstract class Funcionario : Pessoa
    {
        #region Fields
        private int IdFuncionario;
        private string Cargo;
        #endregion

        #region Properties 
        public int IDFuncionario
        {
            get { return IdFuncionario; }
            set { IdFuncionario = value; }
        }

        public string CargoFuncionario
        {
            get { return Cargo; }
            set { Cargo = value; }
        }
        #endregion

        #region Constructors
        protected Funcionario(int id, string cargo, string nome, int idade, string nif, string morada): base(nome, idade, nif, morada)
        {
            this.IdFuncionario = id;
            this.Cargo = cargo;
        }

        #endregion
    }
}
