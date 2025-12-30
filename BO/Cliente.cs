using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{ 
    [Serializable]

    public class Cliente : Pessoa
    {
        #region Fields
        private string idCliente;
        private bool temCartao;
        #endregion

        #region Properties
        public string Id_Cliente
       {
           get { return idCliente; }
           set { idCliente = value; }
       }

       public bool TemCartao
       {
           get { return temCartao; }
           set { temCartao = value; }
       }
        #endregion

        #region Constructors
        public Cliente(string idCliente, bool temCartao, string nome, int idade, string nif, string morada) : base(nome, idade, nif, morada)
        {
            this.Id_Cliente = idCliente;
            this.TemCartao = temCartao;
        }
        #endregion
    }
}
