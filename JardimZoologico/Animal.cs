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
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace JardimZoologico
{
    /// <summary>
    /// Classe Animal que representa um animal no jardim zoológico
    /// </summary>
    public class Animal 
    {
        #region Fields
        private int IdAnimal;
        private string NomeAnimal;
        private string EspecieAnimal;
        private int IdadeAnimal;
        #endregion

        #region Properties
        public int Idint
        {
            get { return IdAnimal; }
            set { IdAnimal = value; }
        }
        public string Nome
        { 
            get { return NomeAnimal; }
            set { NomeAnimal = value; }
        }    
        public string Especie
        {
            get { return EspecieAnimal; }
            set { EspecieAnimal = value; }
        }
        public int Idade
        {
            get { return IdadeAnimal; }
            set { IdadeAnimal = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Construtor da classe Animal
        /// </summary>
        /// <param name="IdAnimal"></param>
        /// <param name="NomeAnimal"></param>
        /// <param name="EspecieAnimal"></param>
        /// <param name="IdadeAnimal"></param>
        public Animal(int IdAnimal, string NomeAnimal, string EspecieAnimal, int IdadeAnimal)
        {
            this.IdAnimal = IdadeAnimal;
            this.NomeAnimal = NomeAnimal;
            this.EspecieAnimal = EspecieAnimal;
            this.IdadeAnimal = IdadeAnimal;
        }
        #endregion

        #region Methods
        //Metodos seram inseridos aqui
        #endregion 

    }
}
