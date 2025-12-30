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
namespace BO
{
    [Serializable]

    public class Animal 
    {
        #region Fields
        private int IdAnimal;
        private string EspecieAnimal;
        #endregion

        #region Properties
        public int IddoAnimal
        {
            get { return IdAnimal; }
            set { IdAnimal = value; }
        }  
        public string Especie
        {
            get { return EspecieAnimal; }
            set { EspecieAnimal = value; }
        }
        #endregion

        #region Constructors

        public Animal(int idAnimal, string especieAnimal)
        {
            this.IdAnimal = idAnimal;
            this.EspecieAnimal = especieAnimal;
        }
        #endregion

        #region Methods
        
        #endregion 

    }
}
