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
    public class Jaula
    {
        #region Fields
        private int IdJaula;
        private string NomeJaula;
        private string TipoJaula;
        private string Localizacao;
        #endregion

        #region Properties
        public int IdJaula
        {
            get { return IdJaula; }
            set { IdJaula = value; }
        }
        public string NomeJaula
        {
            get { return NomeJaula; }
            set { NomeJaula = value; }
        }
        public string TipoJaula
        {
            get { return TipoJaula; }
            set { TipoJaula = value; }
        }
        public string Localizacao
        {
            get { return Localizacao; }
            set { Localizacao = value; }
        }
        #endregion 


        #region Constructors
        public Jaula(int IdJaula, string NomeJaula, string TipoJaula, string Localizacao)
        {
            this.IdJaula = IdJaula;
            this.NomeJaula = NomeJaula;
            this.TipoJaula = TipoJaula;
            this.Localizacao = Localizacao;
        }
        #endregion

        #region Methods
        // Metodos
        #endregion
    }


}
