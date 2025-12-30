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

namespace BO
{
    [Serializable]
    public class Pessoa
    {
        #region Fields
        private string Nif;
        private string Morada;
        private string NomePessoa;
        private int Idade;
        #endregion 

        #region Properties
        public string NumeroNIF
        {
            get { return Nif; }
            set { if (value.Length == 9) Nif = value; }
        }
        public string PessoaMorada
        {
            get { return Morada; }
            set { Morada = value; }
        }
        public string NomeCompleto
        {
            get { return NomePessoa; } 
            set { NomePessoa = value; } 
        }

        public int IdadePessoa
        {
            get { return Idade; }
            set { Idade = value; }
        }
        #endregion 

        #region Contructor
        public Pessoa(string nome, int idade, string nif, string morada)
        {
            this.NomePessoa = nome;
            this.Idade = idade;
            this.Nif = nif;
            this.Morada = morada;
        }
        #endregion 

        #region Methods
        
        #endregion 

    }
}