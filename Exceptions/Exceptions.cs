using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Exceptions
    {
        public class AnimalNaoEncontradoException : Exception
        {
            public AnimalNaoEncontradoException(int id)
                : base($"O animal com o ID {id} não foi encontrado no sistema.") { }
        }

        public class FuncionarioNaoEncontradoException : Exception
        {
            public FuncionarioNaoEncontradoException(int id)
                : base($"O Funcionario com o ID {id} não foi encontrado no sistema.") { }
        }


    }
}
