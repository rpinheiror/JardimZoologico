using BO; // Usar Business Object para aceder aos dados dos Animais
using JardimZoologico;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace GestaoZoologico
{
    public class GestaoAnimais
    {
        // Encapsulamento: a lista é privada para não ser alterada de fora sem controlo
        private List<Animal> _listaAnimais;

        public GestaoAnimais()
        {
            _listaAnimais = new List<Animal>();
        }

        // Método para adicionar (Regra de Negócio)
        public bool AdicionarAnimal(Animal a)
        {
            if (a == null) return false;

            // Aqui podes verificar se o ID já existe antes de adicionar
            _listaAnimais.Add(a);
            return true;
        }

        // Método para listar (Útil para a aplicação demonstradora da Fase 2)
        public List<Animal> GetTodosAnimais()
        {
            return _listaAnimais;
        }
    }
}