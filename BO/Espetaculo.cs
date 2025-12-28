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
    public class Espetaculo
    {
        #region FIELDS
        private int IdEspetaculo;
        private string TipoEspetaculo;
        private List<Animal> ListaAnimais;
        private DateTime DataEspetaculo;

        #endregion

        #region PROPERTIES
        public int Id_Espetaculo
        {
            get { return IdEspetaculo; }
            set { IdEspetaculo = value; }
        }

        public string TPEspetaculo
        {
            get { return TipoEspetaculo; }
            set { TipoEspetaculo = value; }
        }

        public List<Animal> ListAnimais
        {
            get { return ListaAnimais; }
            set { ListaAnimais = value; }
        }

        public DateTime DateEspetaculo
        {
            get { return DataEspetaculo; }
            set { DataEspetaculo = value; }
        }

        #endregion

        #region CONSTRUCTORS
        public Espetaculo(int id, string tpEspetaculo, List<Animal> listaAnimais, DateTime dateEspetaculo)
        {
            this.IdEspetaculo = id;
            this.TipoEspetaculo = tpEspetaculo;
            this.ListaAnimais = listaAnimais;
            this.DataEspetaculo = dateEspetaculo;
        }
        #endregion

        #region Methods
        // Métodos relacionados com Espetáculo podem ser adicionados aqui
        #endregion
    }
}
