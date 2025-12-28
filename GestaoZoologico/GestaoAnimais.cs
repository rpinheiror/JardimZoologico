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
        
        private List<Animal> ListaAnimais;

        public GestaoAnimais()
        {
            ListaAnimais = new List<Animal>();
        }

        
        public bool AdicionarAnimal(Animal a)
        {
            if (a == null) 
            return false;

            if (ListaAnimais.Any(animal => animal.IddoAnimal == a.IddoAnimal)) 
            return false;

            else
                ListaAnimais.Add(a);
            return true;
        }

        
        public List<Animal> RetornaListaAnimais() 
        {
            return ListaAnimais;
        }

        public bool RemoverAnimal(int idanimal)
        {
            Animal a = ListaAnimais.Find(animal => animal.IddoAnimal == idanimal);

            if (a != null)
            {
                ListaAnimais.Remove(a);
                return true;
            }
            return false;
        }
    }
}