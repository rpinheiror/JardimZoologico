using System;

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
    /// <summary>
    /// Representa o ato de alimentar um animal no zoológico.
    /// </summary>
    public class Alimento : Comida
    {
        #region Fields
        private string NomeAnimal;
        private DateTime DataServido;
        #endregion

        #region Properties
        public string NomeAnimal
        {
            get { return NomeAnimal; }
            set { NomeAnimal = value;}
        }
        public DateTime DataServido
        {
            get { return DataServido; }
            set { DataServido = value; }
        }
        #endregion 

        /// <summary>
        /// Construtor da classe Alimento que inicia o nome do animal, data servido, comida
        /// </summary>
        /// <param name="NomeAnimal"></param>
        /// <param name="DataServido"></param>
        /// <param name="IdComida"></param>
        /// <param name="Quantidade"></param>
        /// <param name="TipoComida"></param>
        /// <param name="DataValidade"></param>
        #region Constructors
        public Alimento(string NomeAnimal, DateTime DataServido, : base int IdComida, double Quantidade, string TipoComida, DateTime DataValidade)
        {
            this.NomeAnimal = NomeAnimal;
            this.DataServido = DataServido;
            this.IdComida = IdComida;
            this.Quantidade = Quantidade;
            this.Tipo = TipoComida;
            this.DataValidade = DataValidade;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método abstrato para servir alimento ao animal.
        /// </summary>
        /// <returns>Retorna true se o alimento foi servido com sucesso, caso contrário, false.</returns>
        public abstract bool ServirAlimento(); 
        #endregion
    }

}
