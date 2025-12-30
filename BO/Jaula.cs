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
    public class Jaula
{
    #region Fields
        private int IdJaula;
        private string TipoJaula;
        private string Localizacao;
        private int Capacidade;
    #endregion

    #region Properties
    public int IddaJaula
    {
        get { return IdJaula; }
        set { IdJaula = value; }
    }
    public string TPJaula
    {
        get { return TipoJaula; }
        set { TipoJaula = value; }
    }
    public string LocalJaula
    {
      
        get { return Localizacao; }
        set { Localizacao = value; }
    }
    public int CapacidadeJaula
    {
        get { return Capacidade; }
        set { Capacidade = value; }
    }
    #endregion 


    #region Constructors
    public Jaula(int idJaula, string tpJaula, string localizacao, int capacidadeJaula)
    {
        this.IdJaula = idJaula;
        this.TipoJaula = tpJaula;
        this.Localizacao = localizacao;
        this.Capacidade = capacidadeJaula;
    }
    #endregion

    #region Methods
    // Métodos para manipular a jaula
    #endregion
}
}