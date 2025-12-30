// -----------------------------------------------------------------
// Autor: Rodrigo Henrique Silva Pinheiro
// Número: 31502
// Data: 16/11/2025
// Projeto: Gestão de Jardim Zoológico
// Unidade Curricular: Programação Orientada a Objetos
// Curso: LESI
// Instituição: Instituto Politécnico do Cávado e do Ave (IPCA)
// -----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Veterinario : Pessoa
   
    {
        #region Fields
            private string Especialidade;
            private int AnosExperiencia;
        #endregion

        #region Properties
            public string EspecialidadeVeterinario
            {
                get { return Especialidade; }
                set { Especialidade = value; }
            }
            public int ExperienciaVeterinario
            {
                get { return AnosExperiencia; }
                set { AnosExperiencia = value; }
            }
        #endregion

        #region Constructors
            protected Veterinario(string especialidade, int anosExperiencia, string nome, int idade, string nif, string morada) : base(nome, idade, nif, morada)
            {
                this.Especialidade = especialidade;
                this.AnosExperiencia = anosExperiencia;
            }
        #endregion

        #region Methods
        #endregion
    }
}
