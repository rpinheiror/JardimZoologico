using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
        [Serializable]
        public class Bilhete
    {
        #region FIELDS
        private int IdBilhete;
        private DateTime DataCompra;
        private decimal Preco; 
        private string TipoBilhete;
        #endregion

        #region PROPERTIES
        public int Id_Bilhete
        {
            get { return IdBilhete; }
            set { IdBilhete = value; }
        }
        public DateTime Data_Compra
        {
            get { return DataCompra; }
            set { DataCompra = value; }
        }
        public decimal Preco_Bilhete
        {
            get { return Preco; }
            set { Preco = value; }
        }
        public string Tipo_Bilhete
        {
            get { return TipoBilhete; }
            set { TipoBilhete = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Bilhete(int idBilhete, DateTime dataCompra, decimal preco, string tipoBilhete)
        {
            this.IdBilhete = idBilhete;
            this.DataCompra = dataCompra;
            this.Preco = preco;
            this.TipoBilhete = tipoBilhete;
        }
        #endregion
    }


}
