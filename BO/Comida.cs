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
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Comida
    {
        #region Fields
        private int IdComida;
        private double Quantidade;
        private string TipoComida;
        private DateTime DataValidade;
        #endregion

        #region Properties 
        public int IddaComida
        {
            get { return IdComida; }
            set { IdComida = value; }
        }
        public double QuantidadeComida
        {
            get { return Quantidade; }
            set { Quantidade = value; }
        }
        public string TPcomida
        {
            get { return TipoComida; }
            set { TipoComida = value; }
        }
        public DateTime DATAVAL
        {
            get { return DataValidade; }
            set { DataValidade = value; }
        }
        #endregion 

        #region Constructors
        public Comida(int id, double quantidade, string tipo, DateTime data)
        {
            this.IdComida = id;
            this.Quantidade = quantidade;
            this.TipoComida = tipo;
            this.DataValidade = data;
        }
        #endregion

        #region Methods
        #endregion
    }
}