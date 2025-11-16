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
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace JardimZoologico
{
    public class Comida
    {
        #region Fields
        private int IdComida;
        private double Quantidade;
        private string TipoComida;
        private DateTime DataValidade;
        #endregion

        #region Properties 
        public int IdComida
        {
            get { return IdComida; }
            set { IdComida = value; }
        }
        public double Quantidade
        {
            get { return Quantidade; }
            set { Quantidade = value; }
        }
        public string TipoComida
        {
            get { return TipoComida; }
            set { TipoComida = value; }
        }
        public DateTime DataValidade
        {
            get { return DataValidade }
            set{ DataValidade = value; }
        }
        #endregion 

        #region Constructors
        public Comida(int IdComida, double Quantidade, string TipoComida, DateTime DataValidade)
        {
            this.IdComida = IdComida;
            this.Quantidade = Quantidade;
            this.TipoComida = TipoComida;
            this.DataValidade = DataValidade;
        }
        #endregion

        #region Methods
        public bool DentroValidade()
        {
            return DateTime.Now <= DataValidade;
        }
        #endregion
    }
}