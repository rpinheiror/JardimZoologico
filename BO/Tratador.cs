using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    [Serializable]
    public class Tratador : Funcionario
    {
        #region Fields
        private string AreaTratamento;
        private string TurnoTrabalho;
        #endregion

        #region Properties
        public string AreaTratamentoFuncionario
        {
            get { return AreaTratamento; }
            set { AreaTratamento = value; }
        }
        public string TurnoTrabalhoFuncionario
        {
            get { return TurnoTrabalho; }
            set { TurnoTrabalho = value; }
        }
       
        #endregion

        #region Constructors
        protected Tratador(string areaTratamento, string turno, int id, string cargo, string nome, int idade, string nif, string morada) : base(id, cargo, nome, idade, nif, morada)
        {
            this.AreaTratamento = areaTratamento;
            this.TurnoTrabalho = turno;

        }
        #endregion

        #region Methods
        public void AlimentarAnimal()
        {
            // Lógica para alimentar o animal
        }
        public void LimparJaula()
        {
            // Lógica para limpar a jaula
        }
        #endregion
    }
}
