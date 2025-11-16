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
        private string Nif;
        private string Morada;
        private string NomePessoa;
        private int IdadePessoa;
        #endregion 

        #region Properties
        public const NIF = 9;
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
        public Pessoa(string NomePessoa, int IdadePessoa, string Nif, string morada)
        {
            this.NomePessoa = NomePessoa;
            this.IdadePessoa = IdadePessoa;
            this.Nif = Nif;
            this.Morada = morada;
        }
        #endregion 

        #region Methods
        // Metodos
        #endregion 

    }
}