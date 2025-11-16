extensions : .csharp

# Autor: Rodrigo Henrique Silva Pinheiro
# Data: 16/11/2025
# Projeto: Gestão de Jardim Zoológico
# Unidade Curricular: Programação Orientada a Objetos
# Curso: LESI
# Instituição: Instituto Politecnico Do Cavado e DO Ave (IPCA)
# Versao: Fase 1 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardimZoologico
{
    public class Pessoa
    {
        #region Fields
        private int NIF;
        private string Morada;
        private string NomePessoa;
        private int IdadePessoa;
        #endregion 

        #region Properties
        public int NIF
        {
            get { return NIF; }
            set { NIF = value; }
        }
        public string Morada
        {
            get { return Morada; }
            set { Morada = value; }
        }
        public string NomePessoa
        {
            get { return NomePessoa; }
            set { NomePessoa = value; }
        }

        public int IdadePessoa
        {
            get { return IdadePessoa; }
            set { IdadePessoa = value; }
        }
        #endregion 

        #region Contructor
        public Pessoa(string NomePessoa, int IdadePessoa, int nif, string morada)
        {
            this.NomePessoa = NomePessoa;
            this.IdadePessoa = IdadePessoa;
            this.NIF = nif;
            this.Morada = morada;
        }
        #endregion 

        #region Methods
        // Metodos
        #endregion 

    }
}