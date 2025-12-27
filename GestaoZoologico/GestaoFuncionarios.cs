using JardimZoologico;
using System;
using System.Collections.Generic;
using System.Text;
using BO; // Usar Business Object para aceder aos dados dos Funcionarios

namespace GestaoZoologico
{
    public class GestaoFuncionarios
    {
        // Lista genérica que aceita qualquer tipo de funcionário (Polimorfismo)
        private List<Funcionario> _listaFuncionarios;

        public GestaoFuncionarios()
        {
            _listaFuncionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario f)
        {
            // Aqui podes usar as tuas Exceções Customizadas se o ID já existir
            _listaFuncionarios.Add(f);
        }

        public void ListarTodos()
        {
            foreach (var f in _listaFuncionarios)
            {
                // Graças ao override do ToString, isto imprimirá os dados certos
                Console.WriteLine(f.ToString());
            }
        }
    }
}